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
        //��ToolBar��TabLayout��Ϸ���AppBarLayout
        private Toolbar mToolbar;
        //DrawerLayout�е����˵��ؼ�
        private NavigationView mNavigationView;
        //DrawerLayout�ؼ�
        private DrawerLayout mDrawerLayout;
        //Tab�˵��������������tab�л��˵�
        private TabLayout mTabLayout;
        //v4�е�ViewPager�ؼ�
        private ViewPager mViewPager;
        private HighLight mHightLight;
        private NavigationView.IOnNavigationItemSelectedListener naviListener;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
            naviListener = this;
            //��ʼ���ؼ�������
            initView();

        }
        private void initView()
        {
            //MainActivity�Ĳ����ļ��е���Ҫ�ؼ���ʼ��
            mToolbar = FindViewById<Toolbar>(Resource.Id.tool_bar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mNavigationView = FindViewById<NavigationView>(Resource.Id.navigation_view);
            mTabLayout = FindViewById<TabLayout>(Resource.Id.tab_layout);
            mViewPager = FindViewById<ViewPager>(Resource.Id.view_pager);
            mTabLayout.Post(() =>
            {
                ShowTipMask();

            });


            mTabLayout.TabMode = TabLayout.ModeFixed;//�̶�
            // mTabLayout.TabMode = TabLayout.ModeScrollable;//����
            mTabLayout.TabGravity = TabLayout.GravityFill;//��ǩ�����
            //mTabLayout.TabGravity = TabLayout.GravityCenter;//�̶����м�
            //��ʼ��ToolBar
            SetSupportActionBar(mToolbar);
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Android.Resource.Drawable.IcDialogAlert);
            actionBar.SetDisplayHomeAsUpEnabled(true);
            //��NavigationView���item�ļ����¼�
            mNavigationView.SetNavigationItemSelectedListener(naviListener);
            //����Ӧ��Ĭ�ϴ�DrawerLayout
            // mDrawerLayout.OpenDrawer(mNavigationView);

            //��ʼ��TabLayout��title���ݼ�
            List<Java.Lang.String> titles = new List<Java.Lang.String>();
            Java.Lang.String detail = new Java.Lang.String("�ҵĻ");
            Java.Lang.String share = new Java.Lang.String("��ļ�");
            Java.Lang.String agenda = new Java.Lang.String("ȱϯ�");
            Java.Lang.String other = new Java.Lang.String("�����");
            titles.Add(detail);
            titles.Add(share);
            titles.Add(agenda);
            titles.Add(other);
            //��ʼ��TabLayout��title
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[0]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[1]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[2]));
            mTabLayout.AddTab(mTabLayout.NewTab().SetText(titles[3]));
            //��ʼ��ViewPager�����ݼ�
            List<Android.Support.V4.App.Fragment> fragments = new List<Android.Support.V4.App.Fragment>();
            fragments.Add(new InfoDetailsFragment());
            fragments.Add(new ShareFragment());
            fragments.Add(new AgendaFragment());
            fragments.Add(new AgendaFragment());
            //����ViewPager��adapter
            FragmentAdapter adapter = new FragmentAdapter(SupportFragmentManager, fragments, titles);
            mViewPager.Adapter = adapter;
            //ǧ������ˣ�����TabLayout��ViewPager
            //ͬʱҲҪ��дPagerAdapter��getPageTitle����������Tabû��title
            mTabLayout.SetupWithViewPager(mViewPager);
            mTabLayout.SetTabsFromPagerAdapter(adapter);
        }

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            //���NavigationView�ж����menu itemʱ������Ӧ
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
            //�ر�DrawerLayout�ص�������ѡ�е�tab��fragmentҳ
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
                    //���������Ͻǵ�icon�����Ӧ
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