﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IService
{
    public interface IUserService
    {
        List<user> GetUsers();
    }
}
