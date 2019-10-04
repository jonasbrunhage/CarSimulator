using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class Car
    {
        private string brand;
        private string model;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
