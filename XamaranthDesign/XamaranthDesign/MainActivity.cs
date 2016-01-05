using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Content.Res;
using Android.Graphics;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
namespace XamaranthDesign
{
    [Activity(Label = "XamaranthDesign", Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        FloatingActionButton fabBtn;
        Android.Support.V7.Widget.Toolbar toolbar;
        TabLayout tabLayout;
        CollapsingToolbarLayout collapsingToolbarLayout;
        DrawerLayout drawerLayout;
        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.fab:
                    //点击悬浮按钮弹出的东西
                    Snackbar sn = Snackbar.Make(v, "hello ssadasdasdasdas", Snackbar.LengthShort).SetAction("确定", (s) =>
                            {
                            });
                    sn.Show();
                    ;
                    break;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            initInstances();
        }
        private void initInstances()
        {
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            //底部悬浮按钮
            fabBtn = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fabBtn.SetOnClickListener(this);
            //v7的actionbar
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitleTextColor(Color.White);
            SetSupportActionBar(toolbar);
            //v7 ActionBar的返回按钮
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //顶部标签
            tabLayout = FindViewById<TabLayout>(Resource.Id.tabLayout);
            tabLayout.TabMode = TabLayout.ModeFixed;//固定
           // tabLayout.TabMode = TabLayout.ModeScrollable;//滚动
            tabLayout.TabGravity = TabLayout.GravityFill;//标签填充栏
            //tabLayout.TabGravity = TabLayout.GravityCenter;//固定在中间
            tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 1"));
            tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 2"));
            tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 3"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 2"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 3"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 2"));
            //tabLayout.AddTab(tabLayout.NewTab().SetText("Tab 3"));

            
            collapsingToolbarLayout = FindViewById<CollapsingToolbarLayout>(Resource.Id.collapsingToolbarLayout);
            collapsingToolbarLayout.SetTitle("Design Library");
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;

            }
            return base.OnOptionsItemSelected(item);
        }
    }
}

