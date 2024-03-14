using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10.Data;
using Mission10.Models;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingLeagueController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinData = from Bowler in _bowlerRepository.Bowlers
                           join Team in _bowlerRepository.Teams
                           on Bowler.TeamId equals Team.TeamId
                           where Team.TeamName == "Marlins" || Team.TeamName == "Sharks"
                           select new
                           {
                               BowlerId = Bowler.BowlerId,
                               BowlerLastName = Bowler.BowlerLastName,
                               BowlerFirstName = Bowler.BowlerFirstName,
                               BowlerMiddleInit = Bowler.BowlerMiddleInit,
                               BowlerAddress = Bowler.BowlerAddress,
                               BowlerCity = Bowler.BowlerCity,
                               BowlerState = Bowler.BowlerState,
                               BowlerZip = Bowler.BowlerZip,
                               BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                               TeamName = Team.TeamName
                              
                           };

            return joinData.ToList();
        }


        //[HttpGet]
        //public IEnumerable<Bowler> Get()
        //{
        //    //get all bowlers
        //    var bowlers = _bowlerRepository.Bowlers;
        //    foreach (var bowler in bowlers)
        //    {
        //        bowler.Team = _bowlerRepository.GetTeamById(bowler.TeamId);
        //    }
        //    return bowlers;
        //}
       
        //[HttpGet]
        //public IEnumerable<(Bowler bowler, Team team)> GetBowlersWithTeamInfo()
        //{
        //    return _bowlerRepository.GetBowlersWithTeamInfo();
        //}

    }
}
