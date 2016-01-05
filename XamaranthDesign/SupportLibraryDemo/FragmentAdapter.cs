using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;
using Java.Lang;

namespace SupportLibraryDemo
{
    public class FragmentAdapter : FragmentStatePagerAdapter
    {
        private List<Android.Support.V4.App.Fragment> mFragments;
        private List<Java.Lang.String> mTitles;

        public FragmentAdapter(Android.Support.V4.App.FragmentManager fm, List<Android.Support.V4.App.Fragment> fragments, List<Java.Lang.String> titles) : base(fm)
        {

            mFragments = fragments;
            mTitles =titles;
        }

        public override int Count
        {
            get
            {
                return mFragments.Count;
            }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return mFragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return mTitles[position];
        }
    }
}