//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirPort
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        public int id { get; set; }
        public string airline { get; set; }
        public int destination { get; set; }
        public int timeline { get; set; }
        public Plane()
        {

        }
        public virtual Airline Airline1 { get; set; }
        public virtual Destination Destination1 { get; set; }
        public virtual Timeline Timeline1 { get; set; }
    }
}