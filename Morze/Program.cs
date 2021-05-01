using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    
    class Program
    {
        public static string[] tableMorze = new string[] { ".-", "-...", ".--", "--.",
                                                        "-..", ".", "...-", "--..",
                                                        "..", ".---", "-.-", ".-..",
                                                        "--", "-.", "---", ".--.",
                                                        ".-.", "...", "-", "..-",
                                                        "..-.", "....", "-.-.",
                                                        "---.", "----", "--.-", "--.--",
                                                        "-.--", "-..-", "..-..",
                                                        "..--", ".-.-", ".----",
                                                        "..---", "...--", "....-",
                                                        ".....", "-....", "--...",
                                                        "---..", "----.", "-----"
        };
        public static string[] alphabet = new string[] { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И",
                                                        "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С",
                                                        "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ","Ъ", "Ы", "Ь",
                                                        "Э", "Ю", "Я", "1", "2", "3", "4", "5", "6", "7",
                                                        "8", "9", "0"
        };
        public static string endMessage = "Сообщение: ";
        static string Decoder(string enter)
        {
            string[] message = enter.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j <= 40; j++)
                {
                    if (message[i] == tableMorze[j])
                    {
                        endMessage += alphabet[j];
                    }
                }
            }
            return endMessage;
        }
        static string Coder(string enter)
        {
            char[] message = enter.ToUpper().ToArray();

            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j <= 40; j++)
                {
                    if (Convert.ToString(message[i]) == alphabet[j])
                    {
                        endMessage += tableMorze[j] + " ";
                    }
                }
            }
            return endMessage;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите инструмент:\n[1] - Кодер\n[2] - Декодер\n[Exit] - Выход");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("/Введите сообщение на русском языке/\n");
                    string enter = Console.ReadLine();
                    Console.WriteLine(Coder(enter));
                    endMessage = "Сообщение: ";
                    Console.WriteLine("_____________________________________");
                }
                else if (choice == "2")
                {

                    Console.WriteLine("/Введите код морзе/\n");
                    string enter = Console.ReadLine();
                    Console.WriteLine(Decoder(enter));
                    endMessage = "Сообщение: ";
                    Console.WriteLine("_____________________________________");
                }
                else
                {
                    Console.WriteLine("Такого инструмента нет");
                }
            }
        }
    }
}
