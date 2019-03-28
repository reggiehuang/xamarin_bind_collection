using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelAreaPicker", DoNotGenerateAcw=true)]
	public partial class WheelAreaPicker : global::Android.Widget.LinearLayout, global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelAreaPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelAreaPicker); }
		}

		protected WheelAreaPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']/constructor[@name='WheelAreaPicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelAreaPicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelAreaPicker)) {
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

		static Delegate cb_getArea;
#pragma warning disable 0169
		static Delegate GetGetAreaHandler ()
		{
			if (cb_getArea == null)
				cb_getArea = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetArea);
			return cb_getArea;
		}

		static IntPtr n_GetArea (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Area);
		}
#pragma warning restore 0169

		static IntPtr id_getArea;
		public virtual unsafe string Area {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']/method[@name='getArea' and count(parameter)=0]"
			[Register ("getArea", "()Ljava/lang/String;", "GetGetAreaHandler")]
			get {
				if (id_getArea == IntPtr.Zero)
					id_getArea = JNIEnv.GetMethodID (class_ref, "getArea", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArea), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArea", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCity;
#pragma warning disable 0169
		static Delegate GetGetCityHandler ()
		{
			if (cb_getCity == null)
				cb_getCity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCity);
			return cb_getCity;
		}

		static IntPtr n_GetCity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.City);
		}
#pragma warning restore 0169

		static IntPtr id_getCity;
		public virtual unsafe string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler")]
			get {
				if (id_getCity == IntPtr.Zero)
					id_getCity = JNIEnv.GetMethodID (class_ref, "getCity", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCity), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCity", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProvince;
#pragma warning disable 0169
		static Delegate GetGetProvinceHandler ()
		{
			if (cb_getProvince == null)
				cb_getProvince = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvince);
			return cb_getProvince;
		}

		static IntPtr n_GetProvince (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Province);
		}
#pragma warning restore 0169

		static IntPtr id_getProvince;
		public virtual unsafe string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler")]
			get {
				if (id_getProvince == IntPtr.Zero)
					id_getProvince = JNIEnv.GetMethodID (class_ref, "getProvince", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvince), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProvince", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hideArea;
#pragma warning disable 0169
		static Delegate GetHideAreaHandler ()
		{
			if (cb_hideArea == null)
				cb_hideArea = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideArea);
			return cb_hideArea;
		}

		static void n_HideArea (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideArea ();
		}
#pragma warning restore 0169

		static IntPtr id_hideArea;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelAreaPicker']/method[@name='hideArea' and count(parameter)=0]"
		[Register ("hideArea", "()V", "GetHideAreaHandler")]
		public virtual unsafe void HideArea ()
		{
			if (id_hideArea == IntPtr.Zero)
				id_hideArea = JNIEnv.GetMethodID (class_ref, "hideArea", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideArea);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideArea", "()V"));
			} finally {
			}
		}

	}
}
