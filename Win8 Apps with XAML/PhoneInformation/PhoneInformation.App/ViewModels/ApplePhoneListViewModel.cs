using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.HttpRequester;

namespace PhoneInformation.App.ViewModels
{
    public class ApplePhoneListViewModel : ViewModelBase
    {
        private readonly string brand = "apple";
        private ObservableCollection<PhoneViewModel> phones;

        public ApplePhoneListViewModel()
        {
        }


        public IEnumerable<PhoneViewModel> Phones
        {
            get
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneViewModel>();
                    this.GetData(brand);

                }
                return this.phones;
            }
            set
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneViewModel>();
                }
                this.SetObservableValues(this.phones, value);
            }
        }

        protected async void GetData(string brand)
        {
            this.Phones =
                await HttpRequest.Get<IEnumerable<PhoneViewModel>>("http://localhost:63847/api/PhoneList?brand="+brand);
        }
    }
}