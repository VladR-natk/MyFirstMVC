//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        public Plane()
        {
            this.ApplicationForTheConditionOfTheAircrafts = new HashSet<ApplicationForTheConditionOfTheAircraft>();
        }
    
        public int PlaneID { get; set; }
        public string PlaneName { get; set; }
        public string Model { get; set; }
        public int QuantityOfSeats { get; set; }
        public int NumberOfUnitsInThePark { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public int Wingspan { get; set; }
        public int CruisingSpeed { get; set; }
        public int MaximumFlightAltitude { get; set; }
        public int MaximumFlightRange { get; set; }
    
        public virtual ICollection<ApplicationForTheConditionOfTheAircraft> ApplicationForTheConditionOfTheAircrafts { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TicketInfo TicketInfo { get; set; }
    }
}