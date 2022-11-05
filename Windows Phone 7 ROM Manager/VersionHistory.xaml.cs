using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Windows_Phone_7_ROM_Manager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VersionHistory : Page
    {
        public VersionHistory()
        {
            this.InitializeComponent();

            PopulateVersions();
        }
        private void PopulateVersions()
        {
            List<Versions> VersionList = new List<Versions>();

            Versions newVersion = new Versions();
            newVersion.Name = "RTM Updates";
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.0.7004 (RTM), Release Date: 10/29/2010" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.0.7008, Release Date: End of 2010" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.0.7390, Release Date: 4/22/2011" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.0.7392, Release Date: Mid 2011" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.0.7403, Release Date: Late 2011" });
            VersionList.Add(newVersion);

            newVersion = new Versions();
            newVersion.Name = "Mango Updates";
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.7720 (Mango RTM), Release Date: 9/27/2011" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.7740, Release Date: Late 2011" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8107 (Refresh), Release Date: Late 2011" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8112, Release Date: Early 2012" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8773.98 (Tango), Release Date: June 28, 2012" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8779.8, Release Date: Mid 2012" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8783.12, Release Date: Late 2012" });
            VersionList.Add(newVersion);

            newVersion = new Versions();
            newVersion.Name = "WP 7.8 Updates";
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8858.136 (7.8 RTM), Release Date: 2/1/2013" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8860.142, Release Date: 3/14/2013" });
            newVersion.VersionCollection.Add(new VersionPropSet()
            { Name = "7.10.8862.144, Release Date: 3/14/2013" });
            VersionList.Add(newVersion);

            osVersions.Source = VersionList;
        }
    }

    public class Versions
    {
        public Versions()
        {
            VersionCollection = new ObservableCollection<VersionPropSet>();
        }

        public string Name { get; set; }
        public ObservableCollection<VersionPropSet> VersionCollection { get; private set; }
    }

    public class VersionPropSet
    {
        public string Name { get; set; }
    }
}
