using MovieDatabaseLab;

bool runProgram = true;
List<Movie> movieCatalog = new List<Movie>()
{
    new Movie("Inside Out", "Animated"),
    new Movie("Encanto", "Animated"),
    new Movie("The Faculty", "Horror"),
    new Movie("Shrek", "Animated"),
    new Movie("The Matrix", "Scifi"),
    new Movie("Final Destination", "Horror"),
    new Movie("Gothika", "Horror"),
    new Movie("Jurassic Park", "Scifi"),
    new Movie("Pixels", "Scifi"),
    new Movie("Beauty and the Beast", "Animated")
};
Console.WriteLine("Welcome to Blockbuster Video!");
while (runProgram)
{
    while (true)
    {

        Console.WriteLine($"Which movie category would you like to look at today?");
        string input = Console.ReadLine().ToLower().Trim();

        List<Movie> filteredMovies = movieCatalog.Where(x => x.Category.ToLower().Trim() == input).ToList();

        foreach (Movie m in filteredMovies)
        {
            Console.WriteLine(m.Title);
        }
        if (filteredMovies.Count == 0)
        {
            Console.WriteLine("We couldn't find anything that matched your genre. Please search again.");
        }
        else
        {
            runProgram = true;
            break;
        }
    }
    //I couldn't get Validator to work :(
    while (true)
    {
        Console.WriteLine("Would you like to search another category? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Thank you for visiting Blockbuster Video today!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not valid.");
        }
    }

}
