using Microsoft.AspNetCore.Mvc;
using RavnChallenge.Server.Helpers;
using RavnChallenge.Server.Interfaces;
using RavnChallenge.Shared;
using RavnChallenge.Shared.Dtos;
using System;
using System.Collections.Generic;

namespace RavnChallenge.Server.Controllers
{
    [ApiController]
    [Route("/people")]
    public class PeopleController : ControllerBase
    {
        #region Constructor for dependency injection
        private readonly IRepository repository;
        public PeopleController(IRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region public IActionResult GetPerson(long id)
        [HttpGet("{id}")]
        public IActionResult GetPerson(string id)
        {
            // Initialize the lists
            List<PlanetDto> planets = new List<PlanetDto>();
            List<VehicleDto> vehicles = new List<VehicleDto>();
            List<SpecieDto> species = new List<SpecieDto>();

            // Get data from stored in session
            planets = SessionHelper.GetObjectFromJson<List<PlanetDto>>(HttpContext.Session, "planets");
            vehicles = SessionHelper.GetObjectFromJson<List<VehicleDto>>(HttpContext.Session, "vehicles");
            species = SessionHelper.GetObjectFromJson<List<SpecieDto>>(HttpContext.Session, "species");

            var result = repository.GetSingle<PersonDto>("people/", id);

            // Set the vehicles on the array
            List<string> newVehicles = new List<string>();
            foreach (string thisVehicle in result.Vehicles)
            {
                var _vehicle = vehicles.Find(v => v.Url == thisVehicle);
                newVehicles.Add(_vehicle.Name);
            }
            result.Vehicles = newVehicles;

            // Set the homeworld planet of the character
            var _homeworld = planets.Find(p => p.Url == result.Homeworld);
            result.Homeworld = _homeworld.Name;

            // Set the species for the character, has a default value of human if its empty
            List<string> newSpecies = new List<string>();
            if (result.Species.Count == 0)
            {
                newSpecies.Add("Human");
                result.Species = newSpecies;
            }
            else
            {
                foreach (string thisSpecie in result.Species)
                {
                    var _specie = species.Find(v => v.Url == thisSpecie);
                    newSpecies.Add(_specie.Name);
                }
                result.Species = newSpecies;
            }

            return Ok(result);
        }
        #endregion

        #region public IActionResult GetPeople(string pageNumber = "1")
        [HttpGet]
        public IActionResult GetPeople(string pageNumber = "1")
        {
            // Initialize the lists
            List<PlanetDto> planets = new List<PlanetDto>();
            List<VehicleDto> vehicles = new List<VehicleDto>();
            List<SpecieDto> species = new List<SpecieDto>();

            // Check for data in Session, if no data then get data from endpoints
            var storePlanets = SessionHelper.GetObjectFromJson<List<PlanetDto>>(HttpContext.Session, "planets");
            if (storePlanets != null)
            {
                planets = storePlanets;
                vehicles = SessionHelper.GetObjectFromJson<List<VehicleDto>>(HttpContext.Session, "vehicles");
                species = SessionHelper.GetObjectFromJson<List<SpecieDto>>(HttpContext.Session, "species");
            }
            else
            {
                planets = GetFullData<PlanetDto>("planets/");
                SessionHelper.SetObjectAsJson(HttpContext.Session, "planets", planets);

                species = GetFullData<SpecieDto>("species/");
                SessionHelper.SetObjectAsJson(HttpContext.Session, "species", species);

                vehicles = GetFullData<VehicleDto>("vehicles/");
                SessionHelper.SetObjectAsJson(HttpContext.Session, "vehicles", vehicles);
            }

            // Get people data from endpoint and fill needed data from other stored data
            var result = repository.GetAllPaginated<PersonDto>("people/", pageNumber);
            foreach (PersonDto item in result.Results)
            {
                // Set the vehicles on the array
                List<string> newVehicles = new List<string>();
                foreach (string thisVehicle in item.Vehicles)
                {
                    var _vehicle = vehicles.Find(v => v.Url == thisVehicle);
                    newVehicles.Add(_vehicle.Name);
                }
                item.Vehicles = newVehicles;

                // Set the homeworld planet of the character
                var _homeworld = planets.Find(p => p.Url == item.Homeworld);
                item.Homeworld = _homeworld.Name;

                // Set the species for the character, has a default value of human if its empty
                List<string> newSpecies = new List<string>();
                if (item.Species.Count == 0)
                {
                    newSpecies.Add("Human");
                    item.Species = newSpecies;
                }
                else
                {
                    foreach (string thisSpecie in item.Species)
                    {
                        var _specie = species.Find(v => v.Url == thisSpecie);
                        newSpecies.Add(_specie.Name);
                    }
                    item.Species = newSpecies;
                }
                item.Url = item.Url.Replace("https://swapi.dev/api/people/", "fetchdata/");
            }
            return Ok(result);
        }
        #endregion

        #region public List<T> GetFullData<T>(string entityName) where T : Entity
        public List<T> GetFullData<T>(string entityName) where T : Entity
        {
            List<T> result = new List<T>();
            var data = repository.GetAllPaginated<T>(entityName, "1");
            result.AddRange(data.Results);
            var countLimit = Math.Ceiling((Convert.ToDouble(data.Count) / 10));
            for (int i = 2; i <= countLimit; i++)
            {
                data = repository.GetAllPaginated<T>(entityName, i.ToString());
                result.AddRange(data.Results);
            }
            return result;
        }
        #endregion
    }
}
