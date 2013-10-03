using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneInformation.App.Models
{
    public class DetailedPhoneInformationModel
    {
        public DetailedPhoneInformationModel()
        {
        }

        private string gps;

        public string ImageUrl { get; set; }
        public string PhoneName { get; set; }

        //I General
        public string SecondGenNetwork { get; set; }
        public string ThirdGenNetwork { get; set; }
        public string FourthGenNetwork { get; set; }
        public string Sim { get; set; }
        public string Announced { get; set; }
        public string Status { get; set; }

        //II Body
        public string Dimensions { get; set; }
        public string Weight { get; set; }

        //III Screen
        public string DisplayType { get; set; }
        public string Size { get; set; }
        public string Protection { get; set; }
        public string Multitouch { get; set; }

        //IV Sound
        public string AlertTypes { get; set; }
        public string Loudspeaker { get; set; }
        public string AudioJack { get; set; }
        public string OtherSoundFeatures { get; set; }

        //V Memory
        public string CardSlot { get; set; }
        public string Internal { get; set; }

        //VI Data
        public string GPRS { get; set; }
        public string EDGE { get; set; }
        public string Speed { get; set; }
        public string WLAN { get; set; }
        public string Bluetooth { get; set; }
        public string NFC { get; set; }
        public string USB { get; set; }

        //VII Camera
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public string Video { get; set; }
        public string CameraFeatures { get; set; }

        //VIII Features
        public string OS { get; set; }
        public string Chipset { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string Sensors { get; set; }
        public string Messaging { get; set; }
        public string Browser { get; set; }
        public string Radio { get; set; }
        public string GPS
        {
            get
            {
                return this.gps;
            }
            set
            {
                this.gps = value;
            }
        }
        public string Java { get; set; }
        public string Colors { get; set; }
        public string OtherFeatures { get; set; }

        //IX Battery 
        public string BatteryType { get; set; }
        public string StandbyTime { get; set; }
        public string TalkTime { get; set; }
        public string MusicPlayTime { get; set; }


    }
}
