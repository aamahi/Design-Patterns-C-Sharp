using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete_Product
{
    public class SamsungTablet : Tablet
    {
        private string Model { get; set; }

        private string ScreenSize { get; set; }

        public SamsungTablet(string model, string screensize)
        {
            this.Model = model;
            this.ScreenSize = screensize;
        }

        public override string GetModel()
        {
            return Model;
        }

        public override string GetScreenSize()
        {
            return ScreenSize;
        }
    }
}
