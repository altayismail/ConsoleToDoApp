using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleToDoApp.Models
{
    public class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Size { get; set; }
        public string Column { get; set; } = "TODO";
        public int TeamMemberId { get; set; }
    }
}
