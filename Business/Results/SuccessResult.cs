﻿using Business.Results.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Results
{
    public class SuccessResult : Result
    {
        // Example: Result result = new SuccessResult("Operation successful.");
        public SuccessResult(string message) : base(true, message)
        {
        }

        // Example: Result result = new SuccessResult();
        public SuccessResult() : base(true, "")
        {
        }
    }
}
