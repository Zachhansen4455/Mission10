using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Mission10.Models;

namespace Mission10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlerRepository(BowlingLeagueContext context)
        {
            _bowlerContext = context;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Team> Teams => _bowlerContext.Teams;

        //public Team GetTeamById(int? teamID)
        //{
        //    return _context.Teams.Find(teamID);
        //}

        //public IEnumerable<(Bowler bowler, Team team)> GetBowlersWithTeamInfo()
        //{
        //    return (from bowler in _context.Bowlers
        //            join team in _context.Teams on bowler.TeamId equals team.TeamId
        //            select (bowler, team)).ToList();
        //}
    }
}
