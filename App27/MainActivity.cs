using Android.App;
using Android.Widget;
using Android.OS;

namespace App27
{
    [Activity(Label = "App27", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button mbt;
        bool isClick;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mbt = FindViewById<Button>(Resource.Id.bt);
            mbt.Click += Mbt_Click;
        }

        private void Mbt_Click(object sender, System.EventArgs e)
        {
            if (isClick)
            {
                mbt.SetBackgroundResource(Resource.Drawable.heart);
                isClick = false;
            }else {
                mbt.SetBackgroundResource(Resource.Drawable.heart_press);
                isClick = true;
            }
        }
    }
}

