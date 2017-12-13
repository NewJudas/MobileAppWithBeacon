using CoreLocation;
using Foundation;
using MobilTest.Views;
using UIKit;
using Xamarin.Forms;

namespace MobilTest
{
    public partial class App : Application
    {
        int id = 123;
        NSUuid uuid= new NSUuid("6B84B4693909444DAE3B4B77B7AE584D");
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());


        }

        protected override void OnStart()
        {
            Test();
            if (id != 123)
            {
                MainPage = new NavigationPage(new RegStudentPage());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }
        
        protected override void OnSleep()
        {
            // Handle when your app sleeps
            id = 321;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            OnStart();
        }
        
        public void Test()
        {
            

            var beaconRegion = new CLBeaconRegion(uuid,"Identifyer");
            beaconRegion.NotifyEntryStateOnDisplay = true;

            var locationMrg = new CLLocationManager();

            locationMrg.RegionEntered += (object sender, CLRegionEventArgs e) =>
            {
                if(e.Region.Identifier == "Identifyer")
                {
                    MainPage = new NavigationPage(new Page1());
                }

            };
        }
    }
}
