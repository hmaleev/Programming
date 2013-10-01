using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.HttpRequester;
using PhoneInformation.App.Models;

namespace PhoneInformation.App.ViewModels
{
    public class HTCPhoneListViewModel : ViewModelBase
    {
        //private readonly string brand = "samsung";
        private ObservableCollection<PhoneModel> phones;

        public HTCPhoneListViewModel()
        {
        }


        public IEnumerable<PhoneModel> Phones
        {
            get
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneModel>();
                    this.GetData("htc");

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
            this.Phones =
                await HttpRequest.Get<IEnumerable<PhoneModel>>("http://localhost:63847/api/PhoneList?brand="+brand);
        }
    }
}