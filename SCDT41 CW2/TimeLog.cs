using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public class TimeLog
    {
        public Guid Id { get; set; }
        public int TimeInMinutes { get; set; }
        public DateTime LoggedOn { get; set; }
        public TeamMember? MemberOfTeam { get; set; }
        public TimeLog(int amountInMins, TeamMember? memberOfTeam)
        {
            Id = Guid.NewGuid();
            TimeInMinutes = amountInMins;
            LoggedOn = DateTime.Now;
            MemberOfTeam = memberOfTeam;
        }

        public override string? ToString()
        {
            return $"ID: {Id}, Amount in minutes: {TimeInMinutes}, Team Member: {MemberOfTeam}, Logged On: {LoggedOn}";
        }
    }
}
