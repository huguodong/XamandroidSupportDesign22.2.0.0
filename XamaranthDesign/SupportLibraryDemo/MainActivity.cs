using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Support.V4.App;
using Android.App;
using Zhy.Com.Highlight;
namespace SupportLibraryDemo
{
    [Activity(Label = "Demo", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener, HighLight.IOnPosCallback
    {
        //将ToolBar与TabLayout结合放入AppBarLayout
        private Toolbar mToolbar;
        //DrawerLayout中的左侧菜单控件
        private NavigationView mNavigationView;
        //DrawerLayout控件
        private DrawerLayout mDrawerLayout;
        //Tab菜单，主界面上面的tab切换菜单
        private TabLayout mTabLayout;
        //v4中的ViewPager控件
        private ViewPager mViewPager;
        private HighLight mHightLight;
        private NavigationView.IOnNavigationItemSelectedListener naviListener;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            naviListener = this;
            //初始化控件及布局
            initView();

        }
        private void initView()
        {
            //MainActivity的布局文件中的主要控件初始化
            mToolbar = FindViewById<Toolbar>(Resource.Id.tool_bar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mNavigationView = FindViewById<NavigationView>(Resource.Id.navigation_view);
            mTabLayout = FindViewById<TabLayout>(Resource.Id.tab_layout);
            mViewPager = FindViewById<ViewPager>(Resource.Id.view_pager);
            mTabLayout.Post(() =>
            {
                ShowTipMask();

            });


            mTabLayout.TabMode = TabLayout.ModeFixed;//固定
            // mTabLayout.TabMode = TabLayout.ModeScrollable;//滚动
            mTabLayout.TabGravity = TabLayout.GravityFill;//标签填充栏
            //mTabLayout.TabGravity = TabLayout.GravityCenter;//固定在中间
            //初始化ToolBar
            SetSupportActionBar(mToolbar);
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Android.Resource.Drawable.IcDialogAlert);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            //对NavigationView添加item的监听事件
            mNavigationView.SetNavigationItemSelectedListener(naviListener);
            //开启应用默认打开DrawerLayout
            // mDrawerLayout.OpenDrawer(mNavigationView);

            //初始化TabLayout的title数据集
            List<Java.Lang.String> titles = new List<Java.Lang.String>();
            Java.Lang.String detail = new Java.Lang.String("我的活动");
            Java.Lang.String share = new Java.Lang.String("招募活动");
            Java.Lang.String agenda = new Java.Lang.String("缺席活动");
            Java.Lang.String other = new Java.Lang.String("其他活动");
            titles.Add(detail);
            titles.Add(share);
            titles.Add(agenda);
            titles.Add(other);
            //初始化TabLayout的title
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[0]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[1]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[2]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[3]));
            //初始化ViewPager的数据集
            List<Android.Support.V4.App.Fragment> fragments = new List<Android.Support.V4.App.Fragment>();
            fragments.Add(new InfoDetailsFragment());
            fragments.Add(new ShareFragment());
            fragments.Add(new AgendaFragment());
            fragments.Add(new AgendaFragment());
            //创建ViewPager的adapter
            FragmentAdapter adapter = new FragmentAdapter(SupportFragmentManager, fragments, titles);
            mViewPager.Adapter = adapter;
            //千万别忘了，关联TabLayout与ViewPager
            //同时也要覆写PagerAdapter的getPageTitle方法，否则Tab没有title
            mTabLayout.SetupWithViewPager(mViewPager);
            mTabLayout.SetTabsFromPagerAdapter(adapter);
        }

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            //点击NavigationView中定义的menu item时触发反应
            switch (menuItem.ItemId)
            {
                case Resource.Id.menu_info_details:
                    mViewPager.CurrentItem = 0;
                    break;
                case Resource.Id.menu_share:
                    mViewPager.CurrentItem = 1;
                    break;
                case Resource.Id.menu_agenda:
                    mViewPager.CurrentItem = 2;
                    break;
            }
            //关闭DrawerLayout回到主界面选中的tab的fragment页
            mDrawerLayout.CloseDrawer(mNavigationView);
            return false;
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_info_details:
                    mViewPager.CurrentItem = 0;
                    break;
                case Resource.Id.menu_share:
                    mViewPager.CurrentItem = 1;
                    break;
                case Resource.Id.menu_agenda:
                    mViewPager.CurrentItem = 2;
                    break;
                case Android.Resource.Id.Home:
                    //主界面左上角的icon点击反应
                    mDrawerLayout.OpenDrawer(GravityCompat.Start);
                    break;
            }
            return base.OnOptionsItemSelected(item);
        }
        private void ShowTipMask()
        {
            mHightLight = new HighLight(this)
                    .Anchor(FindViewById<Android.Support.V4.Widget.DrawerLayout>(Resource.Id.drawer_layout))
                    .AddHighLight(Resource.Id.tab_layout, Resource.Layout.info_up, this);
            //.AddHighLight(Resource.Id.id_btn_amazing, Resource.Layout.info_down, B);
            mHightLight.Show();
        }
     
        public void GetPos(float p0, float p1, Android.Graphics.RectF p2, HighLight.MarginInfo p3)
        {
            p3.LeftMargin = p2.Right - p2.Width() / 2;
            p3.TopMargin = p2.Bottom;
        }
    }
}