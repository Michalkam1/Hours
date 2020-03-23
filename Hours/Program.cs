using System;
namespace Akcesory
{
    class Hours
    {
        private int hour;    // ta zmienna posiada właściwość
        private string suffix;

        public int Hour     // Definicja właściwość
        {
            get
            { return hour; }
            set
            {
                if (value >= 0 && value <= 24)
                {
                    
                   if (value >= 12)
                    {
                        hour = value-12;
                        suffix = "pm";
                    }
                    else
                    {
                        hour = value;
                        suffix = "am";
                    }
                }
            }
        }

        public override string ToString()
        { return "Godzina " + hour + ":" + suffix; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hours godz = new Hours();
            Console.Write("Podaj godzinę: ");
            try
            {
                godz.Hour = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Nieprawidłowy Format godziny");
                
            }
            
            // godz.Hour = 1; //dostęp do zmiennej prywatnej poprzez właściwość
                           //przypisanie możliwe dzięki sekcji set we własności Hour
            Console.WriteLine(godz);
            //sekcja set nie tylko umożliwia bezpośredni dostęp do zmiennej 
            //prywatnej hour, ale sprawuje kontrolę nad jej zakresem i 
            //pozwala ustalić wartości innych zmiennych prywatnych
            Console.ReadKey();
        }
    }
}
