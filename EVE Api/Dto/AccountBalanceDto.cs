﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using eZet.Eve.EveApi.Dto;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

namespace eZet.Eve.EveApi.Dto {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AccountBalanceDto {

        public EveApiRowset rowset { get; set; }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AccountBalanceRow {

        [XmlAttribute()]
        public uint accountID { get; set; }

        [XmlAttribute()]
        public ushort accountKey { get; set; }

        [XmlAttribute()]
        public decimal balance { get; set; }
    }
}