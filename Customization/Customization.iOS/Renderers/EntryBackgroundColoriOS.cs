using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customization.Controls;
using Customization.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(EntryBackgroundColor), typeof(EntryBackgroundColoriOS))]
namespace Customization.iOS.Renderers
{
   public class EntryBackgroundColoriOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.DarkGray;

            }
        }
    }
}