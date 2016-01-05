using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Graphics;
namespace XamaranthDesign
{
    [Activity(Label = "test", MainLauncher = true)]
    public class test : AppCompatActivity, View.IOnClickListener
    {
        FloatingActionButton fabBtn;
        Android.Support.V7.Widget.Toolbar toolbar;
        TabLayout tabLayout;
        CollapsingToolbarLayout collapsingToolbarLayout;
        DrawerLayout drawerLayout;
        String[] strs = new String[] {
    "first", "second", "third", "fourth", "fifth","first", "second", "third", "fourth", "fifth","first", "second", "third", "fourth", "fifth"
    };
        ListView lv;
        ShapeLoadingViewCSharp.Widget.LoadingView loading;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.test);
            lv = (ListView)FindViewById(Resource.Id.lv);
            lv.Visibility = ViewStates.Gone;
            loading = (ShapeLoadingViewCSharp.Widget.LoadingView)FindViewById(Resource.Id.loadView);
            initInstances();
            new Handler().PostDelayed(() =>
            {
                lv.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, strs);
                lv.ItemClick += delegate
                {
                    
                    Intent a = new Intent(this, typeof(detail));
                    StartActivity(a);
                };
                loading.Visibility = ViewStates.Gone;
                lv.Visibility = ViewStates.Visible;
            }, 4000);
        }
        private void initInstances()
        { 
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            //�ײ�������ť
            fabBtn = FindViewById<FloatingActionButton>(Resource.Id.fabBtn);
            fabBtn.SetOnClickListener(this);
            //v7��actionbar
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.SetTitleTextColor(Color.White);
            SetSupportActionBar(toolbar);
            //v7 ActionBar�ķ��ذ�ť
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
        }
        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.fabBtn:
                    //���������ť�����Ķ���
                    Snackbar sn = Snackbar.Make(v, "hello ssadasdasdasdas", Snackbar.LengthShort).SetAction("ȷ��", (s) =>
                    {
                    });
                    sn.Show();
                    ;
                    break;
            }
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