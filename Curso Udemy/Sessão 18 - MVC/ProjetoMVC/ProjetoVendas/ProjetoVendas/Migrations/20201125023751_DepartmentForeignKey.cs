﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoVendas.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "DepartMentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartMentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartMentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartMentId",
                table: "Seller",
                column: "DepartMentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartMentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "DepartMentId",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartMentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
