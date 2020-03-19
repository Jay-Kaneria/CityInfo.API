using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "The City Of New York",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "1st POI",
                            Description = "New York's 1st POI"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "2nd POI",
                            Description = "New York's 2nd POI"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "AntWerp",
                    Description = "The City Of Antwerp",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "1st POI",
                            Description = "AntWerp's 1st POI"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "2nd POI",
                            Description = "AntWerp's 2nd POI"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The City Of Paris",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "1st POI",
                            Description = "Paris's 1st POI"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "2nd POI",
                            Description = "Paris's 2nd POI"
                        }
                    }
                },
            };
        }
    }
}