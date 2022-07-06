using GC_Lab_Movie_Database;


//listing movie titles and categories
List<Movie> movieCollection = new List<Movie>()
{
   new Movie("The Thing", "Horror"),
   new Movie("Jaws", "Horror"),
   new Movie("Total Recall", "Action"),
   new Movie("No Country for Old Men", "Action"),
   new Movie("Brazil", "Comedy"),
   new Movie("Repo Man", "Comedy"),
   new Movie("Starship Troopers", "Comedy"),
   new Movie("Mirror", "Drama"),
   new Movie("There Will be Blood", "Drama"),
   new Movie("Dogville", "Drama") 
};

bool runProgram = true;

//greeting
Console.WriteLine("Welcome to the Movie List Application!");

//restarting the program
while (runProgram)
{
    //get user input
    Console.WriteLine("There are 10 movies in this list.  The categories are: Horror, Action, Comedy, and Drama.");
    Console.WriteLine("What category are you interested in?");
    string choice = Console.ReadLine().ToLower().Trim();

    //put movies into a new list based on category
    List<Movie> sortByCategory = movieCollection.Where(x => x.Category == choice).ToList();

    
    foreach (Movie m in sortByCategory)
    {
        Console.WriteLine(m.Title);
    }
    if (sortByCategory.Count == 0)
    {
        Console.WriteLine("We don't have anything for that genre.");
    }

    //run program again
    Console.WriteLine("Would you like to pick a different movie? y/n");
    string input = Console.ReadLine();

    if (input == "n")
    {
        Console.WriteLine("I hope you enjoy your movie!");
        runProgram = false;
    }
    else if (input == "y")
    {

    }
    else
    {
        Console.WriteLine("please enter y/n");
    }
}



