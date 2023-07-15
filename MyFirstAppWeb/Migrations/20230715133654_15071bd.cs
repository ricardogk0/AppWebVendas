using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAppWeb.Migrations
{
    public partial class _15071bd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Venda_VendaIdVenda",
                table: "ItemVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venda",
                table: "Venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVenda",
                table: "ItemVenda");

            migrationBuilder.RenameTable(
                name: "Venda",
                newName: "venda");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "item");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "cliente");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "vendedores");

            migrationBuilder.RenameTable(
                name: "ItemVenda",
                newName: "item_venda");

            migrationBuilder.RenameColumn(
                name: "Numero_Cupom",
                table: "venda",
                newName: "numero_cupom");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "venda",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "venda",
                newName: "valor_total");

            migrationBuilder.RenameColumn(
                name: "CodVendedor",
                table: "venda",
                newName: "cod_vendedor");

            migrationBuilder.RenameColumn(
                name: "CodCliente",
                table: "venda",
                newName: "cod_cliente");

            migrationBuilder.RenameColumn(
                name: "IdVenda",
                table: "venda",
                newName: "id_venda");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "item",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "item",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "item",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Id_item",
                table: "item",
                newName: "id_item");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "cliente",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cpf_Cnpj",
                table: "cliente",
                newName: "cpf_cnpj");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "cliente",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Id_Cliente",
                table: "cliente",
                newName: "id_cliente");

            migrationBuilder.RenameColumn(
                name: "TipoCliente",
                table: "cliente",
                newName: "tipo_cliente");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "vendedores",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "vendedores",
                newName: "codigo");

            migrationBuilder.RenameColumn(
                name: "Id_Vendedor",
                table: "vendedores",
                newName: "id_vendedor");

            migrationBuilder.RenameColumn(
                name: "SalarioBase",
                table: "vendedores",
                newName: "salario_base");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "item_venda",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "CodItem",
                table: "item_venda",
                newName: "cod_item");

            migrationBuilder.RenameColumn(
                name: "IdItemVenda",
                table: "item_venda",
                newName: "id_item_venda");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_VendaIdVenda",
                table: "item_venda",
                newName: "IX_item_venda_VendaIdVenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_venda",
                table: "venda",
                column: "id_venda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_item",
                table: "item",
                column: "id_item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "id_cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendedores",
                table: "vendedores",
                column: "id_vendedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_item_venda",
                table: "item_venda",
                column: "id_item_venda");

            migrationBuilder.AddForeignKey(
                name: "FK_item_venda_venda_VendaIdVenda",
                table: "item_venda",
                column: "VendaIdVenda",
                principalTable: "venda",
                principalColumn: "id_venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_venda_venda_VendaIdVenda",
                table: "item_venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_venda",
                table: "venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item",
                table: "item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendedores",
                table: "vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_item_venda",
                table: "item_venda");

            migrationBuilder.RenameTable(
                name: "venda",
                newName: "Venda");

            migrationBuilder.RenameTable(
                name: "item",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "vendedores",
                newName: "Vendedor");

            migrationBuilder.RenameTable(
                name: "item_venda",
                newName: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "numero_cupom",
                table: "Venda",
                newName: "Numero_Cupom");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Venda",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "valor_total",
                table: "Venda",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "cod_vendedor",
                table: "Venda",
                newName: "CodVendedor");

            migrationBuilder.RenameColumn(
                name: "cod_cliente",
                table: "Venda",
                newName: "CodCliente");

            migrationBuilder.RenameColumn(
                name: "id_venda",
                table: "Venda",
                newName: "IdVenda");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Item",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Item",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Item",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "id_item",
                table: "Item",
                newName: "Id_item");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cpf_cnpj",
                table: "Cliente",
                newName: "Cpf_Cnpj");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Cliente",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "id_cliente",
                table: "Cliente",
                newName: "Id_Cliente");

            migrationBuilder.RenameColumn(
                name: "tipo_cliente",
                table: "Cliente",
                newName: "TipoCliente");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Vendedor",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "codigo",
                table: "Vendedor",
                newName: "Codigo");

            migrationBuilder.RenameColumn(
                name: "id_vendedor",
                table: "Vendedor",
                newName: "Id_Vendedor");

            migrationBuilder.RenameColumn(
                name: "salario_base",
                table: "Vendedor",
                newName: "SalarioBase");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "ItemVenda",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "cod_item",
                table: "ItemVenda",
                newName: "CodItem");

            migrationBuilder.RenameColumn(
                name: "id_item_venda",
                table: "ItemVenda",
                newName: "IdItemVenda");

            migrationBuilder.RenameIndex(
                name: "IX_item_venda_VendaIdVenda",
                table: "ItemVenda",
                newName: "IX_ItemVenda_VendaIdVenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venda",
                table: "Venda",
                column: "IdVenda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id_item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id_Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "Id_Vendedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVenda",
                table: "ItemVenda",
                column: "IdItemVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Venda_VendaIdVenda",
                table: "ItemVenda",
                column: "VendaIdVenda",
                principalTable: "Venda",
                principalColumn: "IdVenda");
        }
    }
}
