﻿using CheckOutScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutScanner.Services.OffersService
{
    public interface IOffersService
    {
        IDictionary<string, Offer> GetOffersPriceTable();
    }
}
