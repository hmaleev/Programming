using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using PhoneInformation.App.HttpRequester;
using PhoneInformation.App.Models;
using Windows.UI.Popups;

namespace PhoneInformation.App.ViewModels
{
    class DetailedPhoneInformationViewModel : ViewModelBase
    {
        private ObservableCollection<DetailedPhoneInformationModel> detailedInfo;
        private string url;

        public DetailedPhoneInformationViewModel()
        {
            this.url = Parameters.location;
        }

        public IEnumerable<DetailedPhoneInformationModel> DetailedInfo
        {
            get
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new ObservableCollection<DetailedPhoneInformationModel>();
                    this.GetData(url);

                }
                return this.detailedInfo;
            }
            set
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new ObservableCollection<DetailedPhoneInformationModel>();
                }
                this.SetObservableValues(this.detailedInfo, value);
            }
        }

        protected async void GetData(string str)
        {
            try
            {
                            this.DetailedInfo =
                await HttpRequest.Get<IEnumerable<DetailedPhoneInformationModel>>("http://phoneinformation.apphb.com//api/PhoneDetails?phoneUrl=" + str);

            }
            catch (HttpRequestException)
            {
                var msg = new MessageDialog("An error has occured");
                msg.ShowAsync();
                // throw;
            }
        }
    }
}
