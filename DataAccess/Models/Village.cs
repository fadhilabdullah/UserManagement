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
    [Table("TB_M_Village")]
    public class Village : BaseModel
    {
        public string Name { get; set; }
        public int District_Id { get; set; }

        [ForeignKey("District_Id")]
        public virtual District District { get; set; }

        public Village() { }

        public Village(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.District_Id = villageVM.District_Id;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public virtual void Update(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.District_Id = villageVM.District_Id;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
