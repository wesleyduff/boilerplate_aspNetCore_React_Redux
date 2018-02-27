using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Repositories;

namespace Client.BaseClient
{
    public class BaseClientService : IBaseServiceClient
    {
        private ILocationRepository _locationRepository;
        public BaseClientService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        /// <summary>
        /// Add a location to the DB
        /// </summary>
        /// <param name="location"></param>
        public Location AddLocation(Location location)
        {
            return _locationRepository.AddLocation(location);
        }

        /// <summary>
        /// Delete a location
        /// </summary>
        /// <param name="location"></param>
        public Location DeleteLocation(Location location)
        {
            return _locationRepository.DeleteLocation(location);
        }

        /// <summary>
        /// Get a list of locations
        /// </summary>
        /// <returns>Collection of Locations</returns>
        public IEnumerable<Location> GetListOfLocations()
        {
            return _locationRepository.GetListOfLocations();
        }

        IEnumerable<Location> IBaseServiceClient.GetListOfLocations()
        {
            return _locationRepository.GetListOfLocations();
        }
    }
}
