Console.WriteLine("Bitte eine Zahl eingeben: ");
string money1 = Console.ReadLine();
double money = double.Parse(money1);

int result200;
int result100;
int result50;
int result20;
int result10;
int result5;


 result200 = (int)money % 200; // rest für 100
result100 = result200 % 100; // rest für 50
result50 = result100 % 50; // rest für 20
result20 = result50 % 20; // rest für 10
result10 = result20 % 10; // rest für 5
result5 = result10 % 5;

Console.WriteLine($"Es sind {(int)money / 200} 200er Scheine");
Console.WriteLine($"Es sind {result200 / 100} 100er Scheine");
Console.WriteLine($"Es sind {result100 / 50} 50er Scheine");
Console.WriteLine($" Es sind {result50 / 20} 20er Scheine");
Console.WriteLine($"Es sind {result20 / 10} 10er Scheine");
Console.WriteLine($"Es sind {result10 / 5} 5er Scheine,");