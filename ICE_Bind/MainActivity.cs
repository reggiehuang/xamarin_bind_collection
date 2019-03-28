using Android.App;
using Android.Widget;
using Android.OS;

namespace ICE_Bind
{
    [Activity(Label = "ICE_Bind", MainLauncher = true)]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
        }

        //private void VerCodeView_CodeFinish(object sender, VerificationCodeView.CodeFinishEventArgs e)
        //{
        //    Toast.MakeText(this, "验证码已发送", ToastLength.Short).Show();
        //}
    }
}

