using ConsoleToDoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleToDoApp.Application.CardOperations
{
    public class GetCardsQuery
    {
        public static void Handle(List<Card> cards) 
        {
            List<Card> toDo = cards.Where(x => x.Column == "TODO").ToList();

            if(toDo.Any())
            {
                Console.WriteLine("________");
                Console.WriteLine("| TODO | ");
                foreach (var card in toDo)
                {
                    PrintCard(card);
                }
            }

            List<Card> inProgress = cards.Where(x => x.Column == "INPROGRESS").ToList();

            if (inProgress.Any())
            {
                Console.WriteLine("_______________");
                Console.WriteLine("| IN PROGRESS |");
                foreach (var card in inProgress)
                {
                    PrintCard(card);
                }
            }

            List<Card> done = cards.Where(x => x.Column == "DONE").ToList();

            if (done.Any())
            {
                Console.WriteLine("________");
                Console.WriteLine("| DONE |");
                foreach (var card in done)
                {
                    PrintCard(card);
                }
            }

        }

        public static void PrintCard(Card card)
        {
            Console.WriteLine($"_______________________________________________");
            Console.WriteLine($"Başlık        : {card.Title}");
            Console.WriteLine($"İçerik        : {card.Content}");
            Console.WriteLine($"Büyüklük      : {card.Size}");
            Console.WriteLine($"Takım Üyesi ID: {card.TeamMemberId}");
            Console.WriteLine($"_______________________________________________");
        }
    }
}
