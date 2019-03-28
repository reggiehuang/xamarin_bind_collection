using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flyco.Tablayout.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/utils/UnreadMsgUtils", DoNotGenerateAcw=true)]
	public partial class UnreadMsgUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flyco/tablayout/utils/UnreadMsgUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnreadMsgUtils); }
		}

		protected UnreadMsgUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/constructor[@name='UnreadMsgUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnreadMsgUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnreadMsgUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_setSize_Lcom_flyco_tablayout_widget_MsgView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/method[@name='setSize' and count(parameter)=2 and parameter[1][@type='com.flyco.tablayout.widget.MsgView'] and parameter[2][@type='int']]"
		[Register ("setSize", "(Lcom/flyco/tablayout/widget/MsgView;I)V", "")]
		public static unsafe void SetSize (global::Com.Flyco.Tablayout.Widget.MsgView p0, int p1)
		{
			if (id_setSize_Lcom_flyco_tablayout_widget_MsgView_I == IntPtr.Zero)
				id_setSize_Lcom_flyco_tablayout_widget_MsgView_I = JNIEnv.GetStaticMethodID (class_ref, "setSize", "(Lcom/flyco/tablayout/widget/MsgView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSize_Lcom_flyco_tablayout_widget_MsgView_I, __args);
			} finally {
			}
		}

		static IntPtr id_show_Lcom_flyco_tablayout_widget_MsgView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/method[@name='show' and count(parameter)=2 and parameter[1][@type='com.flyco.tablayout.widget.MsgView'] and parameter[2][@type='int']]"
		[Register ("show", "(Lcom/flyco/tablayout/widget/MsgView;I)V", "")]
		public static unsafe void Show (global::Com.Flyco.Tablayout.Widget.MsgView p0, int p1)
		{
			if (id_show_Lcom_flyco_tablayout_widget_MsgView_I == IntPtr.Zero)
				id_show_Lcom_flyco_tablayout_widget_MsgView_I = JNIEnv.GetStaticMethodID (class_ref, "show", "(Lcom/flyco/tablayout/widget/MsgView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_show_Lcom_flyco_tablayout_widget_MsgView_I, __args);
			} finally {
			}
		}

	}
}
