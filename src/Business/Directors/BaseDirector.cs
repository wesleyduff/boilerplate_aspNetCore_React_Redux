using Business.Builders;
using Client.BaseClient;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Directors
{
    /// <summary>
    /// BaseDirector gathers data from the cache or makes a call to the store.
    /// </summary>
    public class BaseDirector : IBaseDirector
    {

        private IBaseBuilder _baseBuilder;
        private IBaseServiceClient _baseServiceClient;

        public BaseDirector(IBaseBuilder baseBuilder, IBaseServiceClient baseServiceClient)
        {
            _baseBuilder = baseBuilder;
            _baseServiceClient = baseServiceClient;
        }
        
        /// <summary>
        /// Add location to store if it does not exist or return the location
        /// </summary>
        /// <param name="location"></param>
        /// <returns>The location from cache or from the store</returns>
        public Location AddLocation(Location location)
        {
            try
            {
               return _baseBuilder.AddLocation(location);
            }
            catch (Exception ex)
            {
                //log exception
                throw new Exception("Error Adding Locaitons", ex);
            }
        }

        /// <summary>
        /// Get a list of the locations from the store or from cache
        /// </summary>
        /// <returns>Collection of Locations</returns>
        public IEnumerable<Location> BuildLocations()
        {
            try
            {

                return _baseBuilder.buildLocations();

            } catch (Exception ex)
            {
                //log exception
                throw new Exception("Error Building Locaitons", ex);
            }
        }

        /// <summary>
        /// Delete the location if it is found in the store
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Location that was deleted</returns>
        public Location DeleteLocation(Location location)
        {
            try
            {

                return _baseBuilder.DeleteLocation(location);

            }
            catch (Exception ex)
            {
                //log exception
                throw new Exception("Error deleteing Locaitons", ex);
            }
        }
    }
}
