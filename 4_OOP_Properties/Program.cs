using _4_OOP_Properties;

Person joe = new Person("Joe");

// getter - "lesender Zugriff"
Console.WriteLine($"Name: {joe.Name}");     // Properties immer ohne Klammern

// setter - "schreibender Zugriff"
joe.Name = "Josef";         // setter immer in Kombination mit Zuweisungsoperator 
Console.WriteLine($"Name: {joe.Name}");