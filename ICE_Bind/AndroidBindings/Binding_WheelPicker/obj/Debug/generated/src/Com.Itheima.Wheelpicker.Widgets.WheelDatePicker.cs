using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelDatePicker", DoNotGenerateAcw=true)]
	public partial class WheelDatePicker : global::Android.Widget.LinearLayout, global::Com.Itheima.Wheelpicker.IDebug, global::Com.Itheima.Wheelpicker.IWheelPicker, global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener, global::Com.Itheima.Wheelpicker.Widgets.IWheelDatePicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelDayPicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelMonthPicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='WheelDatePicker.OnDateSelectedListener']"
		[Register ("com/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener", "", "Com.Itheima.Wheelpicker.Widgets.WheelDatePicker/IOnDateSelectedListenerInvoker")]
		public partial interface IOnDateSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/interface[@name='WheelDatePicker.OnDateSelectedListener']/method[@name='onDateSelected' and count(parameter)=2 and parameter[1][@type='com.itheima.wheelpicker.widgets.WheelDatePicker'] and parameter[2][@type='java.util.Date']]"
			[Register ("onDateSelected", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker;Ljava/util/Date;)V", "GetOnDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_Handler:Com.Itheima.Wheelpicker.Widgets.WheelDatePicker/IOnDateSelectedListenerInvoker, Binding_WheelPicker")]
			void OnDateSelected (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0, global::Java.Util.Date p1);

		}

		[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnDateSelectedListenerInvoker : global::Java.Lang.Object, IOnDateSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnDateSelectedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnDateSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDateSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.widgets.WheelDatePicker.OnDateSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDateSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_;
#pragma warning disable 0169
			static Delegate GetOnDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_Handler ()
			{
				if (cb_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_ == null)
					cb_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_);
				return cb_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_;
			}

			static void n_OnDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0 = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnDateSelected (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_;
			public unsafe void OnDateSelected (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0, global::Java.Util.Date p1)
			{
				if (id_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_ == IntPtr.Zero)
					id_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "onDateSelected", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker;Ljava/util/Date;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDateSelected_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_Ljava_util_Date_, __args);
			}

		}

		public partial class DateSelectedEventArgs : global::System.EventArgs {

			public DateSelectedEventArgs (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0, global::Java.Util.Date p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0;
			public global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker P0 {
				get { return p0; }
			}

			global::Java.Util.Date p1;
			public global::Java.Util.Date P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/itheima/wheelpicker/widgets/WheelDatePicker_OnDateSelectedListenerImplementor")]
		internal sealed partial class IOnDateSelectedListenerImplementor : global::Java.Lang.Object, IOnDateSelectedListener {

			object sender;

			public IOnDateSelectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/itheima/wheelpicker/widgets/WheelDatePicker_OnDateSelectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DateSelectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnDateSelected (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker p0, global::Java.Util.Date p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DateSelectedEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnDateSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelDatePicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelDatePicker); }
		}

		protected WheelDatePicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/constructor[@name='WheelDatePicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WheelDatePicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelDatePicker)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/constructor[@name='WheelDatePicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelDatePicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelDatePicker)) {
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDate);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDate;
		public virtual unsafe global::Java.Util.Date CurrentDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurrentDate' and count(parameter)=0]"
			[Register ("getCurrentDate", "()Ljava/util/Date;", "GetGetCurrentDateHandler")]
			get {
				if (id_getCurrentDate == IntPtr.Zero)
					id_getCurrentDate = JNIEnv.GetMethodID (class_ref, "getCurrentDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentDay;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDay;
		public virtual unsafe int CurrentDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurrentDay' and count(parameter)=0]"
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

		static Delegate cb_getCurrentItemPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemPositionHandler ()
		{
			if (cb_getCurrentItemPosition == null)
				cb_getCurrentItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentItemPosition);
			return cb_getCurrentItemPosition;
		}

		static int n_GetCurrentItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentItemPosition;
		[Obsolete (@"deprecated")]
		public virtual unsafe int CurrentItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurrentItemPosition' and count(parameter)=0]"
			[Register ("getCurrentItemPosition", "()I", "GetGetCurrentItemPositionHandler")]
			get {
				if (id_getCurrentItemPosition == IntPtr.Zero)
					id_getCurrentItemPosition = JNIEnv.GetMethodID (class_ref, "getCurrentItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentItemPosition", "()I"));
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentMonth;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentMonth;
		public virtual unsafe int CurrentMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurrentMonth' and count(parameter)=0]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentYear;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentYear;
		public virtual unsafe int CurrentYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurrentYear' and count(parameter)=0]"
			[Register ("getCurrentYear", "()I", "GetGetCurrentYearHandler")]
			get {
				if (id_getCurrentYear == IntPtr.Zero)
					id_getCurrentYear = JNIEnv.GetMethodID (class_ref, "getCurrentYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentYear", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurtainColor;
#pragma warning disable 0169
		static Delegate GetGetCurtainColorHandler ()
		{
			if (cb_getCurtainColor == null)
				cb_getCurtainColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurtainColor);
			return cb_getCurtainColor;
		}

		static int n_GetCurtainColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurtainColor;
		}
#pragma warning restore 0169

		static Delegate cb_setCurtainColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurtainColor_IHandler ()
		{
			if (cb_setCurtainColor_I == null)
				cb_setCurtainColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurtainColor_I);
			return cb_setCurtainColor_I;
		}

		static void n_SetCurtainColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurtainColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurtainColor;
		static IntPtr id_setCurtainColor_I;
		public virtual unsafe int CurtainColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getCurtainColor' and count(parameter)=0]"
			[Register ("getCurtainColor", "()I", "GetGetCurtainColorHandler")]
			get {
				if (id_getCurtainColor == IntPtr.Zero)
					id_getCurtainColor = JNIEnv.GetMethodID (class_ref, "getCurtainColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurtainColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurtainColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setCurtainColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurtainColor", "(I)V", "GetSetCurtainColor_IHandler")]
			set {
				if (id_setCurtainColor_I == IntPtr.Zero)
					id_setCurtainColor_I = JNIEnv.GetMethodID (class_ref, "setCurtainColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtainColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurtainColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCurved;
#pragma warning disable 0169
		static Delegate GetIsCurvedHandler ()
		{
			if (cb_isCurved == null)
				cb_isCurved = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurved);
			return cb_isCurved;
		}

		static bool n_IsCurved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Curved;
		}
#pragma warning restore 0169

		static Delegate cb_setCurved_Z;
#pragma warning disable 0169
		static Delegate GetSetCurved_ZHandler ()
		{
			if (cb_setCurved_Z == null)
				cb_setCurved_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurved_Z);
			return cb_setCurved_Z;
		}

		static void n_SetCurved_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Curved = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCurved;
		static IntPtr id_setCurved_Z;
		public virtual unsafe bool Curved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='isCurved' and count(parameter)=0]"
			[Register ("isCurved", "()Z", "GetIsCurvedHandler")]
			get {
				if (id_isCurved == IntPtr.Zero)
					id_isCurved = JNIEnv.GetMethodID (class_ref, "isCurved", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurved);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurved", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setCurved' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCurved", "(Z)V", "GetSetCurved_ZHandler")]
			set {
				if (id_setCurved_Z == IntPtr.Zero)
					id_setCurved_Z = JNIEnv.GetMethodID (class_ref, "setCurved", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurved_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurved", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCyclic;
#pragma warning disable 0169
		static Delegate GetIsCyclicHandler ()
		{
			if (cb_isCyclic == null)
				cb_isCyclic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCyclic);
			return cb_isCyclic;
		}

		static bool n_IsCyclic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cyclic;
		}
#pragma warning restore 0169

		static Delegate cb_setCyclic_Z;
#pragma warning disable 0169
		static Delegate GetSetCyclic_ZHandler ()
		{
			if (cb_setCyclic_Z == null)
				cb_setCyclic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCyclic_Z);
			return cb_setCyclic_Z;
		}

		static void n_SetCyclic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cyclic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCyclic;
		static IntPtr id_setCyclic_Z;
		public virtual unsafe bool Cyclic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='isCyclic' and count(parameter)=0]"
			[Register ("isCyclic", "()Z", "GetIsCyclicHandler")]
			get {
				if (id_isCyclic == IntPtr.Zero)
					id_isCyclic = JNIEnv.GetMethodID (class_ref, "isCyclic", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCyclic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCyclic", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCyclic", "(Z)V", "GetSetCyclic_ZHandler")]
			set {
				if (id_setCyclic_Z == IntPtr.Zero)
					id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCyclic_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCyclic", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_util_List_;
		[Obsolete (@"deprecated")]
		public virtual unsafe global::System.Collections.IList Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/List;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler")]
			set {
				if (id_setData_Ljava_util_List_ == IntPtr.Zero)
					id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hasAtmospheric;
#pragma warning disable 0169
		static Delegate GetHasAtmosphericHandler ()
		{
			if (cb_hasAtmospheric == null)
				cb_hasAtmospheric = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAtmospheric);
			return cb_hasAtmospheric;
		}

		static bool n_HasAtmospheric (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAtmospheric;
		}
#pragma warning restore 0169

		static IntPtr id_hasAtmospheric;
		public virtual unsafe bool HasAtmospheric {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='hasAtmospheric' and count(parameter)=0]"
			[Register ("hasAtmospheric", "()Z", "GetHasAtmosphericHandler")]
			get {
				if (id_hasAtmospheric == IntPtr.Zero)
					id_hasAtmospheric = JNIEnv.GetMethodID (class_ref, "hasAtmospheric", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasAtmospheric);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAtmospheric", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasCurtain;
#pragma warning disable 0169
		static Delegate GetHasCurtainHandler ()
		{
			if (cb_hasCurtain == null)
				cb_hasCurtain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCurtain);
			return cb_hasCurtain;
		}

		static bool n_HasCurtain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCurtain;
		}
#pragma warning restore 0169

		static IntPtr id_hasCurtain;
		public virtual unsafe bool HasCurtain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='hasCurtain' and count(parameter)=0]"
			[Register ("hasCurtain", "()Z", "GetHasCurtainHandler")]
			get {
				if (id_hasCurtain == IntPtr.Zero)
					id_hasCurtain = JNIEnv.GetMethodID (class_ref, "hasCurtain", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCurtain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCurtain", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasIndicator;
#pragma warning disable 0169
		static Delegate GetHasIndicatorHandler ()
		{
			if (cb_hasIndicator == null)
				cb_hasIndicator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIndicator);
			return cb_hasIndicator;
		}

		static bool n_HasIndicator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIndicator;
		}
#pragma warning restore 0169

		static IntPtr id_hasIndicator;
		public virtual unsafe bool HasIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='hasIndicator' and count(parameter)=0]"
			[Register ("hasIndicator", "()Z", "GetHasIndicatorHandler")]
			get {
				if (id_hasIndicator == IntPtr.Zero)
					id_hasIndicator = JNIEnv.GetMethodID (class_ref, "hasIndicator", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasIndicator);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasIndicator", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasSameWidth;
#pragma warning disable 0169
		static Delegate GetHasSameWidthHandler ()
		{
			if (cb_hasSameWidth == null)
				cb_hasSameWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSameWidth);
			return cb_hasSameWidth;
		}

		static bool n_HasSameWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSameWidth;
		}
#pragma warning restore 0169

		static IntPtr id_hasSameWidth;
		[Obsolete (@"deprecated")]
		public virtual unsafe bool HasSameWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='hasSameWidth' and count(parameter)=0]"
			[Register ("hasSameWidth", "()Z", "GetHasSameWidthHandler")]
			get {
				if (id_hasSameWidth == IntPtr.Zero)
					id_hasSameWidth = JNIEnv.GetMethodID (class_ref, "hasSameWidth", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSameWidth);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSameWidth", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorColor;
#pragma warning disable 0169
		static Delegate GetGetIndicatorColorHandler ()
		{
			if (cb_getIndicatorColor == null)
				cb_getIndicatorColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorColor);
			return cb_getIndicatorColor;
		}

		static int n_GetIndicatorColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorColor;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorColor_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorColor_IHandler ()
		{
			if (cb_setIndicatorColor_I == null)
				cb_setIndicatorColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorColor_I);
			return cb_setIndicatorColor_I;
		}

		static void n_SetIndicatorColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorColor;
		static IntPtr id_setIndicatorColor_I;
		public virtual unsafe int IndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getIndicatorColor' and count(parameter)=0]"
			[Register ("getIndicatorColor", "()I", "GetGetIndicatorColorHandler")]
			get {
				if (id_getIndicatorColor == IntPtr.Zero)
					id_getIndicatorColor = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
			set {
				if (id_setIndicatorColor_I == IntPtr.Zero)
					id_setIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorSize;
#pragma warning disable 0169
		static Delegate GetGetIndicatorSizeHandler ()
		{
			if (cb_getIndicatorSize == null)
				cb_getIndicatorSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorSize);
			return cb_getIndicatorSize;
		}

		static int n_GetIndicatorSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorSize;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorSize_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorSize_IHandler ()
		{
			if (cb_setIndicatorSize_I == null)
				cb_setIndicatorSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorSize_I);
			return cb_setIndicatorSize_I;
		}

		static void n_SetIndicatorSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorSize;
		static IntPtr id_setIndicatorSize_I;
		public virtual unsafe int IndicatorSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getIndicatorSize' and count(parameter)=0]"
			[Register ("getIndicatorSize", "()I", "GetGetIndicatorSizeHandler")]
			get {
				if (id_getIndicatorSize == IntPtr.Zero)
					id_getIndicatorSize = JNIEnv.GetMethodID (class_ref, "getIndicatorSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setIndicatorSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorSize", "(I)V", "GetSetIndicatorSize_IHandler")]
			set {
				if (id_setIndicatorSize_I == IntPtr.Zero)
					id_setIndicatorSize_I = JNIEnv.GetMethodID (class_ref, "setIndicatorSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemAlign;
#pragma warning disable 0169
		static Delegate GetGetItemAlignHandler ()
		{
			if (cb_getItemAlign == null)
				cb_getItemAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemAlign);
			return cb_getItemAlign;
		}

		static int n_GetItemAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemAlign;
		}
#pragma warning restore 0169

		static Delegate cb_setItemAlign_I;
#pragma warning disable 0169
		static Delegate GetSetItemAlign_IHandler ()
		{
			if (cb_setItemAlign_I == null)
				cb_setItemAlign_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemAlign_I);
			return cb_setItemAlign_I;
		}

		static void n_SetItemAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlign = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemAlign;
		static IntPtr id_setItemAlign_I;
		[Obsolete (@"deprecated")]
		public virtual unsafe int ItemAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemAlign' and count(parameter)=0]"
			[Register ("getItemAlign", "()I", "GetGetItemAlignHandler")]
			get {
				if (id_getItemAlign == IntPtr.Zero)
					id_getItemAlign = JNIEnv.GetMethodID (class_ref, "getItemAlign", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlign);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAlign", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemAlign' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlign", "(I)V", "GetSetItemAlign_IHandler")]
			set {
				if (id_setItemAlign_I == IntPtr.Zero)
					id_setItemAlign_I = JNIEnv.GetMethodID (class_ref, "setItemAlign", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlign_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAlign", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemAlignDay;
		static IntPtr id_setItemAlignDay_I;
		public virtual unsafe int ItemAlignDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemAlignDay' and count(parameter)=0]"
			[Register ("getItemAlignDay", "()I", "GetGetItemAlignDayHandler")]
			get {
				if (id_getItemAlignDay == IntPtr.Zero)
					id_getItemAlignDay = JNIEnv.GetMethodID (class_ref, "getItemAlignDay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignDay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAlignDay", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemAlignDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignDay", "(I)V", "GetSetItemAlignDay_IHandler")]
			set {
				if (id_setItemAlignDay_I == IntPtr.Zero)
					id_setItemAlignDay_I = JNIEnv.GetMethodID (class_ref, "setItemAlignDay", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignDay_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAlignDay", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignMonth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemAlignMonth;
		static IntPtr id_setItemAlignMonth_I;
		public virtual unsafe int ItemAlignMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemAlignMonth' and count(parameter)=0]"
			[Register ("getItemAlignMonth", "()I", "GetGetItemAlignMonthHandler")]
			get {
				if (id_getItemAlignMonth == IntPtr.Zero)
					id_getItemAlignMonth = JNIEnv.GetMethodID (class_ref, "getItemAlignMonth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignMonth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAlignMonth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemAlignMonth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignMonth", "(I)V", "GetSetItemAlignMonth_IHandler")]
			set {
				if (id_setItemAlignMonth_I == IntPtr.Zero)
					id_setItemAlignMonth_I = JNIEnv.GetMethodID (class_ref, "setItemAlignMonth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignMonth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAlignMonth", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlignYear = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemAlignYear;
		static IntPtr id_setItemAlignYear_I;
		public virtual unsafe int ItemAlignYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemAlignYear' and count(parameter)=0]"
			[Register ("getItemAlignYear", "()I", "GetGetItemAlignYearHandler")]
			get {
				if (id_getItemAlignYear == IntPtr.Zero)
					id_getItemAlignYear = JNIEnv.GetMethodID (class_ref, "getItemAlignYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlignYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAlignYear", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemAlignYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlignYear", "(I)V", "GetSetItemAlignYear_IHandler")]
			set {
				if (id_setItemAlignYear_I == IntPtr.Zero)
					id_setItemAlignYear_I = JNIEnv.GetMethodID (class_ref, "setItemAlignYear", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlignYear_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAlignYear", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemSpace;
#pragma warning disable 0169
		static Delegate GetGetItemSpaceHandler ()
		{
			if (cb_getItemSpace == null)
				cb_getItemSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemSpace);
			return cb_getItemSpace;
		}

		static int n_GetItemSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setItemSpace_I;
#pragma warning disable 0169
		static Delegate GetSetItemSpace_IHandler ()
		{
			if (cb_setItemSpace_I == null)
				cb_setItemSpace_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemSpace_I);
			return cb_setItemSpace_I;
		}

		static void n_SetItemSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemSpace = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemSpace;
		static IntPtr id_setItemSpace_I;
		public virtual unsafe int ItemSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemSpace' and count(parameter)=0]"
			[Register ("getItemSpace", "()I", "GetGetItemSpaceHandler")]
			get {
				if (id_getItemSpace == IntPtr.Zero)
					id_getItemSpace = JNIEnv.GetMethodID (class_ref, "getItemSpace", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemSpace);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemSpace", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemSpace", "(I)V", "GetSetItemSpace_IHandler")]
			set {
				if (id_setItemSpace_I == IntPtr.Zero)
					id_setItemSpace_I = JNIEnv.GetMethodID (class_ref, "setItemSpace", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemSpace_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemSpace", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemTextColor;
#pragma warning disable 0169
		static Delegate GetGetItemTextColorHandler ()
		{
			if (cb_getItemTextColor == null)
				cb_getItemTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemTextColor);
			return cb_getItemTextColor;
		}

		static int n_GetItemTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setItemTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetItemTextColor_IHandler ()
		{
			if (cb_setItemTextColor_I == null)
				cb_setItemTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemTextColor_I);
			return cb_setItemTextColor_I;
		}

		static void n_SetItemTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemTextColor;
		static IntPtr id_setItemTextColor_I;
		public virtual unsafe int ItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemTextColor' and count(parameter)=0]"
			[Register ("getItemTextColor", "()I", "GetGetItemTextColorHandler")]
			get {
				if (id_getItemTextColor == IntPtr.Zero)
					id_getItemTextColor = JNIEnv.GetMethodID (class_ref, "getItemTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextColor", "(I)V", "GetSetItemTextColor_IHandler")]
			set {
				if (id_setItemTextColor_I == IntPtr.Zero)
					id_setItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setItemTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemTextSize;
#pragma warning disable 0169
		static Delegate GetGetItemTextSizeHandler ()
		{
			if (cb_getItemTextSize == null)
				cb_getItemTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemTextSize);
			return cb_getItemTextSize;
		}

		static int n_GetItemTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setItemTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetItemTextSize_IHandler ()
		{
			if (cb_setItemTextSize_I == null)
				cb_setItemTextSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemTextSize_I);
			return cb_setItemTextSize_I;
		}

		static void n_SetItemTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemTextSize;
		static IntPtr id_setItemTextSize_I;
		public virtual unsafe int ItemTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getItemTextSize' and count(parameter)=0]"
			[Register ("getItemTextSize", "()I", "GetGetItemTextSizeHandler")]
			get {
				if (id_getItemTextSize == IntPtr.Zero)
					id_getItemTextSize = JNIEnv.GetMethodID (class_ref, "getItemTextSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemTextSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setItemTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextSize", "(I)V", "GetSetItemTextSize_IHandler")]
			set {
				if (id_setItemTextSize_I == IntPtr.Zero)
					id_setItemTextSize_I = JNIEnv.GetMethodID (class_ref, "setItemTextSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemTextSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumWidthText;
#pragma warning disable 0169
		static Delegate GetGetMaximumWidthTextHandler ()
		{
			if (cb_getMaximumWidthText == null)
				cb_getMaximumWidthText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaximumWidthText);
			return cb_getMaximumWidthText;
		}

		static IntPtr n_GetMaximumWidthText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaximumWidthText);
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumWidthText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaximumWidthText_Ljava_lang_String_Handler ()
		{
			if (cb_setMaximumWidthText_Ljava_lang_String_ == null)
				cb_setMaximumWidthText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumWidthText_Ljava_lang_String_);
			return cb_setMaximumWidthText_Ljava_lang_String_;
		}

		static void n_SetMaximumWidthText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumWidthText;
		static IntPtr id_setMaximumWidthText_Ljava_lang_String_;
		[Obsolete (@"deprecated")]
		public virtual unsafe string MaximumWidthText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getMaximumWidthText' and count(parameter)=0]"
			[Register ("getMaximumWidthText", "()Ljava/lang/String;", "GetGetMaximumWidthTextHandler")]
			get {
				if (id_getMaximumWidthText == IntPtr.Zero)
					id_getMaximumWidthText = JNIEnv.GetMethodID (class_ref, "getMaximumWidthText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumWidthText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setMaximumWidthText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaximumWidthText", "(Ljava/lang/String;)V", "GetSetMaximumWidthText_Ljava_lang_String_Handler")]
			set {
				if (id_setMaximumWidthText_Ljava_lang_String_ == IntPtr.Zero)
					id_setMaximumWidthText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMaximumWidthText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumWidthText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMaximumWidthTextPosition;
#pragma warning disable 0169
		static Delegate GetGetMaximumWidthTextPositionHandler ()
		{
			if (cb_getMaximumWidthTextPosition == null)
				cb_getMaximumWidthTextPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumWidthTextPosition);
			return cb_getMaximumWidthTextPosition;
		}

		static int n_GetMaximumWidthTextPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumWidthTextPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumWidthTextPosition_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumWidthTextPosition_IHandler ()
		{
			if (cb_setMaximumWidthTextPosition_I == null)
				cb_setMaximumWidthTextPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumWidthTextPosition_I);
			return cb_setMaximumWidthTextPosition_I;
		}

		static void n_SetMaximumWidthTextPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthTextPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumWidthTextPosition;
		static IntPtr id_setMaximumWidthTextPosition_I;
		[Obsolete (@"deprecated")]
		public virtual unsafe int MaximumWidthTextPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getMaximumWidthTextPosition' and count(parameter)=0]"
			[Register ("getMaximumWidthTextPosition", "()I", "GetGetMaximumWidthTextPositionHandler")]
			get {
				if (id_getMaximumWidthTextPosition == IntPtr.Zero)
					id_getMaximumWidthTextPosition = JNIEnv.GetMethodID (class_ref, "getMaximumWidthTextPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthTextPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumWidthTextPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setMaximumWidthTextPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumWidthTextPosition", "(I)V", "GetSetMaximumWidthTextPosition_IHandler")]
			set {
				if (id_setMaximumWidthTextPosition_I == IntPtr.Zero)
					id_setMaximumWidthTextPosition_I = JNIEnv.GetMethodID (class_ref, "setMaximumWidthTextPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthTextPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumWidthTextPosition", "(I)V"), __args);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Month = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMonth;
		static IntPtr id_setMonth_I;
		public virtual unsafe int Month {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getMonth' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setMonth' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedDay = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDay;
		static IntPtr id_setSelectedDay_I;
		public virtual unsafe int SelectedDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getSelectedDay' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getSelectedItemPosition;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemPositionHandler ()
		{
			if (cb_getSelectedItemPosition == null)
				cb_getSelectedItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedItemPosition);
			return cb_getSelectedItemPosition;
		}

		static int n_GetSelectedItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedItemPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedItemPosition_IHandler ()
		{
			if (cb_setSelectedItemPosition_I == null)
				cb_setSelectedItemPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedItemPosition_I);
			return cb_setSelectedItemPosition_I;
		}

		static void n_SetSelectedItemPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemPosition;
		static IntPtr id_setSelectedItemPosition_I;
		[Obsolete (@"deprecated")]
		public virtual unsafe int SelectedItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getSelectedItemPosition' and count(parameter)=0]"
			[Register ("getSelectedItemPosition", "()I", "GetGetSelectedItemPositionHandler")]
			get {
				if (id_getSelectedItemPosition == IntPtr.Zero)
					id_getSelectedItemPosition = JNIEnv.GetMethodID (class_ref, "getSelectedItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSelectedItemPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemPosition", "(I)V", "GetSetSelectedItemPosition_IHandler")]
			set {
				if (id_setSelectedItemPosition_I == IntPtr.Zero)
					id_setSelectedItemPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedItemPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItemTextColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemTextColorHandler ()
		{
			if (cb_getSelectedItemTextColor == null)
				cb_getSelectedItemTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedItemTextColor);
			return cb_getSelectedItemTextColor;
		}

		static int n_GetSelectedItemTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedItemTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedItemTextColor_IHandler ()
		{
			if (cb_setSelectedItemTextColor_I == null)
				cb_setSelectedItemTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedItemTextColor_I);
			return cb_setSelectedItemTextColor_I;
		}

		static void n_SetSelectedItemTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemTextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemTextColor;
		static IntPtr id_setSelectedItemTextColor_I;
		public virtual unsafe int SelectedItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getSelectedItemTextColor' and count(parameter)=0]"
			[Register ("getSelectedItemTextColor", "()I", "GetGetSelectedItemTextColorHandler")]
			get {
				if (id_getSelectedItemTextColor == IntPtr.Zero)
					id_getSelectedItemTextColor = JNIEnv.GetMethodID (class_ref, "getSelectedItemTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSelectedItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemTextColor", "(I)V", "GetSetSelectedItemTextColor_IHandler")]
			set {
				if (id_setSelectedItemTextColor_I == IntPtr.Zero)
					id_setSelectedItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedItemTextColor", "(I)V"), __args);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedMonth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedMonth;
		static IntPtr id_setSelectedMonth_I;
		public virtual unsafe int SelectedMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getSelectedMonth' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSelectedMonth' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedYear = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedYear;
		static IntPtr id_setSelectedYear_I;
		public virtual unsafe int SelectedYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getSelectedYear' and count(parameter)=0]"
			[Register ("getSelectedYear", "()I", "GetGetSelectedYearHandler")]
			get {
				if (id_getSelectedYear == IntPtr.Zero)
					id_getSelectedYear = JNIEnv.GetMethodID (class_ref, "getSelectedYear", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedYear);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedYear", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSelectedYear' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedYear", "(I)V", "GetSetSelectedYear_IHandler")]
			set {
				if (id_setSelectedYear_I == IntPtr.Zero)
					id_setSelectedYear_I = JNIEnv.GetMethodID (class_ref, "setSelectedYear", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedYear_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedYear", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewDay);
		}
#pragma warning restore 0169

		static IntPtr id_getTextViewDay;
		public virtual unsafe global::Android.Widget.TextView TextViewDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getTextViewDay' and count(parameter)=0]"
			[Register ("getTextViewDay", "()Landroid/widget/TextView;", "GetGetTextViewDayHandler")]
			get {
				if (id_getTextViewDay == IntPtr.Zero)
					id_getTextViewDay = JNIEnv.GetMethodID (class_ref, "getTextViewDay", "()Landroid/widget/TextView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewDay), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextViewDay", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewMonth);
		}
#pragma warning restore 0169

		static IntPtr id_getTextViewMonth;
		public virtual unsafe global::Android.Widget.TextView TextViewMonth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getTextViewMonth' and count(parameter)=0]"
			[Register ("getTextViewMonth", "()Landroid/widget/TextView;", "GetGetTextViewMonthHandler")]
			get {
				if (id_getTextViewMonth == IntPtr.Zero)
					id_getTextViewMonth = JNIEnv.GetMethodID (class_ref, "getTextViewMonth", "()Landroid/widget/TextView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewMonth), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextViewMonth", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextViewYear);
		}
#pragma warning restore 0169

		static IntPtr id_getTextViewYear;
		public virtual unsafe global::Android.Widget.TextView TextViewYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getTextViewYear' and count(parameter)=0]"
			[Register ("getTextViewYear", "()Landroid/widget/TextView;", "GetGetTextViewYearHandler")]
			get {
				if (id_getTextViewYear == IntPtr.Zero)
					id_getTextViewYear = JNIEnv.GetMethodID (class_ref, "getTextViewYear", "()Landroid/widget/TextView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextViewYear), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextViewYear", "()Landroid/widget/TextView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface;
		static IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeface", "()Landroid/graphics/Typeface;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTypeface", "(Landroid/graphics/Typeface;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisibleItemCount;
#pragma warning disable 0169
		static Delegate GetGetVisibleItemCountHandler ()
		{
			if (cb_getVisibleItemCount == null)
				cb_getVisibleItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVisibleItemCount);
			return cb_getVisibleItemCount;
		}

		static int n_GetVisibleItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VisibleItemCount;
		}
#pragma warning restore 0169

		static Delegate cb_setVisibleItemCount_I;
#pragma warning disable 0169
		static Delegate GetSetVisibleItemCount_IHandler ()
		{
			if (cb_setVisibleItemCount_I == null)
				cb_setVisibleItemCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVisibleItemCount_I);
			return cb_setVisibleItemCount_I;
		}

		static void n_SetVisibleItemCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VisibleItemCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleItemCount;
		static IntPtr id_setVisibleItemCount_I;
		public virtual unsafe int VisibleItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getVisibleItemCount' and count(parameter)=0]"
			[Register ("getVisibleItemCount", "()I", "GetGetVisibleItemCountHandler")]
			get {
				if (id_getVisibleItemCount == IntPtr.Zero)
					id_getVisibleItemCount = JNIEnv.GetMethodID (class_ref, "getVisibleItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVisibleItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleItemCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setVisibleItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVisibleItemCount", "(I)V", "GetSetVisibleItemCount_IHandler")]
			set {
				if (id_setVisibleItemCount_I == IntPtr.Zero)
					id_setVisibleItemCount_I = JNIEnv.GetMethodID (class_ref, "setVisibleItemCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibleItemCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisibleItemCount", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelDayPicker);
		}
#pragma warning restore 0169

		static IntPtr id_getWheelDayPicker;
		public virtual unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker WheelDayPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getWheelDayPicker' and count(parameter)=0]"
			[Register ("getWheelDayPicker", "()Lcom/itheima/wheelpicker/widgets/WheelDayPicker;", "GetGetWheelDayPickerHandler")]
			get {
				if (id_getWheelDayPicker == IntPtr.Zero)
					id_getWheelDayPicker = JNIEnv.GetMethodID (class_ref, "getWheelDayPicker", "()Lcom/itheima/wheelpicker/widgets/WheelDayPicker;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelDayPicker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDayPicker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWheelDayPicker", "()Lcom/itheima/wheelpicker/widgets/WheelDayPicker;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelMonthPicker);
		}
#pragma warning restore 0169

		static IntPtr id_getWheelMonthPicker;
		public virtual unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker WheelMonthPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getWheelMonthPicker' and count(parameter)=0]"
			[Register ("getWheelMonthPicker", "()Lcom/itheima/wheelpicker/widgets/WheelMonthPicker;", "GetGetWheelMonthPickerHandler")]
			get {
				if (id_getWheelMonthPicker == IntPtr.Zero)
					id_getWheelMonthPicker = JNIEnv.GetMethodID (class_ref, "getWheelMonthPicker", "()Lcom/itheima/wheelpicker/widgets/WheelMonthPicker;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelMonthPicker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelMonthPicker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWheelMonthPicker", "()Lcom/itheima/wheelpicker/widgets/WheelMonthPicker;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WheelYearPicker);
		}
#pragma warning restore 0169

		static IntPtr id_getWheelYearPicker;
		public virtual unsafe global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker WheelYearPicker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getWheelYearPicker' and count(parameter)=0]"
			[Register ("getWheelYearPicker", "()Lcom/itheima/wheelpicker/widgets/WheelYearPicker;", "GetGetWheelYearPickerHandler")]
			get {
				if (id_getWheelYearPicker == IntPtr.Zero)
					id_getWheelYearPicker = JNIEnv.GetMethodID (class_ref, "getWheelYearPicker", "()Lcom/itheima/wheelpicker/widgets/WheelYearPicker;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWheelYearPicker), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWheelYearPicker", "()Lcom/itheima/wheelpicker/widgets/WheelYearPicker;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Year = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYear;
		static IntPtr id_setYear_I;
		public virtual unsafe int Year {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getYear' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setYear' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearEnd = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYearEnd;
		static IntPtr id_setYearEnd_I;
		public virtual unsafe int YearEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getYearEnd' and count(parameter)=0]"
			[Register ("getYearEnd", "()I", "GetGetYearEndHandler")]
			get {
				if (id_getYearEnd == IntPtr.Zero)
					id_getYearEnd = JNIEnv.GetMethodID (class_ref, "getYearEnd", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearEnd);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYearEnd", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setYearEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYearEnd", "(I)V", "GetSetYearEnd_IHandler")]
			set {
				if (id_setYearEnd_I == IntPtr.Zero)
					id_setYearEnd_I = JNIEnv.GetMethodID (class_ref, "setYearEnd", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearEnd_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYearEnd", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearStart = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYearStart;
		static IntPtr id_setYearStart_I;
		public virtual unsafe int YearStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='getYearStart' and count(parameter)=0]"
			[Register ("getYearStart", "()I", "GetGetYearStartHandler")]
			get {
				if (id_getYearStart == IntPtr.Zero)
					id_getYearStart = JNIEnv.GetMethodID (class_ref, "getYearStart", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYearStart);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYearStart", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setYearStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYearStart", "(I)V", "GetSetYearStart_IHandler")]
			set {
				if (id_setYearStart_I == IntPtr.Zero)
					id_setYearStart_I = JNIEnv.GetMethodID (class_ref, "setYearStart", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearStart_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYearStart", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetOnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_IHandler ()
		{
			if (cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I == null)
				cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I);
			return cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
		}

		static void n_OnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker p0 = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemSelected (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='onItemSelected' and count(parameter)=3 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
		[Register ("onItemSelected", "(Lcom/itheima/wheelpicker/WheelPicker;Ljava/lang/Object;I)V", "GetOnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_IHandler")]
		public virtual unsafe void OnItemSelected (global::Com.Itheima.Wheelpicker.WheelPicker p0, global::Java.Lang.Object p1, int p2)
		{
			if (id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I == IntPtr.Zero)
				id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onItemSelected", "(Lcom/itheima/wheelpicker/WheelPicker;Ljava/lang/Object;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemSelected", "(Lcom/itheima/wheelpicker/WheelPicker;Ljava/lang/Object;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAtmospheric_Z;
#pragma warning disable 0169
		static Delegate GetSetAtmospheric_ZHandler ()
		{
			if (cb_setAtmospheric_Z == null)
				cb_setAtmospheric_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAtmospheric_Z);
			return cb_setAtmospheric_Z;
		}

		static void n_SetAtmospheric_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAtmospheric (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAtmospheric_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setAtmospheric' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAtmospheric", "(Z)V", "GetSetAtmospheric_ZHandler")]
		public virtual unsafe void SetAtmospheric (bool p0)
		{
			if (id_setAtmospheric_Z == IntPtr.Zero)
				id_setAtmospheric_Z = JNIEnv.GetMethodID (class_ref, "setAtmospheric", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAtmospheric_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAtmospheric", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCurtain_Z;
#pragma warning disable 0169
		static Delegate GetSetCurtain_ZHandler ()
		{
			if (cb_setCurtain_Z == null)
				cb_setCurtain_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurtain_Z);
			return cb_setCurtain_Z;
		}

		static void n_SetCurtain_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurtain (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurtain_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setCurtain' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCurtain", "(Z)V", "GetSetCurtain_ZHandler")]
		public virtual unsafe void SetCurtain (bool p0)
		{
			if (id_setCurtain_Z == IntPtr.Zero)
				id_setCurtain_Z = JNIEnv.GetMethodID (class_ref, "setCurtain", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtain_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurtain", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetDebug_ZHandler ()
		{
			if (cb_setDebug_Z == null)
				cb_setDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebug_Z);
			return cb_setDebug_Z;
		}

		static void n_SetDebug_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
		public virtual unsafe void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetMethodID (class_ref, "setDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebug_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebug", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIndicator_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicator_ZHandler ()
		{
			if (cb_setIndicator_Z == null)
				cb_setIndicator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIndicator_Z);
			return cb_setIndicator_Z;
		}

		static void n_SetIndicator_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicator_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicator", "(Z)V", "GetSetIndicator_ZHandler")]
		public virtual unsafe void SetIndicator (bool p0)
		{
			if (id_setIndicator_Z == IntPtr.Zero)
				id_setIndicator_Z = JNIEnv.GetMethodID (class_ref, "setIndicator", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicator_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicator", "(Z)V"), __args);
			} finally {
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener p0 = (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDateSelectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setOnDateSelectedListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.widgets.WheelDatePicker.OnDateSelectedListener']]"
		[Register ("setOnDateSelectedListener", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener;)V", "GetSetOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_Handler")]
		public virtual unsafe void SetOnDateSelectedListener (global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener p0)
		{
			if (id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ == IntPtr.Zero)
				id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnDateSelectedListener", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDateSelectedListener_Lcom_itheima_wheelpicker_widgets_WheelDatePicker_OnDateSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDateSelectedListener", "(Lcom/itheima/wheelpicker/widgets/WheelDatePicker$OnDateSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_Handler ()
		{
			if (cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ == null)
				cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_);
			return cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
		}

		static void n_SetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemSelectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setOnItemSelectedListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnItemSelectedListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V", "GetSetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_Handler")]
		public virtual unsafe void SetOnItemSelectedListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0)
		{
			if (id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ == IntPtr.Zero)
				id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_Handler ()
		{
			if (cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ == null)
				cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_);
			return cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
		}

		static void n_SetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnWheelChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setOnWheelChangeListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnWheelChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V", "GetSetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_Handler")]
		public virtual unsafe void SetOnWheelChangeListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0)
		{
			if (id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ == IntPtr.Zero)
				id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSameWidth_Z;
#pragma warning disable 0169
		static Delegate GetSetSameWidth_ZHandler ()
		{
			if (cb_setSameWidth_Z == null)
				cb_setSameWidth_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSameWidth_Z);
			return cb_setSameWidth_Z;
		}

		static void n_SetSameWidth_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSameWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSameWidth_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setSameWidth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setSameWidth", "(Z)V", "GetSetSameWidth_ZHandler")]
		public virtual unsafe void SetSameWidth (bool p0)
		{
			if (id_setSameWidth_Z == IntPtr.Zero)
				id_setSameWidth_Z = JNIEnv.GetMethodID (class_ref, "setSameWidth", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSameWidth_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSameWidth", "(Z)V"), __args);
			} finally {
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearAndMonth (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYearAndMonth_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setYearAndMonth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearFrame (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYearFrame_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelDatePicker']/method[@name='setYearFrame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setYearFrame", "(II)V", "GetSetYearFrame_IIHandler")]
		public virtual unsafe void SetYearFrame (int p0, int p1)
		{
			if (id_setYearFrame_II == IntPtr.Zero)
				id_setYearFrame_II = JNIEnv.GetMethodID (class_ref, "setYearFrame", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setYearFrame_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setYearFrame", "(II)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener"
		public event EventHandler<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.DateSelectedEventArgs> DateSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener, global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListenerImplementor>(
						ref weak_implementor_SetOnDateSelectedListener,
						__CreateIOnDateSelectedListenerImplementor,
						SetOnDateSelectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListener, global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListenerImplementor>(
						ref weak_implementor_SetOnDateSelectedListener,
						global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListenerImplementor.__IsEmpty,
						__v => SetOnDateSelectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDateSelectedListener;

		global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListenerImplementor __CreateIOnDateSelectedListenerImplementor ()
		{
			return new global::Com.Itheima.Wheelpicker.Widgets.WheelDatePicker.IOnDateSelectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener"
		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.ItemSelectedEventArgs> ItemSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor>(
						ref weak_implementor_SetOnItemSelectedListener,
						__CreateIOnItemSelectedListenerImplementor,
						SetOnItemSelectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor>(
						ref weak_implementor_SetOnItemSelectedListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor.__IsEmpty,
						__v => SetOnItemSelectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemSelectedListener;

		global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor __CreateIOnItemSelectedListenerImplementor ()
		{
			return new global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener"
		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelScrollStateChangedEventArgs> WheelScrollStateChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelScrollStateChangedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelScrollStateChangedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelScrolledEventArgs> WheelScrolled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelScrolledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelScrolledHandler -= value);
			}
		}

		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelSelectedEventArgs> WheelSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelSelectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelSelectedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnWheelChangeListener;

		global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor __CreateIOnWheelChangeListenerImplementor ()
		{
			return new global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor (this);
		}
#endregion
	}
}
