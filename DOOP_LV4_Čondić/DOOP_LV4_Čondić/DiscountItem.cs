using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV4_Čondić
{
    class DiscountItem : RentableDecorator
    {
        private readonly double DiscountItemCoeficient = 0.85;
        public DiscountItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() * this.DiscountItemCoeficient;
        }
        public override String Description
        {
            get
            {
                return "Discount: " + base.Description;
            }
        }
    }
}
