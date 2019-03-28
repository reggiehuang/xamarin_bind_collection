using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='FragmentChangeManager']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/utils/FragmentChangeManager", DoNotGenerateAcw=true)]
	public partial class FragmentChangeManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/flyco/tablayout/utils/FragmentChangeManager", typeof (FragmentChangeManager));
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

		protected FragmentChangeManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='FragmentChangeManager']/constructor[@name='FragmentChangeManager' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.FragmentManager'] and parameter[2][@type='int'] and parameter[3][@type='java.util.ArrayList&lt;android.support.v4.app.Fragment&gt;']]"
		[Register (".ctor", "(Landroid/support/v4/app/FragmentManager;ILjava/util/ArrayList;)V", "")]
		public unsafe FragmentChangeManager (global::Android.Support.V4.App.FragmentManager p0, int p1, global::System.Collections.Generic.IList<global::Android.Support.V4.App.Fragment> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/support/v4/app/FragmentManager;ILjava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.Support.V4.App.Fragment>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCurrentFragment;
#pragma warning disable 0169
		static Delegate GetGetCurrentFragmentHandler ()
		{
			if (cb_getCurrentFragment == null)
				cb_getCurrentFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentFragment);
			return cb_getCurrentFragment;
		}

		static IntPtr n_GetCurrentFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Utils.FragmentChangeManager __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Utils.FragmentChangeManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentFragment);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Support.V4.App.Fragment CurrentFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='FragmentChangeManager']/method[@name='getCurrentFragment' and count(parameter)=0]"
			[Register ("getCurrentFragment", "()Landroid/support/v4/app/Fragment;", "GetGetCurrentFragmentHandler")]
			get {
				const string __id = "getCurrentFragment.()Landroid/support/v4/app/Fragment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Flyco.Tablayout.Utils.FragmentChangeManager __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Utils.FragmentChangeManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentTab;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentTab {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='FragmentChangeManager']/method[@name='getCurrentTab' and count(parameter)=0]"
			[Register ("getCurrentTab", "()I", "GetGetCurrentTabHandler")]
			get {
				const string __id = "getCurrentTab.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_setFragments_I;
#pragma warning disable 0169
		static Delegate GetSetFragments_IHandler ()
		{
			if (cb_setFragments_I == null)
				cb_setFragments_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFragments_I);
			return cb_setFragments_I;
		}

		static void n_SetFragments_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Utils.FragmentChangeManager __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Utils.FragmentChangeManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFragments (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='FragmentChangeManager']/method[@name='setFragments' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFragments", "(I)V", "GetSetFragments_IHandler")]
		public virtual unsafe void SetFragments (int p0)
		{
			const string __id = "setFragments.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
