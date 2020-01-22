using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    firstName = table.Column<string>(maxLength: 255, nullable: false),
                    lastName = table.Column<string>(maxLength: 255, nullable: false),
                    nickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    city = table.Column<string>(maxLength: 255, nullable: false),
                    country = table.Column<string>(maxLength: 255, nullable: false),
                    DOB = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 255, nullable: true),
                    State = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
