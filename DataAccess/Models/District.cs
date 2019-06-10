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
    [Table("TB_M_District")]
    public class District : BaseModel
    {
        public string Name { get; set; }
        public int Regency_Id { get; set; }

        [ForeignKey("Regency_Id")]
        public virtual Regency Regency { get; set; }

        public District() { }

        public District(DistrictVM districtVM)
        {
            this.Name = districtVM.Name;
            this.Regency_Id = districtVM.Regency_Id;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public virtual void Update(DistrictVM districtVM)
        {
            this.Name = districtVM.Name;
            this.Regency_Id = districtVM.Regency_Id;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
