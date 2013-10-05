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
    public class SearchViewModel:Common.BindableBase
    {
                private string queryText = "";
         private string brand = Parameters.brand;
        public string QueryText
        {
            get
            {
                return this.queryText;
            }
            set
            {
                this.queryText = value;
                this.OnPropertyChanged("QueryText");
                this.GetData(brand);
            }
        }

                private ObservableCollection<PhoneModel> results;
        public IEnumerable<PhoneModel> Results
        {
            get
            {
                if (this.results == null)
                {
                    results = new ObservableCollection<PhoneModel>();
                }

                return results;
            }
            set
            {
                this.results.Clear();

                foreach (var item in value)
                {
                    this.results.Add(item);
                }
            }
        }

        protected async void GetData(string brand)
        {
            try
            {
                 this.Results =
                await HttpRequest.Get<IEnumerable<PhoneModel>>("http://phoneinformation.apphb.com/api/PhoneList?brand=" + brand);
            }
            catch (HttpRequestException)
            {
                var msg = new MessageDialog("An error has occured");
                msg.ShowAsync();
               // throw;
            }
            catch (Exception)
            {
                var msg = new MessageDialog("An error has occured");
                msg.ShowAsync();
               // throw;
            }
           
        }

    }
}
