using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Directors
{
    public interface IBaseDirector
    {
        IEnumerable<Location> BuildLocations();
        Location AddLocation(Location location);
        Location DeleteLocation(Location location);

    }
}
