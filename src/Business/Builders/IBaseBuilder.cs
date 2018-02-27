using System.Collections.Generic;
using Domain.Entities;

namespace Business.Builders
{
    public interface IBaseBuilder
    {
        IEnumerable<Location> buildLocations();
        Location AddLocation(Location location);
        Location DeleteLocation(Location location);
    }
}  
