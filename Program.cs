// See https://aka.ms/new-console-template for more information

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