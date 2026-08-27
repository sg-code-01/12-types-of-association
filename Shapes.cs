// 2.
// Shape classiniz var. Color ve area fieldlari var. ctor vasitesi ile yalniz
// color qebul edilir; GetInfo() methodu olur coloru ve areani ekrana cixartsin
//
// Circle classiniz var Shape classindan inhertence alir elave olaraq radius
// fieldi var; ctor vasitesi ile qebul edilen radiusa gore sahe tapilir;
//
// Rectangle classiniz var Shape classindan inhertence alir elave olaraq Length
// fieldi var; ctor vasitesi ile qebul edilen length e gore sahe tapilir

class Shape {
    internal string color;
    internal double area;

    public Shape(string color, double area) {
        this.color = color;
        this.area = area;
    }

    public void GetInfo() {
        Console.WriteLine($"Color:  {this.color}");
        Console.WriteLine($"Area:   {this.area}");
    }
}

class Rectangle : Shape {
    double length;

    public Rectangle(string color, double length)
        : base(color, length * length) {
        this.length = length;
    }

    new public void GetInfo() {
        base.GetInfo();
        Console.WriteLine($"Length: {this.length}");
    }
}

class Circle : Shape {
    double radius;

    public Circle(string color, double radius)
        : base(color, 3.14 * radius * radius) {
        this.radius = radius;
    }

    new public void GetInfo() {
        base.GetInfo();
        Console.WriteLine($"Radius: {this.radius}");
    }
}
