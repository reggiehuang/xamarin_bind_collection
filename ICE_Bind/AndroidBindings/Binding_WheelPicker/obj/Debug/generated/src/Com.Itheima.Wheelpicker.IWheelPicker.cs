using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Itheima.Wheelpicker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']"
	[Register ("com/itheima/wheelpicker/IWheelPicker", "", "Com.Itheima.Wheelpicker.IWheelPickerInvoker")]
	public partial interface IWheelPicker : IJavaObject {

		int CurrentItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getCurrentItemPosition' and count(parameter)=0]"
			[Register ("getCurrentItemPosition", "()I", "GetGetCurrentItemPositionHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
		}

		int CurtainColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getCurtainColor' and count(parameter)=0]"
			[Register ("getCurtainColor", "()I", "GetGetCurtainColorHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setCurtainColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurtainColor", "(I)V", "GetSetCurtainColor_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		bool Curved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='isCurved' and count(parameter)=0]"
			[Register ("isCurved", "()Z", "GetIsCurvedHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setCurved' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCurved", "(Z)V", "GetSetCurved_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		bool Cyclic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='isCyclic' and count(parameter)=0]"
			[Register ("isCyclic", "()Z", "GetIsCyclicHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCyclic", "(Z)V", "GetSetCyclic_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		global::System.Collections.IList Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/List;", "GetGetDataHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		bool HasAtmospheric {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='hasAtmospheric' and count(parameter)=0]"
			[Register ("hasAtmospheric", "()Z", "GetHasAtmosphericHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
		}

		bool HasCurtain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='hasCurtain' and count(parameter)=0]"
			[Register ("hasCurtain", "()Z", "GetHasCurtainHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
		}

		bool HasIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='hasIndicator' and count(parameter)=0]"
			[Register ("hasIndicator", "()Z", "GetHasIndicatorHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
		}

		bool HasSameWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='hasSameWidth' and count(parameter)=0]"
			[Register ("hasSameWidth", "()Z", "GetHasSameWidthHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
		}

		int IndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getIndicatorColor' and count(parameter)=0]"
			[Register ("getIndicatorColor", "()I", "GetGetIndicatorColorHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setIndicatorColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int IndicatorSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getIndicatorSize' and count(parameter)=0]"
			[Register ("getIndicatorSize", "()I", "GetGetIndicatorSizeHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setIndicatorSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndicatorSize", "(I)V", "GetSetIndicatorSize_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getItemAlign' and count(parameter)=0]"
			[Register ("getItemAlign", "()I", "GetGetItemAlignHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setItemAlign' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemAlign", "(I)V", "GetSetItemAlign_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getItemSpace' and count(parameter)=0]"
			[Register ("getItemSpace", "()I", "GetGetItemSpaceHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setItemSpace' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemSpace", "(I)V", "GetSetItemSpace_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getItemTextColor' and count(parameter)=0]"
			[Register ("getItemTextColor", "()I", "GetGetItemTextColorHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextColor", "(I)V", "GetSetItemTextColor_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int ItemTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getItemTextSize' and count(parameter)=0]"
			[Register ("getItemTextSize", "()I", "GetGetItemTextSizeHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setItemTextSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemTextSize", "(I)V", "GetSetItemTextSize_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		string MaximumWidthText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getMaximumWidthText' and count(parameter)=0]"
			[Register ("getMaximumWidthText", "()Ljava/lang/String;", "GetGetMaximumWidthTextHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setMaximumWidthText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMaximumWidthText", "(Ljava/lang/String;)V", "GetSetMaximumWidthText_Ljava_lang_String_Handler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int MaximumWidthTextPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getMaximumWidthTextPosition' and count(parameter)=0]"
			[Register ("getMaximumWidthTextPosition", "()I", "GetGetMaximumWidthTextPositionHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setMaximumWidthTextPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumWidthTextPosition", "(I)V", "GetSetMaximumWidthTextPosition_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int SelectedItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getSelectedItemPosition' and count(parameter)=0]"
			[Register ("getSelectedItemPosition", "()I", "GetGetSelectedItemPositionHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setSelectedItemPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemPosition", "(I)V", "GetSetSelectedItemPosition_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int SelectedItemTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getSelectedItemTextColor' and count(parameter)=0]"
			[Register ("getSelectedItemTextColor", "()I", "GetGetSelectedItemTextColorHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setSelectedItemTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemTextColor", "(I)V", "GetSetSelectedItemTextColor_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		int VisibleItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='getVisibleItemCount' and count(parameter)=0]"
			[Register ("getVisibleItemCount", "()I", "GetGetVisibleItemCountHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setVisibleItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVisibleItemCount", "(I)V", "GetSetVisibleItemCount_IHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setAtmospheric' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAtmospheric", "(Z)V", "GetSetAtmospheric_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetAtmospheric (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setCurtain' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCurtain", "(Z)V", "GetSetCurtain_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetCurtain (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndicator", "(Z)V", "GetSetIndicator_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetIndicator (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setOnItemSelectedListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnItemSelectedListener']]"
		[Register ("setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V", "GetSetOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_Handler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetOnItemSelectedListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setOnWheelChangeListener' and count(parameter)=1 and parameter[1][@type='com.itheima.wheelpicker.WheelPicker.OnWheelChangeListener']]"
		[Register ("setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V", "GetSetOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_Handler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetOnWheelChangeListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.itheima.wheelpicker']/interface[@name='IWheelPicker']/method[@name='setSameWidth' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSameWidth", "(Z)V", "GetSetSameWidth_ZHandler:Com.Itheima.Wheelpicker.IWheelPickerInvoker, Binding_WheelPicker")]
		void SetSameWidth (bool p0);

	}

	[global::Android.Runtime.Register ("com/itheima/wheelpicker/IWheelPicker", DoNotGenerateAcw=true)]
	internal class IWheelPickerInvoker : global::Java.Lang.Object, IWheelPicker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/itheima/wheelpicker/IWheelPicker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWheelPickerInvoker); }
		}

		IntPtr class_ref;

		public static IWheelPicker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWheelPicker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.itheima.wheelpicker.IWheelPicker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWheelPickerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItemPosition;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentItemPosition;
		public unsafe int CurrentItemPosition {
			get {
				if (id_getCurrentItemPosition == IntPtr.Zero)
					id_getCurrentItemPosition = JNIEnv.GetMethodID (class_ref, "getCurrentItemPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentItemPosition);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurtainColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getCurtainColor;
		IntPtr id_setCurtainColor_I;
		public unsafe int CurtainColor {
			get {
				if (id_getCurtainColor == IntPtr.Zero)
					id_getCurtainColor = JNIEnv.GetMethodID (class_ref, "getCurtainColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurtainColor);
			}
			set {
				if (id_setCurtainColor_I == IntPtr.Zero)
					id_setCurtainColor_I = JNIEnv.GetMethodID (class_ref, "setCurtainColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtainColor_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Curved = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCurved;
		IntPtr id_setCurved_Z;
		public unsafe bool Curved {
			get {
				if (id_isCurved == IntPtr.Zero)
					id_isCurved = JNIEnv.GetMethodID (class_ref, "isCurved", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurved);
			}
			set {
				if (id_setCurved_Z == IntPtr.Zero)
					id_setCurved_Z = JNIEnv.GetMethodID (class_ref, "setCurved", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurved_Z, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cyclic = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCyclic;
		IntPtr id_setCyclic_Z;
		public unsafe bool Cyclic {
			get {
				if (id_isCyclic == IntPtr.Zero)
					id_isCyclic = JNIEnv.GetMethodID (class_ref, "isCyclic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCyclic);
			}
			set {
				if (id_setCyclic_Z == IntPtr.Zero)
					id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCyclic_Z, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		IntPtr id_getData;
		IntPtr id_setData_Ljava_util_List_;
		public unsafe global::System.Collections.IList Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setData_Ljava_util_List_ == IntPtr.Zero)
					id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAtmospheric;
		}
#pragma warning restore 0169

		IntPtr id_hasAtmospheric;
		public unsafe bool HasAtmospheric {
			get {
				if (id_hasAtmospheric == IntPtr.Zero)
					id_hasAtmospheric = JNIEnv.GetMethodID (class_ref, "hasAtmospheric", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasAtmospheric);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCurtain;
		}
#pragma warning restore 0169

		IntPtr id_hasCurtain;
		public unsafe bool HasCurtain {
			get {
				if (id_hasCurtain == IntPtr.Zero)
					id_hasCurtain = JNIEnv.GetMethodID (class_ref, "hasCurtain", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCurtain);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIndicator;
		}
#pragma warning restore 0169

		IntPtr id_hasIndicator;
		public unsafe bool HasIndicator {
			get {
				if (id_hasIndicator == IntPtr.Zero)
					id_hasIndicator = JNIEnv.GetMethodID (class_ref, "hasIndicator", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasIndicator);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSameWidth;
		}
#pragma warning restore 0169

		IntPtr id_hasSameWidth;
		public unsafe bool HasSameWidth {
			get {
				if (id_hasSameWidth == IntPtr.Zero)
					id_hasSameWidth = JNIEnv.GetMethodID (class_ref, "hasSameWidth", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSameWidth);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIndicatorColor;
		IntPtr id_setIndicatorColor_I;
		public unsafe int IndicatorColor {
			get {
				if (id_getIndicatorColor == IntPtr.Zero)
					id_getIndicatorColor = JNIEnv.GetMethodID (class_ref, "getIndicatorColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorColor);
			}
			set {
				if (id_setIndicatorColor_I == IntPtr.Zero)
					id_setIndicatorColor_I = JNIEnv.GetMethodID (class_ref, "setIndicatorColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorColor_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IndicatorSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIndicatorSize;
		IntPtr id_setIndicatorSize_I;
		public unsafe int IndicatorSize {
			get {
				if (id_getIndicatorSize == IntPtr.Zero)
					id_getIndicatorSize = JNIEnv.GetMethodID (class_ref, "getIndicatorSize", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndicatorSize);
			}
			set {
				if (id_setIndicatorSize_I == IntPtr.Zero)
					id_setIndicatorSize_I = JNIEnv.GetMethodID (class_ref, "setIndicatorSize", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicatorSize_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemAlign = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemAlign;
		IntPtr id_setItemAlign_I;
		public unsafe int ItemAlign {
			get {
				if (id_getItemAlign == IntPtr.Zero)
					id_getItemAlign = JNIEnv.GetMethodID (class_ref, "getItemAlign", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemAlign);
			}
			set {
				if (id_setItemAlign_I == IntPtr.Zero)
					id_setItemAlign_I = JNIEnv.GetMethodID (class_ref, "setItemAlign", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemAlign_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemSpace = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemSpace;
		IntPtr id_setItemSpace_I;
		public unsafe int ItemSpace {
			get {
				if (id_getItemSpace == IntPtr.Zero)
					id_getItemSpace = JNIEnv.GetMethodID (class_ref, "getItemSpace", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemSpace);
			}
			set {
				if (id_setItemSpace_I == IntPtr.Zero)
					id_setItemSpace_I = JNIEnv.GetMethodID (class_ref, "setItemSpace", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemSpace_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemTextColor;
		IntPtr id_setItemTextColor_I;
		public unsafe int ItemTextColor {
			get {
				if (id_getItemTextColor == IntPtr.Zero)
					id_getItemTextColor = JNIEnv.GetMethodID (class_ref, "getItemTextColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextColor);
			}
			set {
				if (id_setItemTextColor_I == IntPtr.Zero)
					id_setItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setItemTextColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextColor_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemTextSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getItemTextSize;
		IntPtr id_setItemTextSize_I;
		public unsafe int ItemTextSize {
			get {
				if (id_getItemTextSize == IntPtr.Zero)
					id_getItemTextSize = JNIEnv.GetMethodID (class_ref, "getItemTextSize", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemTextSize);
			}
			set {
				if (id_setItemTextSize_I == IntPtr.Zero)
					id_setItemTextSize_I = JNIEnv.GetMethodID (class_ref, "setItemTextSize", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemTextSize_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthText = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMaximumWidthText;
		IntPtr id_setMaximumWidthText_Ljava_lang_String_;
		public unsafe string MaximumWidthText {
			get {
				if (id_getMaximumWidthText == IntPtr.Zero)
					id_getMaximumWidthText = JNIEnv.GetMethodID (class_ref, "getMaximumWidthText", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthText), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMaximumWidthText_Ljava_lang_String_ == IntPtr.Zero)
					id_setMaximumWidthText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMaximumWidthText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthText_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumWidthTextPosition = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMaximumWidthTextPosition;
		IntPtr id_setMaximumWidthTextPosition_I;
		public unsafe int MaximumWidthTextPosition {
			get {
				if (id_getMaximumWidthTextPosition == IntPtr.Zero)
					id_getMaximumWidthTextPosition = JNIEnv.GetMethodID (class_ref, "getMaximumWidthTextPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumWidthTextPosition);
			}
			set {
				if (id_setMaximumWidthTextPosition_I == IntPtr.Zero)
					id_setMaximumWidthTextPosition_I = JNIEnv.GetMethodID (class_ref, "setMaximumWidthTextPosition", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumWidthTextPosition_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemPosition = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedItemPosition;
		IntPtr id_setSelectedItemPosition_I;
		public unsafe int SelectedItemPosition {
			get {
				if (id_getSelectedItemPosition == IntPtr.Zero)
					id_getSelectedItemPosition = JNIEnv.GetMethodID (class_ref, "getSelectedItemPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemPosition);
			}
			set {
				if (id_setSelectedItemPosition_I == IntPtr.Zero)
					id_setSelectedItemPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemPosition", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemPosition_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedItemTextColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSelectedItemTextColor;
		IntPtr id_setSelectedItemTextColor_I;
		public unsafe int SelectedItemTextColor {
			get {
				if (id_getSelectedItemTextColor == IntPtr.Zero)
					id_getSelectedItemTextColor = JNIEnv.GetMethodID (class_ref, "getSelectedItemTextColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedItemTextColor);
			}
			set {
				if (id_setSelectedItemTextColor_I == IntPtr.Zero)
					id_setSelectedItemTextColor_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemTextColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemTextColor_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTypeface;
		IntPtr id_setTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Android.Graphics.Typeface Typeface {
			get {
				if (id_getTypeface == IntPtr.Zero)
					id_getTypeface = JNIEnv.GetMethodID (class_ref, "getTypeface", "()Landroid/graphics/Typeface;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeface), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setTypeface", "(Landroid/graphics/Typeface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTypeface_Landroid_graphics_Typeface_, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VisibleItemCount = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVisibleItemCount;
		IntPtr id_setVisibleItemCount_I;
		public unsafe int VisibleItemCount {
			get {
				if (id_getVisibleItemCount == IntPtr.Zero)
					id_getVisibleItemCount = JNIEnv.GetMethodID (class_ref, "getVisibleItemCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVisibleItemCount);
			}
			set {
				if (id_setVisibleItemCount_I == IntPtr.Zero)
					id_setVisibleItemCount_I = JNIEnv.GetMethodID (class_ref, "setVisibleItemCount", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibleItemCount_I, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAtmospheric (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAtmospheric_Z;
		public unsafe void SetAtmospheric (bool p0)
		{
			if (id_setAtmospheric_Z == IntPtr.Zero)
				id_setAtmospheric_Z = JNIEnv.GetMethodID (class_ref, "setAtmospheric", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAtmospheric_Z, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurtain (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCurtain_Z;
		public unsafe void SetCurtain (bool p0)
		{
			if (id_setCurtain_Z == IntPtr.Zero)
				id_setCurtain_Z = JNIEnv.GetMethodID (class_ref, "setCurtain", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurtain_Z, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIndicator (p0);
		}
#pragma warning restore 0169

		IntPtr id_setIndicator_Z;
		public unsafe void SetIndicator (bool p0)
		{
			if (id_setIndicator_Z == IntPtr.Zero)
				id_setIndicator_Z = JNIEnv.GetMethodID (class_ref, "setIndicator", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndicator_Z, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemSelectedListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_;
		public unsafe void SetOnItemSelectedListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnItemSelectedListener p0)
		{
			if (id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ == IntPtr.Zero)
				id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnItemSelectedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemSelectedListener_Lcom_itheima_wheelpicker_WheelPicker_OnItemSelectedListener_, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0 = (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener)global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnWheelChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_;
		public unsafe void SetOnWheelChangeListener (global::Com.Itheima.Wheelpicker.WheelPicker.IOnWheelChangeListener p0)
		{
			if (id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ == IntPtr.Zero)
				id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnWheelChangeListener", "(Lcom/itheima/wheelpicker/WheelPicker$OnWheelChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnWheelChangeListener_Lcom_itheima_wheelpicker_WheelPicker_OnWheelChangeListener_, __args);
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
			global::Com.Itheima.Wheelpicker.IWheelPicker __this = global::Java.Lang.Object.GetObject<global::Com.Itheima.Wheelpicker.IWheelPicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSameWidth (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSameWidth_Z;
		public unsafe void SetSameWidth (bool p0)
		{
			if (id_setSameWidth_Z == IntPtr.Zero)
				id_setSameWidth_Z = JNIEnv.GetMethodID (class_ref, "setSameWidth", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSameWidth_Z, __args);
		}

	}

}
