
Console.Write("How many books do you want? ");
int books_amount = int.Parse(Console.ReadLine());

if (books_amount < 1) {
    Console.WriteLine("Invalid amount of books");
    Environment.Exit(1); // davay dasvidaniya
}

Book[] books = new Book[books_amount];

for (int i = 1; i < books_amount + 1; i++) {
    Console.Write($"[{i}] Name: ");
    string name = Console.ReadLine();

    Console.Write($"[{i}] Price: ");
    float price = float.Parse(Console.ReadLine());

    Console.Write($"[{i}] Genre: ");
    string genre = Console.ReadLine();

    books[i - 1] = new Book(name, price, genre);
}

while (true) {
    Console.WriteLine("");
    Console.WriteLine("1. Kitablari qiymete gore filterle");
    Console.WriteLine("2. Butun kitablari goster");
    Console.WriteLine("0. Proqrami bagla");
    Console.WriteLine("");

    int userInput = int.Parse(Console.ReadLine());

    if (userInput == 1) {
        foreach (var book in books.OrderBy(b => b.price)) {
            Console.WriteLine("--------------");
            book.Detail();
            Console.WriteLine("--------------");
        }
    } else if (userInput == 2) {
        foreach (Book book in books) {
            Console.WriteLine("--------------");
            book.Detail();
            Console.WriteLine("--------------");
        }
    } else if (userInput == 0) {
        break;
    }
}
