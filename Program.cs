using SharpKnP231.Library;
using SharpKnP231.Vectors;
using System;
using System.Reflection;

new VectorDemo().Run();

void ShowReflection()
{
    /*
     * Рефлексія (в ООП) - інструментаріій мови\платформи, який
     * дозволяє одержувати відомості про склад типу даних
     */
    Type bookType = typeof(Book);
    FieldInfo[] fields = bookType.GetFields();
    PropertyInfo[] properties = bookType.GetProperties();
    MethodInfo[] methods = bookType.GetMethods();
    EventInfo[] events = bookType.GetEvents();

    if (fields.Length > 0)
    {
        Console.WriteLine("Type 'Book' has fields:");
        foreach (var field in fields)
        {
            Console.WriteLine(field.Name);
        }
    }
    else
    {
        Console.WriteLine("Type 'Book' has no fields");
    }

    if (properties.Length > 0)
    {
        Console.WriteLine("\nType 'Book' has props:");
        foreach (var prop in properties)
        {
            Console.WriteLine("{0}: {1}", prop.Name, prop.PropertyType.Name);
        }
    }
    else
    {
        Console.WriteLine("\nType 'Book' has no props");
    }

    if (methods.Length > 0)
    {
        Console.WriteLine("\nType 'Book' has methods:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
    else
    {
        Console.WriteLine("\nType 'Book' has no methods");
    }

    if (events.Length > 0)
    {
        Console.WriteLine("\nType 'Book' has events:");
        foreach (var _event in events)
        {
            Console.WriteLine(_event.Name);
        }
    }
    else
    {
        Console.WriteLine("\nType 'Book' has no events");
    }
    /*
     * Рефлексія за об'єктом
     */
    Console.WriteLine("\n\n--------Рефлексія за об'єктом----------");
    Literature j = new Journal()
    {
        Title = "ArgC & ArgC",
        Number = "2(113), 2000",
        Publisher = "https://journals.ua/technology/argc-argv"
    };
    Type jType = j.GetType();
    Console.WriteLine(jType.Name); // Journal - змінна типізується за об'єктом (а не за оголошенням) 
    PropertyInfo? jProp = jType.GetProperty("Number");
    if (jProp != null)
    {
        // prop - відомості про тип даних, а не про об'єкт
        var number = jProp.GetValue(j);
        Console.WriteLine($"Object has 'Number' property with value '{number}'");
    }
    else
    {
        Console.WriteLine("Object has no 'Number' property");
    }

    Library library = new();
    Console.WriteLine("-------printable-------");
    library.ShowPrintable();
    Console.WriteLine("-------color printable-------");
    library.ShowColorPrintable();
    Console.WriteLine("\n-------apa style------");
    library.ShowApaCard();
    Console.WriteLine("\n-------apa style cite------");
    library.PrintApaCards();
    Console.WriteLine("\n-------ieee style cite------");
    library.PrintIeeeCards();

}

void ShowLibrary()
{
    Library library = new();
    library.PrintCatalog();
    Console.WriteLine("\n-----Periodic-----");
    library.PrintPeriodic();
    Console.WriteLine("\n-----NonPeriodic-----");
    library.PrintNonPeriodic();
    Console.WriteLine("\n-------Printable-------");
    library.PrintPrintable();
    Console.WriteLine("\n-----NonPrintable------");
    library.PrintNonPrintable();
    Console.WriteLine("------------------");
}

void Task1()
{
    Console.Write("Enter number from 1 to 100: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num < 1 && num > 100)
    {
        Console.WriteLine("Number must be in range [1;100]");
        return;
    }
    bool f = num % 3 == 0;
    bool b = num % 5 == 0;
    if (f && b)
        Console.WriteLine("Fizz Buzz");
    else if (f)
        Console.WriteLine("Fizz");
    else if (b)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(num);
}

void Task2()
{
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine()!);
    double c = (double)a * b / 100;
    Console.WriteLine(b + "% of " + a + " = " + c);
}

void Task3()
{
    String text = "";
    for (int i = 0; i < 4; i++)
    {
        Console.Write("Enter digit: ");
        int num = int.Parse(Console.ReadLine()!);
        if (num < 0 || num > 9)
        {
            Console.WriteLine("Entered value is not a digit");
            return;
        }
        text += num;
    }
    Console.WriteLine(text);
}

void Task4()
{
    Console.Write("Enter 6-digit number: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num < 100000 || num > 999999)
    {
        Console.WriteLine("Entered value is not a 6-digit number");
        return;
    }
    String text = num.ToString();
    Console.Write("Enter index of digit to swap from: ");
    int from = int.Parse(Console.ReadLine()!);
    Console.Write("Enter index of digit to swap to: ");
    int to = int.Parse(Console.ReadLine()!);
    if (from < 0 || from > 5 || to < 0 || to > 5)
    {
        Console.WriteLine("Entered index is invalid");
        return;
    }
    char[] strChar = text.ToCharArray();
    strChar[from] = text[to];
    strChar[to] = text[from];
    String newNum = new String(strChar);
    Console.WriteLine("Old number: " + text + "\t\tNew number: " + newNum);


    Console.WriteLine(text);
}

void Task5()
{
    Console.Write("Enter date (dd.mm.yyyy): ");
    string date = Console.ReadLine()!;
    string[] parts = date.Split('.');

    if (parts.Length != 3)
    {
        Console.WriteLine("Invalid date");
        return;
    }

    int day = int.Parse(parts[0]);
    int month = int.Parse(parts[1]);
    int year = int.Parse(parts[2]);

    string season = "";
    if (month == 12 || month == 1 || month == 2)
        season = "Winter";
    else if (month >= 3 && month <= 5)
        season = "Spring";
    else if (month >= 6 && month <= 8)
        season = "Summer";
    else
        season = "Autumn";
    DateTime dateTime = DateTime.Parse(date);

    Console.WriteLine(season + " " + dateTime.DayOfWeek);
}

void Task6() 
{
    Console.Write("Enter temperature: ");
    double temp = double.Parse(Console.ReadLine()!);

    Console.Write("Choose your current temperature format? (C/F): ");
    string choice = Console.ReadLine()!;

    if (choice.ToUpper() == "F")
    {
        double c = (temp - 32) * 5 / 9;
        Console.WriteLine(c + "C");
    }
    else if (choice.ToUpper() == "C")
    {
        double f = temp * 9 / 5 + 32;
        Console.WriteLine(f + "F");
    }
}

void Task7()
{
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Enter first number: ");
    int b = int.Parse(Console.ReadLine()!);

    int start = a;
    int end = b;
    if (a > b)
    {
        start = b;
        end = a;
    }

    Console.WriteLine("Even numbers: ");

    for (int i = start; i <= end; i++)
    {
        if (i % 2 == 0)
            Console.Write(i + " ");
    }
}

//Task1();
//Task2();
//Task3();
//Task4();
//Task5();
//Task6();
//Task7();

//Console.Write("enter your name: ");
//String? name = Console.ReadLine();
//if (String.IsNullOrEmpty(name))
//{
//    Console.WriteLine("bye");
//} 
//else
//{
//    Console.WriteLine("hello, " + name);
//}
//int x;
//System.Int32 y;
//string s1;
//System.String s2;
//float f;  // System.Single
//double g; // System.Double

//Nullable<int> v;
//int? a;

//Console.Write("how old are you? ");
//String ageInput = Console.ReadLine()!;
//int age = int.Parse(ageInput);
//Console.WriteLine("next year you'll be " + (age + 1));

//Console.Write("Previous ages: ");
//for (int i = 0; i < age; i++)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();