using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_UserRole")]
    public class UserRole : BaseModel
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }

        [ForeignKey("User_Id")]
        public virtual User User { get; set; }
        [ForeignKey("Role_Id")]
        public virtual Role Role { get; set; }
    }
}
