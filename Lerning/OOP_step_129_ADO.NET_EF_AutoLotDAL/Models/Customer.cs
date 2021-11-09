namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models.Base;


    public partial class Customer : EntityBase
    {
        
        [NotMapped]
        public string FullName => FirstName + " " + LastName;
                
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
