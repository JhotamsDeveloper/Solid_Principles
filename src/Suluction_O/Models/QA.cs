﻿using Suluction_O.Interfaces;
using Suluction_O.Services;

namespace Suluction_O.Models
{
    public class QA : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountQA();
    }
}
