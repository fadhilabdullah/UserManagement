using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_EmpApplication")]
    public class EmpApplication : BaseModel
    {
        public int Employee_Id { get; set; }
        public int Application_Id { get; set; }

        [ForeignKey("Employee_Id")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Application_Id")]
        public virtual Aplication Aplication { get; set; }
    }
}
