using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRenderer;
using CustomRenderer.Android;
using Android.Content;
using Customization.Controls;


[assembly: ExportRenderer(typeof(EntryBackgroundColor), typeof(EntryBackgroundColorAndroid))]
namespace CustomRenderer.Android
{
    public class EntryBackgroundColorAndroid : EntryRenderer
    {
        public EntryBackgroundColorAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.SeaGreen);

            }
        }
    }
}
