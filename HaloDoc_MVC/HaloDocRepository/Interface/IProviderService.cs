﻿using HaloDocDataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloDocRepository.Interface
{
    public interface IProviderService
    {
        public List<PhysicianLocation> FindPhysicianLocation();

    }
}
