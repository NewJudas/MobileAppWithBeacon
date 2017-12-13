using CoreLocation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilTest
{
    public class TestDelux
    {

        static NSUuid uuid = new NSUuid("A1F30FF0-0A9F-4DE0-90DA-95F88164942E");
        static string beaconId = "iOSBeacon";
        static CLBeaconRegion beaconRegion = new CLBeaconRegion(uuid, beaconId)
        {
            NotifyEntryStateOnDisplay = true,
            NotifyOnEntry = true,
            NotifyOnExit = true
        };

        NSMutableDictionary peripheralData = beaconRegion.GetPeripheralData(new NSNumber(-59));

        peripheralDelegate = new BTPeripheralDelegate();
        peripheralMgr = new CBPeripheralManager(peripheralDelegate, DispatchQueue.DefaultGlobalQueue);
        peripheralMgr.StartAdvertising(peripheralData);

        public void OnIBeaconServiceConnect()
        {
            beaconMgr.SetMonitorNotifier(monitorNotifier);
            beaconMgr.SetRangeNotifier(rangeNotifier);

            beaconMgr.StartMonitoringBeaconsInRegion(monitoringRegion);
            beaconMgr.StartRangingBeaconsInRegion(rangingRegion);
        }


        void EnteredRegion(object sender, MonitorEventArgs e)
        {
            ShowMessage("Welcome back!");
        }

        void ExitedRegion(object sender, MonitorEventArgs e)
        {
            ShowMessage("Thanks for shopping here!");
        }

        void RangingBeaconsInRegion(object sender, RangeEventArgs e)
        {
            if (e.Beacons.Count > 0)
            {
                var beacon = e.Beacons.FirstOrDefault();

                switch ((ProximityType)beacon.Proximity)
                {
                    case ProximityType.Immediate:
                    case ProximityType.Near:
                    case ProximityType.Far:
                        ShowMessage("Here's a coupon!", true);
                        break;
                    case ProximityType.Unknown:
                        ShowMessage("Beacon proximity unknown");
                        break;
                }
            }
        }
    }
}
