DateTime now = DateTime.Now;

Console.WriteLine(now);

DateOnly currentDate = DateOnly.FromDateTime(now);
Console.WriteLine(currentDate);

TimeOnly currentTime = TimeOnly.FromDateTime(now);
Console.WriteLine(currentTime.ToString("T")); // long time format

DateOnly christmas = new DateOnly(2025, 12, 24);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(currentTime.ToString("T"));

int currentYear = now.Year;
Console.WriteLine(currentYear);

DateTime firstDayofSchoolYear = new DateTime(2025, 9, 2, 7, 35, 0);
Console.WriteLine(firstDayofSchoolYear.ToString());

DateTime lastDayofSchoolYear = new DateTime(2026, 7, 3, 9, 40, 0);
TimeSpan schoolYear = lastDayofSchoolYear - firstDayofSchoolYear;

Console.WriteLine($"Dauer des Schuljahres: {schoolYear.TotalHours}");

Console.WriteLine("------------------------------Übungen------------------------------");

Console.WriteLine("---1---");

Console.WriteLine("Aktuelles Datum ohne Zeit: " + currentDate);
Console.WriteLine("Aktuelle Uhrzeit ohne Datum: " + currentTime.ToString()); 

Console.WriteLine("---2---");

DateTime today = DateTime.Today;

DateTime ostern = new DateTime(2026, 4, 5);

TimeSpan bisostern = ostern - today;

// show full days (round up if there are partial days)
Console.WriteLine("Tage bis Ostern: " + Math.Ceiling(bisostern.TotalDays));

DateTime geburtstag = new DateTime(2026, 04, 11);
DateTime meingeburtstag = new DateTime(2011, 02, 23);

TimeSpan bisgeburtstag = geburtstag - today;
Console.WriteLine("Tage bis zu meinem Geburtstag: " + Math.Ceiling(bisgeburtstag.TotalDays));

Console.WriteLine("---3---");
int currentMonth = now.Month;
int currentMinute = now.Minute;     
int currentHour = now.Hour;
int currentSecond = now.Second;
int currentMillisecond = now.Millisecond;

Console.WriteLine(currentDate);
Console.WriteLine(currentTime.ToString("t")); // short time format
Console.WriteLine(now.ToLongDateString());

Console.WriteLine(currentTime.ToString("T"));

Console.WriteLine($"Jahr: {currentYear}");
Console.WriteLine($"Monat: {currentMonth}");
Console.WriteLine($"Tag: {currentDate.Day}");
Console.WriteLine("Mein Geburtstag: " + meingeburtstag.ToLongDateString());
Console.WriteLine("Wochentag meiner Geburt: " + meingeburtstag.DayOfWeek);

TimeSpan lifeTime = today - meingeburtstag;
int daysAlive = (int)lifeTime.TotalDays;
Console.WriteLine($"Ich bin seit {daysAlive} Tagen am Leben.");

TimeSpan lifeTimeseconds = today - meingeburtstag;

int secondsAlive = (int)lifeTimeseconds.TotalSeconds;
Console.WriteLine($"Ich bin seit {secondsAlive} Sekunden am Leben.");

DateTime bisFerien = new DateTime(2026, 7, 3);

TimeSpan daysUntilHolidays = bisFerien - today;
Console.WriteLine($"Tage bis Ferienbeginn:" +lastDayofSchoolYear.ToShortDateString() + ": " +(daysUntilHolidays.TotalDays) + " Tage");


Console.WriteLine("---4---");

