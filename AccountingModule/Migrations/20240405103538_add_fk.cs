using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingModule.Migrations
{
    /// <inheritdoc />
    public partial class add_fk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerTaxesID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendorTaxesID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomerTaxesID",
                table: "Product",
                column: "CustomerTaxesID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorTaxesID",
                table: "Product",
                column: "VendorTaxesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Tax_CustomerTaxesID",
                table: "Product",
                column: "CustomerTaxesID",
                principalTable: "Tax",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Tax_VendorTaxesID",
                table: "Product",
                column: "VendorTaxesID",
                principalTable: "Tax",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Tax_CustomerTaxesID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Tax_VendorTaxesID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CustomerTaxesID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_VendorTaxesID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CustomerTaxesID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "VendorTaxesID",
                table: "Product");
        }
    }
}
