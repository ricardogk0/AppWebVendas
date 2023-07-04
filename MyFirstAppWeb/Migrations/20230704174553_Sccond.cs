using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAppWeb.Migrations
{
    public partial class Sccond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Item_ItemId",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vendedor",
                newName: "Id_Vendedor");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Venda",
                newName: "VendedorId_Vendedor");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Venda",
                newName: "ItemId_item");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Venda",
                newName: "ClienteId_Cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Venda",
                newName: "id_venda");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_VendedorId",
                table: "Venda",
                newName: "IX_Venda_VendedorId_Vendedor");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ItemId",
                table: "Venda",
                newName: "IX_Venda_ItemId_item");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                newName: "IX_Venda_ClienteId_Cliente");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Item",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Item",
                newName: "Id_item");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "Id_Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Numero_Cupom",
                table: "Venda",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Venda",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId_Cliente",
                table: "Venda",
                column: "ClienteId_Cliente",
                principalTable: "Cliente",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Item_ItemId_item",
                table: "Venda",
                column: "ItemId_item",
                principalTable: "Item",
                principalColumn: "Id_item",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId_Vendedor",
                table: "Venda",
                column: "VendedorId_Vendedor",
                principalTable: "Vendedor",
                principalColumn: "Id_Vendedor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId_Cliente",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Item_ItemId_item",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Vendedor_VendedorId_Vendedor",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Numero_Cupom",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "Id_Vendedor",
                table: "Vendedor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VendedorId_Vendedor",
                table: "Venda",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "ItemId_item",
                table: "Venda",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "ClienteId_Cliente",
                table: "Venda",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "id_venda",
                table: "Venda",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_VendedorId_Vendedor",
                table: "Venda",
                newName: "IX_Venda_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ItemId_item",
                table: "Venda",
                newName: "IX_Venda_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ClienteId_Cliente",
                table: "Venda",
                newName: "IX_Venda_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Item",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Id_item",
                table: "Item",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Id_Cliente",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Item_ItemId",
                table: "Venda",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Vendedor_VendedorId",
                table: "Venda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
