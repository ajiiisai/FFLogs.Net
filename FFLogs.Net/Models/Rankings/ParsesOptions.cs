using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFLogs.Net.Models.Rankings
{
    public class RankingOptions
    {
        public string Zone { get; set; }
        /// <summary>
        /// An encounter within the zone to fetch parses for. If omitted, all encounters in the zone will be checked. If a valid encounter is specified, then historical graph data for the encounter will also be included in the results.	
        /// </summary>
        public string Encounter { get; set; }
        /// <summary>
        /// The metric to query for. Valid character metrics are 'dps', 'hps', 'bossdps, 'tankhps', or 'playerspeed'. For WoW only, 'krsi' can be used for tank survivability ranks.	
        /// </summary>
        public string Metric { get; set; }
        /// <summary>
        /// The bracket to query for. If omitted or if a value of 0 is specified, then all brackets are examined. Brackets can be obtained from a /zones API request. The special value -1 can be used to obtain scores by bracket %, i.e., to automatically look only at the bracket each parse falls in.	
        /// </summary>
        public string Bracket { get; set; }
        /// <summary>
        /// Optional. Whether or not to compare against rankings (0) when computing performance percentiles or to compare against statistics (1). A value of 0 is assumed if omitted.	
        /// </summary>
        public string Partition { get; set; }
        /// <summary>
        /// Whether to compare against today's rankings or to return historical information (where the rank was back when it was earned. The accepted values are 'today' and 'historical', with the default being 'today'.	
        /// </summary>
        public string Timeframe { get; set; }
        /// <summary>
        /// Whether or not to include combatant info like gear and talents. Optional. Defaults to false.	
        /// </summary>
        public bool? IncludeCombatantInfo { get; set; }
    }
}
