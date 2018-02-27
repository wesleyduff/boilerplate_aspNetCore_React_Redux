using Client.BaseClient;
using Domain.Entities;
using System;
using System.Collections.Generic;


namespace Business.Builders
{
    /// <summary>
    /// BaseBuilder, Use for base class
    /// Cache did not contain any of these requests. 
    /// Make a call to the store for these requests.
    /// </summary>
    public class BaseBuilder : IBaseBuilder
    {
        private IBaseServiceClient _baseClientService;

        public BaseBuilder(IBaseServiceClient baseClientService)
        {
            _baseClientService = baseClientService;
        }

        /// <summary>
        /// Add the location to the store.
        /// The location was not found in the store. 
        /// </summary>
        /// <param name="location"></param>
        /// <returns>The Location that was added to the store</returns>
        public Location AddLocation(Location location)
        {
            return _baseClientService.AddLocation(location);
        }

        /// <summary>
        /// Get all of the locations from the store because they could not be found in the cache.
        /// </summary>
        /// <returns>Collection of Locations from the store</returns>
        public IEnumerable<Location> buildLocations()
        {
            return _baseClientService.GetListOfLocations();
        }

        /// <summary>
        /// Delete the location from the store.
        /// The store was found and should be deleted when called.
        /// </summary>
        /// <param name="location"></param>
        /// <returns>The store that was deleted</returns>
        public Location DeleteLocation(Location location)
        {
            return _baseClientService.DeleteLocation(location);
        }
    }
}
