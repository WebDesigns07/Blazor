using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDevExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : Controller
    {
        [HttpGet]
        public List<Game> Get()
        {
            return new List<Game>
            {
                new Game
                {
                    Home = new Club
                    {
                        Name = "Real Madrid",
                        Players = new List<Player>
                        {
                            new Player { Name = "C.Ronaldo", Age = 24, Score = 35, Assist = 11, Value = 80000000 },
                            new Player { Name = "Modric", Age = 27, Score = 9, Assist = 21, Value = 45000000 },
                            new Player { Name = "Kaka", Age = 29, Score = 17, Assist = 14, Value = 65000000 },
                        },
                        Coach = "J.Mourinho",
                    },
                    Away = new Club
                    {
                        Name = "FC Barcelona",
                        Players = new List<Player>
                        {
                            new Player { Name = "Messi", Age = 22, Score = 31, Assist = 13, Value = 75000000 },
                            new Player { Name = "Xavi", Age = 30, Score = 3, Assist = 16, Value = 50000000 },
                            new Player { Name = "Iniesta", Age = 27, Score = 8, Assist = 14, Value = 60000000 },
                        },
                        Coach = "Guardiola",
                    },
                    Judge = "Jnc",
                    Time = DateTime.Now.Date,
                    Weather = "Rain"
                },
                new Game
                {
                    Home = new Club
                    {
                        Name = "Real Madrid",
                        Players = new List<Player>
                        {
                            new Player { Name = "C.Ronaldo", Age = 24, Score = 35, Assist = 11, Value = 80000000 },
                            new Player { Name = "Modric", Age = 27, Score = 9, Assist = 21, Value = 45000000 },
                            new Player { Name = "Kaka", Age = 29, Score = 17, Assist = 14, Value = 65000000 },
                        },
                        Coach = "J.Mourinho",
                    },
                    Away = new Club
                    {
                        Name = "Atletico Madrid",
                        Players = new List<Player>
                        {
                            new Player { Name = "Falco", Age = 26, Score = 30, Assist = 5, Value = 40000000 },
                            new Player { Name = "Forlan", Age = 30, Score = 15, Assist = 10, Value = 35000000 },
                            new Player { Name = "Koke", Age = 26, Score = 7, Assist = 10, Value = 30000000 },
                        },
                        Coach = "Simoni",
                    },
                    Judge = "Jnc",
                    Time = DateTime.Now.Date.AddDays(7D),
                    Weather = "Sunny"
                },
            };
        }
    }
}