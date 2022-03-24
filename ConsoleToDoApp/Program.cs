using ConsoleToDoApp.Application.CardOperations;
using ConsoleToDoApp.DBOperations;
using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            AppDbContext context = new();
            List<Card> cards = context.Cards.ToList<Card>();
            List<TeamMember> teamMembers = context.TeamMembers.ToList<TeamMember>();

            while (true)
            {
                MenuScript();
                switch (MakeChoice())
                {
                    case 1:
                        GetCardsQuery.Handle(cards);
                        break;
                    case 2:
                        CreateCard.Handle(teamMembers, cards);
                        Console.WriteLine("Kart başarlı bir şekilde TODO kolonuna eklendi.");
                        break;
                    case 3:
                        DeleteCard.Handle(cards);
                        break;
                    case 4:
                        UpdateCard.Handle(cards);
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem yaptınız, tekrar deneyiniz.");
                        break;
                }
            }
        }

        public static int MakeChoice()
        {
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static void MenuScript()
        {
            string menuScript = 
                                "*******************************************\n" +
                                "(1) Board Listelemek\n" +
                                "(2) Board'a Kart Eklemek\n" +
                                "(3) Board'dan Kart Silmek\n" +
                                "(4) Board'da Kart Taşı\n" +
                                "*******************************************\n" +
                                "Lütfen yapmak istediğiniz işlemi seçiniz   : ";
            Console.Write(menuScript);
        }
    }
}
