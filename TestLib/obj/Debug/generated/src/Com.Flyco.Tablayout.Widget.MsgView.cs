using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/widget/MsgView", DoNotGenerateAcw=true)]
	public partial class MsgView : global::Android.Widget.TextView {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/flyco/tablayout/widget/MsgView", typeof (MsgView));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MsgView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/constructor[@name='MsgView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MsgView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				const string __id = "getBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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

		public virtual unsafe int CornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getCornerRadius' and count(parameter)=0]"
			[Register ("getCornerRadius", "()I", "GetGetCornerRadiusHandler")]
			get {
				const string __id = "getCornerRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerRadius", "(I)V", "GetSetCornerRadius_IHandler")]
			set {
				const string __id = "setCornerRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		public virtual unsafe bool IsRadiusHalfHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='isRadiusHalfHeight' and count(parameter)=0]"
			[Register ("isRadiusHalfHeight", "()Z", "GetIsRadiusHalfHeightHandler")]
			get {
				const string __id = "isRadiusHalfHeight.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setIsRadiusHalfHeight' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsRadiusHalfHeight", "(Z)V", "GetSetIsRadiusHalfHeight_ZHandler")]
			set {
				const string __id = "setIsRadiusHalfHeight.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		public virtual unsafe bool IsWidthHeightEqual {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='isWidthHeightEqual' and count(parameter)=0]"
			[Register ("isWidthHeightEqual", "()Z", "GetIsWidthHeightEqualHandler")]
			get {
				const string __id = "isWidthHeightEqual.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setIsWidthHeightEqual' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsWidthHeightEqual", "(Z)V", "GetSetIsWidthHeightEqual_ZHandler")]
			set {
				const string __id = "setIsWidthHeightEqual.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		public virtual unsafe int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				const string __id = "getStrokeColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				const string __id = "setStrokeColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		public virtual unsafe int StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()I", "GetGetStrokeWidthHandler")]
			get {
				const string __id = "getStrokeWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeWidth", "(I)V", "GetSetStrokeWidth_IHandler")]
			set {
				const string __id = "setStrokeWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='dp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dp2px", "(F)I", "GetDp2px_FHandler")]
		protected virtual unsafe int Dp2px (float p0)
		{
			const string __id = "dp2px.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='setBgSelector' and count(parameter)=0]"
		[Register ("setBgSelector", "()V", "GetSetBgSelectorHandler")]
		public virtual unsafe void SetBgSelector ()
		{
			const string __id = "setBgSelector.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.widget']/class[@name='MsgView']/method[@name='sp2px' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("sp2px", "(F)I", "GetSp2px_FHandler")]
		protected virtual unsafe int Sp2px (float p0)
		{
			const string __id = "sp2px.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
