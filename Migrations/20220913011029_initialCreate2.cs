using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsAddressManagement.Migrations
{
    public partial class initialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactAddresses_Contacts_ContactId",
                table: "ContactAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAddresses",
                table: "ContactAddresses");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "ContactAddresses",
                newName: "ContactAddress");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAddresses_ContactId",
                table: "ContactAddress",
                newName: "IX_ContactAddress_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAddress_Contact_ContactId",
                table: "ContactAddress",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactAddress_Contact_ContactId",
                table: "ContactAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "ContactAddress",
                newName: "ContactAddresses");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAddress_ContactId",
                table: "ContactAddresses",
                newName: "IX_ContactAddresses_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAddresses",
                table: "ContactAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAddresses_Contacts_ContactId",
                table: "ContactAddresses",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
