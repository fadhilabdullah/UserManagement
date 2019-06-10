namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TB_R_EmpApplication", newName: "TB_T_UserApplication");
            DropForeignKey("dbo.TB_M_Employee", "Role_Id", "dbo.TB_M_Role");
            DropIndex("dbo.TB_M_Employee", new[] { "Role_Id" });
            RenameColumn(table: "dbo.TB_T_UserApplication", name: "Employee_Id", newName: "User_Id");
            RenameIndex(table: "dbo.TB_T_UserApplication", name: "IX_Employee_Id", newName: "IX_User_Id");
            DropColumn("dbo.TB_M_Employee", "Role_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Employee", "Role_Id", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.TB_T_UserApplication", name: "IX_User_Id", newName: "IX_Employee_Id");
            RenameColumn(table: "dbo.TB_T_UserApplication", name: "User_Id", newName: "Employee_Id");
            CreateIndex("dbo.TB_M_Employee", "Role_Id");
            AddForeignKey("dbo.TB_M_Employee", "Role_Id", "dbo.TB_M_Role", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.TB_T_UserApplication", newName: "TB_R_EmpApplication");
        }
    }
}
