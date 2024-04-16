Recipe Creator

This simple console application allows users to create a recipe by inputting ingredients and steps.

-> Getting Started

Running the application:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the application.

-> Usage

Upon running the application, you will be prompted to enter the recipe name, the number of ingredients, and the number of steps. Then, you'll be prompted to input details for each ingredient (name, quantity, unit) and each step (description). After entering all the information, the application will display the created recipe.

## How It Works

The application consists of three classes:

1. Ingredient: Represents an ingredient or a step in the recipe. It has properties for name, quantity, unit (for ingredients), and description (for steps).

2. Recipe: Represents the entire recipe. It has properties for the recipe name, ingredients list, and steps list. It also contains a `toString` method to format and display the recipe.
3. 'Program': This houses the main. All the methods are called here. It asks the user for their input and sends it through the messages.


