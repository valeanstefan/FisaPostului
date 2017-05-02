using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisaPostului.Domain.Repository
{
    public interface IProgramManager:IBaseManager
    {
        ProgramDto GetById(int id);
        void Update(ProgramDto program);
        void Delete(int id);
        ProgramDto Insert(ProgramDto program);
        List<Program> GetAllUsers();
        List<ProgramDto> GetAllDtos();
    }
}
