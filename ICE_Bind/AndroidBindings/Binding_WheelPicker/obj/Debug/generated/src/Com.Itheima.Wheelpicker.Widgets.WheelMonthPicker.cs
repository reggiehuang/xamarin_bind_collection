using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelMonthPicker", DoNotGenerateAcw=true)]
	public partial class WheelMonthPicker : global::Com.Itheima.Wheelpicker.WheelPicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelMonthPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelMonthPicker); }
		}

		protected WheelMonthPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']/constructor[@name='WheelMonthPicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WheelMonthPicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelMonthPicker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']/constructor[@name='WheelMonthPicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelMonthPicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelMonthPicker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentMonth;
#pragma warning disable 0169
		static Delegate GetGetCurrentMonthHandler ()
		{
			if (cb_getCurrentMonth == null)
				cb_getCurrentMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentMonth);
			return cb_getCurrentMonth;
		}

		static int n_GetCurrentMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentMonth;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentMonth;
		public virtual unsafe int CurrentMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']/method[@name='getCurrentMonth' and count(parameter)=0]"
			[Register ("getCurrentMonth", "()I", "GetGetCurrentMonthHandler")]
			get {
				if (id_getCurrentMonth == IntPtr.Zero)
					id_getCurrentMonth = JNIEnv.GetMethodID (class_ref, "getCurrentMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentMonth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedMonth;
#pragma warning disable 0169
		static Delegate GetGetSelectedMonthHandler ()
		{
			if (cb_getSelectedMonth == null)
				cb_getSelectedMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedMonth);
			return cb_getSelectedMonth;
		}

		static int n_GetSelectedMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedMonth;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedMonth_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedMonth_IHandler ()
		{
			if (cb_setSelectedMonth_I == null)
				cb_setSelectedMonth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedMonth_I);
			return cb_setSelectedMonth_I;
		}

		static void n_SetSelectedMonth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedMonth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedMonth;
		static IntPtr id_setSelectedMonth_I;
		public virtual unsafe int SelectedMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']/method[@name='getSelectedMonth' and count(parameter)=0]"
			[Register ("getSelectedMonth", "()I", "GetGetSelectedMonthHandler")]
			get {
				if (id_getSelectedMonth == IntPtr.Zero)
					id_getSelectedMonth = JNIEnv.GetMethodID (class_ref, "getSelectedMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedMonth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelMonthPicker']/method[@name='setSelectedMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedMonth", "(I)V", "GetSetSelectedMonth_IHandler")]
			set {
				if (id_setSelectedMonth_I == IntPtr.Zero)
					id_setSelectedMonth_I = JNIEnv.GetMethodID (class_ref, "setSelectedMonth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedMonth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedMonth", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
