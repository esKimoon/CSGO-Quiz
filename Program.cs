using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSGO_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufruf von _StartGame
            Game._StartGame();
            //Aufruf von _Fragen
            Game._Fragen();
            //Aufruf von _EndScore
            Game._EndScore();
        }
    }
    public static class Game
    {
        //Verwendete Variablen
        static string PlayerName;
        static string Antwort;
        static int AnzahlFragenGesamt = 10;
        static int Frage = 1;
        static int Score = 0;

        public static void _StartGame()
        {
            //Titel der Konsolenanwendung
            Console.Title = "CSGO Quiz";
            //Benennung der Farbe
            Console.ForegroundColor = ConsoleColor.White;
            _PlayerName();
            _Einleitung();
        }
        static void _Einleitung()
        {
            //Löschen des aktuellen Inhalts
            _Clear();
            //Einfügen des ASCII Text
            _AsciiHintergrund();
            //PlayerName Ausgabe
            Console.WriteLine("\nHallo " + PlayerName);
            //Ein kleiner Text für die Einleitung
            Console.WriteLine("\nEin kleines CS:GO Quiz.\n" +
                "\nBeantworte die Fragen mit '1' '2' '3'.\n");
            Console.WriteLine("Um mit dem Quiz zu beginnen, drücke die 'Enter' Taste.\n");
            //Warten auf Enter Eingabe
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            //Löschen des aktuellen Inhalts
            _Clear();
        }
        static void _PlayerName()
        {
            //Einfügen des ASCII Text
            _AsciiHintergrund();
            //PlayerName Abfrage
            Console.WriteLine("\nBitte nenne uns deinen Namen:");
            //PlayerName Eingabe
            PlayerName = Console.ReadLine();
        }
        static void _AsciiHintergrund()
        {
            Console.WriteLine(@"
   _____  _____  _____  ____  
  / ____|/ ____|/ ____|/ __ \ 
 | |    | (___ | |  __| |  | |
 | |     \___ \| | |_ | |  | |
 | |____ ____) | |__| | |__| |
  \_____|_____/ \_____|\____/ 
  / __ \| |  | |_   _|___  /  
 | |  | | |  | | | |    / /   
 | |  | | |  | | | |   / /    
 | |__| | |__| |_| |_ / /__   
  \___\_\\____/|_____/_____| 
");
        }
        public static void _Fragen()
        {
            //Frage 1
            _Ablauf1();
            _Frage1();
            _Ablauf2();

            //Frage 2
            _Ablauf1();
            _Frage2();
            _Ablauf2();

            //Frage 3
            _Ablauf1();
            _Frage3();
            _Ablauf2();

            //Frage 4
            _Ablauf1();
            _Frage4();
            _Ablauf2();

            //Frage 5
            _Ablauf1();
            _Frage5();
            _Ablauf2();

            //Frage 6
            _Ablauf1();
            _Frage6();
            _Ablauf2();

            //Frage 7
            _Ablauf1();
            _Frage7();
            _Ablauf2();

            //Frage 8
            _Ablauf1();
            _Frage8();
            _Ablauf2();

            //Frage 9
            _Ablauf1();
            _Frage9();
            _Ablauf2();

            //Frage 10
            _Ablauf1();
            _Frage10();
            _Ablauf2();
        }
        static void _FragenNr()
        {
            Console.WriteLine("\nFrage " + Frage + "\n----------\n");
        }
        static void _Frage1()
        {
            Console.WriteLine(Frage1[0] + "\n" + Frage1[1] + "\n" + Frage1[2] + "\n" + Frage1[3] + "\n");
            _Auswertung1();
        }
        static void _Frage2()
        {
            Console.WriteLine(Frage2[0] + "\n" + Frage2[1] + "\n" + Frage2[2] + "\n" + Frage2[3] + "\n");
            _Auswertung3();
        }
        static void _Frage3()
        {
            Console.WriteLine(Frage3[0] + "\n" + Frage3[1] + "\n" + Frage3[2] + "\n" + Frage3[3] + "\n");
            _Auswertung3();
        }
        static void _Frage4()
        {
            Console.WriteLine(Frage4[0] + "\n" + Frage4[1] + "\n" + Frage4[2] + "\n" + Frage4[3] + "\n");
            _Auswertung2();
        }
        static void _Frage5()
        {
            Console.WriteLine(Frage5[0] + "\n" + Frage5[1] + "\n" + Frage5[2] + "\n" + Frage5[3] + "\n");
            _Auswertung2();
        }
        static void _Frage6()
        {
            Console.WriteLine(Frage6[0] + "\n" + Frage6[1] + "\n" + Frage6[2] + "\n" + Frage6[3] + "\n");
            _Auswertung3();
        }
        static void _Frage7()
        {
            Console.WriteLine(Frage7[0] + "\n" + Frage7[1] + "\n" + Frage7[2] + "\n" + Frage7[3] + "\n");
            _Auswertung3();
        }
        static void _Frage8()
        {
            Console.WriteLine(Frage8[0] + "\n" + Frage8[1] + "\n" + Frage8[2] + "\n" + Frage8[3] + "\n");
            _Auswertung1();
        }
        static void _Frage9()
        {
            Console.WriteLine(Frage9[0] + "\n" + Frage9[1] + "\n" + Frage9[2] + "\n" + Frage9[3] + "\n");
            _Auswertung3();
        }
        static void _Frage10()
        {
            Console.WriteLine(Frage10[0] + "\n" + Frage10[1] + "\n" + Frage10[2] + "\n" + Frage10[3] + "\n");
            _Auswertung1();
        }
        static void _Richtig()
        {
            //Wenn Antwort Richtig
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nRichtig\n");
            Console.ForegroundColor = ConsoleColor.White;
            Score++;
            Frage++;
            Console.Beep(500, 100);
            Console.Beep(700, 100);
            Console.Beep(900, 100);
            Console.Beep(1000, 300);
        }
        static void _Falsch()
        {
            //Wenn Antwort Falsch
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nFalsch\n");
            Console.ForegroundColor = ConsoleColor.White;
            Frage++;
            Console.Beep(900, 100);
            Console.Beep(600, 300);
        }
        static void _Auswertung1()
        {
            do
            {
                Antwort = Console.ReadLine();
                if (Antwort == "1")
                {
                    _Richtig();
                    break;
                }
                else if (Antwort == "2" || Antwort == "3")
                {
                    _Falsch();
                    break;
                }
                else if (Antwort != "1" || Antwort != "2" || Antwort != "3")
                {
                    Console.WriteLine(Ungueltig[0]);
                }
            } while (true);
        }
        static void _Auswertung2()
        {
            do
            {
                Antwort = Console.ReadLine();
                if (Antwort == "2")
                {
                    _Richtig();
                    break;
                }
                else if (Antwort == "1" || Antwort == "3")
                {
                    _Falsch();
                    break;
                }
                else if (Antwort != "1" || Antwort != "2" || Antwort != "3")
                {
                    Console.WriteLine(Ungueltig[0]);
                }
            } while (true);
        }
        static void _Auswertung3()
        {
            do
            {
                Antwort = Console.ReadLine();
                if (Antwort == "3")
                {
                    _Richtig();
                    break;
                }
                else if (Antwort == "1" || Antwort == "2")
                {
                    _Falsch();
                    break;
                }
                else if (Antwort != "1" || Antwort != "2" || Antwort != "3")
                {
                    Console.WriteLine(Ungueltig[0]);
                } 
            } while (true) ;
        }
        static void _PlayerScore()
        {
            Console.WriteLine("\n" + PlayerName + ", du hast " + Score + " Punkte\n");
        }
        static void _Timer()
        {
            System.Threading.Thread.Sleep(800);
        }
        static void _Clear()
        {
            Console.Clear();
        }
        static void _Ablauf1()
        {
            _AsciiHintergrund();
            _PlayerScore();
            _FragenNr();
        }
        static void _Ablauf2()
        {
            _Timer();
            _Clear();
        }
        public static void _EndScore()
        {
            int Endscore = 100 / AnzahlFragenGesamt * Score;
            _AsciiHintergrund();
            //Ausgabe des EndScore
            Console.WriteLine(PlayerName + ", Du hast " + Endscore + "% der Fragen richtig beantwortet.\n");
            if (Endscore <= 30)
            {
                Console.WriteLine("Noob...");
            }
            else if (Endscore <= 70)
            {
                Console.WriteLine("Das könnte besser sein...");
            }
            else if (Endscore <= 90)
            {
                Console.WriteLine("Gar nicht so überl... Gut gemacht...");
            }
            else if (Endscore == 100)
            {
                Console.WriteLine("Voll Pro");
            }
            Console.WriteLine("\nZum beenden drücke 'Enter'...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            Environment.Exit(0);
        }

        //Array Fragen mit Antworten
        static string[] Frage1 =
            {
            // 0 //Frage
            "If you Play CS:GO, you just say...",
            // 1 //Antwort 1
            "1. ...rush B and go",
            // 2 //Antwort 2
            "2. ..., go A and Play",
            // 3 //Antwort 3
            "3. ...what?!",
            };
        static string[] Frage2 =
        {
            // 0 //Frage
            "Welches ist die meistgespielte Map?",
            // 1 //Antwort 1
            "1. de_Mirage",
            // 2 //Antwort 2
            "2. cs_Office",
            // 3 //Antwort 3
            "3. de_Dust2",
        };
        static string[] Frage3 =
        {
            // 0 //Frage
            "In welchem Land liegt die Map 'Overpass'?",
            // 1 //Antwort 1
            "1. Italien",
            // 2 //Antwort 2
            "2. Ungarn",
            // 3 //Antwort 3
            "3. Deutschland",
        };
        static string[] Frage4 =
        {
            // 0 //Frage
            "Welches Team gewann die IEM 2019?",
            // 1 //Antwort 1
            "1. FAZE",
            // 2 //Antwort 2
            "2. ASTRALIS",
            // 3 //Antwort 3
            "3. ENCE",
        };
        static string[] Frage5 =
        {
            // 0 //Frage
            "Welcher der folgenden Waffen kann einen '1Shot Headshot' ausführen?",
            // 1 //Antwort 1
            "1. AUG",
            // 2 //Antwort 2
            "2. AK47",
            // 3 //Antwort 3
            "3. M4A4",
        };
        static string[] Frage6 =
        {
            // 0 //Frage
            "Wie viele Waffen haben eine Scope-Funktion?",
            // 1 //Antwort 1
            "1. 3",
            // 2 //Antwort 2
            "2. 5",
            // 3 //Antwort 3
            "3. 6",
        };
        static string[] Frage7 =
        {
            // 0 //Frage
            "Wie hiess die erste Operation in CS:GO?",
            // 1 //Antwort 1
            "1. Hydra",
            // 2 //Antwort 2
            "2. Bravo",
            // 3 //Antwort 3
            "3. Payback",
        };
        static string[] Frage8 =
        {
            // 0 //Frage
            "Welche Map erhielt als letztes ein umfangreiches Update?",
            // 1 //Antwort 1
            "1. Dust2",
            // 2 //Antwort 2
            "2. Cache",
            // 3 //Antwort 3
            "3. Mirage",
        };
        static string[] Frage9 =
        {
            // 0 //Frage
            "Wie viel Zeit hat man, die Bombe zu entschärfen?",
            // 1 //Antwort 1
            "1. 35 Sek",
            // 2 //Antwort 2
            "2. 40 Sek",
            // 3 //Antwort 3
            "3. 45 Sek",
        };
        static string[] Frage10 =
        {
            // 0 //Frage
            "Durch was wurde die Pizzeria in Dust2 ersetzt?",
            // 1 //Antwort 1
            "1. Zahnarzt",
            // 2 //Antwort 2
            "2. Autohändler",
            // 3 //Antwort 3
            "3. Restaurant",
        };
        static string[] Ungueltig =
        {
            "\nDas ist eine ungueltige Eingabe...\n"
        };
    }
}