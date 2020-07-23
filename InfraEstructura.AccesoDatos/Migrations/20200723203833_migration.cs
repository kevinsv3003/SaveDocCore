using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InfraEstructura.AccesoDatos.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AUDI");
            
            migrationBuilder.CreateTable(
                name: "LogTransaccion",
                schema: "AUDI",
                columns: table => new
                {
                    LogTransaccionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Usuario = table.Column<string>(type: "varchar(200)", nullable: false),
                    FechaProceso = table.Column<DateTime>(nullable: false),
                    Accion = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTransaccion", x => x.LogTransaccionID);
                });

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
