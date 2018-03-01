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
    public class BaseBuilder : Crud<Location>, IBaseBuilder
    {
        private IBaseServiceClient _baseClientService;

        public BaseBuilder(IBaseServiceClient baseClientService)
        {
            _baseClientService = baseClientService;
        }

        /// <summary>
        /// Add location to Store
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location</returns>
        public override Location Add(Location item)
        {
            return _baseClientServie.Add(Location);
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
        /// Delete location from the store
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public override Location Delete(Location item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get location from the store
        /// </summary>
        /// <param name="item">Location</param>
        /// <returns>Location</returns>
        public override Location Get(Location item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update location from the store
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public override Location Update(Location item)
        {
            throw new NotImplementedException();
        }
    }
}
