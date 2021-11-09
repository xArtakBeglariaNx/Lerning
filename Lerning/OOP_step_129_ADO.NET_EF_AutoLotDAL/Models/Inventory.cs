namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models.Base;


    [Table("Inventory")]
    public partial class Inventory : EntityBase
    {
        
        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
