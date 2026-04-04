Macro Calculator Final Project

This is a macro calcuator that allows the user to use a food database to keep track of macronutrient goals they set. Users can create goals, look up foods in the database, add foods to the database, add meals in their day, and view the progression of their goals.

The Macros are input by the user when they add the food to their databse. the program also will ask for serving size the macros that were input will be multiplied by the serving size to give the macros of the total meal.

Encapsulation: In the program all the data is private and is accessed through methods for example the goals that are made are updated using SetGoals()

Abstraction: Each class has a specific responsibilty and hides the unecessary stuff from the user. For example, the FoodDatabase hides the things like storing and retreving the foods leaving the other parts to interact with its public methods.

Inheritance: WholeFood and RecipeFood inherit from FoodItem

Polymorphism: Methods like GetCalories() behaves differently depending on if it's WholeFood or a RecipeFood

An important thing to know is the values in the food database aren't exact they are rough estimates. The use has the option to add foods to the database to make it more accurate depending on the type of food they are using like whole milk or skim milk.
