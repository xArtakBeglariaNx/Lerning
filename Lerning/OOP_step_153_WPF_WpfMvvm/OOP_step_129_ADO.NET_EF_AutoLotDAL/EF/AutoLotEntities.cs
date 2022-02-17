using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Interception;
using OOP_step_129_ADO.NET_EF_AutoLotDAL.Models.Base;


namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.EF
{
    public partial class AutoLotEntities : DbContext
    {
        static readonly DatabaseLogger DatabaseLoger =
            new DatabaseLogger("sqllog.txt", true);
        public AutoLotEntities() : base("name = AutoLotConnection")
        {
            //DbInterception.Add(new ConsoleWriterInterceptor());
            //DatabaseLoger.StartLogging();
            //DbInterception.Add(DatabaseLoger);

            var context = (this as IObjectContextAdapter).ObjectContext;
            context.ObjectMaterialized += OnObjectMaterialized;
            context.SavingChanges += OnSavingChanges;
        }

        private void OnSavingChanges(object sender, EventArgs e)
        {
            var context = sender as ObjectContext;
            if (context == null) return;
            foreach (ObjectStateEntry item in context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified | EntityState.Added))
            {
                if ((item.Entity as Inventory) != null)
                {
                    var entity = (Inventory)item.Entity;
                    if (entity.Color == "Red")
                    {
                        item.RejectPropertyChanges(nameof(entity.Color));
                    }
                }
            }
        }

        private void OnObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var model = (e.Entity as EntityBase);
            if (model != null)
            {
                model.IsChanged = false;
            }
        }

        public virtual DbSet<CreditRisk> CreditRisks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Cars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);
        }

        protected override void Dispose(bool disposing)
        {
            DbInterception.Remove(DatabaseLoger);
            DatabaseLoger.StopLogging();
            base.Dispose(disposing);
        }
    }
}
