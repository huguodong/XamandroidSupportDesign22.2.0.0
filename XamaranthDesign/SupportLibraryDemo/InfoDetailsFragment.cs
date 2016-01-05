using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Support.V4.App;

namespace SupportLibraryDemo
{
    public class InfoDetailsFragment : Fragment
    {
        private RecyclerView mRecyclerView;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            mRecyclerView = (RecyclerView)inflater.Inflate(Resource.Layout.info_details_fragment, container, false).JavaCast<RecyclerView>();
            return mRecyclerView;
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            mRecyclerView.SetLayoutManager(new LinearLayoutManager(mRecyclerView.Context));
        }
    }
}