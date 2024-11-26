string timeString1 = "14:30";
string timeString2 = "14:30:45";
string invalidTimeString = "25:00";

// Пример 1: Используем Parse
try
{
    TimeOnly time1 = TimeOnly.Parse(timeString1);
    Console.WriteLine($"Parsed time using Parse: {time1}");
}
catch (FormatException)
{
    Console.WriteLine($"Unable to parse '{timeString1}' using Parse.");
}

// Пример 2: Используем ParseExact
try
{
    TimeOnly time2 = TimeOnly.ParseExact(timeString2, "HH:mm:ss");
    Console.WriteLine($"Parsed time using ParseExact: {time2}");
}
catch (FormatException)
{
    Console.WriteLine($"Unable to parse '{timeString2}' using ParseExact.");
}

// Пример 3: Используем TryParse
if (TimeOnly.TryParse(invalidTimeString, out TimeOnly time3))
{
    Console.WriteLine($"Parsed time using TryParse: {time3}");
}
else
{
    Console.WriteLine($"Unable to parse '{invalidTimeString}' using TryParse.");
}

// Пример 4: Используем TryParseExact
string exactFormat = "HH:mm";
if (TimeOnly.TryParseExact(timeString1, exactFormat, null, System.Globalization.DateTimeStyles.None, out TimeOnly time4))
{
    Console.WriteLine($"Parsed time using TryParseExact: {time4}");
}
else
{
    Console.WriteLine($"Unable to parse '{timeString1}' using TryParseExact.");
}
