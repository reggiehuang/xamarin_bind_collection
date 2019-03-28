using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Jyn.Vcview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']"
	[global::Android.Runtime.Register ("com/jyn/vcview/VerificationCodeView", DoNotGenerateAcw=true)]
	public partial class VerificationCodeView : global::Android.Widget.LinearLayout, global::Android.Text.ITextWatcher, global::Android.Views.View.IOnFocusChangeListener, global::Android.Views.View.IOnKeyListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.jyn.vcview']/interface[@name='VerificationCodeView.OnCodeFinishListener']"
		[Register ("com/jyn/vcview/VerificationCodeView$OnCodeFinishListener", "", "Com.Jyn.Vcview.VerificationCodeView/IOnCodeFinishListenerInvoker")]
		public partial interface IOnCodeFinishListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/interface[@name='VerificationCodeView.OnCodeFinishListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onComplete", "(Ljava/lang/String;)V", "GetOnComplete_Ljava_lang_String_Handler:Com.Jyn.Vcview.VerificationCodeView/IOnCodeFinishListenerInvoker, Binding_Verificationcodeview-release")]
			void OnComplete (string p0);

		}

		[global::Android.Runtime.Register ("com/jyn/vcview/VerificationCodeView$OnCodeFinishListener", DoNotGenerateAcw=true)]
		internal class IOnCodeFinishListenerInvoker : global::Java.Lang.Object, IOnCodeFinishListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/jyn/vcview/VerificationCodeView$OnCodeFinishListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnCodeFinishListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnCodeFinishListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnCodeFinishListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.jyn.vcview.VerificationCodeView.OnCodeFinishListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnCodeFinishListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		public partial class CodeFinishEventArgs : global::System.EventArgs {

			public CodeFinishEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/jyn/vcview/VerificationCodeView_OnCodeFinishListenerImplementor")]
		internal sealed partial class IOnCodeFinishListenerImplementor : global::Java.Lang.Object, IOnCodeFinishListener {

			object sender;

			public IOnCodeFinishListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/jyn/vcview/VerificationCodeView_OnCodeFinishListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CodeFinishEventArgs> Handler;
#pragma warning restore 0649

			public void OnComplete (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CodeFinishEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnCodeFinishListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']"
		[global::Android.Runtime.Register ("com/jyn/vcview/VerificationCodeView$VCInputType", DoNotGenerateAcw=true)]
		public sealed partial class VCInputType : global::Java.Lang.Enum {


			static IntPtr NUMBER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/field[@name='NUMBER']"
			[Register ("NUMBER")]
			public static global::Com.Jyn.Vcview.VerificationCodeView.VCInputType Number {
				get {
					if (NUMBER_jfieldId == IntPtr.Zero)
						NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBER", "Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NUMBERPASSWORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/field[@name='NUMBERPASSWORD']"
			[Register ("NUMBERPASSWORD")]
			public static global::Com.Jyn.Vcview.VerificationCodeView.VCInputType Numberpassword {
				get {
					if (NUMBERPASSWORD_jfieldId == IntPtr.Zero)
						NUMBERPASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBERPASSWORD", "Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBERPASSWORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Jyn.Vcview.VerificationCodeView.VCInputType Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXTPASSWORD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/field[@name='TEXTPASSWORD']"
			[Register ("TEXTPASSWORD")]
			public static global::Com.Jyn.Vcview.VerificationCodeView.VCInputType Textpassword {
				get {
					if (TEXTPASSWORD_jfieldId == IntPtr.Zero)
						TEXTPASSWORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXTPASSWORD", "Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXTPASSWORD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/jyn/vcview/VerificationCodeView$VCInputType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VCInputType); }
			}

			internal VCInputType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/jyn/vcview/VerificationCodeView$VCInputType;", "")]
			public static unsafe global::Com.Jyn.Vcview.VerificationCodeView.VCInputType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Jyn.Vcview.VerificationCodeView.VCInputType __ret = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView.VCInputType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/jyn/vcview/VerificationCodeView$VCInputType;", "")]
			public static unsafe global::Com.Jyn.Vcview.VerificationCodeView.VCInputType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
				try {
					return (global::Com.Jyn.Vcview.VerificationCodeView.VCInputType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Jyn.Vcview.VerificationCodeView.VCInputType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/jyn/vcview/VerificationCodeView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VerificationCodeView); }
		}

		protected VerificationCodeView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/constructor[@name='VerificationCodeView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe VerificationCodeView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (VerificationCodeView)) {
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

		static Delegate cb_getOnCodeFinishListener;
#pragma warning disable 0169
		static Delegate GetGetOnCodeFinishListenerHandler ()
		{
			if (cb_getOnCodeFinishListener == null)
				cb_getOnCodeFinishListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnCodeFinishListener);
			return cb_getOnCodeFinishListener;
		}

		static IntPtr n_GetOnCodeFinishListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCodeFinishListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_Handler ()
		{
			if (cb_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_ == null)
				cb_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_);
			return cb_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_;
		}

		static void n_SetOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener p0 = (global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener)global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCodeFinishListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOnCodeFinishListener;
		static IntPtr id_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_;
		public virtual unsafe global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener OnCodeFinishListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getOnCodeFinishListener' and count(parameter)=0]"
			[Register ("getOnCodeFinishListener", "()Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;", "GetGetOnCodeFinishListenerHandler")]
			get {
				if (id_getOnCodeFinishListener == IntPtr.Zero)
					id_getOnCodeFinishListener = JNIEnv.GetMethodID (class_ref, "getOnCodeFinishListener", "()Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnCodeFinishListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnCodeFinishListener", "()Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setOnCodeFinishListener' and count(parameter)=1 and parameter[1][@type='com.jyn.vcview.VerificationCodeView.OnCodeFinishListener']]"
			[Register ("setOnCodeFinishListener", "(Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;)V", "GetSetOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_Handler")]
			set {
				if (id_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_ == IntPtr.Zero)
					id_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_ = JNIEnv.GetMethodID (class_ref, "setOnCodeFinishListener", "(Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCodeFinishListener_Lcom_jyn_vcview_VerificationCodeView_OnCodeFinishListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCodeFinishListener", "(Lcom/jyn/vcview/VerificationCodeView$OnCodeFinishListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_afterTextChanged_Landroid_text_Editable_;
#pragma warning disable 0169
		static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler ()
		{
			if (cb_afterTextChanged_Landroid_text_Editable_ == null)
				cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterTextChanged_Landroid_text_Editable_);
			return cb_afterTextChanged_Landroid_text_Editable_;
		}

		static void n_AfterTextChanged_Landroid_text_Editable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Text.IEditable p0 = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AfterTextChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_afterTextChanged_Landroid_text_Editable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "GetAfterTextChanged_Landroid_text_Editable_Handler")]
		public virtual unsafe void AfterTextChanged (global::Android.Text.IEditable p0)
		{
			if (id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
				id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID (class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterTextChanged_Landroid_text_Editable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterTextChanged", "(Landroid/text/Editable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
				cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_BeforeTextChanged_Ljava_lang_CharSequence_III);
			return cb_beforeTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_BeforeTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeforeTextChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beforeTextChanged_Ljava_lang_CharSequence_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void BeforeTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			BeforeTextChanged (jls_p0, p1, p2, p3);
			jls_p0?.Dispose ();
		}

		static Delegate cb_getmCursorDrawable;
#pragma warning disable 0169
		static Delegate GetGetmCursorDrawableHandler ()
		{
			if (cb_getmCursorDrawable == null)
				cb_getmCursorDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmCursorDrawable);
			return cb_getmCursorDrawable;
		}

		static int n_GetmCursorDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmCursorDrawable ();
		}
#pragma warning restore 0169

		static IntPtr id_getmCursorDrawable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmCursorDrawable' and count(parameter)=0]"
		[Register ("getmCursorDrawable", "()I", "GetGetmCursorDrawableHandler")]
		public virtual unsafe int GetmCursorDrawable ()
		{
			if (id_getmCursorDrawable == IntPtr.Zero)
				id_getmCursorDrawable = JNIEnv.GetMethodID (class_ref, "getmCursorDrawable", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmCursorDrawable);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmCursorDrawable", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmEtInputType;
#pragma warning disable 0169
		static Delegate GetGetmEtInputTypeHandler ()
		{
			if (cb_getmEtInputType == null)
				cb_getmEtInputType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmEtInputType);
			return cb_getmEtInputType;
		}

		static IntPtr n_GetmEtInputType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetmEtInputType ());
		}
#pragma warning restore 0169

		static IntPtr id_getmEtInputType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtInputType' and count(parameter)=0]"
		[Register ("getmEtInputType", "()Lcom/jyn/vcview/VerificationCodeView$VCInputType;", "GetGetmEtInputTypeHandler")]
		public virtual unsafe global::Com.Jyn.Vcview.VerificationCodeView.VCInputType GetmEtInputType ()
		{
			if (id_getmEtInputType == IntPtr.Zero)
				id_getmEtInputType = JNIEnv.GetMethodID (class_ref, "getmEtInputType", "()Lcom/jyn/vcview/VerificationCodeView$VCInputType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmEtInputType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtInputType", "()Lcom/jyn/vcview/VerificationCodeView$VCInputType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getmEtNumber;
#pragma warning disable 0169
		static Delegate GetGetmEtNumberHandler ()
		{
			if (cb_getmEtNumber == null)
				cb_getmEtNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmEtNumber);
			return cb_getmEtNumber;
		}

		static int n_GetmEtNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmEtNumber ();
		}
#pragma warning restore 0169

		static IntPtr id_getmEtNumber;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtNumber' and count(parameter)=0]"
		[Register ("getmEtNumber", "()I", "GetGetmEtNumberHandler")]
		public virtual unsafe int GetmEtNumber ()
		{
			if (id_getmEtNumber == IntPtr.Zero)
				id_getmEtNumber = JNIEnv.GetMethodID (class_ref, "getmEtNumber", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmEtNumber);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtNumber", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmEtTextBg;
#pragma warning disable 0169
		static Delegate GetGetmEtTextBgHandler ()
		{
			if (cb_getmEtTextBg == null)
				cb_getmEtTextBg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmEtTextBg);
			return cb_getmEtTextBg;
		}

		static int n_GetmEtTextBg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmEtTextBg ();
		}
#pragma warning restore 0169

		static IntPtr id_getmEtTextBg;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtTextBg' and count(parameter)=0]"
		[Register ("getmEtTextBg", "()I", "GetGetmEtTextBgHandler")]
		public virtual unsafe int GetmEtTextBg ()
		{
			if (id_getmEtTextBg == IntPtr.Zero)
				id_getmEtTextBg = JNIEnv.GetMethodID (class_ref, "getmEtTextBg", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmEtTextBg);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtTextBg", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmEtTextColor;
#pragma warning disable 0169
		static Delegate GetGetmEtTextColorHandler ()
		{
			if (cb_getmEtTextColor == null)
				cb_getmEtTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmEtTextColor);
			return cb_getmEtTextColor;
		}

		static int n_GetmEtTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmEtTextColor ();
		}
#pragma warning restore 0169

		static IntPtr id_getmEtTextColor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtTextColor' and count(parameter)=0]"
		[Register ("getmEtTextColor", "()I", "GetGetmEtTextColorHandler")]
		public virtual unsafe int GetmEtTextColor ()
		{
			if (id_getmEtTextColor == IntPtr.Zero)
				id_getmEtTextColor = JNIEnv.GetMethodID (class_ref, "getmEtTextColor", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmEtTextColor);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtTextColor", "()I"));
			} finally {
			}
		}

		static Delegate cb_getmEtTextSize;
#pragma warning disable 0169
		static Delegate GetGetmEtTextSizeHandler ()
		{
			if (cb_getmEtTextSize == null)
				cb_getmEtTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetmEtTextSize);
			return cb_getmEtTextSize;
		}

		static float n_GetmEtTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmEtTextSize ();
		}
#pragma warning restore 0169

		static IntPtr id_getmEtTextSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtTextSize' and count(parameter)=0]"
		[Register ("getmEtTextSize", "()F", "GetGetmEtTextSizeHandler")]
		public virtual unsafe float GetmEtTextSize ()
		{
			if (id_getmEtTextSize == IntPtr.Zero)
				id_getmEtTextSize = JNIEnv.GetMethodID (class_ref, "getmEtTextSize", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getmEtTextSize);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtTextSize", "()F"));
			} finally {
			}
		}

		static Delegate cb_getmEtWidth;
#pragma warning disable 0169
		static Delegate GetGetmEtWidthHandler ()
		{
			if (cb_getmEtWidth == null)
				cb_getmEtWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmEtWidth);
			return cb_getmEtWidth;
		}

		static int n_GetmEtWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmEtWidth ();
		}
#pragma warning restore 0169

		static IntPtr id_getmEtWidth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='getmEtWidth' and count(parameter)=0]"
		[Register ("getmEtWidth", "()I", "GetGetmEtWidthHandler")]
		public virtual unsafe int GetmEtWidth ()
		{
			if (id_getmEtWidth == IntPtr.Zero)
				id_getmEtWidth = JNIEnv.GetMethodID (class_ref, "getmEtWidth", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmEtWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmEtWidth", "()I"));
			} finally {
			}
		}

		static Delegate cb_onFocusChange_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetOnFocusChange_Landroid_view_View_ZHandler ()
		{
			if (cb_onFocusChange_Landroid_view_View_Z == null)
				cb_onFocusChange_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnFocusChange_Landroid_view_View_Z);
			return cb_onFocusChange_Landroid_view_View_Z;
		}

		static void n_OnFocusChange_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFocusChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onFocusChange_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='onFocusChange' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("onFocusChange", "(Landroid/view/View;Z)V", "GetOnFocusChange_Landroid_view_View_ZHandler")]
		public virtual unsafe void OnFocusChange (global::Android.Views.View p0, bool p1)
		{
			if (id_onFocusChange_Landroid_view_View_Z == IntPtr.Zero)
				id_onFocusChange_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "onFocusChange", "(Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFocusChange_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFocusChange", "(Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetOnKey_Landroid_view_View_ILandroid_view_KeyEvent_Handler ()
		{
			if (cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ == null)
				cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnKey_Landroid_view_View_ILandroid_view_KeyEvent_);
			return cb_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
		}

		static bool n_OnKey_Landroid_view_View_ILandroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, IntPtr native_p2)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Keycode p1 = (global::Android.Views.Keycode) native_p1;
			global::Android.Views.KeyEvent p2 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKey (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='onKey' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.view.KeyEvent']]"
		[Register ("onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", "GetOnKey_Landroid_view_View_ILandroid_view_KeyEvent_Handler")]
		public virtual unsafe bool OnKey (global::Android.Views.View p0, [global::Android.Runtime.GeneratedEnum] global::Android.Views.Keycode p1, global::Android.Views.KeyEvent p2)
		{
			if (id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ == IntPtr.Zero)
				id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onKey_Landroid_view_View_ILandroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_onTextChanged_Ljava_lang_CharSequence_III == null)
				cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnTextChanged_Ljava_lang_CharSequence_III);
			return cb_onTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_OnTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTextChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void OnTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextChanged_Ljava_lang_CharSequence_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void OnTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			OnTextChanged (jls_p0, p1, p2, p3);
			jls_p0?.Dispose ();
		}

		static Delegate cb_setmCursorDrawable_I;
#pragma warning disable 0169
		static Delegate GetSetmCursorDrawable_IHandler ()
		{
			if (cb_setmCursorDrawable_I == null)
				cb_setmCursorDrawable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmCursorDrawable_I);
			return cb_setmCursorDrawable_I;
		}

		static void n_SetmCursorDrawable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmCursorDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmCursorDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmCursorDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmCursorDrawable", "(I)V", "GetSetmCursorDrawable_IHandler")]
		public virtual unsafe void SetmCursorDrawable (int p0)
		{
			if (id_setmCursorDrawable_I == IntPtr.Zero)
				id_setmCursorDrawable_I = JNIEnv.GetMethodID (class_ref, "setmCursorDrawable", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmCursorDrawable_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmCursorDrawable", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_;
#pragma warning disable 0169
		static Delegate GetSetmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_Handler ()
		{
			if (cb_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_ == null)
				cb_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_);
			return cb_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_;
		}

		static void n_SetmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Jyn.Vcview.VerificationCodeView.VCInputType p0 = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView.VCInputType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtInputType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtInputType' and count(parameter)=1 and parameter[1][@type='com.jyn.vcview.VerificationCodeView.VCInputType']]"
		[Register ("setmEtInputType", "(Lcom/jyn/vcview/VerificationCodeView$VCInputType;)V", "GetSetmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_Handler")]
		public virtual unsafe void SetmEtInputType (global::Com.Jyn.Vcview.VerificationCodeView.VCInputType p0)
		{
			if (id_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_ == IntPtr.Zero)
				id_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_ = JNIEnv.GetMethodID (class_ref, "setmEtInputType", "(Lcom/jyn/vcview/VerificationCodeView$VCInputType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtInputType_Lcom_jyn_vcview_VerificationCodeView_VCInputType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtInputType", "(Lcom/jyn/vcview/VerificationCodeView$VCInputType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtNumber_I;
#pragma warning disable 0169
		static Delegate GetSetmEtNumber_IHandler ()
		{
			if (cb_setmEtNumber_I == null)
				cb_setmEtNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmEtNumber_I);
			return cb_setmEtNumber_I;
		}

		static void n_SetmEtNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtNumber (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtNumber_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmEtNumber", "(I)V", "GetSetmEtNumber_IHandler")]
		public virtual unsafe void SetmEtNumber (int p0)
		{
			if (id_setmEtNumber_I == IntPtr.Zero)
				id_setmEtNumber_I = JNIEnv.GetMethodID (class_ref, "setmEtNumber", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtNumber_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtNumber", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtTextBg_I;
#pragma warning disable 0169
		static Delegate GetSetmEtTextBg_IHandler ()
		{
			if (cb_setmEtTextBg_I == null)
				cb_setmEtTextBg_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmEtTextBg_I);
			return cb_setmEtTextBg_I;
		}

		static void n_SetmEtTextBg_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtTextBg (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtTextBg_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtTextBg' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmEtTextBg", "(I)V", "GetSetmEtTextBg_IHandler")]
		public virtual unsafe void SetmEtTextBg (int p0)
		{
			if (id_setmEtTextBg_I == IntPtr.Zero)
				id_setmEtTextBg_I = JNIEnv.GetMethodID (class_ref, "setmEtTextBg", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtTextBg_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtTextBg", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetmEtTextColor_IHandler ()
		{
			if (cb_setmEtTextColor_I == null)
				cb_setmEtTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmEtTextColor_I);
			return cb_setmEtTextColor_I;
		}

		static void n_SetmEtTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmEtTextColor", "(I)V", "GetSetmEtTextColor_IHandler")]
		public virtual unsafe void SetmEtTextColor (int p0)
		{
			if (id_setmEtTextColor_I == IntPtr.Zero)
				id_setmEtTextColor_I = JNIEnv.GetMethodID (class_ref, "setmEtTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetmEtTextSize_FHandler ()
		{
			if (cb_setmEtTextSize_F == null)
				cb_setmEtTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetmEtTextSize_F);
			return cb_setmEtTextSize_F;
		}

		static void n_SetmEtTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtTextSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtTextSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setmEtTextSize", "(F)V", "GetSetmEtTextSize_FHandler")]
		public virtual unsafe void SetmEtTextSize (float p0)
		{
			if (id_setmEtTextSize_F == IntPtr.Zero)
				id_setmEtTextSize_F = JNIEnv.GetMethodID (class_ref, "setmEtTextSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtTextSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtTextSize", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setmEtWidth_I;
#pragma warning disable 0169
		static Delegate GetSetmEtWidth_IHandler ()
		{
			if (cb_setmEtWidth_I == null)
				cb_setmEtWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetmEtWidth_I);
			return cb_setmEtWidth_I;
		}

		static void n_SetmEtWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Jyn.Vcview.VerificationCodeView __this = global::Java.Lang.Object.GetObject<global::Com.Jyn.Vcview.VerificationCodeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetmEtWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setmEtWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.jyn.vcview']/class[@name='VerificationCodeView']/method[@name='setmEtWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setmEtWidth", "(I)V", "GetSetmEtWidth_IHandler")]
		public virtual unsafe void SetmEtWidth (int p0)
		{
			if (id_setmEtWidth_I == IntPtr.Zero)
				id_setmEtWidth_I = JNIEnv.GetMethodID (class_ref, "setmEtWidth", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setmEtWidth_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setmEtWidth", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener"
		public event EventHandler<global::Com.Jyn.Vcview.VerificationCodeView.CodeFinishEventArgs> CodeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener, global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListenerImplementor>(
						ref weak_implementor___SetOnCodeFinishListener,
						__CreateIOnCodeFinishListenerImplementor,
						__v => OnCodeFinishListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListener, global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListenerImplementor>(
						ref weak_implementor___SetOnCodeFinishListener,
						global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListenerImplementor.__IsEmpty,
						__v => OnCodeFinishListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnCodeFinishListener;

		global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListenerImplementor __CreateIOnCodeFinishListenerImplementor ()
		{
			return new global::Com.Jyn.Vcview.VerificationCodeView.IOnCodeFinishListenerImplementor (this);
		}
#endregion
	}
}
