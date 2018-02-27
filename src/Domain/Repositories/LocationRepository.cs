using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        /// <summary>
        /// Add location to Storage
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Location that was added</returns>
        public Location AddLocation(Location location)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete the location from the storage
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Location that was deleted</returns>
        public Location DeleteLocation(Location location)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a list of all locations that have been saved.
        /// </summary>
        /// <returns>Collection of Locations</returns>
        public IEnumerable<Location> GetListOfLocations()
        {
            throw new NotImplementedException();
        }
    }
}
