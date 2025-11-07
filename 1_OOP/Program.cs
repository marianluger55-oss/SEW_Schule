using _01_FirstOOP;
using _20_FirstOOP;

int i = 5;      //int -->Datentyp, i-->Name der Variable, 5-->Wert

Person leon = new Person("Leon", "Kammlander", 15);         //new Person erzeugt ein Objekt 
                                                            //Person -->Datentyp 
                                                            //leon-->Name der Variable
                                                            //new Person -->ruft den Konstruktor auf,erzeugt ein Objekt und 
                                                            //weist dieses der Variable zu
Person joachim = new Person("Joachim", "Halmetschlager", 15);

//Erzeuge eine KLasse Tractor mit den Attributen: brand, type, powerInKW 
//Erzeuge drei Objekte von der KLasse Traktor

tractor NewHolland = new tractor("NewHolland", "T7 190", 140);
tractor Deutz = new tractor("Steyr", "8070", 47);
tractor deutzk = new tractor("Xerion", "5000", 385);

NewHolland.GetPowerInHp();//Methodenaufruf -->Objekt, .-Operator, Name der Methode
double hp = NewHolland.GetPowerInHp();
Console.WriteLine($"Leistung: {hp} PS");
Console.WriteLine($"Info:{NewHolland.GetInfo()}");