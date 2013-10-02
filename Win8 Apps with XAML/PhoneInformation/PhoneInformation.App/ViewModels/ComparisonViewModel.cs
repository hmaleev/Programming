using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.HttpRequester;
using PhoneInformation.App.Models;

namespace PhoneInformation.App.ViewModels
{
    class ComparisonViewModel:ViewModelBase
    {
          private ObservableCollection<DetailedPhoneInformationModel> detailedInfo;
        private string url;

        public ComparisonViewModel()
        {
            this.url = Url.location;
        }

        public IEnumerable<DetailedPhoneInformationModel> DetailedInfo
        {
            get
            {
                if (this.detailedInfo == null)
                {
                    this.detailedInfo = new ObservableCollection<DetailedPhoneInformationModel>();
                    this.GetData("5322","3233");

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

        protected async void GetData( string firstPhoneId, string secondPhoneId)
        {
            this.DetailedInfo =
                await HttpRequest.Get<IEnumerable<DetailedPhoneInformationModel>>("http://phoneinformation.apphb.com/api/ComparePhones?firstPhoneId="+firstPhoneId+"&secondPhoneId="+secondPhoneId);
        }
    }
}
