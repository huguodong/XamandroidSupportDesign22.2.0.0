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
    public class ShareFragment : Fragment
    {
        private View mParentView;
        private RecyclerView mRecyclerView;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            mParentView = inflater.Inflate(Resource.Layout.share_fragment, container, false);
            return mParentView;
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            mRecyclerView = (RecyclerView)mParentView.FindViewById(Resource.Id.recycler_view).JavaCast<RecyclerView>();

            LinearLayoutManager manager = new LinearLayoutManager(mRecyclerView.Context);
            manager.Orientation=LinearLayoutManager.Horizontal;
            mRecyclerView.SetLayoutManager(manager);
            mRecyclerView.SetAdapter(new RecyclerViewAdapter(Activity));
        }
    }
}