using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/widgets/WheelYearPicker", DoNotGenerateAcw=true)]
	public partial class WheelYearPicker : global::Com.Itheima.Wheelpicker.WheelPicker, global::Com.Itheima.Wheelpicker.Widgets.IWheelYearPicker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/widgets/WheelYearPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelYearPicker); }
		}

		protected WheelYearPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/constructor[@name='WheelYearPicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WheelYearPicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelYearPicker)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/constructor[@name='WheelYearPicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelYearPicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelYearPicker)) {
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentYear;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentYear;
		public virtual unsafe int CurrentYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='getCurrentYear' and count(parameter)=0]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedYear = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedYear;
		static IntPtr id_setSelectedYear_I;
		public virtual unsafe int SelectedYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='getSelectedYear' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='setSelectedYear' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearEnd = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYearEnd;
		static IntPtr id_setYearEnd_I;
		public virtual unsafe int YearEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='getYearEnd' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='setYearEnd' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YearStart = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getYearStart;
		static IntPtr id_setYearStart_I;
		public virtual unsafe int YearStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='getYearStart' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='setYearStart' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.Widgets.WheelYearPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetYearFrame (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setYearFrame_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker.widgets']/class[@name='WheelYearPicker']/method[@name='setYearFrame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

	}
}
