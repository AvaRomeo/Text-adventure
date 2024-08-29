Console.WriteLine("Welkom bij dit Harry Potter Avontuur");

//de gebruiker moet op enter drukken om ver te gaan om hun huis te kiezen

Console.WriteLine("Druk op Enter om verder te gaan...");
Console.ReadLine();

Console.Clear();

//de gebruiker gaat hun huis kiezen

Console.WriteLine("Kies jouw huis:");
Console.WriteLine("1. Gryffindor");
Console.WriteLine("2. Slytherin");
Console.WriteLine("3. Hufflepuf");
Console.WriteLine("4. Ravenclaw");

int choice = 0;
bool validChoice = false;

while (!validChoice)
{
    Console.Write("Maak een keuze (1-4): ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
    {
        validChoice = true;
    }
    else
    {
        Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
    }
}

string chosenHouse = "";

switch (choice)
{
    case 1:
        chosenHouse = "Gryffindor";
        Console.ForegroundColor = ConsoleColor.Red;
        break;
    case 2:
        chosenHouse = "Slytherin";
        Console.ForegroundColor = ConsoleColor.Green;
        break;
    case 3:
        chosenHouse = "Hufflepuf";
        Console.ForegroundColor = ConsoleColor.Yellow;
        break;
    case 4:
        chosenHouse = "Ravenclaw";
        Console.ForegroundColor = ConsoleColor.Blue;
        break;
}

Console.WriteLine($"Je hebt {chosenHouse} gekozen!");

// TODO: Opslaan van het gekozen huis en vervolg van het avontuur

Console.ResetColor();
