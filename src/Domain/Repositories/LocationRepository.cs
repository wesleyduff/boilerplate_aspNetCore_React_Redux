using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.AbstractClasses;

namespace Domain.Repositories
{
    public class LocationRepository : Crud<Location>, ILocationRepository
    {

        /// <summary>
        /// Add a Location to the store
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location</returns>
        public override Location Add(Location item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete the location from the storage
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location that was deleted</returns>
        public override Location Delete(Location item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a Location
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location</returns>
        public override Location Get(Location item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update Location
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location</returns>
        public override Location Update(Location item)
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
