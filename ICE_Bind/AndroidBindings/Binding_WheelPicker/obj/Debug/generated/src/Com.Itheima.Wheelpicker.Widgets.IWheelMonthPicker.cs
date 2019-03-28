using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelMonthPicker']"
	[Register ("com/itheima/wheelpicker/widgets/IWheelMonthPicker", "", "Com.Itheima.Wheelpicker.Widgets.IWheelMonthPickerInvoker")]
	public partial interface IWheelMonthPicker : IJavaObject {

		int CurrentMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelMonthPicker']/method[@name='getCurrentMonth' and count(parameter)=0]"
			[Register ("getCurrentMonth", "()I", "GetGetCurrentMonthHandler:Com.Itheima.Wheelpicker.Widgets.IWheelMonthPickerInvoker, Binding_WheelPicker")] get;
		}

		int SelectedMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelMonthPicker']/method[@name='getSelectedMonth' and count(parameter)=0]"
			[Register ("getSelectedMonth", "()I", "GetGetSelectedMonthHandler:Com.Itheima.Wheelpicker.Widgets.IWheelMonthPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelMonthPicker']/method[@name='setSelectedMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedMonth", "(I)V", "GetSetSelectedMonth_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelMonthPickerInvoker, Binding_WheelPicker")] set;
		}

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/IWheelMonthPicker", DoNotGenerateAcw=true)]
	internal class IWheelMonthPickerInvoker : global::Java.Lang.Object, IWheelMonthPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/IWheelMonthPicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelMonthPickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelMonthPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelMonthPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.IWheelMonthPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelMonthPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentMonth;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentMonth;
		public unsafe int CurrentMonth {
			get {
				if (id_getCurrentMonth == IntPtr.Zero)
					id_getCurrentMonth = JNIEnv.GetMethodID (class_ref, "getCurrentMonth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentMonth);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedMonth = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedMonth;
		IntPtr id_setSelectedMonth_I;
		public unsafe int SelectedMonth {
			get {
				if (id_getSelectedMonth == IntPtr.Zero)
					id_getSelectedMonth = JNIEnv.GetMethodID (class_ref, "getSelectedMonth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedMonth);
			}
			set {
				if (id_setSelectedMonth_I == IntPtr.Zero)
					id_setSelectedMonth_I = JNIEnv.GetMethodID (class_ref, "setSelectedMonth", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedMonth_I, __args);
			}
		}

	}

}
