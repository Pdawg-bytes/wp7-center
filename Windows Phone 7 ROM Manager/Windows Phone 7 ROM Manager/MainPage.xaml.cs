using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Windows_Phone_7_ROM_Manager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void mainshellnav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                contentFrame.Navigate(typeof(Settings));
                mainshellnav.Header = "Settings";
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "HomePage":
                    default:
                        contentFrame.Navigate(typeof(HomePage));
                        mainshellnav.Header = "Home";
                        break;
                    case "RomMan":
                        contentFrame.Navigate(typeof(RomMan));
                        mainshellnav.Header = "ROM Manager";
                        break;
                    case "Rooting":
                        contentFrame.Navigate(typeof(Rooting));
                        mainshellnav.Header = "Rooting";
                        break;
                    case "UnlockedROMs":
                        contentFrame.Navigate(typeof(UnlockedROMs));
                        mainshellnav.Header = "Unlocked ROMs";
                        break;
                    case "Resources":
                        contentFrame.Navigate(typeof(Resources));
                        mainshellnav.Header = "Resources";
                        break;
                    case "OSArch":
                        contentFrame.Navigate(typeof(OSArch));
                        mainshellnav.Header = "OS Architecture";
                        break;
                    case "VersionHistory":
                        contentFrame.Navigate(typeof(VersionHistory));
                        mainshellnav.Header = "Version History";
                        break;
                }
            }
        }

        private void mainshellnav_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(HomePage));
        }
    }
}
