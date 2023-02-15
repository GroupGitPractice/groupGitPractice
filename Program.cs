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