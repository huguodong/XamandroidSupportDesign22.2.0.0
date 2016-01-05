using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Support.Design.Widget;

namespace SupportLibraryDemo
{
    [Activity(Label = "SubActivity")]
    public class SubActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_sub);

            Toolbar toolbar = (Toolbar)this.FindViewById(Resource.Id.tool_bar);
            SetSupportActionBar(toolbar);
            Android.Support.V7.App.ActionBar actionBar = SupportActionBar;
            actionBar.SetHomeAsUpIndicator(Android.Resource.Drawable.IcInputDelete);
            actionBar.SetDisplayHomeAsUpEnabled(true);

            CollapsingToolbarLayout collapsingToolbar =
                    (CollapsingToolbarLayout)FindViewById(Resource.Id.collapsing_toolbar);
            collapsingToolbar.SetTitle("œÍ«ÈΩÁ√Ê");
        }
    }
}