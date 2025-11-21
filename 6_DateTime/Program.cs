DateTime now = DateTime.Now;

Console.WriteLine(now); 

DateOnly currentDay = DateOnly.FromDateTime(now);
Console.WriteLine(currentDay);


TimeOnly currentTime = TimeOnly.FromDateTime(now);

Console.WriteLine(currentTime);

DateOnly christmas = new DateOnly(2025, 12, 24); 

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(currentTime.ToLongTimeString());  

int currentYear = now.Year;
Console.WriteLine(currentYear);

DateTime firstDayofSchoolYear = new DateTime(2025, 9, 2, 7, 35, 0); 

Console.Write(firstDayofSchoolYear.ToString());

DateTime lastDayofSchoolYear = new DateTime(2026, 7, 3, 9, 40, 0); 

TimeSpan schoolYear = lastDayofSchoolYear - firstDayofSchoolYear;

Console.WriteLine($"Dauer des Schuljahres: { schoolYear.TotalHours}");
