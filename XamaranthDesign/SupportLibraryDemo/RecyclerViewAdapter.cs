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

namespace SupportLibraryDemo
{
    public class RecyclerViewAdapter : RecyclerView.Adapter
    {
        private int[] colors = {Resource.Color.color_0,Resource.Color.color_1, Resource.Color.color_2, Resource.Color.color_3,
            Resource.Color.color_4, Resource.Color.color_5, Resource.Color.color_6, Resource.Color.color_7,
            Resource.Color.color_8, Resource.Color.color_9,};
        private Context mContext;
        public static TextView view;
        public RecyclerViewAdapter(Context mContext)
        {
            this.mContext = mContext;
        }

        public override int ItemCount
        {
            get
            {
                return colors.Length * 2;
            }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ViewHolder.mTextView.SetBackgroundColor(mContext.Resources.GetColor(colors[position % (colors.Length)]));
            ViewHolder.mTextView.Text = position + "";
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            view = (TextView)LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_item, parent, false);
            return new ViewHolder(view);
        }


        public  class ViewHolder : RecyclerView.ViewHolder
        {
            public static TextView mTextView;

            public ViewHolder(TextView view) : base(view)
            {
                mTextView = view;
            }
        }
    }
}