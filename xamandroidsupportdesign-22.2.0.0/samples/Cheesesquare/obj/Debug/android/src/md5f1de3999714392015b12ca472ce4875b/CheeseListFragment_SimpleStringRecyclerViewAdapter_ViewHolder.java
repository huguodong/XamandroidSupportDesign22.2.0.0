package md5f1de3999714392015b12ca472ce4875b;


public class CheeseListFragment_SimpleStringRecyclerViewAdapter_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("Cheesesquare.CheeseListFragment+SimpleStringRecyclerViewAdapter+ViewHolder, Cheesesquare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CheeseListFragment_SimpleStringRecyclerViewAdapter_ViewHolder.class, __md_methods);
	}


	public CheeseListFragment_SimpleStringRecyclerViewAdapter_ViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CheeseListFragment_SimpleStringRecyclerViewAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("Cheesesquare.CheeseListFragment+SimpleStringRecyclerViewAdapter+ViewHolder, Cheesesquare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
