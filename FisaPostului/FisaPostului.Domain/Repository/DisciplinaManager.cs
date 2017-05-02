using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using Omu.ValueInjecter;

namespace FisaPostului.Domain.Repository
{
    public class DisciplinaManager : IDisciplinaManager
    {
        private readonly IRepository<Disciplina> _disciplinaRepository;

        public DisciplinaManager(IRepository<Disciplina> disciplinaManager)
        {
            _disciplinaRepository = disciplinaManager;
        }

        public void Delete(int id)
        {
            Disciplina disciplinaModel = _disciplinaRepository.Find(id);
            _disciplinaRepository.Delete(disciplinaModel);
            _disciplinaRepository.SaveChanges();
        }

        public void Dispose()
        {
            _disciplinaRepository.Dispose();
        }

        public List<DisciplinaDto> GetAllDtos()
        {
            List<Disciplina> disciplinaList = _disciplinaRepository.All().ToList();
            List<DisciplinaDto> disciplinaDtoList = disciplinaList.Select(disciplina => Mapper.Map<DisciplinaDto>(disciplina)).ToList();
            return disciplinaDtoList;
        }

        public List<Disciplina> GetAll()
        {
            List<Disciplina> disciplinaList = _disciplinaRepository.All().ToList();
            return disciplinaList;
        }

        public DisciplinaDto GetById(int id)
        {
            Disciplina disciplina = _disciplinaRepository.Find(id);
            if (disciplina != null)
            {
                return Mapper.Map<DisciplinaDto>(disciplina);
            }
            else
                return null;
        }

        public DisciplinaDto Insert(DisciplinaDto disciplina)
        {
            if(disciplina == null)
            {
                return new DisciplinaDto();
            }
            _disciplinaRepository.Insert(Mapper.Map<Disciplina>(disciplina));
            _disciplinaRepository.SaveChanges();
            return disciplina;
        }

        public void Update(DisciplinaDto disciplina)
        {
            if(disciplina != null)
            {
                _disciplinaRepository.Update(Mapper.Map<Disciplina>(disciplina));
                _disciplinaRepository.SaveChanges();
            }
        }
    }
}