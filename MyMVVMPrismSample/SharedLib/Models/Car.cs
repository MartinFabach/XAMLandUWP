using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Models
{
    public class Car : BindableBase
    {
        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { SetProperty(ref manufacturer, value); }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { SetProperty(ref model, value); }
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model}";
        }
    }
}
