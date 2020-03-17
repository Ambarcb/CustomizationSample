using System;
using Xamarin.Forms;
using Customization.Droid.Effects;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Customization")]
[assembly: ExportEffect(typeof(AndroidFocusEffect), "FocusEffect")]

namespace Customization.Droid.Effects
{
    public class AndroidFocusEffect : PlatformEffect
    {
        Android.Graphics.Color originalBackgroundColor = new Android.Graphics.Color(120, 20, 40, 60);
        Android.Graphics.Color backgroundColor = new Android.Graphics.Color(255, 52, 152, 219);

        protected override void OnAttached()
        {

            backgroundColor = Android.Graphics.Color.PowderBlue;
            Control.SetBackgroundColor(backgroundColor);
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
           
                if (args.PropertyName == "IsFocused")
                {
                    if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    {
                        Control.SetBackgroundColor(originalBackgroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(backgroundColor);
                    }
                }
           
        }
    }
}