using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='OnTabSelectListener']"
	[Register ("com/flyco/tablayout/listener/OnTabSelectListener", "", "Com.Flyco.Tablayout.Listener.IOnTabSelectListenerInvoker")]
	public partial interface IOnTabSelectListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='OnTabSelectListener']/method[@name='onTabReselect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTabReselect", "(I)V", "GetOnTabReselect_IHandler:Com.Flyco.Tablayout.Listener.IOnTabSelectListenerInvoker, TestLib")]
		void OnTabReselect (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='OnTabSelectListener']/method[@name='onTabSelect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTabSelect", "(I)V", "GetOnTabSelect_IHandler:Com.Flyco.Tablayout.Listener.IOnTabSelectListenerInvoker, TestLib")]
		void OnTabSelect (int p0);

	}

	[global::Android.Runtime.Register ("com/flyco/tablayout/listener/OnTabSelectListener", DoNotGenerateAcw=true)]
	internal class IOnTabSelectListenerInvoker : global::Java.Lang.Object, IOnTabSelectListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/flyco/tablayout/listener/OnTabSelectListener", typeof (IOnTabSelectListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnTabSelectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnTabSelectListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flyco.tablayout.listener.OnTabSelectListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnTabSelectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTabReselect_I;
#pragma warning disable 0169
		static Delegate GetOnTabReselect_IHandler ()
		{
			if (cb_onTabReselect_I == null)
				cb_onTabReselect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTabReselect_I);
			return cb_onTabReselect_I;
		}

		static void n_OnTabReselect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTabReselect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTabReselect_I;
		public unsafe void OnTabReselect (int p0)
		{
			if (id_onTabReselect_I == IntPtr.Zero)
				id_onTabReselect_I = JNIEnv.GetMethodID (class_ref, "onTabReselect", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabReselect_I, __args);
		}

		static Delegate cb_onTabSelect_I;
#pragma warning disable 0169
		static Delegate GetOnTabSelect_IHandler ()
		{
			if (cb_onTabSelect_I == null)
				cb_onTabSelect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTabSelect_I);
			return cb_onTabSelect_I;
		}

		static void n_OnTabSelect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.IOnTabSelectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTabSelect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTabSelect_I;
		public unsafe void OnTabSelect (int p0)
		{
			if (id_onTabSelect_I == IntPtr.Zero)
				id_onTabSelect_I = JNIEnv.GetMethodID (class_ref, "onTabSelect", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTabSelect_I, __args);
		}

	}

	public partial class TabReselectEventArgs : global::System.EventArgs {

		public TabReselectEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class TabSelectEventArgs : global::System.EventArgs {

		public TabSelectEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/flyco/tablayout/listener/OnTabSelectListenerImplementor")]
	internal sealed partial class IOnTabSelectListenerImplementor : global::Java.Lang.Object, IOnTabSelectListener {

		object sender;

		public IOnTabSelectListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/flyco/tablayout/listener/OnTabSelectListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<TabReselectEventArgs> OnTabReselectHandler;
#pragma warning restore 0649

		public void OnTabReselect (int p0)
		{
			var __h = OnTabReselectHandler;
			if (__h != null)
				__h (sender, new TabReselectEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<TabSelectEventArgs> OnTabSelectHandler;
#pragma warning restore 0649

		public void OnTabSelect (int p0)
		{
			var __h = OnTabSelectHandler;
			if (__h != null)
				__h (sender, new TabSelectEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnTabSelectListenerImplementor value)
		{
			return value.OnTabReselectHandler == null && value.OnTabSelectHandler == null;
		}
	}

}
