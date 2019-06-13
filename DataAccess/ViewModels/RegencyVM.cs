using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RegencyVM
    {
        public RegencyVM(string name)
        {
            this.Name = name;
        }

        public RegencyVM() { }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Province_Id { get; set; }
    }
}
