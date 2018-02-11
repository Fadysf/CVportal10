using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace CVportal
{
    class Program
    {
        static string[] PersonUp = new string[7];
        static int arrayCounter = 0;
        static string namn, efnamn, roll, personBes;
        static string personNr;
        static int Mobil;
        static string email;


        static string desain = "================";

        static void Main(string[] args)
        {

            Console.WriteLine("\n\t\t\t\t\t\tHej och Välkommen");
            Thread.Sleep(3000);
            Console.Clear();
            MenyVal();
        }

        public static void MenyVal()
        {


            bool choose = true;
            while (choose)
            {
                Console.WriteLine(desain);
                Console.WriteLine("CV portal");
                Console.WriteLine(desain);

                Console.WriteLine("1)Skriv in dina uppgifter:\n");
                Console.WriteLine("2)Visa dina uppgifter:\n");
                Console.WriteLine("3)Ändra dina uppgifter:\n");
                Console.WriteLine("4)Spara till fil:\n");
                Console.WriteLine("5)Sök efter Filen:\n");
                Console.WriteLine("6)Avsluta:\n");

                Int32.TryParse(Console.ReadLine(), out int meny);
                if (meny == 0 || meny > 6)
                {
                    Console.WriteLine("Du skrev fel");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                switch (meny)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("\nMata in ditt förnamn:");
                        namn = Console.ReadLine().ToLower();

                        Console.WriteLine("\nMata in ditt efternamn:");
                        efnamn = Console.ReadLine().ToLower();
                        PersonUp[arrayCounter] = "Namn: " + namn + " " + efnamn;
                        arrayCounter++;


                        Console.WriteLine("\nMata in din Roll (tex: IT, bygg mm....... )");
                        roll = Console.ReadLine();
                        PersonUp[arrayCounter] = "Roll: " + roll;
                        arrayCounter++;

                        p:
                        try
                        {

                            Console.WriteLine("\nMata in ditt personnummer(yymmdd-xxxx):");
                            personNr = Console.ReadLine();
                            PersonUp[arrayCounter] = "Persomnummer: " + personNr;
                            arrayCounter++;

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Du skrev fel");
                            arrayCounter--;

                            goto p;


                        }



                        m:
                        try
                        {
                            Console.WriteLine("\nMata in ditt mobilnummer:");
                            Mobil = Convert.ToInt32(Console.ReadLine());
                            PersonUp[arrayCounter] = "Mobilnummer +46" + Mobil;
                            arrayCounter++;

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("du skrev fel");
                            arrayCounter--;

                            goto m;

                        }


                        Console.WriteLine("\nSkriv din mailadress:");
                        email = Console.ReadLine();
                        PersonUp[arrayCounter] = "Email: " + email;
                        arrayCounter++;


                        Console.WriteLine("\nBerätta lite kort om dig själv(mellan 100 och 200 Tecken)");
                        personBes = Console.ReadLine();
                        PersonUp[arrayCounter] = "Personlig Beskrivning: " + personBes;
                        arrayCounter++;

                        stad:
                        Console.WriteLine("\nValj det kontor du vill ansoka till\n" +
                            "1)Stokholm\n" +
                            "2)Uppsala\n" +
                            "3)Göteborg\n" +
                            "4)Gävle\n");

                        Int32.TryParse(Console.ReadLine(), out int kontor);

                        if (kontor == 0 || kontor > 4)
                        {
                            Console.WriteLine("Oj du skrev fel! var god valj nagot av alternativen 1 till 4");
                            Thread.Sleep(2000);
                            goto stad;

                        }

                        switch (kontor)
                        {
                            case 1:

                                PersonUp[arrayCounter] = "Kontor är Stokholm\n";
                                arrayCounter++;

                                break;

                            case 2:
                                PersonUp[arrayCounter] = "Kontor är Uppsala\n";
                                arrayCounter++;

                                break;

                            case 3:
                                PersonUp[arrayCounter] = "Kontor är Göteborg\n";
                                arrayCounter++;

                                break;

                            case 4:
                                PersonUp[arrayCounter] = "Kontor är Gävle\n";
                                arrayCounter++;

                                break;



                        }

                        Console.WriteLine("Vi har nu tagit emot din information tack for din tid!\n Tillbaka till meny\n");
                        Thread.Sleep(2000);



                        break;


                    case 2:

                        if (string.IsNullOrWhiteSpace(namn))
                        {
                            //om användare har inte regsterat någon än
                            Console.WriteLine("Du har inte registrerat något ännu");
                            Thread.Sleep(3000);
                            Console.Clear();
                            MenyVal();
                        }

                        Console.Clear();
                        Console.WriteLine(desain);
                        foreach (object listarry in PersonUp)
                        {

                            Console.WriteLine(listarry);


                        }
                        Console.WriteLine(desain);

                        break;

                    case 3:

                        if (string.IsNullOrWhiteSpace(namn))
                        {
                            //om användare har inte regsterat någon än
                            Console.WriteLine("Du har inte registrerat något ännu");
                            Thread.Sleep(4000);
                            Console.Clear();
                            MenyVal();
                        }
                        Console.WriteLine(desain);
                        Console.WriteLine("Vad vill du ändra?\n" +
                        "1: Namn och efternamn\n" +
                        "2: Roll\n" +
                        "3: personnummer\n" +
                        "4: mobil\n" +
                        "5: mail\n" +
                        "6: Om du vill ändra nagot i ditt personliga meddelande\n" +
                        "7: kontoret\n");
                        Console.WriteLine(desain);
                        
                        Int32.TryParse(Console.ReadLine(), out int lillaMeny);

                        try
                        {

                        
                        
                        switch (lillaMeny)
                        {
                            
                            
                            case 1:
                                Console.WriteLine("\nSkriv ditt förnamn");
                                namn = Console.ReadLine();
                                Console.WriteLine("Skriv ditt efternamn");
                                efnamn = Console.ReadLine();
                                PersonUp[0] = "Namn: " + namn + " " + efnamn;
                                break;
                            case 2:

                                Console.WriteLine("\nSkriv din roll");
                                roll = Console.ReadLine();
                                PersonUp[1] = "Roll: " + roll;
                                break;
                            case 3:

                                Console.WriteLine("\nSkriv ditt personnummer");
                                personNr = Console.ReadLine();
                                PersonUp[2] = "Persomnummer: " + personNr;
                                break;
                            case 4:
                                Console.WriteLine("\nSkriv ditt mobil nummer");
                                Mobil = int.Parse(Console.ReadLine());
                                PersonUp[3] = "Mobilnummer +46 " + Mobil;
                                break;
                            case 5:
                                Console.WriteLine("\nSkriv din Email");
                                email = Console.ReadLine();
                                PersonUp[4] = "Email: " + email;

                                break;
                            case 6:
                                Console.WriteLine("\nByta texten");
                                personBes = Console.ReadLine();
                                PersonUp[5] = "Personlig Beskrivning: " + personBes;
                                break;

                            case 7:

                                Console.WriteLine("\nSkriv vilken stad:");
                                string Stadkonto;
                                Stadkonto = Console.ReadLine();
                                PersonUp[6] = "\nStad: " + Stadkonto;
                                break;



                        }

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("du skrev något som inte stämmer försök igen");
                            Thread.Sleep(4000);
                            goto case 3;
                        }
                        break;

                    case 4:

                        //copy array till fil genom att dela på array index
                        Console.WriteLine(desain);
                        string path = "D:\\Map\\" + namn + " " + efnamn + ".txt";
                        StreamWriter file = new StreamWriter(path, true);
                        file.WriteLine(PersonUp[0]);
                        file.WriteLine(PersonUp[1]);
                        file.WriteLine(PersonUp[2]);
                        file.WriteLine(PersonUp[3]);
                        file.WriteLine(PersonUp[4]);
                        file.WriteLine(PersonUp[5]);
                        file.WriteLine(PersonUp[6]);
                        file.Close();

                        Console.WriteLine("Dina uppgifter är nu sparade i var portal.");
                        //rensa array och array konter 
                        arrayCounter = 0;
                        Array.Clear(PersonUp, 0, PersonUp.Length);
                        namn = "";
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case 5:

                        Console.WriteLine(desain);
                        Console.WriteLine("Sök med ditt förnamn och efternamn:");
                        string toSearch;
                        toSearch = Console.ReadLine().ToLower().Trim();

                        Boolean sök = false;



                        if (File.Exists("D:\\Map\\" + toSearch + ".txt"))
                        {
                            sök = true;
                            Console.Clear();
                            Console.WriteLine("Filen finns");
                            Console.WriteLine(desain);
                            using (StreamReader sr = new StreamReader("D:\\Map\\" + toSearch + ".txt"))
                            {
                                // Read the stream to a string, and write the string to the console.
                                String line = sr.ReadToEnd();
                                Console.WriteLine(line);
                            }
                            Console.WriteLine(desain);
                            Thread.Sleep(4000);

                        }

                        if (sök == false)

                        {
                            Console.WriteLine(desain);
                            Console.WriteLine("Filen finns inte");
                            Console.WriteLine(desain);

                            Thread.Sleep(3000);
                            Console.Clear();
                            MenyVal();
                        }
                        

                        break;

                    case 6:
                        Console.WriteLine("Tack & hej");
                        Thread.Sleep(4000);

                        return;

                        
                }


            }



        }
    }
}
