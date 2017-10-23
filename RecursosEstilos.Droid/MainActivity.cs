using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace RecursosEstilos.Droid
{
    [Activity(Label = "RecursosEstilos.Droid", MainLauncher = true)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this,bundle);
            LoadApplication(new Core.App());
        }
    }
}

