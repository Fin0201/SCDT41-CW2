using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public class Timelog
    {
        public Guid Id { get; set; }
        public int TimeInMinutes { get; set; }
        public DateTime LoggedOn { get; set; }
        public TeamMember? MemberOfTeam { get; set; }
        public Timelog(int amountInMins, TeamMember? memberOfTeam)
        {
            Id = Guid.NewGuid();
            TimeInMinutes = amountInMins;
            LoggedOn = DateTime.Now;
            MemberOfTeam = memberOfTeam;
        }

        public override string? ToString()
        {
            return $"ID: {Id}, Time in Minutes: {TimeInMinutes}, {MemberOfTeam}, Logged On: {LoggedOn}";
        }
    }
}
