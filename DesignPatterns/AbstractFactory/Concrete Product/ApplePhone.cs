using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete_Product
{
    public class ApplePhone : Phone
    {
        private string Model { get; set; }

        private string Camera { get; set; }

        public ApplePhone(string model, string camera)
        {
            this.Model = model;
            this.Camera = camera;
        }

        public override string GetCamera()
        {
            return Camera;
        }

        public override string GetModel()
        {
            return Model;
        }
    }
}
