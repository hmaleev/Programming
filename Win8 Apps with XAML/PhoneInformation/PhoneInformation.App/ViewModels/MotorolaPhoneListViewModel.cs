using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.HttpRequester;
using PhoneInformation.App.Models;
using PhoneInformation.App.Commands;
using System.Windows.Input;

namespace PhoneInformation.App.ViewModels
{
    public class MotorolaPhoneListViewModel : ViewModelBase
    {
        //private readonly string brand = "samsung";
        private ObservableCollection<PhoneModel> phones;
        private string url;
        //private ICommand addNewCommand;

        //public ICommand AddNew
        //{
        //    get
        //    {
        //        if (this.addNewCommand == null)
        //        {
        //            this.addNewCommand = new RelayCommand(this.HandleAddNewCommand);
        //        }
        //        return this.addNewCommand;
        //    }
        //}

        //private void HandleAddNewCommand(object obj)
        //{
        //    this.url = "motorola_moto_x-5601.php";

        //}


        public MotorolaPhoneListViewModel()
        {
        }


        public IEnumerable<PhoneModel> Phones
        {
            get
            {
                if (this.phones == null)
                {
                    this.phones = new ObservableCollection<PhoneModel>();
                    this.GetData("motorola");

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
            var m = this.Phones;
        }
    }
}