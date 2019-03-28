using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/SlidingTabLayout", DoNotGenerateAcw=true)]
	public partial class SlidingTabLayout : global::Android.Widget.HorizontalScrollView, global::Android.Support.V4.View.ViewPager.IOnPageChangeListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout.InnerPagerAdapter']"
		[global::Android.Runtime.Register ("com/flyco/tablayout/SlidingTabLayout$InnerPagerAdapter", DoNotGenerateAcw=true)]
		public partial class InnerPagerAdapter : global::Android.Support.V4.App.FragmentPagerAdapter {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/flyco/tablayout/SlidingTabLayout$InnerPagerAdapter", typeof (InnerPagerAdapter));
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

			protected InnerPagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout.InnerPagerAdapter']/constructor[@name='SlidingTabLayout.InnerPagerAdapter' and count(parameter)=4 and parameter[1][@type='com.flyco.tablayout.SlidingTabLayout'] and parameter[2][@type='android.support.v4.app.FragmentManager'] and parameter[3][@type='java.util.ArrayList&lt;android.support.v4.app.Fragment&gt;'] and parameter[4][@type='java.lang.String[]']]"
			[Register (".ctor", "(Lcom/flyco/tablayout/SlidingTabLayout;Landroid/support/v4/app/FragmentManager;Ljava/util/ArrayList;[Ljava/lang/String;)V", "")]
			public unsafe InnerPagerAdapter (global::Com.Flyco.Tablayout.SlidingTabLayout __self, global::Android.Support.V4.App.FragmentManager p0, global::System.Collections.Generic.IList<global::Android.Support.V4.App.Fragment> p1, string[] p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/support/v4/app/FragmentManager;Ljava/util/ArrayList;[Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Support.V4.App.Fragment>.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [2] = new JniArgumentValue (native_p1);
					__args [3] = new JniArgumentValue (native_p2);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_getCount;
#pragma warning disable 0169
			static Delegate GetGetCountHandler ()
			{
				if (cb_getCount == null)
					cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
				return cb_getCount;
			}

			static int n_GetCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Flyco.Tablayout.SlidingTabLayout.InnerPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout.InnerPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count;
			}
#pragma warning restore 0169

			public override unsafe int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout.InnerPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					const string __id = "getCount.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getItem_I;
#pragma warning disable 0169
			static Delegate GetGetItem_IHandler ()
			{
				if (cb_getItem_I == null)
					cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
				return cb_getItem_I;
			}

			static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Flyco.Tablayout.SlidingTabLayout.InnerPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout.InnerPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout.InnerPagerAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Landroid/support/v4/app/Fragment;", "GetGetItem_IHandler")]
			public override unsafe global::Android.Support.V4.App.Fragment GetItem (int p0)
			{
				const string __id = "getItem.(I)Landroid/support/v4/app/Fragment;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/flyco/tablayout/SlidingTabLayout", typeof (SlidingTabLayout));
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

		protected SlidingTabLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/constructor[@name='SlidingTabLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SlidingTabLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/constructor[@name='SlidingTabLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SlidingTabLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/constructor[@name='SlidingTabLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SlidingTabLayout (global::Android.Content.Context p0)
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

		static Delegate cb_getCurrentTab;
#pragma warning disable 0169
		static Delegate GetGetCurrentTabHandler ()
		{
			if (cb_getCurrentTab == null)
				cb_getCurrentTab = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentTab);
			return cb_getCurrentTab;
		}

		static int n_GetCurrentTab (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTab;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentTab_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentTab_IHandler ()
		{
			if (cb_setCurrentTab_I == null)
				cb_setCurrentTab_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentTab_I);
			return cb_setCurrentTab_I;
		}

		static void n_SetCurrentTab_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentTab = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getCurrentTab' and count(parameter)=0]"
			[Register ("getCurrentTab", "()I", "GetGetCurrentTabHandler")]
			get {
				const string __id = "getCurrentTab.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setCurrentTab' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentTab", "(I)V", "GetSetCurrentTab_IHandler")]
			set {
				const string __id = "setCurrentTab.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerColor;
#pragma warning disable 0169
		static Delegate GetGetDividerColorHandler ()
		{
			if (cb_getDividerColor == null)
				cb_getDividerColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDividerColor);
			return cb_getDividerColor;
		}

		static int n_GetDividerColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerColor_I;
#pragma warning disable 0169
		static Delegate GetSetDividerColor_IHandler ()
		{
			if (cb_setDividerColor_I == null)
				cb_setDividerColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDividerColor_I);
			return cb_setDividerColor_I;
		}

		static void n_SetDividerColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int DividerColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getDividerColor' and count(parameter)=0]"
			[Register ("getDividerColor", "()I", "GetGetDividerColorHandler")]
			get {
				const string __id = "getDividerColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setDividerColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDividerColor", "(I)V", "GetSetDividerColor_IHandler")]
			set {
				const string __id = "setDividerColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerPadding;
#pragma warning disable 0169
		static Delegate GetGetDividerPaddingHandler ()
		{
			if (cb_getDividerPadding == null)
				cb_getDividerPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDividerPadding);
			return cb_getDividerPadding;
		}

		static float n_GetDividerPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerPadding_F;
#pragma warning disable 0169
		static Delegate GetSetDividerPadding_FHandler ()
		{
			if (cb_setDividerPadding_F == null)
				cb_setDividerPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDividerPadding_F);
			return cb_setDividerPadding_F;
		}

		static void n_SetDividerPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerPadding = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float DividerPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getDividerPadding' and count(parameter)=0]"
			[Register ("getDividerPadding", "()F", "GetGetDividerPaddingHandler")]
			get {
				const string __id = "getDividerPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setDividerPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDividerPadding", "(F)V", "GetSetDividerPadding_FHandler")]
			set {
				const string __id = "setDividerPadding.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDividerWidth;
#pragma warning disable 0169
		static Delegate GetGetDividerWidthHandler ()
		{
			if (cb_getDividerWidth == null)
				cb_getDividerWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDividerWidth);
			return cb_getDividerWidth;
		}

		static float n_GetDividerWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DividerWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setDividerWidth_F;
#pragma warning disable 0169
		static Delegate GetSetDividerWidth_FHandler ()
		{
			if (cb_setDividerWidth_F == null)
				cb_setDividerWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDividerWidth_F);
			return cb_setDividerWidth_F;
		}

		static void n_SetDividerWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DividerWidth = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float DividerWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getDividerWidth' and count(parameter)=0]"
			[Register ("getDividerWidth", "()F", "GetGetDividerWidthHandler")]
			get {
				const string __id = "getDividerWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setDividerWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDividerWidth", "(F)V", "GetSetDividerWidth_FHandler")]
			set {
				const string __id = "setDividerWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorColor' and count(parameter)=0]"
			[Register ("getIndicatorColor", "()I", "GetGetIndicatorColorHandler")]
			get {
				const string __id = "getIndicatorColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
			set {
				const string __id = "setIndicatorColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorCornerRadius;
#pragma warning disable 0169
		static Delegate GetGetIndicatorCornerRadiusHandler ()
		{
			if (cb_getIndicatorCornerRadius == null)
				cb_getIndicatorCornerRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorCornerRadius);
			return cb_getIndicatorCornerRadius;
		}

		static float n_GetIndicatorCornerRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorCornerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorCornerRadius_F;
#pragma warning disable 0169
		static Delegate GetSetIndicatorCornerRadius_FHandler ()
		{
			if (cb_setIndicatorCornerRadius_F == null)
				cb_setIndicatorCornerRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIndicatorCornerRadius_F);
			return cb_setIndicatorCornerRadius_F;
		}

		static void n_SetIndicatorCornerRadius_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorCornerRadius = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorCornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorCornerRadius' and count(parameter)=0]"
			[Register ("getIndicatorCornerRadius", "()F", "GetGetIndicatorCornerRadiusHandler")]
			get {
				const string __id = "getIndicatorCornerRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorCornerRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIndicatorCornerRadius", "(F)V", "GetSetIndicatorCornerRadius_FHandler")]
			set {
				const string __id = "setIndicatorCornerRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorHeight;
#pragma warning disable 0169
		static Delegate GetGetIndicatorHeightHandler ()
		{
			if (cb_getIndicatorHeight == null)
				cb_getIndicatorHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorHeight);
			return cb_getIndicatorHeight;
		}

		static float n_GetIndicatorHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorHeight_F;
#pragma warning disable 0169
		static Delegate GetSetIndicatorHeight_FHandler ()
		{
			if (cb_setIndicatorHeight_F == null)
				cb_setIndicatorHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIndicatorHeight_F);
			return cb_setIndicatorHeight_F;
		}

		static void n_SetIndicatorHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorHeight = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorHeight' and count(parameter)=0]"
			[Register ("getIndicatorHeight", "()F", "GetGetIndicatorHeightHandler")]
			get {
				const string __id = "getIndicatorHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorHeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIndicatorHeight", "(F)V", "GetSetIndicatorHeight_FHandler")]
			set {
				const string __id = "setIndicatorHeight.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorMarginBottom;
#pragma warning disable 0169
		static Delegate GetGetIndicatorMarginBottomHandler ()
		{
			if (cb_getIndicatorMarginBottom == null)
				cb_getIndicatorMarginBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorMarginBottom);
			return cb_getIndicatorMarginBottom;
		}

		static float n_GetIndicatorMarginBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorMarginBottom;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorMarginBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorMarginBottom' and count(parameter)=0]"
			[Register ("getIndicatorMarginBottom", "()F", "GetGetIndicatorMarginBottomHandler")]
			get {
				const string __id = "getIndicatorMarginBottom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorMarginLeft;
#pragma warning disable 0169
		static Delegate GetGetIndicatorMarginLeftHandler ()
		{
			if (cb_getIndicatorMarginLeft == null)
				cb_getIndicatorMarginLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorMarginLeft);
			return cb_getIndicatorMarginLeft;
		}

		static float n_GetIndicatorMarginLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorMarginLeft;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorMarginLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorMarginLeft' and count(parameter)=0]"
			[Register ("getIndicatorMarginLeft", "()F", "GetGetIndicatorMarginLeftHandler")]
			get {
				const string __id = "getIndicatorMarginLeft.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorMarginRight;
#pragma warning disable 0169
		static Delegate GetGetIndicatorMarginRightHandler ()
		{
			if (cb_getIndicatorMarginRight == null)
				cb_getIndicatorMarginRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorMarginRight);
			return cb_getIndicatorMarginRight;
		}

		static float n_GetIndicatorMarginRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorMarginRight;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorMarginRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorMarginRight' and count(parameter)=0]"
			[Register ("getIndicatorMarginRight", "()F", "GetGetIndicatorMarginRightHandler")]
			get {
				const string __id = "getIndicatorMarginRight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorMarginTop;
#pragma warning disable 0169
		static Delegate GetGetIndicatorMarginTopHandler ()
		{
			if (cb_getIndicatorMarginTop == null)
				cb_getIndicatorMarginTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorMarginTop);
			return cb_getIndicatorMarginTop;
		}

		static float n_GetIndicatorMarginTop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorMarginTop;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorMarginTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorMarginTop' and count(parameter)=0]"
			[Register ("getIndicatorMarginTop", "()F", "GetGetIndicatorMarginTopHandler")]
			get {
				const string __id = "getIndicatorMarginTop.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorStyle;
#pragma warning disable 0169
		static Delegate GetGetIndicatorStyleHandler ()
		{
			if (cb_getIndicatorStyle == null)
				cb_getIndicatorStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorStyle);
			return cb_getIndicatorStyle;
		}

		static int n_GetIndicatorStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorStyle;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorStyle_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorStyle_IHandler ()
		{
			if (cb_setIndicatorStyle_I == null)
				cb_setIndicatorStyle_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorStyle_I);
			return cb_setIndicatorStyle_I;
		}

		static void n_SetIndicatorStyle_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorStyle = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int IndicatorStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorStyle' and count(parameter)=0]"
			[Register ("getIndicatorStyle", "()I", "GetGetIndicatorStyleHandler")]
			get {
				const string __id = "getIndicatorStyle.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorStyle' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorStyle", "(I)V", "GetSetIndicatorStyle_IHandler")]
			set {
				const string __id = "setIndicatorStyle.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorWidth;
#pragma warning disable 0169
		static Delegate GetGetIndicatorWidthHandler ()
		{
			if (cb_getIndicatorWidth == null)
				cb_getIndicatorWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIndicatorWidth);
			return cb_getIndicatorWidth;
		}

		static float n_GetIndicatorWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorWidth_F;
#pragma warning disable 0169
		static Delegate GetSetIndicatorWidth_FHandler ()
		{
			if (cb_setIndicatorWidth_F == null)
				cb_setIndicatorWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIndicatorWidth_F);
			return cb_setIndicatorWidth_F;
		}

		static void n_SetIndicatorWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorWidth = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float IndicatorWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getIndicatorWidth' and count(parameter)=0]"
			[Register ("getIndicatorWidth", "()F", "GetGetIndicatorWidthHandler")]
			get {
				const string __id = "getIndicatorWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIndicatorWidth", "(F)V", "GetSetIndicatorWidth_FHandler")]
			set {
				const string __id = "setIndicatorWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabCount;
#pragma warning disable 0169
		static Delegate GetGetTabCountHandler ()
		{
			if (cb_getTabCount == null)
				cb_getTabCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabCount);
			return cb_getTabCount;
		}

		static int n_GetTabCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabCount;
		}
#pragma warning restore 0169

		public virtual unsafe int TabCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTabCount' and count(parameter)=0]"
			[Register ("getTabCount", "()I", "GetGetTabCountHandler")]
			get {
				const string __id = "getTabCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTabPadding;
#pragma warning disable 0169
		static Delegate GetGetTabPaddingHandler ()
		{
			if (cb_getTabPadding == null)
				cb_getTabPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTabPadding);
			return cb_getTabPadding;
		}

		static float n_GetTabPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabPadding;
		}
#pragma warning restore 0169

		static Delegate cb_setTabPadding_F;
#pragma warning disable 0169
		static Delegate GetSetTabPadding_FHandler ()
		{
			if (cb_setTabPadding_F == null)
				cb_setTabPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTabPadding_F);
			return cb_setTabPadding_F;
		}

		static void n_SetTabPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TabPadding = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float TabPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTabPadding' and count(parameter)=0]"
			[Register ("getTabPadding", "()F", "GetGetTabPaddingHandler")]
			get {
				const string __id = "getTabPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTabPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTabPadding", "(F)V", "GetSetTabPadding_FHandler")]
			set {
				const string __id = "setTabPadding.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTabSpaceEqual;
#pragma warning disable 0169
		static Delegate GetIsTabSpaceEqualHandler ()
		{
			if (cb_isTabSpaceEqual == null)
				cb_isTabSpaceEqual = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTabSpaceEqual);
			return cb_isTabSpaceEqual;
		}

		static bool n_IsTabSpaceEqual (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabSpaceEqual;
		}
#pragma warning restore 0169

		static Delegate cb_setTabSpaceEqual_Z;
#pragma warning disable 0169
		static Delegate GetSetTabSpaceEqual_ZHandler ()
		{
			if (cb_setTabSpaceEqual_Z == null)
				cb_setTabSpaceEqual_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTabSpaceEqual_Z);
			return cb_setTabSpaceEqual_Z;
		}

		static void n_SetTabSpaceEqual_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TabSpaceEqual = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool TabSpaceEqual {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='isTabSpaceEqual' and count(parameter)=0]"
			[Register ("isTabSpaceEqual", "()Z", "GetIsTabSpaceEqualHandler")]
			get {
				const string __id = "isTabSpaceEqual.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTabSpaceEqual' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTabSpaceEqual", "(Z)V", "GetSetTabSpaceEqual_ZHandler")]
			set {
				const string __id = "setTabSpaceEqual.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTabWidth;
#pragma warning disable 0169
		static Delegate GetGetTabWidthHandler ()
		{
			if (cb_getTabWidth == null)
				cb_getTabWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTabWidth);
			return cb_getTabWidth;
		}

		static float n_GetTabWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setTabWidth_F;
#pragma warning disable 0169
		static Delegate GetSetTabWidth_FHandler ()
		{
			if (cb_setTabWidth_F == null)
				cb_setTabWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTabWidth_F);
			return cb_setTabWidth_F;
		}

		static void n_SetTabWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TabWidth = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float TabWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTabWidth' and count(parameter)=0]"
			[Register ("getTabWidth", "()F", "GetGetTabWidthHandler")]
			get {
				const string __id = "getTabWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTabWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTabWidth", "(F)V", "GetSetTabWidth_FHandler")]
			set {
				const string __id = "setTabWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTextAllCaps;
#pragma warning disable 0169
		static Delegate GetIsTextAllCapsHandler ()
		{
			if (cb_isTextAllCaps == null)
				cb_isTextAllCaps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTextAllCaps);
			return cb_isTextAllCaps;
		}

		static bool n_IsTextAllCaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextAllCaps;
		}
#pragma warning restore 0169

		static Delegate cb_setTextAllCaps_Z;
#pragma warning disable 0169
		static Delegate GetSetTextAllCaps_ZHandler ()
		{
			if (cb_setTextAllCaps_Z == null)
				cb_setTextAllCaps_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTextAllCaps_Z);
			return cb_setTextAllCaps_Z;
		}

		static void n_SetTextAllCaps_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextAllCaps = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool TextAllCaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='isTextAllCaps' and count(parameter)=0]"
			[Register ("isTextAllCaps", "()Z", "GetIsTextAllCapsHandler")]
			get {
				const string __id = "isTextAllCaps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTextAllCaps' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTextAllCaps", "(Z)V", "GetSetTextAllCaps_ZHandler")]
			set {
				const string __id = "setTextAllCaps.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextBold;
#pragma warning disable 0169
		static Delegate GetGetTextBoldHandler ()
		{
			if (cb_getTextBold == null)
				cb_getTextBold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextBold);
			return cb_getTextBold;
		}

		static int n_GetTextBold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextBold;
		}
#pragma warning restore 0169

		static Delegate cb_setTextBold_I;
#pragma warning disable 0169
		static Delegate GetSetTextBold_IHandler ()
		{
			if (cb_setTextBold_I == null)
				cb_setTextBold_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextBold_I);
			return cb_setTextBold_I;
		}

		static void n_SetTextBold_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextBold = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TextBold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTextBold' and count(parameter)=0]"
			[Register ("getTextBold", "()I", "GetGetTextBoldHandler")]
			get {
				const string __id = "getTextBold.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTextBold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextBold", "(I)V", "GetSetTextBold_IHandler")]
			set {
				const string __id = "setTextBold.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSelectColor;
#pragma warning disable 0169
		static Delegate GetGetTextSelectColorHandler ()
		{
			if (cb_getTextSelectColor == null)
				cb_getTextSelectColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextSelectColor);
			return cb_getTextSelectColor;
		}

		static int n_GetTextSelectColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSelectColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSelectColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextSelectColor_IHandler ()
		{
			if (cb_setTextSelectColor_I == null)
				cb_setTextSelectColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextSelectColor_I);
			return cb_setTextSelectColor_I;
		}

		static void n_SetTextSelectColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSelectColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TextSelectColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTextSelectColor' and count(parameter)=0]"
			[Register ("getTextSelectColor", "()I", "GetGetTextSelectColorHandler")]
			get {
				const string __id = "getTextSelectColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTextSelectColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextSelectColor", "(I)V", "GetSetTextSelectColor_IHandler")]
			set {
				const string __id = "setTextSelectColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextUnselectColor;
#pragma warning disable 0169
		static Delegate GetGetTextUnselectColorHandler ()
		{
			if (cb_getTextUnselectColor == null)
				cb_getTextUnselectColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTextUnselectColor);
			return cb_getTextUnselectColor;
		}

		static int n_GetTextUnselectColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextUnselectColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextUnselectColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextUnselectColor_IHandler ()
		{
			if (cb_setTextUnselectColor_I == null)
				cb_setTextUnselectColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTextUnselectColor_I);
			return cb_setTextUnselectColor_I;
		}

		static void n_SetTextUnselectColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextUnselectColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TextUnselectColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTextUnselectColor' and count(parameter)=0]"
			[Register ("getTextUnselectColor", "()I", "GetGetTextUnselectColorHandler")]
			get {
				const string __id = "getTextUnselectColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTextUnselectColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextUnselectColor", "(I)V", "GetSetTextUnselectColor_IHandler")]
			set {
				const string __id = "setTextUnselectColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextsize;
#pragma warning disable 0169
		static Delegate GetGetTextsizeHandler ()
		{
			if (cb_getTextsize == null)
				cb_getTextsize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTextsize);
			return cb_getTextsize;
		}

		static float n_GetTextsize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Textsize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextsize_F;
#pragma warning disable 0169
		static Delegate GetSetTextsize_FHandler ()
		{
			if (cb_setTextsize_F == null)
				cb_setTextsize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTextsize_F);
			return cb_setTextsize_F;
		}

		static void n_SetTextsize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Textsize = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float Textsize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTextsize' and count(parameter)=0]"
			[Register ("getTextsize", "()F", "GetGetTextsizeHandler")]
			get {
				const string __id = "getTextsize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setTextsize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextsize", "(F)V", "GetSetTextsize_FHandler")]
			set {
				const string __id = "setTextsize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnderlineColor;
#pragma warning disable 0169
		static Delegate GetGetUnderlineColorHandler ()
		{
			if (cb_getUnderlineColor == null)
				cb_getUnderlineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnderlineColor);
			return cb_getUnderlineColor;
		}

		static int n_GetUnderlineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnderlineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setUnderlineColor_I;
#pragma warning disable 0169
		static Delegate GetSetUnderlineColor_IHandler ()
		{
			if (cb_setUnderlineColor_I == null)
				cb_setUnderlineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnderlineColor_I);
			return cb_setUnderlineColor_I;
		}

		static void n_SetUnderlineColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnderlineColor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int UnderlineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getUnderlineColor' and count(parameter)=0]"
			[Register ("getUnderlineColor", "()I", "GetGetUnderlineColorHandler")]
			get {
				const string __id = "getUnderlineColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setUnderlineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnderlineColor", "(I)V", "GetSetUnderlineColor_IHandler")]
			set {
				const string __id = "setUnderlineColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnderlineHeight;
#pragma warning disable 0169
		static Delegate GetGetUnderlineHeightHandler ()
		{
			if (cb_getUnderlineHeight == null)
				cb_getUnderlineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetUnderlineHeight);
			return cb_getUnderlineHeight;
		}

		static float n_GetUnderlineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnderlineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setUnderlineHeight_F;
#pragma warning disable 0169
		static Delegate GetSetUnderlineHeight_FHandler ()
		{
			if (cb_setUnderlineHeight_F == null)
				cb_setUnderlineHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetUnderlineHeight_F);
			return cb_setUnderlineHeight_F;
		}

		static void n_SetUnderlineHeight_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnderlineHeight = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float UnderlineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getUnderlineHeight' and count(parameter)=0]"
			[Register ("getUnderlineHeight", "()F", "GetGetUnderlineHeightHandler")]
			get {
				const string __id = "getUnderlineHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setUnderlineHeight' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setUnderlineHeight", "(F)V", "GetSetUnderlineHeight_FHandler")]
			set {
				const string __id = "setUnderlineHeight.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addNewTab_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddNewTab_Ljava_lang_String_Handler ()
		{
			if (cb_addNewTab_Ljava_lang_String_ == null)
				cb_addNewTab_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNewTab_Ljava_lang_String_);
			return cb_addNewTab_Ljava_lang_String_;
		}

		static void n_AddNewTab_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNewTab (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='addNewTab' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addNewTab", "(Ljava/lang/String;)V", "GetAddNewTab_Ljava_lang_String_Handler")]
		public virtual unsafe void AddNewTab (string p0)
		{
			const string __id = "addNewTab.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dp2px (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='dp2px' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_getMsgView_I;
#pragma warning disable 0169
		static Delegate GetGetMsgView_IHandler ()
		{
			if (cb_getMsgView_I == null)
				cb_getMsgView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMsgView_I);
			return cb_getMsgView_I;
		}

		static IntPtr n_GetMsgView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMsgView (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getMsgView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMsgView", "(I)Lcom/flyco/tablayout/widget/MsgView;", "GetGetMsgView_IHandler")]
		public virtual unsafe global::Com.Flyco.Tablayout.Widget.MsgView GetMsgView (int p0)
		{
			const string __id = "getMsgView.(I)Lcom/flyco/tablayout/widget/MsgView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Widget.MsgView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTitleView_I;
#pragma warning disable 0169
		static Delegate GetGetTitleView_IHandler ()
		{
			if (cb_getTitleView_I == null)
				cb_getTitleView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTitleView_I);
			return cb_getTitleView_I;
		}

		static IntPtr n_GetTitleView_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTitleView (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='getTitleView' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTitleView", "(I)Landroid/widget/TextView;", "GetGetTitleView_IHandler")]
		public virtual unsafe global::Android.Widget.TextView GetTitleView (int p0)
		{
			const string __id = "getTitleView.(I)Landroid/widget/TextView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideMsg_I;
#pragma warning disable 0169
		static Delegate GetHideMsg_IHandler ()
		{
			if (cb_hideMsg_I == null)
				cb_hideMsg_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_HideMsg_I);
			return cb_hideMsg_I;
		}

		static void n_HideMsg_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideMsg (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='hideMsg' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hideMsg", "(I)V", "GetHideMsg_IHandler")]
		public virtual unsafe void HideMsg (int p0)
		{
			const string __id = "hideMsg.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnPageScrollStateChanged_IHandler ()
		{
			if (cb_onPageScrollStateChanged_I == null)
				cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
			return cb_onPageScrollStateChanged_I;
		}

		static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
		public virtual unsafe void OnPageScrollStateChanged (int p0)
		{
			const string __id = "onPageScrollStateChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
		static Delegate GetOnPageScrolled_IFIHandler ()
		{
			if (cb_onPageScrolled_IFI == null)
				cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
			return cb_onPageScrolled_IFI;
		}

		static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
		public virtual unsafe void OnPageScrolled (int p0, float p1, int p2)
		{
			const string __id = "onPageScrolled.(IFI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
		static Delegate GetOnPageSelected_IHandler ()
		{
			if (cb_onPageSelected_I == null)
				cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
			return cb_onPageSelected_I;
		}

		static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
		public virtual unsafe void OnPageSelected (int p0)
		{
			const string __id = "onPageSelected.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentTab_IZ;
#pragma warning disable 0169
		static Delegate GetSetCurrentTab_IZHandler ()
		{
			if (cb_setCurrentTab_IZ == null)
				cb_setCurrentTab_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetCurrentTab_IZ);
			return cb_setCurrentTab_IZ;
		}

		static void n_SetCurrentTab_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentTab (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setCurrentTab' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setCurrentTab", "(IZ)V", "GetSetCurrentTab_IZHandler")]
		public virtual unsafe void SetCurrentTab (int p0, bool p1)
		{
			const string __id = "setCurrentTab.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorGravity_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorGravity_IHandler ()
		{
			if (cb_setIndicatorGravity_I == null)
				cb_setIndicatorGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorGravity_I);
			return cb_setIndicatorGravity_I;
		}

		static void n_SetIndicatorGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorGravity (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIndicatorGravity", "(I)V", "GetSetIndicatorGravity_IHandler")]
		public virtual unsafe void SetIndicatorGravity (int p0)
		{
			const string __id = "setIndicatorGravity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorMargin_FFFF;
#pragma warning disable 0169
		static Delegate GetSetIndicatorMargin_FFFFHandler ()
		{
			if (cb_setIndicatorMargin_FFFF == null)
				cb_setIndicatorMargin_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetIndicatorMargin_FFFF);
			return cb_setIndicatorMargin_FFFF;
		}

		static void n_SetIndicatorMargin_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorMargin (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorMargin' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setIndicatorMargin", "(FFFF)V", "GetSetIndicatorMargin_FFFFHandler")]
		public virtual unsafe void SetIndicatorMargin (float p0, float p1, float p2, float p3)
		{
			const string __id = "setIndicatorMargin.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setIndicatorWidthEqualTitle_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicatorWidthEqualTitle_ZHandler ()
		{
			if (cb_setIndicatorWidthEqualTitle_Z == null)
				cb_setIndicatorWidthEqualTitle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIndicatorWidthEqualTitle_Z);
			return cb_setIndicatorWidthEqualTitle_Z;
		}

		static void n_SetIndicatorWidthEqualTitle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicatorWidthEqualTitle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setIndicatorWidthEqualTitle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicatorWidthEqualTitle", "(Z)V", "GetSetIndicatorWidthEqualTitle_ZHandler")]
		public virtual unsafe void SetIndicatorWidthEqualTitle (bool p0)
		{
			const string __id = "setIndicatorWidthEqualTitle.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMsgMargin_IFF;
#pragma warning disable 0169
		static Delegate GetSetMsgMargin_IFFHandler ()
		{
			if (cb_setMsgMargin_IFF == null)
				cb_setMsgMargin_IFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, float>) n_SetMsgMargin_IFF);
			return cb_setMsgMargin_IFF;
		}

		static void n_SetMsgMargin_IFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMsgMargin (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setMsgMargin' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setMsgMargin", "(IFF)V", "GetSetMsgMargin_IFFHandler")]
		public virtual unsafe void SetMsgMargin (int p0, float p1, float p2)
		{
			const string __id = "setMsgMargin.(IFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_Handler ()
		{
			if (cb_setOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_ == null)
				cb_setOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_);
			return cb_setOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_;
		}

		static void n_SetOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener p0 = (global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener)global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTabSelectListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setOnTabSelectListener' and count(parameter)=1 and parameter[1][@type='com.flyco.tablayout.listener.OnTabSelectListener']]"
		[Register ("setOnTabSelectListener", "(Lcom/flyco/tablayout/listener/OnTabSelectListener;)V", "GetSetOnTabSelectListener_Lcom_flyco_tablayout_listener_OnTabSelectListener_Handler")]
		public virtual unsafe void SetOnTabSelectListener (global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener p0)
		{
			const string __id = "setOnTabSelectListener.(Lcom/flyco/tablayout/listener/OnTabSelectListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSnapOnTabClick_Z;
#pragma warning disable 0169
		static Delegate GetSetSnapOnTabClick_ZHandler ()
		{
			if (cb_setSnapOnTabClick_Z == null)
				cb_setSnapOnTabClick_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSnapOnTabClick_Z);
			return cb_setSnapOnTabClick_Z;
		}

		static void n_SetSnapOnTabClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSnapOnTabClick (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setSnapOnTabClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSnapOnTabClick", "(Z)V", "GetSetSnapOnTabClick_ZHandler")]
		public virtual unsafe void SetSnapOnTabClick (bool p0)
		{
			const string __id = "setSnapOnTabClick.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUnderlineGravity_I;
#pragma warning disable 0169
		static Delegate GetSetUnderlineGravity_IHandler ()
		{
			if (cb_setUnderlineGravity_I == null)
				cb_setUnderlineGravity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnderlineGravity_I);
			return cb_setUnderlineGravity_I;
		}

		static void n_SetUnderlineGravity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUnderlineGravity (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setUnderlineGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUnderlineGravity", "(I)V", "GetSetUnderlineGravity_IHandler")]
		public virtual unsafe void SetUnderlineGravity (int p0)
		{
			const string __id = "setUnderlineGravity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0)
		{
			const string __id = "setViewPager.(Landroid/support/v4/view/ViewPager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetViewPager (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setViewPager' and count(parameter)=2 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;[Ljava/lang/String;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0, string[] p1)
		{
			const string __id = "setViewPager.(Landroid/support/v4/view/ViewPager;[Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Android.Support.V4.App.FragmentActivity p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentActivity> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Android.Support.V4.App.Fragment>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='setViewPager' and count(parameter)=4 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='android.support.v4.app.FragmentActivity'] and parameter[4][@type='java.util.ArrayList&lt;android.support.v4.app.Fragment&gt;']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;[Ljava/lang/String;Landroid/support/v4/app/FragmentActivity;Ljava/util/ArrayList;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_arrayLjava_lang_String_Landroid_support_v4_app_FragmentActivity_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager p0, string[] p1, global::Android.Support.V4.App.FragmentActivity p2, global::System.Collections.Generic.IList<global::Android.Support.V4.App.Fragment> p3)
		{
			const string __id = "setViewPager.(Landroid/support/v4/view/ViewPager;[Ljava/lang/String;Landroid/support/v4/app/FragmentActivity;Ljava/util/ArrayList;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Android.Support.V4.App.Fragment>.ToLocalJniHandle (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_showDot_I;
#pragma warning disable 0169
		static Delegate GetShowDot_IHandler ()
		{
			if (cb_showDot_I == null)
				cb_showDot_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ShowDot_I);
			return cb_showDot_I;
		}

		static void n_ShowDot_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDot (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='showDot' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("showDot", "(I)V", "GetShowDot_IHandler")]
		public virtual unsafe void ShowDot (int p0)
		{
			const string __id = "showDot.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showMsg_II;
#pragma warning disable 0169
		static Delegate GetShowMsg_IIHandler ()
		{
			if (cb_showMsg_II == null)
				cb_showMsg_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ShowMsg_II);
			return cb_showMsg_II;
		}

		static void n_ShowMsg_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowMsg (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='showMsg' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("showMsg", "(II)V", "GetShowMsg_IIHandler")]
		public virtual unsafe void ShowMsg (int p0, int p1)
		{
			const string __id = "showMsg.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Flyco.Tablayout.SlidingTabLayout __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.SlidingTabLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sp2px (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout']/class[@name='SlidingTabLayout']/method[@name='sp2px' and count(parameter)=1 and parameter[1][@type='float']]"
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

#region "Event implementation for Com.Flyco.Tablayout.Listener.IOnTabSelectListener"
		public event EventHandler<global::Com.Flyco.Tablayout.Listener.TabReselectEventArgs> TabReselect {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener, global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor>(
						ref weak_implementor_SetOnTabSelectListener,
						__CreateIOnTabSelectListenerImplementor,
						SetOnTabSelectListener,
						__h => __h.OnTabReselectHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener, global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor>(
						ref weak_implementor_SetOnTabSelectListener,
						global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor.__IsEmpty,
						__v => SetOnTabSelectListener (null),
						__h => __h.OnTabReselectHandler -= value);
			}
		}

		public event EventHandler<global::Com.Flyco.Tablayout.Listener.TabSelectEventArgs> TabSelect {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener, global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor>(
						ref weak_implementor_SetOnTabSelectListener,
						__CreateIOnTabSelectListenerImplementor,
						SetOnTabSelectListener,
						__h => __h.OnTabSelectHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener, global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor>(
						ref weak_implementor_SetOnTabSelectListener,
						global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor.__IsEmpty,
						__v => SetOnTabSelectListener (null),
						__h => __h.OnTabSelectHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTabSelectListener;

		global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor __CreateIOnTabSelectListenerImplementor ()
		{
			return new global::Com.Flyco.Tablayout.Listener.IOnTabSelectListenerImplementor (this);
		}
#endregion
	}
}
