﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           //migrationBuilder.CreateTable(
            //   name: "Expenses",
            //   columns: table => new
            //   {
            //       Id = table.Column<int>(nullable: false)
             //         .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
              //     Description = table.Column<string>(nullable: false),
             //       Sum = table.Column<int>(nullable: false),
             //       Location = table.Column<string>(nullable: true),
             //     Date = table.Column<DateTime>(nullable: false),
             //      Currency = table.Column<string>(nullable: true),
             //      Type = table.Column<int>(nullable: false)
             //   },
            //    constraints: table =>
           //  {
            //     table.primarykey("pk_expenses", x => x.id);
             // });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");
        }
    }
}
