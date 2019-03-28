using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='CustomTabEntity']"
	[Register ("com/flyco/tablayout/listener/CustomTabEntity", "", "Com.Flyco.Tablayout.Listener.ICustomTabEntityInvoker")]
	public partial interface ICustomTabEntity : IJavaObject {

		int TabSelectedIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='CustomTabEntity']/method[@name='getTabSelectedIcon' and count(parameter)=0]"
			[Register ("getTabSelectedIcon", "()I", "GetGetTabSelectedIconHandler:Com.Flyco.Tablayout.Listener.ICustomTabEntityInvoker, TestLib")] get;
		}

		string TabTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='CustomTabEntity']/method[@name='getTabTitle' and count(parameter)=0]"
			[Register ("getTabTitle", "()Ljava/lang/String;", "GetGetTabTitleHandler:Com.Flyco.Tablayout.Listener.ICustomTabEntityInvoker, TestLib")] get;
		}

		int TabUnselectedIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.listener']/interface[@name='CustomTabEntity']/method[@name='getTabUnselectedIcon' and count(parameter)=0]"
			[Register ("getTabUnselectedIcon", "()I", "GetGetTabUnselectedIconHandler:Com.Flyco.Tablayout.Listener.ICustomTabEntityInvoker, TestLib")] get;
		}

	}

	[global::Android.Runtime.Register ("com/flyco/tablayout/listener/CustomTabEntity", DoNotGenerateAcw=true)]
	internal class ICustomTabEntityInvoker : global::Java.Lang.Object, ICustomTabEntity {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/flyco/tablayout/listener/CustomTabEntity", typeof (ICustomTabEntityInvoker));

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

		public static ICustomTabEntity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICustomTabEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.flyco.tablayout.listener.CustomTabEntity"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICustomTabEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTabSelectedIcon;
#pragma warning disable 0169
		static Delegate GetGetTabSelectedIconHandler ()
		{
			if (cb_getTabSelectedIcon == null)
				cb_getTabSelectedIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabSelectedIcon);
			return cb_getTabSelectedIcon;
		}

		static int n_GetTabSelectedIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Listener.ICustomTabEntity __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.ICustomTabEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabSelectedIcon;
		}
#pragma warning restore 0169

		IntPtr id_getTabSelectedIcon;
		public unsafe int TabSelectedIcon {
			get {
				if (id_getTabSelectedIcon == IntPtr.Zero)
					id_getTabSelectedIcon = JNIEnv.GetMethodID (class_ref, "getTabSelectedIcon", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTabSelectedIcon);
			}
		}

		static Delegate cb_getTabTitle;
#pragma warning disable 0169
		static Delegate GetGetTabTitleHandler ()
		{
			if (cb_getTabTitle == null)
				cb_getTabTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTabTitle);
			return cb_getTabTitle;
		}

		static IntPtr n_GetTabTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Listener.ICustomTabEntity __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.ICustomTabEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TabTitle);
		}
#pragma warning restore 0169

		IntPtr id_getTabTitle;
		public unsafe string TabTitle {
			get {
				if (id_getTabTitle == IntPtr.Zero)
					id_getTabTitle = JNIEnv.GetMethodID (class_ref, "getTabTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTabTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTabUnselectedIcon;
#pragma warning disable 0169
		static Delegate GetGetTabUnselectedIconHandler ()
		{
			if (cb_getTabUnselectedIcon == null)
				cb_getTabUnselectedIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTabUnselectedIcon);
			return cb_getTabUnselectedIcon;
		}

		static int n_GetTabUnselectedIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flyco.Tablayout.Listener.ICustomTabEntity __this = global::Java.Lang.Object.GetObject<global::Com.Flyco.Tablayout.Listener.ICustomTabEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TabUnselectedIcon;
		}
#pragma warning restore 0169

		IntPtr id_getTabUnselectedIcon;
		public unsafe int TabUnselectedIcon {
			get {
				if (id_getTabUnselectedIcon == IntPtr.Zero)
					id_getTabUnselectedIcon = JNIEnv.GetMethodID (class_ref, "getTabUnselectedIcon", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTabUnselectedIcon);
			}
		}

	}

}
