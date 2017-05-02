using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using Omu.ValueInjecter;

namespace FisaPostului.Domain.Repository
{
    public class ProgramManager : IProgramManager
    {
        private readonly IRepository<Program> _programRepository;

        public ProgramManager(IRepository<Program> programRepository)
        {
            _programRepository = programRepository;
        }

        public void Delete(int id)
        {
            Program programModel = _programRepository.Find(id);
            _programRepository.Delete(programModel);
            _programRepository.SaveChanges();
        }

        public void Dispose()
        {
            _programRepository.Dispose();
        }

        public List<ProgramDto> GetAllDtos()
        {
            List<Program> programList = _programRepository.All().ToList();
            List<ProgramDto> programDtoList = programList.Select(program => Mapper.Map<ProgramDto>(program)).ToList();
            return programDtoList;
        }

        public List<Program> GetAllUsers()
        {
            List<Program> programList = _programRepository.All().ToList();
            return programList;
        }

        public ProgramDto GetById(int id)
        {
            Program program = _programRepository.Find(id);
            if (program != null)
            {
                return Mapper.Map<ProgramDto>(program);
            }
            else
                return null;
        }

        public ProgramDto Insert(ProgramDto program)
        {
            if(program == null)
            {
                return new ProgramDto();
            }
            _programRepository.Insert(Mapper.Map<Program>(program));
            _programRepository.SaveChanges();
            return program;
        }

        public void Update(ProgramDto program)
        {
            if (program != null)
            {
                _programRepository.Update(Mapper.Map<Program>(program));
                _programRepository.SaveChanges();
            }            
        }
    }
}