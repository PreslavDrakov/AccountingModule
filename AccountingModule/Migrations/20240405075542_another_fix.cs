using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingModule.Migrations
{
    /// <inheritdoc />
    public partial class another_fix : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "VendorTaxesID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeValue",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerTaxesID",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "VendorTaxesID",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeValue",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerTaxesID",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
