using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleToDoApp.Models
{
    public class TeamMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
