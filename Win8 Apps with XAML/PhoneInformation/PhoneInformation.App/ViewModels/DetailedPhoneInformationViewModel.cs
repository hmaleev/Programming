using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.HttpRequester;
using PhoneInformation.App.Models;

namespace PhoneInformation.App.ViewModels
{
    class DetailedPhoneInformationViewModel : ViewModelBase
    {
        private DetailedPhoneInformationModel detailedInfo;
        private string url = "motorola_moto_x-5601.php";

        //public DetailedPhoneInformationViewModel(string str)
        //{
        //    this.url = str;
        //    this.url="motorola_moto_x-5601.php"

        //}

        public DetailedPhoneInformationViewModel()
        {
        }

        public DetailedPhoneInformationModel DetailedInfo
        {
            get
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new DetailedPhoneInformationModel();
                    this.GetData(url);

                }
                return this.detailedInfo;
            }
            set
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new DetailedPhoneInformationModel();
                }
                this.detailedInfo = value;
                this.OnPropertyChanged(detailedInfo.GPS);
                //this.SetObservableValues(this.detailedInfo, value);
            }
        }

        protected async void GetData( string str)
        {
            this.DetailedInfo =
                await HttpRequest.Get<DetailedPhoneInformationModel>("http://localhost:63847/api/PhoneDetails?phoneUrl="+str);
            // var sim = DetailedInfo.ToArray();
            var s = this.DetailedInfo;
        }
    }
}
