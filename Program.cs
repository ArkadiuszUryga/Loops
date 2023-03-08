
using Loops;
using System.Reflection.Emit;


internal class Program
{
    private static readonly char[] _allowedCharacters = new char[10]
        {
    '0','1','2','3','4','5','6','7','8','9'
    };

    private static void Main(string[] args)
    {
        Console.WriteLine("wybierz numer zadania (od 1 do 10)");
        Console.WriteLine("Zadanie1: wypisz liczby od 1 do 100");
        Console.WriteLine("Zadanie2: wypisz liczby od 8 do 50");
        Console.WriteLine("Zadanie3: wypisz liczby parzyste od 2 to 50");
        Console.WriteLine("Zadanie4: wypisz liczby od 100 do 1");
        Console.WriteLine("Zadanie5: wypisz liczby podzielne przez 8 ( w zakresie 1..100)");
        Console.WriteLine("Zadanie6: wypisz liczby podzielne przez 3 lub 5 ( w zakresie 1..100)");
        Console.WriteLine("Zadanie7: wypisz liczby podzielne przez 3 albo 5 ( w zakresie 1..100) (nie wypisuj tych podzielnych jednocześnie przez 3 i 5)");
        Console.WriteLine("Zadanie8: wypisz największą liczbę niepodzielną przez 2,3,5,7 ale mniejszą od 1000");
        Console.WriteLine("Zadanie9: sprawdź czy podana jako parametr liczba jest parzysta");
        Console.WriteLine("Zadanie10: sprawdź czy podana jako parametr liczba jest liczbą pierwszą. (podzielna tylko przez 1 i przez samą siebie)");
        Console.WriteLine("Zadanie11: wylicz największy wspólny dzielnik 2 liczb podanych jako parametry");
        Console.WriteLine("Zadanie12: ile jest liczb pierwszych w zakresie od a do b podanym jako parametry");
        Console.WriteLine("Zadanie13: sprawdź czy pesel ( jako parametr) jest prawidłowym peselem");
    Label:
        int numberFromUser = GetNumberFromUser();
        //Console.WriteLine(numberFromUser);
        Console.WriteLine("Wybrałeś "+numberFromUser);
        switch (numberFromUser)
        {
            case 1:
               
                Class2.Task1();
                break;
            case 2:
               
                Class1.Task2(); break;
            case 3:
                Class3.Task3(); break;
            case 4:
                Class4.Task4(); break;
            case 5:
                Class5.Task5(); break;
            case 6:
                Class6.Task6(); break;
            case 7:
                Class7.Task7(); break;
            case 8:
                Class8.Task8(); break;
            case 9:
                Class9.Task9(); break;
            case 10:
                Class10.Task10(); break;
                case 11:
            Class11.Task11(); break;
                case 12:
            Class12.Task12(); break;
                case 13:
            Class13.Task13(); break;
            default: Console.WriteLine("Wybrałeś zły numer zadania");
           
                goto Label;
                
        }
    }
    public static int GetNumberFromUser()
    {
        Console.WriteLine("Please, provide some number");
        var given=Console.ReadLine();
        if (IsValidNumber(given))
        {
            return int.Parse(given);
        }
        Console.WriteLine("Please, provide Valid Number Bro!");
        return GetNumberFromUser();
        
       
    }
    public static String GetStringFromUser()
    {
        Console.WriteLine("Please, provide some number");
        var given = Console.ReadLine();
        if (IsValidNumber(given))
        {
            return given;
        }
        Console.WriteLine("Please, provide Valid Number Bro!");
        return GetStringFromUser();


    }
    private static bool IsValidNumber(string number)
    {
        return
            number.All(character => _allowedCharacters.Contains(character));
    }
    
}