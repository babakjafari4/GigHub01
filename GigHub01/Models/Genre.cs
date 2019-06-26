using System.ComponentModel.DataAnnotations;

namespace GigHub01.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}