using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']"
	[Register ("com/itheima/wheelpicker/widgets/IWheelYearPicker", "", "Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker")]
	public partial interface IWheelYearPicker : IJavaObject {

		int CurrentYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='getCurrentYear' and count(parameter)=0]"
			[Register ("getCurrentYear", "()I", "GetGetCurrentYearHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] get;
		}

		int SelectedYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='getSelectedYear' and count(parameter)=0]"
			[Register ("getSelectedYear", "()I", "GetGetSelectedYearHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='setSelectedYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedYear", "(I)V", "GetSetSelectedYear_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] set;
		}

		int YearEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='getYearEnd' and count(parameter)=0]"
			[Register ("getYearEnd", "()I", "GetGetYearEndHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='setYearEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYearEnd", "(I)V", "GetSetYearEnd_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] set;
		}

		int YearStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='getYearStart' and count(parameter)=0]"
			[Register ("getYearStart", "()I", "GetGetYearStartHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='setYearStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYearStart", "(I)V", "GetSetYearStart_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelYearPicker']/method[@name='setYearFrame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setYearFrame", "(II)V", "GetSetYearFrame_IIHandler:Com.Itheima.Wheelpicker.Widgets.IWheelYearPickerInvoker, Binding_WheelPicker")]
		void SetYearFrame (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/IWheelYearPicker", DoNotGenerateAcw=true)]
	internal class IWheelYearPickerInvoker : global::Java.Lang.Object, IWheelYearPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/IWheelYearPicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelYearPickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelYearPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelYearPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.IWheelYearPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelYearPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrentYear;
#pragma warning disable 0169
		static Delegate GetGetCurrentYearHandler ()
		{
			if (cb_getCurrentYear == null)
				cb_getCurrentYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentYear);
			return cb_getCurrentYear;
		}

		static int n_GetCurrentYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentYear;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentYear;
		public unsafe int CurrentYear {
			get {
				if (id_getCurrentYear == IntPtr.Zero)
					id_getCurrentYear = JNIEnv.GetMethodID (class_ref, "getCurrentYear", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentYear);
			}
		}

		static Delegate cb_getSelectedYear;
#pragma warning disable 0169
		static Delegate GetGetSelectedYearHandler ()
		{
			if (cb_getSelectedYear == null)
				cb_getSelectedYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedYear);
			return cb_getSelectedYear;
		}

		static int n_GetSelectedYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedYear;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedYear_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedYear_IHandler ()
		{
			if (cb_setSelectedYear_I == null)
				cb_setSelectedYear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedYear_I);
			return cb_setSelectedYear_I;
		}

		static void n_SetSelectedYear_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedYear = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedYear;
		IntPtr id_setSelectedYear_I;
		public unsafe int SelectedYear {
			get {
				if (id_getSelectedYear == IntPtr.Zero)
					id_getSelectedYear = JNIEnv.GetMethodID (class_ref, "getSelectedYear", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedYear);
			}
			set {
				if (id_setSelectedYear_I == IntPtr.Zero)
					id_setSelectedYear_I = JNIEnv.GetMethodID (class_ref, "setSelectedYear", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedYear_I, __args);
			}
		}

		static Delegate cb_getYearEnd;
#pragma warning disable 0169
		static Delegate GetGetYearEndHandler ()
		{
			if (cb_getYearEnd == null)
				cb_getYearEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYearEnd);
			return cb_getYearEnd;
		}

		static int n_GetYearEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YearEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setYearEnd_I;
#pragma warning disable 0169
		static Delegate GetSetYearEnd_IHandler ()
		{
			if (cb_setYearEnd_I == null)
				cb_setYearEnd_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYearEnd_I);
			return cb_setYearEnd_I;
		}

		static void n_SetYearEnd_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearEnd = p0;
		}
#pragma warning restore 0169

		IntPtr id_getYearEnd;
		IntPtr id_setYearEnd_I;
		public unsafe int YearEnd {
			get {
				if (id_getYearEnd == IntPtr.Zero)
					id_getYearEnd = JNIEnv.GetMethodID (class_ref, "getYearEnd", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearEnd);
			}
			set {
				if (id_setYearEnd_I == IntPtr.Zero)
					id_setYearEnd_I = JNIEnv.GetMethodID (class_ref, "setYearEnd", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearEnd_I, __args);
			}
		}

		static Delegate cb_getYearStart;
#pragma warning disable 0169
		static Delegate GetGetYearStartHandler ()
		{
			if (cb_getYearStart == null)
				cb_getYearStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYearStart);
			return cb_getYearStart;
		}

		static int n_GetYearStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YearStart;
		}
#pragma warning restore 0169

		static Delegate cb_setYearStart_I;
#pragma warning disable 0169
		static Delegate GetSetYearStart_IHandler ()
		{
			if (cb_setYearStart_I == null)
				cb_setYearStart_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYearStart_I);
			return cb_setYearStart_I;
		}

		static void n_SetYearStart_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearStart = p0;
		}
#pragma warning restore 0169

		IntPtr id_getYearStart;
		IntPtr id_setYearStart_I;
		public unsafe int YearStart {
			get {
				if (id_getYearStart == IntPtr.Zero)
					id_getYearStart = JNIEnv.GetMethodID (class_ref, "getYearStart", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearStart);
			}
			set {
				if (id_setYearStart_I == IntPtr.Zero)
					id_setYearStart_I = JNIEnv.GetMethodID (class_ref, "setYearStart", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearStart_I, __args);
			}
		}

		static Delegate cb_setYearFrame_II;
#pragma warning disable 0169
		static Delegate GetSetYearFrame_IIHandler ()
		{
			if (cb_setYearFrame_II == null)
				cb_setYearFrame_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetYearFrame_II);
			return cb_setYearFrame_II;
		}

		static void n_SetYearFrame_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearFrame (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setYearFrame_II;
		public unsafe void SetYearFrame (int p0, int p1)
		{
			if (id_setYearFrame_II == IntPtr.Zero)
				id_setYearFrame_II = JNIEnv.GetMethodID (class_ref, "setYearFrame", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearFrame_II, __args);
		}

	}

}
