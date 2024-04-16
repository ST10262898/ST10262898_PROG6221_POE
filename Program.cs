// Cailey Mocktar
// ST10262898
// Group 2

// References: 
// https://www.w3schools.com/cs/cs_arrays.php
// https://www.programiz.com/csharp-programming/for-loop

namespace ST10262898_PROG6221_POE
{
    internal class Program
    {
        private List<Ingredient> ingredients;
        private List<Ingredient> steps;

        static void Main(string[] args)
        {
            // Boolean variable to control program termination
            Boolean close = false;

            // Prompting user for recipe name
            Console.WriteLine("Recipe name: ");
            string recipeName = Console.ReadLine();

            // Prompting user for the number of ingredients
            Console.WriteLine("How many ingredients will be used?");
            int numIngr = int.Parse(Console.ReadLine());

            // Creating a list to store ingredients
            List<Ingredient> ingredients = new List<Ingredient>();

            // Loop to input ingredients
            for (int i = 0; i < numIngr; i++)
            {
                Console.WriteLine("Ingredient Name: ");
                string ingrName = Console.ReadLine();
                Console.WriteLine("Ingredient Quantity: ");
                double ingrQuantity = double.Parse(Console.ReadLine());
                Console.WriteLine("Unit of measurement: ");
                string ingrUnit = Console.ReadLine();

                // Creating an Ingredient object and adding it to the list
                Ingredient ingredient = new Ingredient(ingrName, ingrQuantity, ingrUnit);
                ingredients.Add(ingredient);
            }

            // Prompting user for the number of steps
            Console.WriteLine("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Creating a list to store steps
            List<Ingredient> steps = new List<Ingredient>();

            // Loop to input steps
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step description: ");
                string descSteps = Console.ReadLine();

                // Creating an Ingredient object for step description and adding it to the list
                Ingredient step = new Ingredient(descSteps);
                steps.Add(step);
            }

            // Creating a Recipe object and setting its properties
            Recipe recipe = new Recipe();
            recipe.recName = recipeName;
            recipe.Ingredients = ingredients;
            recipe.descStep = steps;

            // Displaying recipe details
            Console.WriteLine(recipe.toString());

            // Prompting user if they want to scale the recipe
            Console.WriteLine("Do you want to scale your recipe?\n1. Yes\n2. No");
            int scaleAns = int.Parse(Console.ReadLine());

            if (scaleAns == 1)
            {
                recipe.scaled();
            }
            else if (scaleAns == 2)
            {
                Console.WriteLine("Your recipe remains the same.");
            }
            else
            {
                Console.WriteLine("Wrong selection!");
                close = true;
            }

            // Prompting user if they want to reset ingredient quantities
            Console.WriteLine("Do you want to reset your quantities?\n1. Yes\n2. No");
            int resetAns = int.Parse(Console.ReadLine());

            if (resetAns == 1)
            {
                recipe.clearData();
            }
            else if (resetAns == 2)
            {
                Console.WriteLine("Your quantities remains the same.");
            }
            else
            {
                Console.WriteLine("Wrong selection!");
                close = true;
            }

            // Prompting user if they want to enter a new recipe
            Console.WriteLine("Do you want to enter a new recipe?\n1. Yes\n2. No");
            int clearAns = int.Parse(Console.ReadLine());

            if (clearAns == 1)
            {
                recipe.clearData();
            }
            else if (clearAns == 2)
            {
                Console.WriteLine("Your data remains the same.");
            }
            else
            {
                Console.WriteLine("Wrong selection!");
                close = true;
            }
        }
    }
}
