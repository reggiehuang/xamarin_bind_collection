using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelAreaPicker']"
	[Register ("com/itheima/wheelpicker/widgets/IWheelAreaPicker", "", "Com.Itheima.Wheelpicker.Widgets.IWheelAreaPickerInvoker")]
	public partial interface IWheelAreaPicker : IJavaObject {

		string Area {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelAreaPicker']/method[@name='getArea' and count(parameter)=0]"
			[Register ("getArea", "()Ljava/lang/String;", "GetGetAreaHandler:Com.Itheima.Wheelpicker.Widgets.IWheelAreaPickerInvoker, Binding_WheelPicker")] get;
		}

		string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelAreaPicker']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler:Com.Itheima.Wheelpicker.Widgets.IWheelAreaPickerInvoker, Binding_WheelPicker")] get;
		}

		string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelAreaPicker']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler:Com.Itheima.Wheelpicker.Widgets.IWheelAreaPickerInvoker, Binding_WheelPicker")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelAreaPicker']/method[@name='hideArea' and count(parameter)=0]"
		[Register ("hideArea", "()V", "GetHideAreaHandler:Com.Itheima.Wheelpicker.Widgets.IWheelAreaPickerInvoker, Binding_WheelPicker")]
		void HideArea ();

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/IWheelAreaPicker", DoNotGenerateAcw=true)]
	internal class IWheelAreaPickerInvoker : global::Java.Lang.Object, IWheelAreaPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/IWheelAreaPicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelAreaPickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelAreaPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelAreaPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.IWheelAreaPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelAreaPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Area);
		}
#pragma warning restore 0169

		IntPtr id_getArea;
		public unsafe string Area {
			get {
				if (id_getArea == IntPtr.Zero)
					id_getArea = JNIEnv.GetMethodID (class_ref, "getArea", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getArea), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.City);
		}
#pragma warning restore 0169

		IntPtr id_getCity;
		public unsafe string City {
			get {
				if (id_getCity == IntPtr.Zero)
					id_getCity = JNIEnv.GetMethodID (class_ref, "getCity", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCity), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Province);
		}
#pragma warning restore 0169

		IntPtr id_getProvince;
		public unsafe string Province {
			get {
				if (id_getProvince == IntPtr.Zero)
					id_getProvince = JNIEnv.GetMethodID (class_ref, "getProvince", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvince), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelAreaPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideArea ();
		}
#pragma warning restore 0169

		IntPtr id_hideArea;
		public unsafe void HideArea ()
		{
			if (id_hideArea == IntPtr.Zero)
				id_hideArea = JNIEnv.GetMethodID (class_ref, "hideArea", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideArea);
		}

	}

}
