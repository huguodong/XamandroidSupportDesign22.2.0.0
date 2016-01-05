using System;
using System.Collections.Generic;
using Android.Runtime;

namespace DE.Hdodenhof.Circleimageview {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R']"
	[global::Android.Runtime.Register ("de/hdodenhof/circleimageview/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("de/hdodenhof/circleimageview/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']/field[@name='civ_border_color']"
			[Register ("civ_border_color")]
			public const int CivBorderColor = (int) 2130771969;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']/field[@name='civ_border_overlay']"
			[Register ("civ_border_overlay")]
			public const int CivBorderOverlay = (int) 2130771970;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']/field[@name='civ_border_width']"
			[Register ("civ_border_width")]
			public const int CivBorderWidth = (int) 2130771968;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']/field[@name='civ_fill_color']"
			[Register ("civ_fill_color")]
			public const int CivFillColor = (int) 2130771971;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("de/hdodenhof/circleimageview/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Attr)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']"
		[global::Android.Runtime.Register ("de/hdodenhof/circleimageview/R$styleable", DoNotGenerateAcw=true)]
		public sealed partial class Styleable : global::Java.Lang.Object {


			static IntPtr CircleImageView_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/field[@name='CircleImageView']"
			[Register ("CircleImageView")]
			public static IList<int> CircleImageView {
				get {
					if (CircleImageView_jfieldId == IntPtr.Zero)
						CircleImageView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CircleImageView", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, CircleImageView_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/field[@name='CircleImageView_civ_border_color']"
			[Register ("CircleImageView_civ_border_color")]
			public const int CircleImageViewCivBorderColor = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/field[@name='CircleImageView_civ_border_overlay']"
			[Register ("CircleImageView_civ_border_overlay")]
			public const int CircleImageViewCivBorderOverlay = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/field[@name='CircleImageView_civ_border_width']"
			[Register ("CircleImageView_civ_border_width")]
			public const int CircleImageViewCivBorderWidth = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/field[@name='CircleImageView_civ_fill_color']"
			[Register ("CircleImageView_civ_fill_color")]
			public const int CircleImageViewCivFillColor = (int) 3;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("de/hdodenhof/circleimageview/R$styleable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Styleable); }
			}

			internal Styleable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R.styleable']/constructor[@name='R.styleable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Styleable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Styleable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/hdodenhof/circleimageview/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.hdodenhof.circleimageview']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
