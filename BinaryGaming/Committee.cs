//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BinaryGaming
{
    using System;
    using System.Collections.Generic;
    
    public partial class Committee
    {
        public int Id { get; set; }
        public int CommitteePositionsId { get; set; }
        public int MembersId { get; set; }
    
        public virtual CommitteePositions CommitteePosition { get; set; }
        public virtual Members Member { get; set; }
    }
}
