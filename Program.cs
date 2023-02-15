// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
















































// Dictionary<type, type> name = new Dictionary<type, type>();
Dictionary<string, string> favFoods = new Dictionary<string, string>();
favFoods.Add("rice", "Nigerian Jollof Rice");
favFoods.Add("soup", "Goat Meat Pepper Soup");
favFoods.Add("appetizer", "Spicy Tuna Sushi Roll");

foreach(var entry in favFoods) {
    Console.WriteLine($"My favorite {entry.Key} is {entry.Value}");
}
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

string[] favFoods = { "Pizza rolls", "Ramen", "Wings", "Sushi", "Fruit" };

for (int i = 0; i < favFoods.Length; i++)
{
    Console.WriteLine(favFoods[i]);
}