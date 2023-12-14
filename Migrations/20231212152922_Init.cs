using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Crudblazorserve2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiaires",
                columns: table => new
                {
                    Id_beneficiaire = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    designation_beneficiaire = table.Column<string>(type: "text", nullable: false),
                    libelle_projet = table.Column<string>(type: "text", nullable: false),
                    telephone1 = table.Column<int>(type: "integer", nullable: false),
                    telephone2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaires", x => x.Id_beneficiaire);
                });

            migrationBuilder.CreateTable(
                name: "Cautions",
                columns: table => new
                {
                    idcaution = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numappeloffre = table.Column<string>(type: "text", nullable: false),
                    numcaution = table.Column<string>(type: "text", nullable: false),
                    datecaution = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    travaux = table.Column<string>(type: "text", nullable: false),
                    devise = table.Column<string>(type: "text", nullable: false),
                    montantlettre = table.Column<string>(type: "text", nullable: false),
                    montant = table.Column<double>(type: "double precision", nullable: false),
                    raisonsocialecli = table.Column<string>(type: "text", nullable: false),
                    numrccli = table.Column<string>(type: "text", nullable: false),
                    bpcli = table.Column<string>(type: "text", nullable: false),
                    telephone1cli = table.Column<string>(type: "text", nullable: false),
                    telephone2cli = table.Column<string>(type: "text", nullable: false),
                    libbeneficiaire = table.Column<string>(type: "text", nullable: false),
                    projetbeneficiaire = table.Column<string>(type: "text", nullable: false),
                    tel1bene = table.Column<string>(type: "text", nullable: false),
                    tel2bene = table.Column<string>(type: "text", nullable: false),
                    addresscli = table.Column<string>(type: "text", nullable: false),
                    addressbene = table.Column<string>(type: "text", nullable: false),
                    emailcli = table.Column<string>(type: "text", nullable: false),
                    emailbene = table.Column<string>(type: "text", nullable: false),
                    bpbene = table.Column<string>(type: "text", nullable: false),
                    codepaysbene = table.Column<string>(type: "text", nullable: false),
                    codepayscli = table.Column<string>(type: "text", nullable: false),
                    article = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cautions", x => x.idcaution);
                });

            migrationBuilder.CreateTable(
                name: "Donneurordres",
                columns: table => new
                {
                    id_client = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    raison_sociale = table.Column<string>(type: "text", nullable: false),
                    num_registre_commerce = table.Column<string>(type: "text", nullable: false),
                    bp = table.Column<string>(type: "text", nullable: false),
                    telephone1 = table.Column<int>(type: "integer", nullable: false),
                    telephone2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donneurordres", x => x.id_client);
                });

            migrationBuilder.CreateTable(
                name: "Typearticles",
                columns: table => new
                {
                    id_article = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    libelle_article = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typearticles", x => x.id_article);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiaires");

            migrationBuilder.DropTable(
                name: "Cautions");

            migrationBuilder.DropTable(
                name: "Donneurordres");

            migrationBuilder.DropTable(
                name: "Typearticles");
        }
    }
}
