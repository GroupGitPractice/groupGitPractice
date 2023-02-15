// See https://aka.ms/new-console-template for more information
// Create an list and loop through

List<string> favoriteFoodList = new List<string>();
favoriteFoodList.Add("Pasta");
favoriteFoodList.Add("Sushi");
favoriteFoodList.Add("Fries");
favoriteFoodList.Add("Fajitas");
favoriteFoodList.Add("Poke Bowls");

foreach (var food in favoriteFoodList)
{
    Console.WriteLine("I LOVE " + food);
}

// Create an array and loop through

string[] favFoodsArray = { "Pizza rolls", "Ramen", "Wings", "Sushi", "Fruit" };

for (int i = 0; i < favFoodsArray.Length; i++)
{
    Console.WriteLine(favFoodsArray[i]);
}

// Dictionary<type, type> name = new Dictionary<type, type>();
Dictionary<string, string> favFoodsDictionary = new Dictionary<string, string>();
favFoodsDictionary.Add("rice", "Nigerian Jollof Rice");
favFoodsDictionary.Add("soup", "Goat Meat Pepper Soup");
favFoodsDictionary.Add("appetizer", "Spicy Tuna Sushi Roll");

foreach(var entry in favFoods) {
    Console.WriteLine($"My favorite {entry.Key} is {entry.Value}");
}