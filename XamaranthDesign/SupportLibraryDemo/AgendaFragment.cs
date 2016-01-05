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
using Android.Support.Design.Widget;
using Android.Text;
using Java.Lang;
using Android.Support.V4.App;

namespace SupportLibraryDemo
{
    public class AgendaFragment : Fragment, ITextWatcher, FloatingActionButton.IOnClickListener
    {
        private View mParentView;

        private TextInputLayout mTextInputLayout;
        private EditText mEditText;
        System.String[] strs = new System.String[] {
    "first", "second", "third", "fourth", "fifth","first", "second", "third", "fourth", "fifth","first", "second", "third", "fourth", "fifth"
    };
        ListView lv;
        private FloatingActionButton mFloatingActionButton;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            mParentView = inflater.Inflate(Resource.Layout.agenda_fragment, container, false);
            return mParentView;
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            DemoTextInputLayout();
            lv = mParentView.FindViewById<ListView>(Resource.Id.listView1);
            lv.Adapter = new ArrayAdapter<string>(null, Android.Resource.Layout.SimpleListItem1, strs);
            DemomFloatingActionButton();
        }
        private void DemoTextInputLayout()
        {
            mTextInputLayout = (TextInputLayout)mParentView.FindViewById(Resource.Id.text_input_layout).JavaCast<TextInputLayout>();
            mEditText = mTextInputLayout.EditText;
            mTextInputLayout.SetHint("请输入4位学号");

            mEditText.AddTextChangedListener(this);
        }
        private void DemomFloatingActionButton()
        {
            mFloatingActionButton = (FloatingActionButton)mParentView.FindViewById(Resource.Id.action_button).JavaCast<FloatingActionButton>();
            mFloatingActionButton.SetOnClickListener(this);
        }

        public void AfterTextChanged(IEditable s)
        {
        }

        public void BeforeTextChanged(ICharSequence s, int start, int count, int after)
        {
            if (s.Length() > 4)
            {
                mTextInputLayout.SetError("学号输入错误！");
                mTextInputLayout.SetErrorEnabled(true);
            }
            else
            {
                mTextInputLayout.SetErrorEnabled(false);
            }
        }

        public void OnTextChanged(ICharSequence s, int start, int before, int count)
        {

        }

        public void OnClick(View v)
        {
            Snackbar.Make(v, "结束当前Acitivty", Snackbar.LengthLong).SetAction("确定", ((e)=>
              {
                  Activity.Finish();
              })).Show();
        }
    }
}