using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262898_PROG6221_POE
{
    internal class Ingredient
    {
        // Properties to store ingredient details
        public string ingrName { get; set; } // Name of the ingredient
        public double ingrQuantity { get; set; } // Quantity of the ingredient
        public string ingrUnit { get; set; } // Unit of measurement for the ingredient
        public string stepDesc { get; set; } // Description of a step
        private double ogQuan; // Original quantity of the ingredient

        // Constructor for an ingredient with name, quantity, and unit
        public Ingredient(string ingrName, double ingrQuantity, string ingrUnit)
        {
            this.ingrName = ingrName;
            this.ingrQuantity = ingrQuantity;
            this.ingrUnit = ingrUnit;
            this.ogQuan = ingrQuantity; // Saving the original quantity for resetting
        }

        // Constructor for a step description
        public Ingredient(string stepDesc)
        {
            this.stepDesc = stepDesc;
        }

        // Method to reset the quantity of the ingredient to its original value
        public void ResetQuantity()
        {
            ingrQuantity = ogQuan;
        }
    }
}
