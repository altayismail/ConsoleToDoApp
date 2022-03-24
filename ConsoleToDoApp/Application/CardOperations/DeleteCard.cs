using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoApp.Application.CardOperations
{
    public class DeleteCard
    {
        public static void Handle(List<Card> cards)
        {
            while (true)
            {
                Console.Write("Silmek istediğiniz kartın başlığı: ");
                var title = Console.ReadLine();

                if(cards.Any(x => x.Title == title))
                {
                    cards.Remove(cards.Where(x => x.Title == title).SingleOrDefault());
                    Console.WriteLine("Kart başarılı bir şekilde silindi.");
                    break;
                }
                else
                {
                    Console.WriteLine("İlgili kart bulunamadı.");
                    Console.Write("Silme işlemini sonlandırmak için (1)\n" +
                                       "Yeniden denemek için (2)\n" +
                                       "Seçim: ");
                    var choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                        break;
                    else if (choice == 2)
                        continue;

                }

            }
        }
    }
}
