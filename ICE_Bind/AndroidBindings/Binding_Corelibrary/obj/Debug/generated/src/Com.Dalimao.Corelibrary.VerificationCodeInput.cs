using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Dalimao.Corelibrary {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.dalimao.corelibrary']/class[@name='VerificationCodeInput']"
	[global::Android.Runtime.Register ("com/dalimao/corelibrary/VerificationCodeInput", DoNotGenerateAcw=true)]
	public partial class VerificationCodeInput : global::Android.Views.ViewGroup {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.dalimao.corelibrary']/interface[@name='VerificationCodeInput.Listener']"
		[Register ("com/dalimao/corelibrary/VerificationCodeInput$Listener", "", "Com.Dalimao.Corelibrary.VerificationCodeInput/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.dalimao.corelibrary']/interface[@name='VerificationCodeInput.Listener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onComplete", "(Ljava/lang/String;)V", "GetOnComplete_Ljava_lang_String_Handler:Com.Dalimao.Corelibrary.VerificationCodeInput/IListenerInvoker, Binding_Corelibrary")]
			void OnComplete (string p0);

		}

		[global::Android.Runtime.Register ("com/dalimao/corelibrary/VerificationCodeInput$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/dalimao/corelibrary/VerificationCodeInput$Listener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.dalimao.corelibrary.VerificationCodeInput.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_ == null)
					cb_onComplete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Ljava_lang_String_);
				return cb_onComplete_Ljava_lang_String_;
			}

			static void n_OnComplete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_;
			public unsafe void OnComplete (string p0)
			{
				if (id_onComplete_Ljava_lang_String_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/dalimao/corelibrary/VerificationCodeInput_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/dalimao/corelibrary/VerificationCodeInput_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/dalimao/corelibrary/VerificationCodeInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VerificationCodeInput); }
		}

		protected VerificationCodeInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.dalimao.corelibrary']/class[@name='VerificationCodeInput']/constructor[@name='VerificationCodeInput' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe VerificationCodeInput (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (VerificationCodeInput)) {
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

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Dalimao.Corelibrary.VerificationCodeInput __this = global::Java.Lang.Object.GetObject<global::Com.Dalimao.Corelibrary.VerificationCodeInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dalimao.corelibrary']/class[@name='VerificationCodeInput']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_;
#pragma warning disable 0169
		static Delegate GetSetOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_Handler ()
		{
			if (cb_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_ == null)
				cb_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_);
			return cb_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_;
		}

		static void n_SetOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Dalimao.Corelibrary.VerificationCodeInput __this = global::Java.Lang.Object.GetObject<global::Com.Dalimao.Corelibrary.VerificationCodeInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener p0 = (global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener)global::Java.Lang.Object.GetObject<global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCompleteListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.dalimao.corelibrary']/class[@name='VerificationCodeInput']/method[@name='setOnCompleteListener' and count(parameter)=1 and parameter[1][@type='com.dalimao.corelibrary.VerificationCodeInput.Listener']]"
		[Register ("setOnCompleteListener", "(Lcom/dalimao/corelibrary/VerificationCodeInput$Listener;)V", "GetSetOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_Handler")]
		public virtual unsafe void SetOnCompleteListener (global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener p0)
		{
			if (id_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_ == IntPtr.Zero)
				id_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_ = JNIEnv.GetMethodID (class_ref, "setOnCompleteListener", "(Lcom/dalimao/corelibrary/VerificationCodeInput$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCompleteListener_Lcom_dalimao_corelibrary_VerificationCodeInput_Listener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCompleteListener", "(Lcom/dalimao/corelibrary/VerificationCodeInput$Listener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Dalimao.Corelibrary.VerificationCodeInput.IListener"
		public event EventHandler<global::Com.Dalimao.Corelibrary.VerificationCodeInput.EventArgs> Complete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener, global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						__CreateIListenerImplementor,
						SetOnCompleteListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListener, global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListenerImplementor>(
						ref weak_implementor_SetOnCompleteListener,
						global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListenerImplementor.__IsEmpty,
						__v => SetOnCompleteListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCompleteListener;

		global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListenerImplementor __CreateIListenerImplementor ()
		{
			return new global::Com.Dalimao.Corelibrary.VerificationCodeInput.IListenerImplementor (this);
		}
#endregion
	}
}
