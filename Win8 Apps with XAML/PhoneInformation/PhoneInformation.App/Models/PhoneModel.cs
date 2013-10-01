using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneInformation.App.Models
{
    public class PhoneModel
    {
        private string name;
        private string link;
        private string imageSrc;

        public PhoneModel()
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Link
        {
            get
            {
                return this.link;
            }
            set
            {
                this.link = value;
            }
        }

        public string ImageSrc
        {
            get
            {
                return this.imageSrc;
            }
            set
            {
                this.imageSrc = value;
            }
        }
    }
}
