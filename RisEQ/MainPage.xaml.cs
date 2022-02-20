using RisEQ.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RisEQ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<SliderClass> Sliders = new ObservableCollection<SliderClass>();
        public MainPage()
        {
            this.InitializeComponent();
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            Sliders.Add(new SliderClass { Value = 12 });
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            SlidersList.ItemsSource = Sliders;
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            // Hide default title bar.
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            // Set XAML element as a draggable region.
            Window.Current.SetTitleBar(AppTitleBar);
        }

        private void BothChan_Checked(object sender, RoutedEventArgs e)
        {
            LChan.IsEnabled = false;
            RChan.IsEnabled = false;
        }

        private void LChan_Checked(object sender, RoutedEventArgs e)
        {
            
            RChan.IsChecked = false;
            BothChan.IsEnabled = false;
        }

        private void RChan_Checked(object sender, RoutedEventArgs e)
        {
            
            LChan.IsChecked = false;
            BothChan.IsEnabled = false;
        }

        private void BothChan_Unchecked(object sender, RoutedEventArgs e)
        {
            LChan.IsEnabled = true;
            RChan.IsEnabled = true;
        }

        private void LChan_Unchecked(object sender, RoutedEventArgs e)
        {
            BothChan.IsEnabled = true;
        }

        private void RChan_Unchecked(object sender, RoutedEventArgs e)
        {
            BothChan.IsEnabled = true;
        }
    }
}
