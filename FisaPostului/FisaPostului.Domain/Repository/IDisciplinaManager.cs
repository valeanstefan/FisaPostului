using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisaPostului.Domain.Repository
{
    public interface IDisciplinaManager:IBaseManager
    {
        DisciplinaDto GetById(int id);
        void Update(DisciplinaDto disciplina);
        void Delete(int id);
        DisciplinaDto Insert(DisciplinaDto disciplina);
        List<Disciplina> GetAll();
        List<DisciplinaDto> GetAllDtos();
    }
}
