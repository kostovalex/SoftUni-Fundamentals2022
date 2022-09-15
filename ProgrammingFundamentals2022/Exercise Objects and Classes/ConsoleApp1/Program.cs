using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            
            List<string> allNames = new List<string>();
            List<string> allMembers = new List<string>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                
                if (teams.Any(x=>x.TeamName== input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
                else if (teams.Any(x => x.Creator == input[0]))
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(input[1], input[0]);
                    allNames.Add(newTeam.TeamName);
                    allMembers.Add(newTeam.Creator);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");
                }   
            }
            
            string[] command = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "end of assignment")
            {
                string member = command[0];
                string teamName = command[1];
                
                if (!teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                
                else if (teams.Any(x => x.Member.Any(m => m == member)) || teams.Any(x => x.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                
                else 
                {
                    foreach (Team team in teams)
                    {
                        if (team.TeamName == teamName)
                        {
                            team.Member.Add(member);
                            allMembers.Add(member);
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
            }

            List<Team> disbandedTeams = teams.Where(x => x.Member.Count <= 0).ToList();
            List<Team> actualTeams = teams.Where(x => x.Member.Count > 0).ToList();

            foreach (Team team in actualTeams.OrderByDescending(n => n.Member.Count).ThenBy(u => u.TeamName).ToList())
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Member.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
           
            Console.WriteLine("Teams to disband:");
            
            foreach (Team team in disbandedTeams.OrderBy(n => n.TeamName).ToList())
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            this.Member = new List<string>();
            
        }

        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }
       
    }
}
