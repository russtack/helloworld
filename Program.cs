// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] myGenerals = new string[2];
myGenerals[0] = "pompeius";


string[] carthage = { "Hasdrubal", "Hanibal" };



List<string> mareshals = new List<string>() { "Napoleon", "Grouchy" };


string[,] twoDimensions = new string[,] { { "Hasdrubal", "Hanibal" }, { "Napoleon", "Grouchy" } };
mareshals.Add("Souchet");
System.Console.WriteLine(mareshals[2]);
Console.WriteLine(twoDimensions[1,0]);

Dictionary<string, decimal> generals = new Dictionary<string, decimal>() {{ "Carthage", 5.6m},{"Mago", 63.5m}};
System.Console.WriteLine(generals["Carthage"]);