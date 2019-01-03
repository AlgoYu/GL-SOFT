using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyWebSite.Migrations
{
    public partial class some : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SystemInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogoUrl = table.Column<string>(nullable: true),
                    QQ = table.Column<string>(nullable: true),
                    WeChat = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    WeChatQR = table.Column<string>(nullable: true),
                    SiteTitle = table.Column<string>(nullable: true),
                    KeyWords = table.Column<string>(nullable: true),
                    Copyright = table.Column<string>(nullable: true),
                    Record = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemInfo", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SystemInfo");
        }
    }
}
