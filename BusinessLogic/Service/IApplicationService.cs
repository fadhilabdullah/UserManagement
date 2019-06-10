using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogic.Service
{
    public interface IApplicationService
    {
        List<Aplication> Get();
        List<Aplication> GetSearch(string values);
        Aplication Get(int Id);
        bool Insert(ApplicationVM aplicationVM);
        bool Update(int id, ApplicationVM aplicationVM);
        bool Delete(int id);
    }
}
