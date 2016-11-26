namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using DataAccess.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.DormitoryContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
			this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccess.DormitoryContext context)
        {
			if (System.Diagnostics.Debugger.IsAttached == false)
			{
				System.Diagnostics.Debugger.Launch();
			}
			var employee = new Employee()
			{
				EmployeeID = "1",
				Username = "1",
				Password = "1",
				DateOfBirth = new DateTime(2016, 1, 1),
				Phone = 0
			};
			context.Employees.AddOrUpdate(x => x.EmployeeID, employee);
        }
    }
}
