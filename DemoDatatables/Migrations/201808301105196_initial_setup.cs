namespace DemoDatatables.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        ContactName = c.String(nullable: false),
                        ContactTitle = c.String(nullable: false),
                        Address = c.String(),
                        City = c.String(nullable: false),
                        Region = c.String(),
                        PostalCode = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Fax = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);

            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Md. Razib', 'Front Desk', 'Chittagong', '4000', 'Bangladesh', '0185698745')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Dream', 'Md. Akkas', 'Front Desk', 'Chittagong', '4000', 'Bangladesh', '0157884656')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Comfort', 'Ataur Rahman', 'Front Desk', 'Chittagong', '4000', 'Bangladesh', '965478451')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Ovijhit', 'Front Desk', 'Chittagong', '4000', 'Bangladesh', '1265466498')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Suite Sadaf', 'Md. Mowla', 'General Manager', 'Coxs Bazar', '4200', 'Bangladesh', '95317487412')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Sumit Barua', 'Front Desk', 'Chittagong', '4000', 'Bangladesh', '15154687870')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Hossainul Hoque', 'Manager', 'Chittagong', '4000', 'Bangladesh', '0136381321')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Suite sadaf', 'Azizul Hoque', 'Accountant', 'Coxs Bazar', '4200', 'Bangladesh', '105468435430')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Probin Barua', 'Accountant', 'Chittagong', '4000', 'Bangladesh', '0213545')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Dream', 'Ashraful Rahman', 'Manager', 'Chittagong', '4000', 'Bangladesh', '20135746534')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Comfort', 'Yousuf Ali', 'Accountant', 'Chittagong', '4000', 'Bangladesh', '5201357435')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Suite Sadaf', 'Tinku', 'MD', 'Coxs Bazar', '4200', 'Bangladesh', '013548687')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Safina', 'Showkotur Rahman', 'MD', 'Chittagong', '4000', 'Bangladesh', '1065455464')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Dream', 'Md. Sihab', 'MD', 'Chittagong', '4000', 'Bangladesh', '0654654686')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Suite sadaf', 'Mohammad Mohibbullah', 'Front Desk', 'Coxs Bazar', '4200', 'Bangladesh', '078445434')");
            Sql("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, City, PostalCode, Country, Phone) VALUES ('Hotel Suite sadaf', 'Mohd.Nur Alam', 'Restaurant Manager', 'Coxs Bazar', '4200', 'Bangladesh', '0413568484')");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
