using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleToDoApp.Models.SizeEnum;

namespace ConsoleToDoApp.Application.CardOperations
{
    public static class CreateCard
    {
        public static void Handle(List<TeamMember> teamMembers, List<Card> cards)
        {
            Card card = new();

            Console.Write("Başlık Giriniz                                       : ");
            var title = Console.ReadLine();
            card.Title = title;

            Console.Write("İçerik Giriniz                                       : ");
            var content = Console.ReadLine();
            card.Content = content;

            try
            {
                Console.Write("Büyüklük Seçiniz, 1-(XS) 2-(S) 3-(M) 4-(L) 5-(XL)    : ");
                var size = int.Parse(Console.ReadLine());
                card.Size = Enum.GetName(typeof(Size), size);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            while (true)
            {
                try
                {
                    Console.Write("Kişi Seçiniz (Id ile)                                : ");
                    var memberId = int.Parse(Console.ReadLine());

                    if (teamMembers.Any(x => x.Id == memberId))
                    {
                        card.TeamMemberId = memberId;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("İlgili takım üyesi bulunamadı, tekrar deneyiniz.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                
            }

            cards.Add(card);
        }
    }
}
