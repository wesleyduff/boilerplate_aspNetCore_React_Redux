using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Client.BaseClient
{
    public interface IBaseServiceClient
    {
        IEnumerable<Location> GetListOfLocations();

        Location AddLocation(Location location);

        Location DeleteLocation(Location location);
    }
}
