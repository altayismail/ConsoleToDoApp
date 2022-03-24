using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoApp.Application.CardOperations
{
    public class UpdateCard
    {
        public static void Handle(List<Card> cards)
        {
            Console.Write("Taşımak istediğiniz kartın başlığını giriniz: ");
            string title = Console.ReadLine();

            Card card = cards.Where(x => x.Title.ToLowerInvariant() == title.ToLowerInvariant()).Single();

            if(card is not null)
            {
                Console.WriteLine("Taşımak istediğiniz kart bilgileri:");
                PrintCard(card);
                Console.WriteLine("Taşımak istediğiniz line'ı seçiniz.");
                Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                try
                {
                    Console.Write("Seçim: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                        card.Column = "TODO";
                    else if (choice == 2)
                        card.Column = "INPROGRESS";
                    else if (choice == 3)
                        card.Column = "DONE";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata : " + ex.Message);
                } 
            }
            else
            {
                Console.WriteLine("Aradığınız kart bulunamadı.");
            }
        }

        public static void PrintCard(Card card)
        {
            Console.WriteLine($"_______________________________________________");
            Console.WriteLine($"Başlık        : {card.Title}");
            Console.WriteLine($"İçerik        : {card.Content}");
            Console.WriteLine($"Büyüklük      : {card.Size}");
            Console.WriteLine($"Takım Üyesi ID: {card.TeamMemberId}");
            Console.WriteLine($"Bulunduğu Line: {card.Column}");
            Console.WriteLine($"_______________________________________________");
        }
    }
}
