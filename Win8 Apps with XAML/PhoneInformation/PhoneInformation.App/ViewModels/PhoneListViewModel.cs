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
    class PhoneListViewModel : ViewModelBase
    {

        private ObservableCollection<PhoneModel> phones;
        private string brand = Parameters.brand;
        public PhoneListViewModel()
        {

        }


        public IEnumerable<PhoneModel> Phones
        {
            get
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneModel>();
                    this.GetData(this.brand);

                }
                return this.phones;
            }
            set
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneModel>();
                }
                this.SetObservableValues(this.phones, value);
            }
        }

        protected async void GetData(string brand)
        {
            string message = string.Empty;
            try
            {
                this.Phones =
               await HttpRequest.Get<IEnumerable<PhoneModel>>("http://phoneinformation.apphb.com/api/PhoneList?brand=" + brand);
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
