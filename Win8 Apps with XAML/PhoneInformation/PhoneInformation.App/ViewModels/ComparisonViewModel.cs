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
    class ComparisonViewModel : ViewModelBase
    {
        private ObservableCollection<DetailedPhoneInformationModel> detailedInfo;
        private string firstPhoneId;
        private string secondPhoneId;

        public ComparisonViewModel()
        {
            this.firstPhoneId = Parameters.firstPhoneId;
            this.secondPhoneId = Parameters.secondPhoneId;
        }

        public IEnumerable<DetailedPhoneInformationModel> DetailedInfo
        {
            get
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new ObservableCollection<DetailedPhoneInformationModel>();
                    this.GetData(firstPhoneId, secondPhoneId);

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

        protected async void GetData(string firstPhoneId, string secondPhoneId)
        {
            string message = string.Empty;
            try
            {
                this.DetailedInfo =
               await HttpRequest.Get<IEnumerable<DetailedPhoneInformationModel>>("http://phoneinformation.apphb.com/api/ComparePhones?firstPhoneId=" + firstPhoneId + "&secondPhoneId=" + secondPhoneId);
            }
            catch (Exception)
            {
                message = "An error has occured";
            }
            if (message != string.Empty)
            {
                var msg = new MessageDialog(message);
                await msg.ShowAsync();
            }

        }
    }
}
