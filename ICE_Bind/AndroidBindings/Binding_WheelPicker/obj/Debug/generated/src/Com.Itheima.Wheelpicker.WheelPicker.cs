using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']"
	[global::Android.Runtime.Register ("com/itheima/wheelpicker/WheelPicker", DoNotGenerateAcw=true)]
	public partial class WheelPicker : global::Android.Views.View, global::Com.Itheima.Wheelpicker.IDebug, global::Com.Itheima.Wheelpicker.IWheelPicker, global::Java.Lang.IRunnable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='ALIGN_CENTER']"
		[Register ("ALIGN_CENTER")]
		public const int AlignCenter = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='ALIGN_LEFT']"
		[Register ("ALIGN_LEFT")]
		public const int AlignLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='ALIGN_RIGHT']"
		[Register ("ALIGN_RIGHT")]
		public const int AlignRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='SCROLL_STATE_DRAGGING']"
		[Register ("SCROLL_STATE_DRAGGING")]
		public const int ScrollStateDragging = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='SCROLL_STATE_IDLE']"
		[Register ("SCROLL_STATE_IDLE")]
		public const int ScrollStateIdle = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/field[@name='SCROLL_STATE_SCROLLING']"
		[Register ("SCROLL_STATE_SCROLLING")]
		public const int ScrollStateScrolling = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnItemSelectedListener']"
		[Register ("com/itheima/wheelpicker/WheelPicker$OnItemSelectedListener", "", "Com.Itheima.Wheelpicker.WheelPicker/IOnItemSelectedListenerInvoker")]
		public partial interface IOnItemSelectedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnItemSelectedListener']/method[@name='onItemSelected' and count(parameter)=3 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='int']]"
			[Register ("onItemSelected", "(Lcom/itheima/wheelpicker/WheelPicker;Ljava/lang/Object;I)V", "GetOnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_IHandler:Com.Itheima.Wheelpicker.WheelPicker/IOnItemSelectedListenerInvoker, Binding_WheelPicker")]
			void OnItemSelected (global::Com.Itheima.Wheelpicker.WheelPicker p0, global::Java.Lang.Object p1, int p2);

		}

		[global::Android.Runtime.Register ("com/itheima/wheelpicker/WheelPicker$OnItemSelectedListener", DoNotGenerateAcw=true)]
		internal class IOnItemSelectedListenerInvoker : global::Java.Lang.Object, IOnItemSelectedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/WheelPicker$OnItemSelectedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnItemSelectedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnItemSelectedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnItemSelectedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.WheelPicker.OnItemSelectedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnItemSelectedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
#pragma warning disable 0169
			static Delegate GetOnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_IHandler ()
			{
				if (cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I == null)
					cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_OnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I);
				return cb_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
			}

			static void n_OnItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Itheima.Wheelpicker.WheelPicker p0 = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnItemSelected (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I;
			public unsafe void OnItemSelected (global::Com.Itheima.Wheelpicker.WheelPicker p0, global::Java.Lang.Object p1, int p2)
			{
				if (id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I == IntPtr.Zero)
					id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "onItemSelected", "(Lcom/itheima/wheelpicker/WheelPicker;Ljava/lang/Object;I)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSelected_Lcom_itheima_wheelpicker_WheelPicker_Ljava_lang_Object_I, __args);
			}

		}

		public partial class ItemSelectedEventArgs : global::System.EventArgs {

			public ItemSelectedEventArgs (global::Com.Itheima.Wheelpicker.WheelPicker p0, global::Java.Lang.Object p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Itheima.Wheelpicker.WheelPicker p0;
			public global::Com.Itheima.Wheelpicker.WheelPicker P0 {
				get { return p0; }
			}

			global::Java.Lang.Object p1;
			public global::Java.Lang.Object P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/itheima/wheelpicker/WheelPicker_OnItemSelectedListenerImplementor")]
		internal sealed partial class IOnItemSelectedListenerImplementor : global::Java.Lang.Object, IOnItemSelectedListener {

			object sender;

			public IOnItemSelectedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/itheima/wheelpicker/WheelPicker_OnItemSelectedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemSelectedEventArgs> Handler;
#pragma warning restore 0649

			public void OnItemSelected (global::Com.Itheima.Wheelpicker.WheelPicker p0, global::Java.Lang.Object p1, int p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ItemSelectedEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnItemSelectedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnWheelChangeListener']"
		[Register ("com/itheima/wheelpicker/WheelPicker$OnWheelChangeListener", "", "Com.Itheima.Wheelpicker.WheelPicker/IOnWheelChangeListenerInvoker")]
		public partial interface IOnWheelChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnWheelChangeListener']/method[@name='onWheelScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onWheelScrollStateChanged", "(I)V", "GetOnWheelScrollStateChanged_IHandler:Com.Itheima.Wheelpicker.WheelPicker/IOnWheelChangeListenerInvoker, Binding_WheelPicker")]
			void OnWheelScrollStateChanged (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnWheelChangeListener']/method[@name='onWheelScrolled' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onWheelScrolled", "(I)V", "GetOnWheelScrolled_IHandler:Com.Itheima.Wheelpicker.WheelPicker/IOnWheelChangeListenerInvoker, Binding_WheelPicker")]
			void OnWheelScrolled (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='WheelPicker.OnWheelChangeListener']/method[@name='onWheelSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onWheelSelected", "(I)V", "GetOnWheelSelected_IHandler:Com.Itheima.Wheelpicker.WheelPicker/IOnWheelChangeListenerInvoker, Binding_WheelPicker")]
			void OnWheelSelected (int p0);

		}

		[global::Android.Runtime.Register ("com/itheima/wheelpicker/WheelPicker$OnWheelChangeListener", DoNotGenerateAcw=true)]
		internal class IOnWheelChangeListenerInvoker : global::Java.Lang.Object, IOnWheelChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/WheelPicker$OnWheelChangeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnWheelChangeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnWheelChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnWheelChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.WheelPicker.OnWheelChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnWheelChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onWheelScrollStateChanged_I;
#pragma warning disable 0169
			static Delegate GetOnWheelScrollStateChanged_IHandler ()
			{
				if (cb_onWheelScrollStateChanged_I == null)
					cb_onWheelScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnWheelScrollStateChanged_I);
				return cb_onWheelScrollStateChanged_I;
			}

			static void n_OnWheelScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWheelScrollStateChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWheelScrollStateChanged_I;
			public unsafe void OnWheelScrollStateChanged (int p0)
			{
				if (id_onWheelScrollStateChanged_I == IntPtr.Zero)
					id_onWheelScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onWheelScrollStateChanged", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWheelScrollStateChanged_I, __args);
			}

			static Delegate cb_onWheelScrolled_I;
#pragma warning disable 0169
			static Delegate GetOnWheelScrolled_IHandler ()
			{
				if (cb_onWheelScrolled_I == null)
					cb_onWheelScrolled_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnWheelScrolled_I);
				return cb_onWheelScrolled_I;
			}

			static void n_OnWheelScrolled_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWheelScrolled (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWheelScrolled_I;
			public unsafe void OnWheelScrolled (int p0)
			{
				if (id_onWheelScrolled_I == IntPtr.Zero)
					id_onWheelScrolled_I = JNIEnv.GetMethodID (class_ref, "onWheelScrolled", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWheelScrolled_I, __args);
			}

			static Delegate cb_onWheelSelected_I;
#pragma warning disable 0169
			static Delegate GetOnWheelSelected_IHandler ()
			{
				if (cb_onWheelSelected_I == null)
					cb_onWheelSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnWheelSelected_I);
				return cb_onWheelSelected_I;
			}

			static void n_OnWheelSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnWheelSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onWheelSelected_I;
			public unsafe void OnWheelSelected (int p0)
			{
				if (id_onWheelSelected_I == IntPtr.Zero)
					id_onWheelSelected_I = JNIEnv.GetMethodID (class_ref, "onWheelSelected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWheelSelected_I, __args);
			}

		}

		public partial class WheelScrollStateChangedEventArgs : global::System.EventArgs {

			public WheelScrollStateChangedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class WheelScrolledEventArgs : global::System.EventArgs {

			public WheelScrolledEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class WheelSelectedEventArgs : global::System.EventArgs {

			public WheelSelectedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/itheima/wheelpicker/WheelPicker_OnWheelChangeListenerImplementor")]
		internal sealed partial class IOnWheelChangeListenerImplementor : global::Java.Lang.Object, IOnWheelChangeListener {

			object sender;

			public IOnWheelChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/itheima/wheelpicker/WheelPicker_OnWheelChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<WheelScrollStateChangedEventArgs> OnWheelScrollStateChangedHandler;
#pragma warning restore 0649

			public void OnWheelScrollStateChanged (int p0)
			{
				var __h = OnWheelScrollStateChangedHandler;
				if (__h != null)
					__h (sender, new WheelScrollStateChangedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<WheelScrolledEventArgs> OnWheelScrolledHandler;
#pragma warning restore 0649

			public void OnWheelScrolled (int p0)
			{
				var __h = OnWheelScrolledHandler;
				if (__h != null)
					__h (sender, new WheelScrolledEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<WheelSelectedEventArgs> OnWheelSelectedHandler;
#pragma warning restore 0649

			public void OnWheelSelected (int p0)
			{
				var __h = OnWheelSelectedHandler;
				if (__h != null)
					__h (sender, new WheelSelectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnWheelChangeListenerImplementor value)
			{
				return value.OnWheelScrollStateChangedHandler == null && value.OnWheelScrolledHandler == null && value.OnWheelSelectedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/itheima/wheelpicker/WheelPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WheelPicker); }
		}

		protected WheelPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/constructor[@name='WheelPicker' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WheelPicker (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WheelPicker)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/constructor[@name='WheelPicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WheelPicker (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (WheelPicker)) {
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

		static Delegate cb_getCurrentItemPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemPositionHandler ()
		{
			if (cb_getCurrentItemPosition == null)
				cb_getCurrentItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentItemPosition);
			return cb_getCurrentItemPosition;
		}

		static int n_GetCurrentItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentItemPosition;
		public virtual unsafe int CurrentItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getCurrentItemPosition' and count(parameter)=0]"
			[Register ("getCurrentItemPosition", "()I", "GetGetCurrentItemPositionHandler")]
			get {
				if (id_getCurrentItemPosition == IntPtr.Zero)
					id_getCurrentItemPosition = JNIEnv.GetMethodID (class_ref, "getCurrentItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentItemPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurtainColor;
#pragma warning disable 0169
		static Delegate GetGetCurtainColorHandler ()
		{
			if (cb_getCurtainColor == null)
				cb_getCurtainColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurtainColor);
			return cb_getCurtainColor;
		}

		static int n_GetCurtainColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurtainColor;
		}
#pragma warning restore 0169

		static Delegate cb_setCurtainColor_I;
#pragma warning disable 0169
		static Delegate GetSetCurtainColor_IHandler ()
		{
			if (cb_setCurtainColor_I == null)
				cb_setCurtainColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurtainColor_I);
			return cb_setCurtainColor_I;
		}

		static void n_SetCurtainColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurtainColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurtainColor;
		static IntPtr id_setCurtainColor_I;
		public virtual unsafe int CurtainColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getCurtainColor' and count(parameter)=0]"
			[Register ("getCurtainColor", "()I", "GetGetCurtainColorHandler")]
			get {
				if (id_getCurtainColor == IntPtr.Zero)
					id_getCurtainColor = JNIEnv.GetMethodID (class_ref, "getCurtainColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurtainColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurtainColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setCurtainColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurtainColor", "(I)V", "GetSetCurtainColor_IHandler")]
			set {
				if (id_setCurtainColor_I == IntPtr.Zero)
					id_setCurtainColor_I = JNIEnv.GetMethodID (class_ref, "setCurtainColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtainColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurtainColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCurved;
#pragma warning disable 0169
		static Delegate GetIsCurvedHandler ()
		{
			if (cb_isCurved == null)
				cb_isCurved = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurved);
			return cb_isCurved;
		}

		static bool n_IsCurved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Curved;
		}
#pragma warning restore 0169

		static Delegate cb_setCurved_Z;
#pragma warning disable 0169
		static Delegate GetSetCurved_ZHandler ()
		{
			if (cb_setCurved_Z == null)
				cb_setCurved_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurved_Z);
			return cb_setCurved_Z;
		}

		static void n_SetCurved_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Curved = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCurved;
		static IntPtr id_setCurved_Z;
		public virtual unsafe bool Curved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='isCurved' and count(parameter)=0]"
			[Register ("isCurved", "()Z", "GetIsCurvedHandler")]
			get {
				if (id_isCurved == IntPtr.Zero)
					id_isCurved = JNIEnv.GetMethodID (class_ref, "isCurved", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurved);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurved", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setCurved' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCurved", "(Z)V", "GetSetCurved_ZHandler")]
			set {
				if (id_setCurved_Z == IntPtr.Zero)
					id_setCurved_Z = JNIEnv.GetMethodID (class_ref, "setCurved", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurved_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurved", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCyclic;
#pragma warning disable 0169
		static Delegate GetIsCyclicHandler ()
		{
			if (cb_isCyclic == null)
				cb_isCyclic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCyclic);
			return cb_isCyclic;
		}

		static bool n_IsCyclic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cyclic;
		}
#pragma warning restore 0169

		static Delegate cb_setCyclic_Z;
#pragma warning disable 0169
		static Delegate GetSetCyclic_ZHandler ()
		{
			if (cb_setCyclic_Z == null)
				cb_setCyclic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCyclic_Z);
			return cb_setCyclic_Z;
		}

		static void n_SetCyclic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cyclic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCyclic;
		static IntPtr id_setCyclic_Z;
		public virtual unsafe bool Cyclic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='isCyclic' and count(parameter)=0]"
			[Register ("isCyclic", "()Z", "GetIsCyclicHandler")]
			get {
				if (id_isCyclic == IntPtr.Zero)
					id_isCyclic = JNIEnv.GetMethodID (class_ref, "isCyclic", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCyclic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCyclic", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCyclic", "(Z)V", "GetSetCyclic_ZHandler")]
			set {
				if (id_setCyclic_Z == IntPtr.Zero)
					id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCyclic_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCyclic", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_util_List_;
		public virtual unsafe global::System.Collections.IList Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/List;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler")]
			set {
				if (id_setData_Ljava_util_List_ == IntPtr.Zero)
					id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hasAtmospheric;
#pragma warning disable 0169
		static Delegate GetHasAtmosphericHandler ()
		{
			if (cb_hasAtmospheric == null)
				cb_hasAtmospheric = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAtmospheric);
			return cb_hasAtmospheric;
		}

		static bool n_HasAtmospheric (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAtmospheric;
		}
#pragma warning restore 0169

		static IntPtr id_hasAtmospheric;
		public virtual unsafe bool HasAtmospheric {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='hasAtmospheric' and count(parameter)=0]"
			[Register ("hasAtmospheric", "()Z", "GetHasAtmosphericHandler")]
			get {
				if (id_hasAtmospheric == IntPtr.Zero)
					id_hasAtmospheric = JNIEnv.GetMethodID (class_ref, "hasAtmospheric", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasAtmospheric);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAtmospheric", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasCurtain;
#pragma warning disable 0169
		static Delegate GetHasCurtainHandler ()
		{
			if (cb_hasCurtain == null)
				cb_hasCurtain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCurtain);
			return cb_hasCurtain;
		}

		static bool n_HasCurtain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCurtain;
		}
#pragma warning restore 0169

		static IntPtr id_hasCurtain;
		public virtual unsafe bool HasCurtain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='hasCurtain' and count(parameter)=0]"
			[Register ("hasCurtain", "()Z", "GetHasCurtainHandler")]
			get {
				if (id_hasCurtain == IntPtr.Zero)
					id_hasCurtain = JNIEnv.GetMethodID (class_ref, "hasCurtain", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCurtain);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCurtain", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasIndicator;
#pragma warning disable 0169
		static Delegate GetHasIndicatorHandler ()
		{
			if (cb_hasIndicator == null)
				cb_hasIndicator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasIndicator);
			return cb_hasIndicator;
		}

		static bool n_HasIndicator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIndicator;
		}
#pragma warning restore 0169

		static IntPtr id_hasIndicator;
		public virtual unsafe bool HasIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='hasIndicator' and count(parameter)=0]"
			[Register ("hasIndicator", "()Z", "GetHasIndicatorHandler")]
			get {
				if (id_hasIndicator == IntPtr.Zero)
					id_hasIndicator = JNIEnv.GetMethodID (class_ref, "hasIndicator", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasIndicator);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasIndicator", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasSameWidth;
#pragma warning disable 0169
		static Delegate GetHasSameWidthHandler ()
		{
			if (cb_hasSameWidth == null)
				cb_hasSameWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSameWidth);
			return cb_hasSameWidth;
		}

		static bool n_HasSameWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSameWidth;
		}
#pragma warning restore 0169

		static IntPtr id_hasSameWidth;
		public virtual unsafe bool HasSameWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='hasSameWidth' and count(parameter)=0]"
			[Register ("hasSameWidth", "()Z", "GetHasSameWidthHandler")]
			get {
				if (id_hasSameWidth == IntPtr.Zero)
					id_hasSameWidth = JNIEnv.GetMethodID (class_ref, "hasSameWidth", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSameWidth);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSameWidth", "()Z"));
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
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorColor;
		static IntPtr id_setIndicatorColor_I;
		public virtual unsafe int IndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getIndicatorColor' and count(parameter)=0]"
			[Register ("getIndicatorColor", "()I", "GetGetIndicatorColorHandler")]
			get {
				if (id_getIndicatorColor == IntPtr.Zero)
					id_getIndicatorColor = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
			set {
				if (id_setIndicatorColor_I == IntPtr.Zero)
					id_setIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIndicatorSize;
#pragma warning disable 0169
		static Delegate GetGetIndicatorSizeHandler ()
		{
			if (cb_getIndicatorSize == null)
				cb_getIndicatorSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndicatorSize);
			return cb_getIndicatorSize;
		}

		static int n_GetIndicatorSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndicatorSize;
		}
#pragma warning restore 0169

		static Delegate cb_setIndicatorSize_I;
#pragma warning disable 0169
		static Delegate GetSetIndicatorSize_IHandler ()
		{
			if (cb_setIndicatorSize_I == null)
				cb_setIndicatorSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIndicatorSize_I);
			return cb_setIndicatorSize_I;
		}

		static void n_SetIndicatorSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIndicatorSize;
		static IntPtr id_setIndicatorSize_I;
		public virtual unsafe int IndicatorSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getIndicatorSize' and count(parameter)=0]"
			[Register ("getIndicatorSize", "()I", "GetGetIndicatorSizeHandler")]
			get {
				if (id_getIndicatorSize == IntPtr.Zero)
					id_getIndicatorSize = JNIEnv.GetMethodID (class_ref, "getIndicatorSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndicatorSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setIndicatorSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorSize", "(I)V", "GetSetIndicatorSize_IHandler")]
			set {
				if (id_setIndicatorSize_I == IntPtr.Zero)
					id_setIndicatorSize_I = JNIEnv.GetMethodID (class_ref, "setIndicatorSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicatorSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemAlign;
#pragma warning disable 0169
		static Delegate GetGetItemAlignHandler ()
		{
			if (cb_getItemAlign == null)
				cb_getItemAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemAlign);
			return cb_getItemAlign;
		}

		static int n_GetItemAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemAlign;
		}
#pragma warning restore 0169

		static Delegate cb_setItemAlign_I;
#pragma warning disable 0169
		static Delegate GetSetItemAlign_IHandler ()
		{
			if (cb_setItemAlign_I == null)
				cb_setItemAlign_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemAlign_I);
			return cb_setItemAlign_I;
		}

		static void n_SetItemAlign_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlign = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemAlign;
		static IntPtr id_setItemAlign_I;
		public virtual unsafe int ItemAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getItemAlign' and count(parameter)=0]"
			[Register ("getItemAlign", "()I", "GetGetItemAlignHandler")]
			get {
				if (id_getItemAlign == IntPtr.Zero)
					id_getItemAlign = JNIEnv.GetMethodID (class_ref, "getItemAlign", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlign);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemAlign", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setItemAlign' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlign", "(I)V", "GetSetItemAlign_IHandler")]
			set {
				if (id_setItemAlign_I == IntPtr.Zero)
					id_setItemAlign_I = JNIEnv.GetMethodID (class_ref, "setItemAlign", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlign_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemAlign", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemSpace;
#pragma warning disable 0169
		static Delegate GetGetItemSpaceHandler ()
		{
			if (cb_getItemSpace == null)
				cb_getItemSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemSpace);
			return cb_getItemSpace;
		}

		static int n_GetItemSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setItemSpace_I;
#pragma warning disable 0169
		static Delegate GetSetItemSpace_IHandler ()
		{
			if (cb_setItemSpace_I == null)
				cb_setItemSpace_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemSpace_I);
			return cb_setItemSpace_I;
		}

		static void n_SetItemSpace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemSpace = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemSpace;
		static IntPtr id_setItemSpace_I;
		public virtual unsafe int ItemSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getItemSpace' and count(parameter)=0]"
			[Register ("getItemSpace", "()I", "GetGetItemSpaceHandler")]
			get {
				if (id_getItemSpace == IntPtr.Zero)
					id_getItemSpace = JNIEnv.GetMethodID (class_ref, "getItemSpace", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemSpace);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemSpace", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setItemSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemSpace", "(I)V", "GetSetItemSpace_IHandler")]
			set {
				if (id_setItemSpace_I == IntPtr.Zero)
					id_setItemSpace_I = JNIEnv.GetMethodID (class_ref, "setItemSpace", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemSpace_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemSpace", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemTextColor;
#pragma warning disable 0169
		static Delegate GetGetItemTextColorHandler ()
		{
			if (cb_getItemTextColor == null)
				cb_getItemTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemTextColor);
			return cb_getItemTextColor;
		}

		static int n_GetItemTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setItemTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetItemTextColor_IHandler ()
		{
			if (cb_setItemTextColor_I == null)
				cb_setItemTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemTextColor_I);
			return cb_setItemTextColor_I;
		}

		static void n_SetItemTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemTextColor;
		static IntPtr id_setItemTextColor_I;
		public virtual unsafe int ItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getItemTextColor' and count(parameter)=0]"
			[Register ("getItemTextColor", "()I", "GetGetItemTextColorHandler")]
			get {
				if (id_getItemTextColor == IntPtr.Zero)
					id_getItemTextColor = JNIEnv.GetMethodID (class_ref, "getItemTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextColor", "(I)V", "GetSetItemTextColor_IHandler")]
			set {
				if (id_setItemTextColor_I == IntPtr.Zero)
					id_setItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setItemTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemTextSize;
#pragma warning disable 0169
		static Delegate GetGetItemTextSizeHandler ()
		{
			if (cb_getItemTextSize == null)
				cb_getItemTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemTextSize);
			return cb_getItemTextSize;
		}

		static int n_GetItemTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setItemTextSize_I;
#pragma warning disable 0169
		static Delegate GetSetItemTextSize_IHandler ()
		{
			if (cb_setItemTextSize_I == null)
				cb_setItemTextSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemTextSize_I);
			return cb_setItemTextSize_I;
		}

		static void n_SetItemTextSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextSize = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getItemTextSize;
		static IntPtr id_setItemTextSize_I;
		public virtual unsafe int ItemTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getItemTextSize' and count(parameter)=0]"
			[Register ("getItemTextSize", "()I", "GetGetItemTextSizeHandler")]
			get {
				if (id_getItemTextSize == IntPtr.Zero)
					id_getItemTextSize = JNIEnv.GetMethodID (class_ref, "getItemTextSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemTextSize", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setItemTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextSize", "(I)V", "GetSetItemTextSize_IHandler")]
			set {
				if (id_setItemTextSize_I == IntPtr.Zero)
					id_setItemTextSize_I = JNIEnv.GetMethodID (class_ref, "setItemTextSize", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextSize_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemTextSize", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumWidthText;
#pragma warning disable 0169
		static Delegate GetGetMaximumWidthTextHandler ()
		{
			if (cb_getMaximumWidthText == null)
				cb_getMaximumWidthText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaximumWidthText);
			return cb_getMaximumWidthText;
		}

		static IntPtr n_GetMaximumWidthText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaximumWidthText);
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumWidthText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMaximumWidthText_Ljava_lang_String_Handler ()
		{
			if (cb_setMaximumWidthText_Ljava_lang_String_ == null)
				cb_setMaximumWidthText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumWidthText_Ljava_lang_String_);
			return cb_setMaximumWidthText_Ljava_lang_String_;
		}

		static void n_SetMaximumWidthText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthText = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumWidthText;
		static IntPtr id_setMaximumWidthText_Ljava_lang_String_;
		public virtual unsafe string MaximumWidthText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getMaximumWidthText' and count(parameter)=0]"
			[Register ("getMaximumWidthText", "()Ljava/lang/String;", "GetGetMaximumWidthTextHandler")]
			get {
				if (id_getMaximumWidthText == IntPtr.Zero)
					id_getMaximumWidthText = JNIEnv.GetMethodID (class_ref, "getMaximumWidthText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumWidthText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setMaximumWidthText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaximumWidthText", "(Ljava/lang/String;)V", "GetSetMaximumWidthText_Ljava_lang_String_Handler")]
			set {
				if (id_setMaximumWidthText_Ljava_lang_String_ == IntPtr.Zero)
					id_setMaximumWidthText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMaximumWidthText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumWidthText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMaximumWidthTextPosition;
#pragma warning disable 0169
		static Delegate GetGetMaximumWidthTextPositionHandler ()
		{
			if (cb_getMaximumWidthTextPosition == null)
				cb_getMaximumWidthTextPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumWidthTextPosition);
			return cb_getMaximumWidthTextPosition;
		}

		static int n_GetMaximumWidthTextPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumWidthTextPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumWidthTextPosition_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumWidthTextPosition_IHandler ()
		{
			if (cb_setMaximumWidthTextPosition_I == null)
				cb_setMaximumWidthTextPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumWidthTextPosition_I);
			return cb_setMaximumWidthTextPosition_I;
		}

		static void n_SetMaximumWidthTextPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthTextPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumWidthTextPosition;
		static IntPtr id_setMaximumWidthTextPosition_I;
		public virtual unsafe int MaximumWidthTextPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getMaximumWidthTextPosition' and count(parameter)=0]"
			[Register ("getMaximumWidthTextPosition", "()I", "GetGetMaximumWidthTextPositionHandler")]
			get {
				if (id_getMaximumWidthTextPosition == IntPtr.Zero)
					id_getMaximumWidthTextPosition = JNIEnv.GetMethodID (class_ref, "getMaximumWidthTextPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthTextPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumWidthTextPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setMaximumWidthTextPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumWidthTextPosition", "(I)V", "GetSetMaximumWidthTextPosition_IHandler")]
			set {
				if (id_setMaximumWidthTextPosition_I == IntPtr.Zero)
					id_setMaximumWidthTextPosition_I = JNIEnv.GetMethodID (class_ref, "setMaximumWidthTextPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthTextPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumWidthTextPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItemPosition;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemPositionHandler ()
		{
			if (cb_getSelectedItemPosition == null)
				cb_getSelectedItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedItemPosition);
			return cb_getSelectedItemPosition;
		}

		static int n_GetSelectedItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedItemPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedItemPosition_IHandler ()
		{
			if (cb_setSelectedItemPosition_I == null)
				cb_setSelectedItemPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedItemPosition_I);
			return cb_setSelectedItemPosition_I;
		}

		static void n_SetSelectedItemPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemPosition;
		static IntPtr id_setSelectedItemPosition_I;
		public virtual unsafe int SelectedItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getSelectedItemPosition' and count(parameter)=0]"
			[Register ("getSelectedItemPosition", "()I", "GetGetSelectedItemPositionHandler")]
			get {
				if (id_getSelectedItemPosition == IntPtr.Zero)
					id_getSelectedItemPosition = JNIEnv.GetMethodID (class_ref, "getSelectedItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setSelectedItemPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemPosition", "(I)V", "GetSetSelectedItemPosition_IHandler")]
			set {
				if (id_setSelectedItemPosition_I == IntPtr.Zero)
					id_setSelectedItemPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedItemPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedItemTextColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedItemTextColorHandler ()
		{
			if (cb_getSelectedItemTextColor == null)
				cb_getSelectedItemTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedItemTextColor);
			return cb_getSelectedItemTextColor;
		}

		static int n_GetSelectedItemTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedItemTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedItemTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedItemTextColor_IHandler ()
		{
			if (cb_setSelectedItemTextColor_I == null)
				cb_setSelectedItemTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedItemTextColor_I);
			return cb_setSelectedItemTextColor_I;
		}

		static void n_SetSelectedItemTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemTextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedItemTextColor;
		static IntPtr id_setSelectedItemTextColor_I;
		public virtual unsafe int SelectedItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getSelectedItemTextColor' and count(parameter)=0]"
			[Register ("getSelectedItemTextColor", "()I", "GetGetSelectedItemTextColorHandler")]
			get {
				if (id_getSelectedItemTextColor == IntPtr.Zero)
					id_getSelectedItemTextColor = JNIEnv.GetMethodID (class_ref, "getSelectedItemTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedItemTextColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setSelectedItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemTextColor", "(I)V", "GetSetSelectedItemTextColor_IHandler")]
			set {
				if (id_setSelectedItemTextColor_I == IntPtr.Zero)
					id_setSelectedItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemTextColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemTextColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedItemTextColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTypeface;
		static IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypeface", "()Landroid/graphics/Typeface;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTypeface", "(Landroid/graphics/Typeface;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisibleItemCount;
#pragma warning disable 0169
		static Delegate GetGetVisibleItemCountHandler ()
		{
			if (cb_getVisibleItemCount == null)
				cb_getVisibleItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVisibleItemCount);
			return cb_getVisibleItemCount;
		}

		static int n_GetVisibleItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VisibleItemCount;
		}
#pragma warning restore 0169

		static Delegate cb_setVisibleItemCount_I;
#pragma warning disable 0169
		static Delegate GetSetVisibleItemCount_IHandler ()
		{
			if (cb_setVisibleItemCount_I == null)
				cb_setVisibleItemCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVisibleItemCount_I);
			return cb_setVisibleItemCount_I;
		}

		static void n_SetVisibleItemCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VisibleItemCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleItemCount;
		static IntPtr id_setVisibleItemCount_I;
		public virtual unsafe int VisibleItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='getVisibleItemCount' and count(parameter)=0]"
			[Register ("getVisibleItemCount", "()I", "GetGetVisibleItemCountHandler")]
			get {
				if (id_getVisibleItemCount == IntPtr.Zero)
					id_getVisibleItemCount = JNIEnv.GetMethodID (class_ref, "getVisibleItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVisibleItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleItemCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setVisibleItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVisibleItemCount", "(I)V", "GetSetVisibleItemCount_IHandler")]
			set {
				if (id_setVisibleItemCount_I == IntPtr.Zero)
					id_setVisibleItemCount_I = JNIEnv.GetMethodID (class_ref, "setVisibleItemCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibleItemCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisibleItemCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAtmospheric_Z;
#pragma warning disable 0169
		static Delegate GetSetAtmospheric_ZHandler ()
		{
			if (cb_setAtmospheric_Z == null)
				cb_setAtmospheric_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAtmospheric_Z);
			return cb_setAtmospheric_Z;
		}

		static void n_SetAtmospheric_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAtmospheric (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAtmospheric_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setAtmospheric' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAtmospheric", "(Z)V", "GetSetAtmospheric_ZHandler")]
		public virtual unsafe void SetAtmospheric (bool p0)
		{
			if (id_setAtmospheric_Z == IntPtr.Zero)
				id_setAtmospheric_Z = JNIEnv.GetMethodID (class_ref, "setAtmospheric", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAtmospheric_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAtmospheric", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCurtain_Z;
#pragma warning disable 0169
		static Delegate GetSetCurtain_ZHandler ()
		{
			if (cb_setCurtain_Z == null)
				cb_setCurtain_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCurtain_Z);
			return cb_setCurtain_Z;
		}

		static void n_SetCurtain_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurtain (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurtain_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setCurtain' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCurtain", "(Z)V", "GetSetCurtain_ZHandler")]
		public virtual unsafe void SetCurtain (bool p0)
		{
			if (id_setCurtain_Z == IntPtr.Zero)
				id_setCurtain_Z = JNIEnv.GetMethodID (class_ref, "setCurtain", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtain_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurtain", "(Z)V"), __args);
			} finally {
			}
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
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
		public virtual unsafe void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetMethodID (class_ref, "setDebug", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDebug_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebug", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIndicator_Z;
#pragma warning disable 0169
		static Delegate GetSetIndicator_ZHandler ()
		{
			if (cb_setIndicator_Z == null)
				cb_setIndicator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIndicator_Z);
			return cb_setIndicator_Z;
		}

		static void n_SetIndicator_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicator (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIndicator_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicator", "(Z)V", "GetSetIndicator_ZHandler")]
		public virtual unsafe void SetIndicator (bool p0)
		{
			if (id_setIndicator_Z == IntPtr.Zero)
				id_setIndicator_Z = JNIEnv.GetMethodID (class_ref, "setIndicator", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicator_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIndicator", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_Handler ()
		{
			if (cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ == null)
				cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_);
			return cb_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
		}

		static void n_SetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemSelectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setOnItemSelectedListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnItemSelectedListener']]"
		[Register ("setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V", "GetSetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_Handler")]
		public virtual unsafe void SetOnItemSelectedListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0)
		{
			if (id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ == IntPtr.Zero)
				id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_Handler ()
		{
			if (cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ == null)
				cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_);
			return cb_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
		}

		static void n_SetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnWheelChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setOnWheelChangeListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnWheelChangeListener']]"
		[Register ("setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V", "GetSetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_Handler")]
		public virtual unsafe void SetOnWheelChangeListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0)
		{
			if (id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ == IntPtr.Zero)
				id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSameWidth_Z;
#pragma warning disable 0169
		static Delegate GetSetSameWidth_ZHandler ()
		{
			if (cb_setSameWidth_Z == null)
				cb_setSameWidth_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSameWidth_Z);
			return cb_setSameWidth_Z;
		}

		static void n_SetSameWidth_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Itheima.Wheelpicker.WheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSameWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSameWidth_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/class[@name='WheelPicker']/method[@name='setSameWidth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSameWidth", "(Z)V", "GetSetSameWidth_ZHandler")]
		public virtual unsafe void SetSameWidth (bool p0)
		{
			if (id_setSameWidth_Z == IntPtr.Zero)
				id_setSameWidth_Z = JNIEnv.GetMethodID (class_ref, "setSameWidth", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSameWidth_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSameWidth", "(Z)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener"
		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.ItemSelectedEventArgs> ItemSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor>(
						ref weak_implementor_SetOnItemSelectedListener,
						__CreateIOnItemSelectedListenerImplementor,
						SetOnItemSelectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor>(
						ref weak_implementor_SetOnItemSelectedListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor.__IsEmpty,
						__v => SetOnItemSelectedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemSelectedListener;

		global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor __CreateIOnItemSelectedListenerImplementor ()
		{
			return new global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener"
		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelScrollStateChangedEventArgs> WheelScrollStateChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelScrollStateChangedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelScrollStateChangedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelScrolledEventArgs> WheelScrolled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelScrolledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelScrolledHandler -= value);
			}
		}

		public event EventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.WheelSelectedEventArgs> WheelSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						__CreateIOnWheelChangeListenerImplementor,
						SetOnWheelChangeListener,
						__h => __h.OnWheelSelectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener, global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor>(
						ref weak_implementor_SetOnWheelChangeListener,
						global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor.__IsEmpty,
						__v => SetOnWheelChangeListener (null),
						__h => __h.OnWheelSelectedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnWheelChangeListener;

		global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor __CreateIOnWheelChangeListenerImplementor ()
		{
			return new global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListenerImplementor (this);
		}
#endregion
	}
}
