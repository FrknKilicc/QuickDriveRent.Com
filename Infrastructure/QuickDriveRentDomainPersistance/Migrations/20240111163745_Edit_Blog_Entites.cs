﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickDriveRentDomainPersistance.Migrations
{
    /// <inheritdoc />
    public partial class Edit_Blog_Entites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Blogs");
        }
    }
}
