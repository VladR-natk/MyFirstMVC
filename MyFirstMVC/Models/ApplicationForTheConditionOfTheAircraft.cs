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
    
    public partial class ApplicationForTheConditionOfTheAircraft
    {
        public int ApplicationID { get; set; }
        public int PlaneID { get; set; }
        public bool Status { get; set; }
        public string Comment { get; set; }
        public int TheSupplierID { get; set; }
        public int TechnicianID { get; set; }
        public int Company { get; set; }
    
        public virtual Plane Plane { get; set; }
        public virtual Stuff Stuff { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
