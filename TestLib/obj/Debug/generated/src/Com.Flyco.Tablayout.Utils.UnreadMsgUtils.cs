using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Flyco.Tablayout.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']"
	[global::Android.Runtime.Register ("com/flyco/tablayout/utils/UnreadMsgUtils", DoNotGenerateAcw=true)]
	public partial class UnreadMsgUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/flyco/tablayout/utils/UnreadMsgUtils", typeof (UnreadMsgUtils));
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

		protected UnreadMsgUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/constructor[@name='UnreadMsgUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnreadMsgUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/method[@name='setSize' and count(parameter)=2 and parameter[1][@type='com.flyco.tablayout.widget.MsgView'] and parameter[2][@type='int']]"
		[Register ("setSize", "(Lcom/flyco/tablayout/widget/MsgView;I)V", "")]
		public static unsafe void SetSize (global::Com.Flyco.Tablayout.Widget.MsgView p0, int p1)
		{
			const string __id = "setSize.(Lcom/flyco/tablayout/widget/MsgView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flyco.tablayout.utils']/class[@name='UnreadMsgUtils']/method[@name='show' and count(parameter)=2 and parameter[1][@type='com.flyco.tablayout.widget.MsgView'] and parameter[2][@type='int']]"
		[Register ("show", "(Lcom/flyco/tablayout/widget/MsgView;I)V", "")]
		public static unsafe void Show (global::Com.Flyco.Tablayout.Widget.MsgView p0, int p1)
		{
			const string __id = "show.(Lcom/flyco/tablayout/widget/MsgView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
