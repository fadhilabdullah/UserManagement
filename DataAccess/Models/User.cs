using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_User")]
    public class User : BaseModel
    {
        public string Password { get; set; }
        public string LoginStatus { get; set; }

        [ForeignKey("Employee")]
        public int Employee_Id { get; set; }
        public virtual Employee Employee { get; set; }

        public User() { }

        public User(UserVM userVM)
        {
            this.Password = userVM.Password;
            this.LoginStatus = userVM.LoginStatus;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public virtual void Update(UserVM userVM)
        {
            this.Password = userVM.LoginStatus;
            this.LoginStatus = userVM.LoginStatus;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
