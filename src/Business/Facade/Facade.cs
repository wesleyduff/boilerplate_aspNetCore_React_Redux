using Business.Directors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Facade
{
    public class Facade
    {
        private IBaseDirector _baseDirector;

        public Facade(IBaseDirector baseDirector)
        {
            _baseDirector = baseDirector;
        }
        
         
    }
}
