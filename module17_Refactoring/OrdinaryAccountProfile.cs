﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace module17_Refactoring
{
    public class OrdinaryAccountProfile : IAccountProfile
    {
        public double CalculateInterest(double balanse)
        {
            double interest;
            interest = balanse * 0.2;
            return interest;
        }
    }
}
