using System;
using System.Collections.ObjectModel;
using System.Linq;
using PhoneInformation.App.Models;

namespace PhoneInformation.App.ViewModels
{
    public class PhoneViewModel:ViewModelBase
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string ImageSrc { get; set; }
    }
}
