﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class TestService : ITestService
    {
        public string Name { get; set; }

        public async Task<string> PrintName()
        {
            return "bla";
        }
    }
}
