using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelDayPicker", DoNotGenerateAcw=true)]
	public partial class WheelDayPicker : global::Com.Itheima.Wheelpicker.WheelPicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelDayPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelDayPicker); }
		}

		protected WheelDayPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/constructor[@name='WheelDayPicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WheelDayPicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelDayPicker)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/constructor[@name='WheelDayPicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelDayPicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelDayPicker)) {
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentDay;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDay;
		public virtual unsafe int CurrentDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='getCurrentDay' and count(parameter)=0]"
			[Register ("getCurrentDay", "()I", "GetGetCurrentDayHandler")]
			get {
				if (id_getCurrentDay == IntPtr.Zero)
					id_getCurrentDay = JNIEnv.GetMethodID (class_ref, "getCurrentDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDay", "()I"));
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Month = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMonth;
		static IntPtr id_setMonth_I;
		public virtual unsafe int Month {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='getMonth' and count(parameter)=0]"
			[Register ("getMonth", "()I", "GetGetMonthHandler")]
			get {
				if (id_getMonth == IntPtr.Zero)
					id_getMonth = JNIEnv.GetMethodID (class_ref, "getMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='setMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMonth", "(I)V", "GetSetMonth_IHandler")]
			set {
				if (id_setMonth_I == IntPtr.Zero)
					id_setMonth_I = JNIEnv.GetMethodID (class_ref, "setMonth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMonth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMonth", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDay;
		static IntPtr id_setSelectedDay_I;
		public virtual unsafe int SelectedDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='getSelectedDay' and count(parameter)=0]"
			[Register ("getSelectedDay", "()I", "GetGetSelectedDayHandler")]
			get {
				if (id_getSelectedDay == IntPtr.Zero)
					id_getSelectedDay = JNIEnv.GetMethodID (class_ref, "getSelectedDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedDay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedDay", "(I)V", "GetSetSelectedDay_IHandler")]
			set {
				if (id_setSelectedDay_I == IntPtr.Zero)
					id_setSelectedDay_I = JNIEnv.GetMethodID (class_ref, "setSelectedDay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedDay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedDay", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Year = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYear;
		static IntPtr id_setYear_I;
		public virtual unsafe int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='getYear' and count(parameter)=0]"
			[Register ("getYear", "()I", "GetGetYearHandler")]
			get {
				if (id_getYear == IntPtr.Zero)
					id_getYear = JNIEnv.GetMethodID (class_ref, "getYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYear", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='setYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYear", "(I)V", "GetSetYear_IHandler")]
			set {
				if (id_setYear_I == IntPtr.Zero)
					id_setYear_I = JNIEnv.GetMethodID (class_ref, "setYear", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYear_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYear", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearAndMonth (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYearAndMonth_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDayPicker']/method[@name='setYearAndMonth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setYearAndMonth", "(II)V", "GetSetYearAndMonth_IIHandler")]
		public virtual unsafe void SetYearAndMonth (int p0, int p1)
		{
			if (id_setYearAndMonth_II == IntPtr.Zero)
				id_setYearAndMonth_II = JNIEnv.GetMethodID (class_ref, "setYearAndMonth", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearAndMonth_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYearAndMonth", "(II)V"), __args);
			} finally {
			}
		}

	}
}
