using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SIPASC2Stats.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the SIPASC2StatsUser class
    public class SIPASC2StatsUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public string BattleNetID { get; set; }

        public byte[] AvatarImage { get; set; }
    }
}
