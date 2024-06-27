using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DUT_Values.Models
{
    public class DUTValue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DUTValueId { get; set; }
        [Required]
        public string DUTValueName { get; set; }
    }
}
