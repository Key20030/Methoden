using System;

namespace Methoden
{
    class Program
    {
        
            public static void Main()
            {
                Console.WriteLine("geben sie ein text ein");
                string eingabe_string = Console.ReadLine();
                int anzahl = 0;
                bool flag;
                do

                {
                    flag = false;
                    Console.WriteLine("geben sie eine Zahl ein");
                    try
                    {




                        anzahl = Convert.ToInt32(Console.ReadLine());




                    }
                    catch
                    {
                        Console.WriteLine("Fehler");
                        Console.Clear();
                        flag = true;

                    }

                } while (flag);

                anzahl = ausgabeTextMalX(eingabe_string, anzahl);


                Console.Write("\nAnzahlder Buchstaben: {0}", anzahl);
                static int ausgabeTextMalX(string text, int anzahl1)
                {
                    int t = 0;
                    int e = 0;

                    t = text.Length;
                    e = anzahl1;

                    e *= t;
                    Console.WriteLine(e);
                    for (int i = 0; i < anzahl1; i++)
                    {


                        Console.WriteLine(text);


                    }
                    anzahl1 = e;
                    Console.WriteLine(anzahl1);
                    return anzahl1;

                }
            }

        }
    }



