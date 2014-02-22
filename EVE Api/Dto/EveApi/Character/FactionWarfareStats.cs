﻿using System;
using System.Xml.Serialization;

namespace eZet.Eve.EoLib.Dto.EveApi.Character {
    public class FactionWarfareStats : XmlElement {

        [XmlElement("factionID")]
        public long FactionId { get; set; }

        [XmlElement("factionName")]
        public string FactionName { get; set; }

        [XmlIgnore]
        public DateTime EnlistedDate { get; private set; }

        [XmlElement("enlisted")]
        public string EnlistedDateAsString {
            get { return EnlistedDate.ToString(DateFormat); }
            set { EnlistedDate = DateTime.ParseExact(value, DateFormat, null); }
        }

        [XmlElement("currentRank")]
        public int CurrentRank { get; set; }

        [XmlElement("highestRank")]
        public int HighestRank { get; set; }

        [XmlElement("killsYesterday")]
        public int KillsYesterday { get; set; }

        [XmlElement("killsLastWeek")]
        public int KillsLastWeek { get; set; }

        [XmlElement("killsTotal")]
        public int KillsTotal { get; set; }

        [XmlElement("vicoryPointsYesterday")]
        public int VictoryPointsYesterday { get; set; }

        [XmlElement("victoryPointsLastWeek")]
        public int VictoryPointsLastWeek { get; set; }

        [XmlElement("victoryPointsTotal")]
        public int VictoryPointsTotal { get; set; }

    }
}
