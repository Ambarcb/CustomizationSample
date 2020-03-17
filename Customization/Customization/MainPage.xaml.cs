using Customization.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Customization
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
            orientationLabel.Text = Convert.ToString($"My device orientation is {orientation}");
        }
    }
}
