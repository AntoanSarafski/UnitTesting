using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Car
    {
        public void Drive(int kms)
        {
            if (kms < 0 )
            {
                throw new ArgumentException("Don't Lie!");
            }
            Mileage += kms;
        }

        public int Mileage { get; set; }
    }
}
