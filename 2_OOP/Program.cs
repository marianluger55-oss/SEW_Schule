
using _2_OOP;

Rectangle Desk = new Rectangle(3.0, 2.0);
Rectangle Chair = new Rectangle(0.5, 0.5);
Rectangle Cupboard = new Rectangle(4.0, 5.0);

Desk.Area();                                                 //ohne:
double area_Desk = Desk.Area();                              //ohne:
Console.WriteLine($"Die Fläche beträgt:{area_Desk}");        // geht auch so: Console.WriteLine($"Die Fläche beträgt:{Desk.Area()};
Chair.Area();
double area_Chair = Chair.Area();
Console.WriteLine($"Die Fläche beträgt:{area_Chair}");
Cupboard.Area();
double area_Cupboard = Cupboard.Area();
Console.WriteLine($"Die Fläche beträgt:{area_Cupboard}");

Console.WriteLine();

Desk.Circumference();
double circumference_Desk = Desk.Circumference();
Console.WriteLine($"Der Umfang beträgt:{circumference_Desk}");
Chair.Circumference();
double circumference_Chair = Chair.Circumference();
Console.WriteLine($"Der Umfang beträgt:{circumference_Chair}");
Cupboard.Circumference();
double circumference_Cupboard = Cupboard.Circumference();
Console.WriteLine($"Der Umfang beträgt:{circumference_Cupboard}");

Console.WriteLine();

Desk.Resize(2.0);       // kein Rückgabewert, aber der innere Zustand des Objekt wird verändert
Console.WriteLine($"Fläche:{Desk.Area()}");
Console.WriteLine($"Umfang:{Desk.Circumference()}");

