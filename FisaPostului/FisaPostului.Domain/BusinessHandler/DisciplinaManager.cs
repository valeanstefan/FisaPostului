using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using Omu.ValueInjecter;
using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.BusinessHandler;

namespace FisaPostului.Domain.Repository
{
    public class DisciplinaManager : Handler<DisciplinaDto, Disciplina>, IDisciplinaManager
    {
    }
}