using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickDriveRentDomainPersistance.Migrations
{
    /// <inheritdoc />
    public partial class Edit_entites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Categories_CategoryId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CoverImgUrl",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Blogs",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                newName: "IX_Blogs_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverImgUrl",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogId",
                table: "Blogs",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Blogs_BlogId",
                table: "Blogs",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Blogs_BlogId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CoverImgUrl",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Blogs",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                newName: "IX_Blogs_CategoryID");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CoverImgUrl",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CategoryId",
                table: "Authors",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Categories_CategoryId",
                table: "Authors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryID",
                table: "Blogs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID");
        }
    }
}
