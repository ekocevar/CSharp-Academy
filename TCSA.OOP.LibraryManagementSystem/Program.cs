using Spectre.Console;

string[] menuChoices = new string[4] { "View Books", "Add Book", "Delete Book", "Exit" };
List<string> books = new List<string>() { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", 
    "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", 
    "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", 
    "Catch-22", "The Hitchhiker's Guide to the Galaxy" };

while (true)
{
    string choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>().Title("What do you want to do next?")
                    .AddChoices(menuChoices));
    if (choice.Equals(menuChoices[0]))
    {
        Console.Clear();
        if (books.Count > 0)
            viewBooks(books);
    }
    else if (choice.Equals(menuChoices[1]))
    {
        string? bookName = Console.ReadLine();
        if (books.Count > 0 && bookName != null)
            addBook(ref books, bookName);
    }
    else if (choice.Equals(menuChoices[2]))
    {
        string? bookName = Console.ReadLine();

        if (books.Count > 0 && bookName != null)
            deleteBook(ref books, bookName);
    }
    else
    {
        Console.Clear();
        break;
    }
}

void viewBooks(List<string> books)
{
    Console.Clear();
    foreach(string elem in books)
    {
        Console.WriteLine(elem);
    }
    Console.WriteLine("");
}

void addBook(ref List<string> books, string bookName)
{
    books.Add(bookName);
}

void deleteBook(ref List<string> books, string bookName)
{
    if (books.Contains(bookName))
        books.Remove(bookName);
}



/*
 Next implement the View book, add book and delete book function so we can make this program work
 */