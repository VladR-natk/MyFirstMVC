//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketInfo
    {
        public int TicketID { get; set; }
        public int ClientID { get; set; }
        public int PlaneID { get; set; }
        public int ScheduleID { get; set; }
        public string PlaceOfDeparture { get; set; }
        public string PlaceOfArrival { get; set; }
        public string DepartureDate { get; set; }
        public bool BaggageAvailability { get; set; }
        public string SeatInTheCabin { get; set; }
        public double TicketPrice { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
