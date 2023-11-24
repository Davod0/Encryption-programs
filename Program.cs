internal class Program
{
    private static void Main(string[] args)
    {

    }

    static void EncryptingWordToNumber()  // Ett program som skriver ut ASC|| för varje bokstav i ett ord eller mening som matas in
    {
        Console.Write("Enter the word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            int x = (int)word[i];
            //int x = word[i];  Oxå rätt    // Här görs casting (int)word[i] då kastar man variabeln som lagras i word till int men egentligen det behövs inte för att skriva ut ASC|| värdet för string varibeln, det funkar bara med word[i].
            //Console.Write(x);           // man kan bara skriva int x = word[i]; och det funkar, eftrsom word är bara en string variabel men om det hade varit en lista elle array då det kommer inte att funka på så sättet att skriva ut ASC|| värdet på en sting i en lista eller array .
            Console.WriteLine(x);         // string[] Name = { "a", "b", "c" };   Console.WriteLine((int)(Name[0])); FEL
                                          // List<string> list = new List<string> { "a", "b", "c" };     Console.WriteLine((int)list[0]); FEL                 
                                          //  string stäng = "h"  int x = (int)sträng[h];  Console.WriteLine(H);  svar = 104. RÄTT


        }

    }



    static void Caesar_kryptering()  // Kryptering program, 
    {

        Console.Write("Mata in ett ord: ");
        string word = Console.ReadLine();
        Console.Write("Mata in ett heltal:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        foreach (char i in word)  // Lösning 1
        {
            int b = i + number;
            Console.Write((char)b);
        }

        Console.WriteLine("\n");


        for (int i = 0; i < word.Length; i++)  // Lösning 2
        {
            int a = (int)word[i] + number;  // Adderar värdet som är lagrad i variabeln word med number
                                            //int a = word[i] + number;
            Console.Write((char)a);   // Casting int to char ASC||

            //Console.WriteLine((char)(word[i] + number));  
        }
    }




    static void CastingStringToInt()
    {
        string sträng = "h";       // Här skapas en string variabel och  varje bokstav/tecken har ett värde tillexempel värdet för h är 104
        int x = (int)sträng[0];   // Här skaps en int variabel x och kastar man string variabeln sträng till en int för att sedan använda sig av [] och komma åt värdet som h har.
        Console.WriteLine(x);    // Här blir x = 104



        string sträng_1 = "hel";
        int b = sträng_1[0];
        int c = sträng_1[1];
        int d = sträng_1[2];
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}