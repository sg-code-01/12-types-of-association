// Task: 1.
// a)Product class yaradin (Name,Price,Count)
// b)Detail methodu olsun Product haqqinda butun melumatlari geriye qaytarsin
// c)Discount methodu olsun (int) endirim faizi qebul etsin ve geriye productin
// satis price-ni yazdirsin. d)Book class Productdan miras alır ve Genre
// ozelliyi var; f) Name ve Price dəyərləri təyin olunmadan Product obyekti
// yaradıla bilməz e) Genre dəyəri təyin olunmadan Book yaradıla bilməz

class Product {
    // a)Product class yaradin (Name,Price,Count)
    string name;
    internal float price;
    internal int count;

    public Product(string name, float price) {
        this.name = name;
        this.price = price;
        this.count = 1;
    }

    public Product(string name, float price, int count) : this(name, price) {
        this.count = count;
    }

    // b)Detail methodu olsun Product haqqinda butun melumatlari geriye
    // qaytarsin
    public void Detail() {
        Console.WriteLine($"Name:  {this.name}");
        Console.WriteLine($"Price: {this.price}");
        Console.WriteLine($"Count: {this.count}");
    }

    public void Discount(float discount_percent) {
        Console.WriteLine(
            $"Price with discount: {this.price * (100 - discount_percent)}");
    }
}

class Book : Product {
    string genre;

    public Book(string name, float price, string genre) : base(name, price) {
        this.genre = genre;
    }

    public Book(string name, float price, string genre, int count)
        : this(name, price, genre) {
        this.count = count;
    }

    new public void Detail() {
        base.Detail();
        Console.WriteLine($"Genre: {this.genre}");
    }
}
