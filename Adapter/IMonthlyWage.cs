﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IMonthlyWage
    {
        double GetMonthlyWage();
        string PrintMonthlyPaySlip();
    }
}
