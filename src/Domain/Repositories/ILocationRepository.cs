using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repositories
{
    interface ILocationRepository
    {
        IEnumerable<Location> GetListOfLocations();
    }
}
