using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']"
	[Register ("com/itheima/wheelpicker/widgets/IWheelDatePicker", "", "Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker")]
	public partial interface IWheelDatePicker : IJavaObject {

		global::Java.Util.Date CurrentDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getCurrentDate' and count(parameter)=0]"
			[Register ("getCurrentDate", "()Ljava/util/Date;", "GetGetCurrentDateHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		int ItemAlignDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getItemAlignDay' and count(parameter)=0]"
			[Register ("getItemAlignDay", "()I", "GetGetItemAlignDayHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='setItemAlignDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignDay", "(I)V", "GetSetItemAlignDay_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemAlignMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getItemAlignMonth' and count(parameter)=0]"
			[Register ("getItemAlignMonth", "()I", "GetGetItemAlignMonthHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='setItemAlignMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignMonth", "(I)V", "GetSetItemAlignMonth_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemAlignYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getItemAlignYear' and count(parameter)=0]"
			[Register ("getItemAlignYear", "()I", "GetGetItemAlignYearHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='setItemAlignYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignYear", "(I)V", "GetSetItemAlignYear_IHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] set;
		}

		global::Android.Widget.TextView TextViewDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getTextViewDay' and count(parameter)=0]"
			[Register ("getTextViewDay", "()Landroid/widget/TextView;", "GetGetTextViewDayHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		global::Android.Widget.TextView TextViewMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getTextViewMonth' and count(parameter)=0]"
			[Register ("getTextViewMonth", "()Landroid/widget/TextView;", "GetGetTextViewMonthHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		global::Android.Widget.TextView TextViewYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getTextViewYear' and count(parameter)=0]"
			[Register ("getTextViewYear", "()Landroid/widget/TextView;", "GetGetTextViewYearHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker WheelDayPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getWheelDayPicker' and count(parameter)=0]"
			[Register ("getWheelDayPicker", "()Lcom/itheima/wheelpicker/widgets/WheelDayPicker;", "GetGetWheelDayPickerHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker WheelMonthPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getWheelMonthPicker' and count(parameter)=0]"
			[Register ("getWheelMonthPicker", "()Lcom/itheima/wheelpicker/widgets/WheelMonthPicker;", "GetGetWheelMonthPickerHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker WheelYearPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='getWheelYearPicker' and count(parameter)=0]"
			[Register ("getWheelYearPicker", "()Lcom/itheima/wheelpicker/widgets/WheelYearPicker;", "GetGetWheelYearPickerHandler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='IWheelDatePicker']/method[@name='setOnDateSelectedListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.widgets.WheelDatePicker.OnDateSelectedListener']]"
		[Register ("setOnDateSelectedListener", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener;)V", "GetSetOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_Handler:Com.Itheima.Wheelpicker.Widgets.IWheelDatePickerInvoker, Binding_WheelPicker")]
		void SetOnDateSelectedListener (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener p0);

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/IWheelDatePicker", DoNotGenerateAcw=true)]
	internal class IWheelDatePickerInvoker : global::Java.Lang.Object, IWheelDatePicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/IWheelDatePicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelDatePickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelDatePicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelDatePicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.IWheelDatePicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelDatePickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrentDate;
#pragma warning disable 0169
		static Delegate GetGetCurrentDateHandler ()
		{
			if (cb_getCurrentDate == null)
				cb_getCurrentDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentDate);
			return cb_getCurrentDate;
		}

		static IntPtr n_GetCurrentDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDate);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentDate;
		public unsafe global::Java.Util.Date CurrentDate {
			get {
				if (id_getCurrentDate == IntPtr.Zero)
					id_getCurrentDate = JNIEnv.GetMethodID (class_ref, "getCurrentDate", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDate), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getItemAlignDay;
#pragma warning disable 0169
		static Delegate GetGetItemAlignDayHandler ()
		{
			if (cb_getItemAlignDay == null)
				cb_getItemAlignDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemAlignDay);
			return cb_getItemAlignDay;
		}

		static int n_GetItemAlignDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemAlignDay;
		}
#pragma warning restore 0169

		static Delegate cb_setItemAlignDay_I;
#pragma warning disable 0169
		static Delegate GetSetItemAlignDay_IHandler ()
		{
			if (cb_setItemAlignDay_I == null)
				cb_setItemAlignDay_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemAlignDay_I);
			return cb_setItemAlignDay_I;
		}

		static void n_SetItemAlignDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignDay = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemAlignDay;
		IntPtr id_setItemAlignDay_I;
		public unsafe int ItemAlignDay {
			get {
				if (id_getItemAlignDay == IntPtr.Zero)
					id_getItemAlignDay = JNIEnv.GetMethodID (class_ref, "getItemAlignDay", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignDay);
			}
			set {
				if (id_setItemAlignDay_I == IntPtr.Zero)
					id_setItemAlignDay_I = JNIEnv.GetMethodID (class_ref, "setItemAlignDay", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignDay_I, __args);
			}
		}

		static Delegate cb_getItemAlignMonth;
#pragma warning disable 0169
		static Delegate GetGetItemAlignMonthHandler ()
		{
			if (cb_getItemAlignMonth == null)
				cb_getItemAlignMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemAlignMonth);
			return cb_getItemAlignMonth;
		}

		static int n_GetItemAlignMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemAlignMonth;
		}
#pragma warning restore 0169

		static Delegate cb_setItemAlignMonth_I;
#pragma warning disable 0169
		static Delegate GetSetItemAlignMonth_IHandler ()
		{
			if (cb_setItemAlignMonth_I == null)
				cb_setItemAlignMonth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemAlignMonth_I);
			return cb_setItemAlignMonth_I;
		}

		static void n_SetItemAlignMonth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignMonth = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemAlignMonth;
		IntPtr id_setItemAlignMonth_I;
		public unsafe int ItemAlignMonth {
			get {
				if (id_getItemAlignMonth == IntPtr.Zero)
					id_getItemAlignMonth = JNIEnv.GetMethodID (class_ref, "getItemAlignMonth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignMonth);
			}
			set {
				if (id_setItemAlignMonth_I == IntPtr.Zero)
					id_setItemAlignMonth_I = JNIEnv.GetMethodID (class_ref, "setItemAlignMonth", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignMonth_I, __args);
			}
		}

		static Delegate cb_getItemAlignYear;
#pragma warning disable 0169
		static Delegate GetGetItemAlignYearHandler ()
		{
			if (cb_getItemAlignYear == null)
				cb_getItemAlignYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemAlignYear);
			return cb_getItemAlignYear;
		}

		static int n_GetItemAlignYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemAlignYear;
		}
#pragma warning restore 0169

		static Delegate cb_setItemAlignYear_I;
#pragma warning disable 0169
		static Delegate GetSetItemAlignYear_IHandler ()
		{
			if (cb_setItemAlignYear_I == null)
				cb_setItemAlignYear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemAlignYear_I);
			return cb_setItemAlignYear_I;
		}

		static void n_SetItemAlignYear_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignYear = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemAlignYear;
		IntPtr id_setItemAlignYear_I;
		public unsafe int ItemAlignYear {
			get {
				if (id_getItemAlignYear == IntPtr.Zero)
					id_getItemAlignYear = JNIEnv.GetMethodID (class_ref, "getItemAlignYear", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignYear);
			}
			set {
				if (id_setItemAlignYear_I == IntPtr.Zero)
					id_setItemAlignYear_I = JNIEnv.GetMethodID (class_ref, "setItemAlignYear", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignYear_I, __args);
			}
		}

		static Delegate cb_getTextViewDay;
#pragma warning disable 0169
		static Delegate GetGetTextViewDayHandler ()
		{
			if (cb_getTextViewDay == null)
				cb_getTextViewDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextViewDay);
			return cb_getTextViewDay;
		}

		static IntPtr n_GetTextViewDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewDay);
		}
#pragma warning restore 0169

		IntPtr id_getTextViewDay;
		public unsafe global::Android.Widget.TextView TextViewDay {
			get {
				if (id_getTextViewDay == IntPtr.Zero)
					id_getTextViewDay = JNIEnv.GetMethodID (class_ref, "getTextViewDay", "()Landroid/widget/TextView;");
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewDay), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTextViewMonth;
#pragma warning disable 0169
		static Delegate GetGetTextViewMonthHandler ()
		{
			if (cb_getTextViewMonth == null)
				cb_getTextViewMonth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextViewMonth);
			return cb_getTextViewMonth;
		}

		static IntPtr n_GetTextViewMonth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewMonth);
		}
#pragma warning restore 0169

		IntPtr id_getTextViewMonth;
		public unsafe global::Android.Widget.TextView TextViewMonth {
			get {
				if (id_getTextViewMonth == IntPtr.Zero)
					id_getTextViewMonth = JNIEnv.GetMethodID (class_ref, "getTextViewMonth", "()Landroid/widget/TextView;");
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewMonth), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTextViewYear;
#pragma warning disable 0169
		static Delegate GetGetTextViewYearHandler ()
		{
			if (cb_getTextViewYear == null)
				cb_getTextViewYear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextViewYear);
			return cb_getTextViewYear;
		}

		static IntPtr n_GetTextViewYear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewYear);
		}
#pragma warning restore 0169

		IntPtr id_getTextViewYear;
		public unsafe global::Android.Widget.TextView TextViewYear {
			get {
				if (id_getTextViewYear == IntPtr.Zero)
					id_getTextViewYear = JNIEnv.GetMethodID (class_ref, "getTextViewYear", "()Landroid/widget/TextView;");
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewYear), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWheelDayPicker;
#pragma warning disable 0169
		static Delegate GetGetWheelDayPickerHandler ()
		{
			if (cb_getWheelDayPicker == null)
				cb_getWheelDayPicker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWheelDayPicker);
			return cb_getWheelDayPicker;
		}

		static IntPtr n_GetWheelDayPicker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelDayPicker);
		}
#pragma warning restore 0169

		IntPtr id_getWheelDayPicker;
		public unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker WheelDayPicker {
			get {
				if (id_getWheelDayPicker == IntPtr.Zero)
					id_getWheelDayPicker = JNIEnv.GetMethodID (class_ref, "getWheelDayPicker", "()Lcom/itheima/wheelpicker/widgets/WheelDayPicker;");
				return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelDayPicker), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWheelMonthPicker;
#pragma warning disable 0169
		static Delegate GetGetWheelMonthPickerHandler ()
		{
			if (cb_getWheelMonthPicker == null)
				cb_getWheelMonthPicker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWheelMonthPicker);
			return cb_getWheelMonthPicker;
		}

		static IntPtr n_GetWheelMonthPicker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelMonthPicker);
		}
#pragma warning restore 0169

		IntPtr id_getWheelMonthPicker;
		public unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker WheelMonthPicker {
			get {
				if (id_getWheelMonthPicker == IntPtr.Zero)
					id_getWheelMonthPicker = JNIEnv.GetMethodID (class_ref, "getWheelMonthPicker", "()Lcom/itheima/wheelpicker/widgets/WheelMonthPicker;");
				return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelMonthPicker), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWheelYearPicker;
#pragma warning disable 0169
		static Delegate GetGetWheelYearPickerHandler ()
		{
			if (cb_getWheelYearPicker == null)
				cb_getWheelYearPicker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWheelYearPicker);
			return cb_getWheelYearPicker;
		}

		static IntPtr n_GetWheelYearPicker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelYearPicker);
		}
#pragma warning restore 0169

		IntPtr id_getWheelYearPicker;
		public unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker WheelYearPicker {
			get {
				if (id_getWheelYearPicker == IntPtr.Zero)
					id_getWheelYearPicker = JNIEnv.GetMethodID (class_ref, "getWheelYearPicker", "()Lcom/itheima/wheelpicker/widgets/WheelYearPicker;");
				return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelYearPicker), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_Handler ()
		{
			if (cb_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ == null)
				cb_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_);
			return cb_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_;
		}

		static void n_SetOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener p0 = (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDateSelectedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_;
		public unsafe void SetOnDateSelectedListener (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener p0)
		{
			if (id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ == IntPtr.Zero)
				id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnDateSelectedListener", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_, __args);
		}

	}

}
