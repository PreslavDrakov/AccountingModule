using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingModule.Migrations
{
    /// <inheritdoc />
    public partial class validate_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Tax_CustomerTaxesID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Tax_VendorTaxesID",
                table: "Product");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Tax_CustomerTaxesID",
                table: "Product",
                column: "CustomerTaxesID",
                principalTable: "Tax",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Tax_VendorTaxesID",
                table: "Product",
                column: "VendorTaxesID",
                principalTable: "Tax",
                principalColumn: "ID");
        }
    }
}
