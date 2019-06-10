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
    [Table("TB_M_Regency")]
    public class Regency : BaseModel
    {
        public string Name { get; set; }
        public int Province_Id { get; set; }

        [ForeignKey("Province_Id")]
        public virtual Province Province { get; set; }

        public Regency() { }

        public Regency(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.Province_Id = regencyVM.Province_Id;
            this.CreateDate = DateTime.Now.ToLocalTime();
            this.UpdateDate = DateTime.Now.ToLocalTime();
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }

        public virtual void Update(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.Province_Id = regencyVM.Province_Id;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
