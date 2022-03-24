using ConsoleToDoApp.Models;
using System.Linq;

namespace ConsoleToDoApp.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using(var context = new AppDbContext())
            {
                if (context.Cards.Any())
                    return;

                if (context.TeamMembers.Any())
                    return;

                context.Cards.AddRange
                    (
                        new Card()
                        {
                            Id = 1,
                            Title = "Test",
                            Content = "TestContent",
                            Size = SizeEnum.Size.M.ToString(),
                            TeamMemberId = 1,
                            Column = "TODO"
                        },
                        new Card()
                        {
                            Id = 2,
                            Title = "Test1",
                            Content = "TestContent1",
                            Size = SizeEnum.Size.L.ToString(),
                            TeamMemberId = 2,
                            Column = "TODO"
                        },
                        new Card()
                        {
                            Id = 3,
                            Title = "Test3",
                            Content = "TestContent3",
                            Size = SizeEnum.Size.XS.ToString(),
                            TeamMemberId = 3,
                            Column = "INPROGRESS"
                        }
                    );

                context.SaveChanges();

                context.TeamMembers.AddRange
                    (
                        new TeamMember
                        {
                            Id = 1,
                            Name = "TestName",
                            Surname = "TestSurname"
                        },
                        new TeamMember
                        {
                            Id = 2,
                            Name = "TestName1",
                            Surname = "TestSurname1"
                        },
                        new TeamMember
                        {
                            Id = 3,
                            Name = "TestName2",
                            Surname = "TestSurname2"
                        }
                    );

                context.SaveChanges();
            }
        }
    }
}
