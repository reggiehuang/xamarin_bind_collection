using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']"
	[Register ("com/itheima/wheelpicker/widgets/IWheelDayPicker", "", "Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker")]
	public partial interface IWheelDayPicker : IJavaObject {

		int CurrentDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='getCurrentDay' and count(parameter)=0]"
			[Register ("getCurrentDay", "()I", "GetGetCurrentDayHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] get;
		}

		int Month {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='getMonth' and count(parameter)=0]"
			[Register ("getMonth", "()I", "GetGetMonthHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='setMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMonth", "(I)V", "GetSetMonth_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] set;
		}

		int SelectedDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='getSelectedDay' and count(parameter)=0]"
			[Register ("getSelectedDay", "()I", "GetGetSelectedDayHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedDay", "(I)V", "GetSetSelectedDay_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] set;
		}

		int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='getYear' and count(parameter)=0]"
			[Register ("getYear", "()I", "GetGetYearHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='setYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYear", "(I)V", "GetSetYear_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDayPicker']/method[@name='setYearAndMonth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setYearAndMonth", "(II)V", "GetSetYearAndMonth_IIHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDayPickerInvoker, Binding_WheelPicker")]
		void SetYearAndMonth (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/IWheelDayPicker", DoNotGenerateAcw=true)]
	internal class IWheelDayPickerInvoker : global::Java.Lang.Object, IWheelDayPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/IWheelDayPicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelDayPickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelDayPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelDayPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.IWheelDayPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelDayPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrentDay;
#pragma warning disable 0169
		static Delegate GetGetCurrentDayHandler ()
		{
			if (cb_getCurrentDay == null)
				cb_getCurrentDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentDay);
			return cb_getCurrentDay;
		}

		static int n_GetCurrentDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentDay;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentDay;
		public unsafe int CurrentDay {
			get {
				if (id_getCurrentDay == IntPtr.Zero)
					id_getCurrentDay = JNIEnv.GetMethodID (class_ref, "getCurrentDay", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDay);
			}
		}

		static Delegate cb_getMonth;
#pragma warning disable 0169
		static Delegate GetGetMonthHandler ()
		{
			if (cb_getMonth == null)
				cb_getMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMonth);
			return cb_getMonth;
		}

		static int n_GetMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Month;
		}
#pragma warning restore 0169

		static Delegate cb_setMonth_I;
#pragma warning disable 0169
		static Delegate GetSetMonth_IHandler ()
		{
			if (cb_setMonth_I == null)
				cb_setMonth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMonth_I);
			return cb_setMonth_I;
		}

		static void n_SetMonth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Month = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMonth;
		IntPtr id_setMonth_I;
		public unsafe int Month {
			get {
				if (id_getMonth == IntPtr.Zero)
					id_getMonth = JNIEnv.GetMethodID (class_ref, "getMonth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMonth);
			}
			set {
				if (id_setMonth_I == IntPtr.Zero)
					id_setMonth_I = JNIEnv.GetMethodID (class_ref, "setMonth", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMonth_I, __args);
			}
		}

		static Delegate cb_getSelectedDay;
#pragma warning disable 0169
		static Delegate GetGetSelectedDayHandler ()
		{
			if (cb_getSelectedDay == null)
				cb_getSelectedDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedDay);
			return cb_getSelectedDay;
		}

		static int n_GetSelectedDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedDay;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedDay_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedDay_IHandler ()
		{
			if (cb_setSelectedDay_I == null)
				cb_setSelectedDay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedDay_I);
			return cb_setSelectedDay_I;
		}

		static void n_SetSelectedDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedDay = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedDay;
		IntPtr id_setSelectedDay_I;
		public unsafe int SelectedDay {
			get {
				if (id_getSelectedDay == IntPtr.Zero)
					id_getSelectedDay = JNIEnv.GetMethodID (class_ref, "getSelectedDay", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDay);
			}
			set {
				if (id_setSelectedDay_I == IntPtr.Zero)
					id_setSelectedDay_I = JNIEnv.GetMethodID (class_ref, "setSelectedDay", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedDay_I, __args);
			}
		}

		static Delegate cb_getYear;
#pragma warning disable 0169
		static Delegate GetGetYearHandler ()
		{
			if (cb_getYear == null)
				cb_getYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYear);
			return cb_getYear;
		}

		static int n_GetYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Year;
		}
#pragma warning restore 0169

		static Delegate cb_setYear_I;
#pragma warning disable 0169
		static Delegate GetSetYear_IHandler ()
		{
			if (cb_setYear_I == null)
				cb_setYear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYear_I);
			return cb_setYear_I;
		}

		static void n_SetYear_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Year = p0;
		}
#pragma warning restore 0169

		IntPtr id_getYear;
		IntPtr id_setYear_I;
		public unsafe int Year {
			get {
				if (id_getYear == IntPtr.Zero)
					id_getYear = JNIEnv.GetMethodID (class_ref, "getYear", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYear);
			}
			set {
				if (id_setYear_I == IntPtr.Zero)
					id_setYear_I = JNIEnv.GetMethodID (class_ref, "setYear", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYear_I, __args);
			}
		}

		static Delegate cb_setYearAndMonth_II;
#pragma warning disable 0169
		static Delegate GetSetYearAndMonth_IIHandler ()
		{
			if (cb_setYearAndMonth_II == null)
				cb_setYearAndMonth_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetYearAndMonth_II);
			return cb_setYearAndMonth_II;
		}

		static void n_SetYearAndMonth_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearAndMonth (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setYearAndMonth_II;
		public unsafe void SetYearAndMonth (int p0, int p1)
		{
			if (id_setYearAndMonth_II == IntPtr.Zero)
				id_setYearAndMonth_II = JNIEnv.GetMethodID (class_ref, "setYearAndMonth", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearAndMonth_II, __args);
		}

	}

}
