namespace OOP_step_128_ADO.NET_EF_AutoLotConsoleApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int CustId { get; set; }

        [Column("CarId")]
        public int Foo { get; set; }
        [ForeignKey(nameof(Foo))]

        public virtual Customer Customers { get; set; }

        public virtual Car Car { get; set; }
    }
}
