using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetListOfLocations();

        Location AddLocation(Location location);

        Location DeleteLocation(Location location);
    }
}
