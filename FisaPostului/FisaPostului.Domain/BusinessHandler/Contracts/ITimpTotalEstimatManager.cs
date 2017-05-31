﻿using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisaPostului.Domain.BusinessHandler.Contracts
{
    public interface ITimpTotalEstimatManager : IHandler<TimpTotalEstimatDto, timp_total_estimat>
    {
    }
}
