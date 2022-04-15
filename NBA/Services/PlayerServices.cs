using NBA.Models;

namespace NBA.Services
{
    public class PlayerServices
    {
        public List<Player> Get()
        {
            var players = new List<Player>();
            players.Add(new Player { Name = "Stephen Curry", Position= "PG", Img = "Steph.png" });
            players.Add(new Player { Name = "Klay Thompson", Position= "SG", Img = "klay.png" });
            players.Add(new Player { Name = "Andre Wiggns",  Position= "PF", Img = "andrew.png" });
            players.Add(new Player { Name = "Daymon Green",  Position= "SF", Img = "daymon.png" });
            players.Add(new Player { Name = "James Wiseman", Position= "C", Img = "jamesW.png", });

            var team = new List<Team>();
            team.Add(new Team { Name = "Gold State Warrios", Img = "golden-state-warriors.png", Players = players });

            return players;
        }
        public List<Team> GetTeam()
        {
            var players1 = new List<Player>();
            players1.Add(new Player { Name = "Russel Westbrook", Position = "PG", Img = "russelW.png" });
            players1.Add(new Player { Name = "Carmelo Anthony", Position = "SG", Img = "carmeloA.png" });
            players1.Add(new Player { Name = "Lebron James", Position = "PF", Img = "lebronJ.png" });
            players1.Add(new Player { Name = "Anthony Davis", Position = "SF", Img = "anthonyD.png" });
            players1.Add(new Player { Name = "Dwhite Howard", Position = "C", Img = "dwightH.png" });

            var players2 = new List<Player>();
            players2.Add(new Player { Name = "Stephen Curry", Position = "PG", Img = "Steph.png" });
            players2.Add(new Player { Name = "Klay Thompson", Position = "SG", Img = "klay.png" });
            players2.Add(new Player { Name = "Andre Wiggns", Position = "PF", Img = "andrew.png" });
            players2.Add(new Player { Name = "Daymon Green", Position = "SF", Img = "daymon.png" });
            players2.Add(new Player { Name = "James Wiseman", Position = "C", Img = "jamesW.png", });

            var team = new List<Team>();
            team.Add(new Team { Name = "Gold State Warrios", Img = "golden-state-warriors.png", Players = players2, Id = 0 });
            team.Add(new Team { Name = "Chicago Bulls", Img = "losAngeles.png", Players = players1, Id = 1 });

            return team;
        }



            public Player GetByID(string name)
        {
            return Get().Where(t => t.Name == name).FirstOrDefault();
        }
    }
}