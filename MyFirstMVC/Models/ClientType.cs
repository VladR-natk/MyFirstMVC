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
    
    public partial class ClientType
    {
        public ClientType()
        {
            this.Clients = new HashSet<Client>();
        }
    
        public int ClientTypeID { get; set; }
        public string TypeOfClient { get; set; }
        public int Discount { get; set; }
    
        public virtual ICollection<Client> Clients { get; set; }
    }
}
