using Mission10.Models;

namespace Mission10.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

        //Team GetTeamById(int? teamId);
        //rules for template
        //IEnumerable<(Bowler bowler, Team team)> GetBowlersWithTeamInfo();
    }
}
