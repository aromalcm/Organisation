using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organisation.Profiles
{
    public class Profiles:AutoMapper.Profile
    {
        public Profiles()
        {
            CreateMap<DB.Organisation, Models.Organisation>();
            CreateMap<DB.Employee, Models.Employee>();
        }
    }
}
