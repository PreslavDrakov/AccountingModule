using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingModule.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ComputationValue = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TypeValue = table.Column<int>(type: "int", nullable: false),
                    ScopeValue = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TypeValue = table.Column<int>(type: "int", nullable: false),
                    SalesPrice = table.Column<double>(type: "float", nullable: true),
                    CostPrice = table.Column<double>(type: "float", nullable: true),
                    CanBeSold = table.Column<bool>(type: "bit", nullable: false),
                    CanBePurchased = table.Column<bool>(type: "bit", nullable: false),
                    CustomerTaxesID = table.Column<int>(type: "int", nullable: false),
                    VendorTaxesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Tax_CustomerTaxesID",
                        column: x => x.CustomerTaxesID,
                        principalTable: "Tax",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Product_Tax_VendorTaxesID",
                        column: x => x.VendorTaxesID,
                        principalTable: "Tax",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CustomerTaxesID",
                table: "Product",
                column: "CustomerTaxesID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorTaxesID",
                table: "Product",
                column: "VendorTaxesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Tax");
        }
    }
}
