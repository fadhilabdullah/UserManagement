namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyTableUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_User", "Employee_Id", c => c.Int(nullable: true));
            CreateIndex("dbo.TB_M_User", "Employee_Id");
            AddForeignKey("dbo.TB_M_User", "Employee_Id", "dbo.TB_M_Employee", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_User", "Employee_Id", "dbo.TB_M_Employee");
            DropIndex("dbo.TB_M_User", new[] { "Employee_Id" });
            DropColumn("dbo.TB_M_User", "Employee_Id");
        }
    }
}
