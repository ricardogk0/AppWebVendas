using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAppWeb.Migrations
{
    public partial class _1507bd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Item_ItemId_item",
                table: "ItemVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Venda_VendaId",
                table: "ItemVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId_Cliente",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId_Vendedor",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ClienteId_Cliente",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_VendedorId_Vendedor",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_ItemVenda_ItemId_item",
                table: "ItemVenda");

            migrationBuilder.DropIndex(
                name: "IX_ItemVenda_VendaId",
                table: "ItemVenda");

            migrationBuilder.DropColumn(
                name: "ItemId_item",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "VendedorId_Vendedor",
                table: "Venda",
                newName: "CodVendedor");

            migrationBuilder.RenameColumn(
                name: "ClienteId_Cliente",
                table: "Venda",
                newName: "CodCliente");

            migrationBuilder.RenameColumn(
                name: "VendaId",
                table: "ItemVenda",
                newName: "CodItem");

            migrationBuilder.AddColumn<int>(
                name: "VendaIdVenda",
                table: "ItemVenda",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_VendaIdVenda",
                table: "ItemVenda",
                column: "VendaIdVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Venda_VendaIdVenda",
                table: "ItemVenda",
                column: "VendaIdVenda",
                principalTable: "Venda",
                principalColumn: "IdVenda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Venda_VendaIdVenda",
                table: "ItemVenda");

            migrationBuilder.DropIndex(
                name: "IX_ItemVenda_VendaIdVenda",
                table: "ItemVenda");

            migrationBuilder.DropColumn(
                name: "VendaIdVenda",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "CodVendedor",
                table: "Venda",
                newName: "VendedorId_Vendedor");

            migrationBuilder.RenameColumn(
                name: "CodCliente",
                table: "Venda",
                newName: "ClienteId_Cliente");

            migrationBuilder.RenameColumn(
                name: "CodItem",
                table: "ItemVenda",
                newName: "VendaId");

            migrationBuilder.AddColumn<int>(
                name: "ItemId_item",
                table: "ItemVenda",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId_Cliente",
                table: "Venda",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_VendedorId_Vendedor",
                table: "Venda",
                column: "VendedorId_Vendedor");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_ItemId_item",
                table: "ItemVenda",
                column: "ItemId_item");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_VendaId",
                table: "ItemVenda",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Item_ItemId_item",
                table: "ItemVenda",
                column: "ItemId_item",
                principalTable: "Item",
                principalColumn: "Id_item",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Venda_VendaId",
                table: "ItemVenda",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "IdVenda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId_Cliente",
                table: "Venda",
                column: "ClienteId_Cliente",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId_Vendedor",
                table: "Venda",
                column: "VendedorId_Vendedor",
                principalTable: "Vendedor",
                principalColumn: "Id_Vendedor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
