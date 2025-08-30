using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_books_bb_ks_bbk_id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "fk_books_ud_ks_udk_id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ud_ks",
                table: "ud_ks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_bb_ks",
                table: "bb_ks");

            migrationBuilder.RenameTable(
                name: "ud_ks",
                newName: "udk");

            migrationBuilder.RenameTable(
                name: "bb_ks",
                newName: "bbk");

            migrationBuilder.RenameIndex(
                name: "ix_ud_ks_code",
                table: "udk",
                newName: "ix_udk_code");

            migrationBuilder.RenameIndex(
                name: "ix_bb_ks_code",
                table: "bbk",
                newName: "ix_bbk_code");

            migrationBuilder.AddPrimaryKey(
                name: "pk_udk",
                table: "udk",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_bbk",
                table: "bbk",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_bbk_bbk_id",
                table: "books",
                column: "bbk_id",
                principalTable: "bbk",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_udk_udk_id",
                table: "books",
                column: "udk_id",
                principalTable: "udk",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_books_bbk_bbk_id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "fk_books_udk_udk_id",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "pk_udk",
                table: "udk");

            migrationBuilder.DropPrimaryKey(
                name: "pk_bbk",
                table: "bbk");

            migrationBuilder.RenameTable(
                name: "udk",
                newName: "ud_ks");

            migrationBuilder.RenameTable(
                name: "bbk",
                newName: "bb_ks");

            migrationBuilder.RenameIndex(
                name: "ix_udk_code",
                table: "ud_ks",
                newName: "ix_ud_ks_code");

            migrationBuilder.RenameIndex(
                name: "ix_bbk_code",
                table: "bb_ks",
                newName: "ix_bb_ks_code");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ud_ks",
                table: "ud_ks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_bb_ks",
                table: "bb_ks",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_bb_ks_bbk_id",
                table: "books",
                column: "bbk_id",
                principalTable: "bb_ks",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_books_ud_ks_udk_id",
                table: "books",
                column: "udk_id",
                principalTable: "ud_ks",
                principalColumn: "id");
        }
    }
}
