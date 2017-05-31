﻿using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.Database;
using FisaPostului.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FisaPostului.Domain.BusinessHandler
{
    public class RepartizareOreManager : Handler<RepartizareOreDto, repartizare_ore>, IRepartizareOreManager
    {
    }
}