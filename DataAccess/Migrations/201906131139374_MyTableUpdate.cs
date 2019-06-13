namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyTableUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_M_Employee", "User_Id", "dbo.TB_M_User");
            DropIndex("dbo.TB_M_Employee", new[] { "User_Id" });
            DropColumn("dbo.TB_M_Employee", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Employee", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.TB_M_Employee", "User_Id");
            AddForeignKey("dbo.TB_M_Employee", "User_Id", "dbo.TB_M_User", "Id", cascadeDelete: true);
        }
    }
}
