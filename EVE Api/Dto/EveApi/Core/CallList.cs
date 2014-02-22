﻿using System;
using System.Xml.Serialization;

namespace eZet.Eve.EoLib.Dto.EveApi.Core {
    public class CallList : XmlElement, IXmlSerializable {

        [XmlElement("rowset")]
        public XmlRowSet<CallGroup> CallGroups { get; set; }


        [XmlElement("rowset")]
        public XmlRowSet<Call> Calls { get; set; }


        [Serializable]
        [XmlRoot("row")]
        public class CallGroup {
            
            [XmlAttribute("groupID")]
            public long GroupId { get; set; }

            [XmlAttribute("name")]
            public string GroupName { get; set; }

            [XmlAttribute("description")]
            public string Description { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class Call {

            [XmlAttribute("accessMask")]
            public int AccessMask { get; set; }

            [XmlAttribute("type")]
            public string Character { get; set; }

            [XmlAttribute("name")]
            public string Name { get; set; }

            [XmlAttribute("groupID")]
            public long groupId { get; set; }

            [XmlAttribute("description")]
            public string Description { get; set; }
            
        }

        public System.Xml.Schema.XmlSchema GetSchema() {
            throw new NotImplementedException();
        }

        public void ReadXml(System.Xml.XmlReader reader) {
            CallGroups = deserializeRowSet(reader, new CallGroup());
            Calls = deserializeRowSet(reader, new Call());
        }

        public void WriteXml(System.Xml.XmlWriter writer) {
            throw new NotImplementedException();
        }
    }

}
