
using Pokedex;
List<Pokemon> pokedex = new();


List<Pokemon> pokeList = new();
pokeList.Add(new Pokemon(new(){"Pikachu", "Raichu"}, "Lightning", 2));
pokeList.Add(new Pokemon(new(){ "Charmander", "Charmeleon", "Charizard" }, "Fire", 3));
pokeList.Add(new Pokemon(new() { "Squirtle", "Warturtle", "Blastoise" }, "Water", 3));
pokeList.Add(new Pokemon(new() { "Bulbasaur", "Ivysaur", "Venusaur" }, "Grass", 3));

bool programStarted = true;
string userMenuChoice;
while(programStarted)
{
    Console.Clear();
    PrintWelcomeMessage();
    PrintPokelist();
    PrintPokedex();
    userMenuChoice = AskUserForMenuChoice();
    if (userMenuChoice == "evolve")
    {
        StartEvolveProcess();
    }
    else if (userMenuChoice == "add")
    {
        int choice = ChoosePokemonFromList();
        AddPokemonToList(choice);
    }
    else if (userMenuChoice == "remove")
    {
        int choice = ChoosePokemonFromPokedex();
        //RemovePokemonFromPokedex();
    }
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();

}



// METHODS

int ChoosePokemonFromList()
{
    Console.Write("Which one would you like to add? ");
    bool success = Int32.TryParse(Console.ReadLine(), out int choice);
    if (success)
    {
        return choice-1;
    }
    else
        ChoosePokemonFromList();
    return 0;
}

int ChoosePokemonFromPokedex()
{
    Console.Write("Which one would you like to remove? ");
    bool success = Int32.TryParse(Console.ReadLine(), out int choice);
    if (success)
    {
        return choice-1;
    }
    else
        ChoosePokemonFromPokedex();
    return 0;
}

void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to Mickes Pokedex!\n");
}

void PrintPokelist()
{
    Console.WriteLine("PokeList:\n");
    if (pokeList.Count() <= 0)
    {
        Console.WriteLine("EMPTY!");
    }
    int pokeNo = 1;
    foreach(Pokemon pokemon in pokeList)
    {
        Console.WriteLine($"{pokeNo}. {pokemon.GetName()} - {pokemon.GetType()}");
        pokeNo++;
    }
    Console.WriteLine();
}

void PrintPokedex()
{
    Console.WriteLine("Pokedex:\n");
    int pokeNo = 1;
    foreach(Pokemon pokemon in pokedex)
    {
        Console.WriteLine($"{pokeNo}. {pokemon.GetName()} - {pokemon.GetType()}");
        pokeNo++;
    }
    Console.WriteLine();
}

string AskUserForMenuChoice()
{
    Console.Write("What would you like to do? Evolve/Add/Remove? ");
    string userString = Console.ReadLine().ToLower();
    if (userString == "evolve" || userString == "add" || userString == "remove")
    {
        return userString;
    }
    Console.WriteLine("Please choose evolve/add/remove.");
    AskUserForMenuChoice();
    return "";
}

void AddPokemonToList(int userMenuChoice)
{
    Console.WriteLine($"Added {pokeList[userMenuChoice].GetName()} to the pokedex.");
    pokedex.Add(pokeList[userMenuChoice]);
    pokeList.Remove(pokeList[userMenuChoice]);
}

void StartEvolveProcess()
{
    Console.WriteLine("Evolve whom?");
    int userInputInt = Convert.ToInt32(Console.ReadLine());
    EvolvePokemon(userInputInt-1);
}

void EvolvePokemon(int userInputInt)
{
    Pokemon currentPokemon = pokedex[userInputInt];
    string oldName = currentPokemon.GetName();
    currentPokemon.Evolve();
    Console.WriteLine($"{oldName} evolved into: {currentPokemon.GetName()}");
}


int indexCounter = 0;
int indexToRemove = 0;
int input = 1;
foreach(Pokemon pokemon in pokedex)
{
    if(input == pokedex.GetNumberOchSåVidare())
    {
        indexToRemove = indexCounter;
    }
    indexCounter++;
}

pokedex.Remove(pokedex[indexToRemove]);

int userInput = Convert.ToInt32(Console.ReadLine()) - 1;

pokedex.Remove(pokedex[userInput-1]);