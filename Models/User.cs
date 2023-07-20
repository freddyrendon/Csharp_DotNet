using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("users")]
    public class User
    {
        [column("id")]
        public int Id { get; set; }

        [column("name")]
        public string Name { get; set; }

        [column("email")]
        public string Email { get; set; }

    }
}