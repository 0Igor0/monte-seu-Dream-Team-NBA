using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBA.Migrations
{
    public partial class populaPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Players(TeamId, Name, Position, Img) VALUES(1,'Stephen Cury', 'PG', '/img/players/Steph.png')");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Players");
        }
    }
}
