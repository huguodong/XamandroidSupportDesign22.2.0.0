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
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;
using Android.App;
using Android.Support.V7.App;
namespace XamaranthDesign
{
    [Activity(Label = "detail")]
    public class detail : AppCompatActivity
    {
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.mdetail);
            var toolbar = FindViewById< Android.Support.V7.Widget.Toolbar> (Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            var collapsingToolbar = FindViewById<CollapsingToolbarLayout>(Resource.Id.collapsing_toolbar);
            collapsingToolbar.SetTitle("≤‚ ‘≤‚ ‘");

            loadBackdrop();
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
        void loadBackdrop()
        {
            var imageView = FindViewById<ImageView>(Resource.Id.backdrop);
            FindViewById<TextView>(Resource.Id.text1).Text="≤‚ ‘";
            FindViewById<TextView>(Resource.Id.text2).Text = "≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘≤‚ ‘";
           // var r = Cheeses.GetRandomCheeseBackground();
            imageView.SetImageResource(Resource.Drawable.cheese_3);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.sample_actions, menu);
            return true;
        }
    }
}