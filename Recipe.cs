using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262898_PROG6221_POE
{
    internal class Recipe
    {
        // Properties to store recipe details
        public string ingrName { get; set; } // Name of an ingredient (seems redundant)
        public double ingrQuantity { get; set; } // Quantity of an ingredient (seems redundant)
        public string ingrUnit { get; set; } // Unit of measurement for an ingredient (seems redundant)
        public List<Ingredient> Ingredients { get; set; } // List of ingredients
        public List<Ingredient> descStep { get; set; } // List of steps
        public string recName { get; set; } // Name of the recipe

        // Method to generate a string representation of the recipe
        public string toString()
        {
            string message = "Recipe for " + recName + "\n\nIngredients:\n";

            // Iterating over each ingredient to include in the message
            foreach (Ingredient ingredient in Ingredients)
            {
                message += $"{ingredient.ingrName}\t\t{ingredient.ingrQuantity} {ingredient.ingrUnit}\n";
            }

            message += "\nSteps:\n";

            // Iterating over each step to include in the message
            foreach (Ingredient step in descStep)
            {
                message += step.stepDesc + "\n";
            }

            message += "\nEnjoy!\n";

            return message;
        }

        // Method to scale the quantities of ingredients
        public void scaled()
        {
            Console.WriteLine("Scaling Options:\n0\n0.5\n2\n3");
            double factor = double.Parse(Console.ReadLine());

            // Iterating over each ingredient to scale its quantity
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredient ingredient = Ingredients[i];

                if (factor == 0.5)
                {
                    Console.WriteLine("Quantities have been halved.");
                    ingredient.ingrQuantity *= 0.5;
                    Console.WriteLine($"{ingredient.ingrQuantity} {ingredient.ingrUnit}");
                }
                else if (factor == 2)
                {
                    Console.WriteLine("Quantities have been doubled.");
                    ingredient.ingrQuantity *= 2;
                    Console.WriteLine($"{ingredient.ingrQuantity} {ingredient.ingrUnit}");
                }
                else if (factor == 3)
                {
                    Console.WriteLine("Quantities have been tripled.");
                    ingredient.ingrQuantity *= 3;
                    Console.WriteLine($"{ingredient.ingrQuantity} {ingredient.ingrUnit}");
                }
                else
                {
                    Console.WriteLine("Quantities remain the same.");
                    Console.WriteLine($"{ingredient.ingrQuantity} {ingredient.ingrUnit}");
                }
            }
        }

        // Method to clear data (ingredients and steps)
        public void clearData()
        {
            Ingredients.Clear();
            descStep.Clear();
            Console.WriteLine("Data cleared.");
        }

        // Method to reset ingredient quantities to their original values
        public void Reset()
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].ResetQuantity();
            }
        }

    }
}
