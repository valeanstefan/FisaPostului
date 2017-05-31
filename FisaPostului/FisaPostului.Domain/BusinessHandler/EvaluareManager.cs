using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.BusinessHandler
{
    public class EvaluareManager : Handler<EvaluareDto, evaluare>, IEvaluareManager
    {
    }
}