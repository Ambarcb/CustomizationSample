using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customization.iOS.Services;
using Customization.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceOrientationServiceiOS))]
namespace Customization.iOS.Services
{
   public class DeviceOrientationServiceiOS : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}