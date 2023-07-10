using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyFirstAppWeb.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Item_ItemId_item",
                table: "Venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venda",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ItemId_item",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "id_venda",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Venda",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "ItemId_item",
                table: "Venda",
                newName: "IdVenda");

            migrationBuilder.AlterColumn<int>(
                name: "IdVenda",
                table: "Venda",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venda",
                table: "Venda",
                column: "IdVenda");

            migrationBuilder.CreateTable(
                name: "ItemVenda",
                columns: table => new
                {
                    IdItemVenda = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VendaId = table.Column<int>(type: "integer", nullable: false),
                    ItemId_item = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVenda", x => x.IdItemVenda);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Item_ItemId_item",
                        column: x => x.ItemId_item,
                        principalTable: "Item",
                        principalColumn: "Id_item",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVenda_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "IdVenda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_ItemId_item",
                table: "ItemVenda",
                column: "ItemId_item");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVenda_VendaId",
                table: "ItemVenda",
                column: "VendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venda",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Venda",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "Venda",
                newName: "ItemId_item");

            migrationBuilder.AlterColumn<int>(
                name: "ItemId_item",
                table: "Venda",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id_venda",
                table: "Venda",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<double>(
                name: "Quantidade",
                table: "Venda",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venda",
                table: "Venda",
                column: "id_venda");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ItemId_item",
                table: "Venda",
                column: "ItemId_item");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Item_ItemId_item",
                table: "Venda",
                column: "ItemId_item",
                principalTable: "Item",
                principalColumn: "Id_item",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
