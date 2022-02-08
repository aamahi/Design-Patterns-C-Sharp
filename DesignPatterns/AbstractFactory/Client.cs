using AbstractFactory.Concrete_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private Phone Phone;
        private Tablet Tablet;


        public void GetProductsFromFactory(string factoryName)
        {
            factoryName = factoryName.ToLower();
            GadgetFactory gadgetFactory;

            switch(factoryName)
            {
                case "samsung":
                    gadgetFactory = new SamsungFactory();
                    break;
                case "apple":
                    gadgetFactory= new AppleFactory();
                    break;
                default:
                    throw new ArgumentException("Factory doesn't exist");

            }

            Phone = gadgetFactory.GetPhone();
            Tablet = gadgetFactory.GetTablet();
        }


        public void ShowProductDetails()
        {
            Console.WriteLine($"Phone Model: {Phone.GetModel()}");
            Console.WriteLine($"Phone Camera: {Phone.GetCamera()}");
            Console.WriteLine($"Tablet Model: {Tablet.GetModel()}");
            Console.WriteLine($"Tablet Screent Size: {Tablet.GetScreenSize()}");
        }


    }
}
