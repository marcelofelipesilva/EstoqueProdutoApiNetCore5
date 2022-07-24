using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueProdutoApi.Migrations
{
    public partial class atualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ContatoAcesso",
                columns: table => new
                {
                    ContaAcessoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Matricula = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ContatoAcesso", x => x.ContaAcessoID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Fornecedor",
                columns: table => new
                {
                    FornecedorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Fornecedor", x => x.FornecedorID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Produto",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Produto", x => x.ProdutoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ContatoAcesso");

            migrationBuilder.DropTable(
                name: "TB_Fornecedor");

            migrationBuilder.DropTable(
                name: "TB_Produto");
        }
    }
}
