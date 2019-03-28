using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flyco.Tablayout.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/widget/MsgView", DoNotGenerateAcw=true)]
	public partial class MsgView : global::Android.Widget.TextView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flyco/tablayout/widget/MsgView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MsgView); }
		}

		protected MsgView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MsgView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MsgView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MsgView)) {
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

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundColor;
		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCornerRadius;
#pragma warning disable 0169
		static Delegate GetGetCornerRadiusHandler ()
		{
			if (cb_getCornerRadius == null)
				cb_getCornerRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCornerRadius);
			return cb_getCornerRadius;
		}

		static int n_GetCornerRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CornerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setCornerRadius_I;
#pragma warning disable 0169
		static Delegate GetSetCornerRadius_IHandler ()
		{
			if (cb_setCornerRadius_I == null)
				cb_setCornerRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCornerRadius_I);
			return cb_setCornerRadius_I;
		}

		static void n_SetCornerRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CornerRadius = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCornerRadius;
		static IntPtr id_setCornerRadius_I;
		public virtual unsafe int CornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getCornerRadius' and count(parameter)=0]"
			[Register ("getCornerRadius", "()I", "GetGetCornerRadiusHandler")]
			get {
				if (id_getCornerRadius == IntPtr.Zero)
					id_getCornerRadius = JNIEnv.GetMethodID (class_ref, "getCornerRadius", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCornerRadius);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCornerRadius", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerRadius", "(I)V", "GetSetCornerRadius_IHandler")]
			set {
				if (id_setCornerRadius_I == IntPtr.Zero)
					id_setCornerRadius_I = JNIEnv.GetMethodID (class_ref, "setCornerRadius", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCornerRadius_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCornerRadius", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRadiusHalfHeight;
#pragma warning disable 0169
		static Delegate GetIsRadiusHalfHeightHandler ()
		{
			if (cb_isRadiusHalfHeight == null)
				cb_isRadiusHalfHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRadiusHalfHeight);
			return cb_isRadiusHalfHeight;
		}

		static bool n_IsRadiusHalfHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRadiusHalfHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setIsRadiusHalfHeight_Z;
#pragma warning disable 0169
		static Delegate GetSetIsRadiusHalfHeight_ZHandler ()
		{
			if (cb_setIsRadiusHalfHeight_Z == null)
				cb_setIsRadiusHalfHeight_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsRadiusHalfHeight_Z);
			return cb_setIsRadiusHalfHeight_Z;
		}

		static void n_SetIsRadiusHalfHeight_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsRadiusHalfHeight = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRadiusHalfHeight;
		static IntPtr id_setIsRadiusHalfHeight_Z;
		public virtual unsafe bool IsRadiusHalfHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='isRadiusHalfHeight' and count(parameter)=0]"
			[Register ("isRadiusHalfHeight", "()Z", "GetIsRadiusHalfHeightHandler")]
			get {
				if (id_isRadiusHalfHeight == IntPtr.Zero)
					id_isRadiusHalfHeight = JNIEnv.GetMethodID (class_ref, "isRadiusHalfHeight", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRadiusHalfHeight);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRadiusHalfHeight", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setIsRadiusHalfHeight' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsRadiusHalfHeight", "(Z)V", "GetSetIsRadiusHalfHeight_ZHandler")]
			set {
				if (id_setIsRadiusHalfHeight_Z == IntPtr.Zero)
					id_setIsRadiusHalfHeight_Z = JNIEnv.GetMethodID (class_ref, "setIsRadiusHalfHeight", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsRadiusHalfHeight_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsRadiusHalfHeight", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isWidthHeightEqual;
#pragma warning disable 0169
		static Delegate GetIsWidthHeightEqualHandler ()
		{
			if (cb_isWidthHeightEqual == null)
				cb_isWidthHeightEqual = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWidthHeightEqual);
			return cb_isWidthHeightEqual;
		}

		static bool n_IsWidthHeightEqual (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWidthHeightEqual;
		}
#pragma warning restore 0169

		static Delegate cb_setIsWidthHeightEqual_Z;
#pragma warning disable 0169
		static Delegate GetSetIsWidthHeightEqual_ZHandler ()
		{
			if (cb_setIsWidthHeightEqual_Z == null)
				cb_setIsWidthHeightEqual_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsWidthHeightEqual_Z);
			return cb_setIsWidthHeightEqual_Z;
		}

		static void n_SetIsWidthHeightEqual_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsWidthHeightEqual = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isWidthHeightEqual;
		static IntPtr id_setIsWidthHeightEqual_Z;
		public virtual unsafe bool IsWidthHeightEqual {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='isWidthHeightEqual' and count(parameter)=0]"
			[Register ("isWidthHeightEqual", "()Z", "GetIsWidthHeightEqualHandler")]
			get {
				if (id_isWidthHeightEqual == IntPtr.Zero)
					id_isWidthHeightEqual = JNIEnv.GetMethodID (class_ref, "isWidthHeightEqual", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWidthHeightEqual);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isWidthHeightEqual", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setIsWidthHeightEqual' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsWidthHeightEqual", "(Z)V", "GetSetIsWidthHeightEqual_ZHandler")]
			set {
				if (id_setIsWidthHeightEqual_Z == IntPtr.Zero)
					id_setIsWidthHeightEqual_Z = JNIEnv.GetMethodID (class_ref, "setIsWidthHeightEqual", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsWidthHeightEqual_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsWidthHeightEqual", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetStrokeColorHandler ()
		{
			if (cb_getStrokeColor == null)
				cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
			return cb_getStrokeColor;
		}

		static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_setStrokeColor_I == null)
				cb_setStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeColor_I);
			return cb_setStrokeColor_I;
		}

		static void n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public virtual unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static int n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeWidth_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_IHandler ()
		{
			if (cb_setStrokeWidth_I == null)
				cb_setStrokeWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeWidth_I);
			return cb_setStrokeWidth_I;
		}

		static void n_SetStrokeWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_I;
		public virtual unsafe int StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()I", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStrokeWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeWidth", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeWidth", "(I)V", "GetSetStrokeWidth_IHandler")]
			set {
				if (id_setStrokeWidth_I == IntPtr.Zero)
					id_setStrokeWidth_I = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStrokeWidth_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeWidth", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_dp2px_F;
#pragma warning disable 0169
		static Delegate GetDp2px_FHandler ()
		{
			if (cb_dp2px_F == null)
				cb_dp2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Dp2px_F);
			return cb_dp2px_F;
		}

		static int n_Dp2px_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dp2px (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dp2px_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='dp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dp2px", "(F)I", "GetDp2px_FHandler")]
		protected virtual unsafe int Dp2px (float p0)
		{
			if (id_dp2px_F == IntPtr.Zero)
				id_dp2px_F = JNIEnv.GetMethodID (class_ref, "dp2px", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_dp2px_F, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dp2px", "(F)I"), __args);
			} finally {
			}
		}

		static Delegate cb_setBgSelector;
#pragma warning disable 0169
		static Delegate GetSetBgSelectorHandler ()
		{
			if (cb_setBgSelector == null)
				cb_setBgSelector = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetBgSelector);
			return cb_setBgSelector;
		}

		static void n_SetBgSelector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBgSelector ();
		}
#pragma warning restore 0169

		static IntPtr id_setBgSelector;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setBgSelector' and count(parameter)=0]"
		[Register ("setBgSelector", "()V", "GetSetBgSelectorHandler")]
		public virtual unsafe void SetBgSelector ()
		{
			if (id_setBgSelector == IntPtr.Zero)
				id_setBgSelector = JNIEnv.GetMethodID (class_ref, "setBgSelector", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBgSelector);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBgSelector", "()V"));
			} finally {
			}
		}

		static Delegate cb_sp2px_F;
#pragma warning disable 0169
		static Delegate GetSp2px_FHandler ()
		{
			if (cb_sp2px_F == null)
				cb_sp2px_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_Sp2px_F);
			return cb_sp2px_F;
		}

		static int n_Sp2px_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.Widget.MsgView __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sp2px (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sp2px_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='sp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("sp2px", "(F)I", "GetSp2px_FHandler")]
		protected virtual unsafe int Sp2px (float p0)
		{
			if (id_sp2px_F == IntPtr.Zero)
				id_sp2px_F = JNIEnv.GetMethodID (class_ref, "sp2px", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sp2px_F, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sp2px", "(F)I"), __args);
			} finally {
			}
		}

	}
}
