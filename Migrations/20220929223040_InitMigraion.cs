using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyNFTTracker.Migrations
{
    public partial class InitMigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorPrice = table.Column<decimal>(type: "decimal(9,8)", nullable: true),
                    ListedCount = table.Column<int>(type: "int", nullable: true),
                    AvgPrice24HrListedCount = table.Column<decimal>(type: "decimal(9,8)", nullable: true),
                    VolumeAll = table.Column<decimal>(type: "decimal(9,8)", nullable: true),
                    StakingLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WlTokenLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowData = table.Column<bool>(type: "bit", nullable: false),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasNft = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonFungibleToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MintAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellerFeeBasisPoints = table.Column<decimal>(type: "decimal(9,8)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RarityRank = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonFungibleToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonFungibleToken_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BalanceLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(9,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalanceLog_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profit = table.Column<decimal>(type: "decimal(9,8)", nullable: false),
                    Simulation = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherToken_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OtherToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(9,8)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NonFungibleTokenLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyingPrice = table.Column<decimal>(type: "decimal(9,8)", nullable: false),
                    BuyingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sold = table.Column<bool>(type: "bit", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "decimal(9,8)", nullable: true),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsedTool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Simulation = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NonFungibleTokenId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonFungibleTokenLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonFungibleTokenLine_NonFungibleToken_NonFungibleTokenId",
                        column: x => x.NonFungibleTokenId,
                        principalTable: "NonFungibleToken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_NonFungibleTokenLine_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BalanceHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(9,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BalanceHistory_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceHistory_WalletId",
                table: "BalanceHistory",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_BalanceLog_UserId",
                table: "BalanceLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NonFungibleToken_ProjectId",
                table: "NonFungibleToken",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_NonFungibleTokenLine_NonFungibleTokenId",
                table: "NonFungibleTokenLine",
                column: "NonFungibleTokenId");

            migrationBuilder.CreateIndex(
                name: "IX_NonFungibleTokenLine_UserId",
                table: "NonFungibleTokenLine",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherToken_ProjectId",
                table: "OtherToken",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherToken_UserId",
                table: "OtherToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceHistory");

            migrationBuilder.DropTable(
                name: "BalanceLog");

            migrationBuilder.DropTable(
                name: "NonFungibleTokenLine");

            migrationBuilder.DropTable(
                name: "OtherToken");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "NonFungibleToken");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
