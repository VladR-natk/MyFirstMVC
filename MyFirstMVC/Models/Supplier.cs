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
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.ApplicationForTheConditionOfTheAircrafts = new HashSet<ApplicationForTheConditionOfTheAircraft>();
            this.Planes = new HashSet<Plane>();
        }
    
        public int SupplierID { get; set; }
        public string Company { get; set; }
        public int RepresentativeID { get; set; }
        public string RepresentativeFirstName { get; set; }
        public string RepresentativeLastName { get; set; }
        public string RepresentativePatronymic { get; set; }
        public string RepresentativeNumber { get; set; }
        public string RepresentativeEmail { get; set; }
    
        public virtual ICollection<ApplicationForTheConditionOfTheAircraft> ApplicationForTheConditionOfTheAircrafts { get; set; }
        public virtual ICollection<Plane> Planes { get; set; }
    }
}
