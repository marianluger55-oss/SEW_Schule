

using _7_Birthday;

DateTime day = new DateTime(2000, 2, 1);
Person john = new Person("John", "Doe", day);
Person jane = new Person("Jane", "Smith", new DateTime(2000, 12, 1));
Console.WriteLine($"John: {john.Age}");  // Output: John's age
Console.WriteLine($"Jane: {jane.Age}");  // Output: Jane's age

Console.WriteLine($"Tage gelebt (John): {john.DaysLived}");  // Output: Days John has lived
Console.WriteLine($"Tage gelebt (Jane): {jane.DaysLived}");  // Output: Days Jane has lived

Console.WriteLine($"Tage bis zu Johns nächsten Geburtstag: {john.DaysUntilNextBirthday}");  // Output: Days until John's next birthday
Console.WriteLine($"Tage bis zu Janes nächsten Geburtstag: {jane.DaysUntilNextBirthday}");  // Output: Days until Jane's next birthday