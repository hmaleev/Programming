using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace PhoneInformation.App.Models
{
    class PhoneListModel
    {
        private ObservableCollection<PhoneModel> phoneList;

        public PhoneListModel()
        {
        }

        public ObservableCollection<PhoneModel> PhoneList
        {
            get
            {
                return this.phoneList;
            }
            set
            {
                this.phoneList = value;
            }
        }
    }
}
