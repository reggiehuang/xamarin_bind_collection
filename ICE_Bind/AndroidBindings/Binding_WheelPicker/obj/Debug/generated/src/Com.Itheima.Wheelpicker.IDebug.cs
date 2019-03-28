using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IDebug']"
	[Register ("com/itheima/wheelpicker/IDebug", "", "Com.Itheima.Wheelpicker.IDebugInvoker")]
	public partial interface IDebug : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IDebug']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler:Com.Itheima.Wheelpicker.IDebugInvoker, Binding_WheelPicker")]
		void SetDebug (bool p0);

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/IDebug", DoNotGenerateAcw=true)]
	internal class IDebugInvoker : global::Java.Lang.Object, IDebug {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/IDebug");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDebugInvoker); }
		}

		IntPtr class_ref;

		public static IDebug GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDebug> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.IDebug"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDebugInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Itheima.Wheelpicker.IDebug __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IDebug> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDebug_Z;
		public unsafe void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetMethodID (class_ref, "setDebug", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebug_Z, __args);
		}

	}

}
