using Spectre.Console;
using Spectre.Console.Rendering;

string[] menuChoices = new string[4] { "View Books", "Add Book", "Delete Book", "Exit" };
List<string> books = new List<string>() { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", 
    "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", 
    "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", 
    "Catch-22", "The Hitchhiker's Guide to the Galaxy" };

while (true)
{
    string choice = AnsiConsole.Prompt(new SelectionPrompt<string>().Title("What do you want to do next?").AddChoices(menuChoices));
    
    if (choice.Equals(menuChoices[0]))
    {
        AnsiConsole.Clear();
        if (books.Count > 0)
            viewBooks(books);
    }
    else if (choice.Equals(menuChoices[1]))
    {
        if (books.Count > 0)
            addBook(ref books);
    }
    else if (choice.Equals(menuChoices[2]))
    {
        if (books.Count > 0)
            deleteBook(ref books);
    }
    else
    {
        AnsiConsole.Clear();
        break;
    }
}

void viewBooks(List<string> books)
{
    AnsiConsole.Clear();
    foreach(string elem in books)
    {
        AnsiConsole.MarkupLine($"[italic]{elem}[/]");
    }
    AnsiConsole.WriteLine("");
    AnsiConsole.WriteLine("Press any key to continue;");
    AnsiConsole.Console.Input.ReadKey(true);
}

void addBook(ref List<string> books)
{
    string? bookName = AnsiConsole.Ask<string>("Please enter the name of the book that you would like to add to the list: ");

    if (!books.Contains(bookName))
    {
        books.Add(bookName);
        AnsiConsole.MarkupLine($"\n[italic]{bookName}[/] has been added to the book list.\n");
    }
    else
        AnsiConsole.MarkupLine($"\n[italic]{bookName}[/] is already in the list.\n");
}

void deleteBook(ref List<string> books)
{
    string? bookName = AnsiConsole.Ask<string>("Please enter the name of the book that you would like to delete: ");

    if (books.Contains(bookName))
    {
        books.Remove(bookName);
        AnsiConsole.MarkupLine($"\n[italic]{bookName}[/] has been deleted from the list.\n");
    }
    else
        AnsiConsole.MarkupLine($"\n[italic]{bookName}[/] is not in the list.\n");
}

/* 
 ->
 ->
 ->
 ->
 */

