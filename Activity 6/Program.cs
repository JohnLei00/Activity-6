// See https://aka.ms/new-console-template for more information
List<string> cities = new List<string>();
string city;

Console.WriteLine("Enter city names (type 'exit' to finish):");

// Input city names
while (true)
{
    city = Console.ReadLine();
    if (city.ToLower() == "exit") break;
    cities.Add(city);
}

// Remove duplicates and sort cities
var uniqueCities = cities.Distinct().OrderBy(c => c).ToList();

Console.WriteLine("\nCities in alphabetical order:");
foreach (var c in uniqueCities)
{
    Console.WriteLine(c);
}
