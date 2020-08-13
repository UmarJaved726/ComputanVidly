namespace ComputanVidely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DiscountRate, DurationInMonth)values(1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DiscountRate, DurationInMonth)values(2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DiscountRate, DurationInMonth)values(3, 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DiscountRate, DurationInMonth)values(4, 300, 12, 200)");
        }
        
        public override void Down()
        {
        }
    }
}
