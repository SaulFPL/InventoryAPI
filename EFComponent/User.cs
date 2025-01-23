using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComponent
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserNames { get; set; }
        public string UserLastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long UserPhone { get; set; }
        public bool UserStatus { get; set; }
    }
}
