using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }
        [DisplayName("Type Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} have to be fill.")]
        public string TypeName { get; set; }
    }
}
