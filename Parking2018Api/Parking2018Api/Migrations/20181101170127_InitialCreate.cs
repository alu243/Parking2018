using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parking2018Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_AGECY_SYS_DATA",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    SEQ = table.Column<string>(maxLength: 10, nullable: true),
                    AGECY_DAY = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_AGECY_SYS_DATA", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_BILL",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    BT_NO = table.Column<string>(maxLength: 1, nullable: true),
                    BILL_NO = table.Column<string>(maxLength: 16, nullable: true),
                    EMPY_NO = table.Column<string>(maxLength: 20, nullable: true),
                    PDA_NO = table.Column<string>(maxLength: 16, nullable: true),
                    KEY_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    START_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    END_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    CAR_NO = table.Column<string>(nullable: true),
                    KIND_NO = table.Column<string>(maxLength: 3, nullable: true),
                    CLR_NO = table.Column<string>(maxLength: 2, nullable: true),
                    CK_NO = table.Column<string>(maxLength: 3, nullable: true),
                    ROAD_NO = table.Column<string>(maxLength: 6, nullable: true),
                    GIRD_NO = table.Column<string>(maxLength: 11, nullable: true),
                    START_TIME = table.Column<string>(maxLength: 4, nullable: true),
                    END_TIME = table.Column<string>(maxLength: 4, nullable: true),
                    RATE = table.Column<int>(nullable: false),
                    TIME_QTY = table.Column<int>(nullable: false),
                    AMOUNT = table.Column<int>(nullable: false),
                    FK_NO = table.Column<string>(maxLength: 2, nullable: true),
                    PDA_PRINT = table.Column<string>(maxLength: 1, nullable: true),
                    PRINT_CNT = table.Column<int>(nullable: false),
                    CANCEL_YN = table.Column<string>(maxLength: 1, nullable: true),
                    FINISH_YN = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BILL", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_BILL_REC",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    SEQ_NO = table.Column<string>(maxLength: 3, nullable: true),
                    BILL_NO = table.Column<string>(maxLength: 16, nullable: true),
                    END_TIME = table.Column<string>(maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_BILL_REC", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_CAR_KIND",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    CK_NO = table.Column<string>(maxLength: 3, nullable: true),
                    CK_NAME = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CAR_KIND", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_CLASS",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    CLASS_NO = table.Column<string>(maxLength: 1, nullable: true),
                    CLASS_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    WORK_TIME = table.Column<int>(nullable: false),
                    START_TIME = table.Column<int>(maxLength: 4, nullable: false),
                    END_TIME = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_CLASS", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_COLOR",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    CLR_NO = table.Column<string>(maxLength: 4, nullable: true),
                    CLR_NAME = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_COLOR", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_DEFECTIVE_CAR",
                columns: table => new
                {
                    SEQ = table.Column<string>(maxLength: 11, nullable: false),
                    CERTIFIED_NO = table.Column<string>(maxLength: 20, nullable: true),
                    CAR_NO = table.Column<string>(maxLength: 10, nullable: true),
                    START_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    END_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    AREA_CODE = table.Column<string>(maxLength: 2, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DEFECTIVE_CAR", x => x.SEQ);
                });

            migrationBuilder.CreateTable(
                name: "M_DEFECTIVE_USE",
                columns: table => new
                {
                    BILL_NO = table.Column<string>(maxLength: 16, nullable: false),
                    CERTIFIED_NO = table.Column<string>(maxLength: 20, nullable: true),
                    CAR_NO1 = table.Column<string>(maxLength: 10, nullable: true),
                    CAR_NO2 = table.Column<string>(maxLength: 10, nullable: true),
                    USE_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DEFECTIVE_USE", x => x.BILL_NO);
                });

            migrationBuilder.CreateTable(
                name: "M_FREE_CAR",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    YEAR = table.Column<string>(maxLength: 4, nullable: true),
                    FK_NO = table.Column<string>(maxLength: 2, nullable: true),
                    PARK_NO = table.Column<string>(maxLength: 9, nullable: true),
                    KIND_NO = table.Column<string>(maxLength: 3, nullable: true),
                    CAR_NO = table.Column<string>(maxLength: 10, nullable: true),
                    P_START_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    P_END_DATE = table.Column<string>(maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_FREE_CAR", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_FREE_KIND",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    FK_NO = table.Column<string>(maxLength: 2, nullable: true),
                    FK_NAME = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_FREE_KIND", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_GIRD",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    GIRD_NO = table.Column<string>(maxLength: 11, nullable: true),
                    GIRD_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    GT_NO = table.Column<string>(maxLength: 1, nullable: true),
                    AMOUNT_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    AMOUNT = table.Column<int>(nullable: false),
                    G_LEVEL = table.Column<int>(nullable: false),
                    MAX_HOUR = table.Column<int>(nullable: false),
                    SPEC_AMOUNT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_GIRD", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_GIRD_TYPE",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    GT_NO = table.Column<string>(maxLength: 1, nullable: true),
                    GT_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    QTY_YN = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_GIRD_TYPE", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_KIND",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    KIND_NO = table.Column<string>(maxLength: 3, nullable: true),
                    KIND_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    AMOUNT1 = table.Column<int>(nullable: false),
                    AMOUNT2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_KIND", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDA_CLASS_WEAVE",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    C_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    EMPY_NO = table.Column<string>(maxLength: 20, nullable: true),
                    ROAD_NO = table.Column<string>(maxLength: 6, nullable: true),
                    CLASS_NO = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDA_CLASS_WEAVE", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDA_GROUP",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    PDA_NO = table.Column<string>(maxLength: 16, nullable: true),
                    EMPY_NO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDA_GROUP", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDA_PARAMETER",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SYS_CODE = table.Column<string>(maxLength: 10, nullable: true),
                    CODE = table.Column<string>(maxLength: 2, nullable: true),
                    STIME = table.Column<string>(maxLength: 6, nullable: true),
                    ETIME = table.Column<string>(maxLength: 6, nullable: true),
                    FREE_MINUTE = table.Column<int>(nullable: false),
                    FREES_MINUTE = table.Column<int>(nullable: false),
                    HOLIDAY_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    I1 = table.Column<int>(nullable: false),
                    I2 = table.Column<int>(nullable: false),
                    I3 = table.Column<int>(nullable: false),
                    C1 = table.Column<string>(maxLength: 50, nullable: true),
                    C2 = table.Column<string>(maxLength: 5, nullable: true),
                    C3 = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDA_PARAMETER", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_PDA_PASSWORD",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    C_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    C_PASSWORD = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_PDA_PASSWORD", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_ROAD",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    ROAD_NO = table.Column<string>(maxLength: 6, nullable: true),
                    ROAD_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    ROAD_RANGE = table.Column<string>(maxLength: 80, nullable: true),
                    ROAD_NUM = table.Column<int>(nullable: false),
                    ROAD_TYPE = table.Column<string>(maxLength: 1, nullable: true),
                    CELL_NO = table.Column<string>(maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_ROAD", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_SEQNO",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    PDA_NO = table.Column<string>(maxLength: 16, nullable: true),
                    SEQ_NO = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SEQNO", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_SPOILS_CAR",
                columns: table => new
                {
                    CAR_NO = table.Column<string>(maxLength: 10, nullable: false),
                    CREATED = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SPOILS_CAR", x => x.CAR_NO);
                });

            migrationBuilder.CreateTable(
                name: "M_SPOILSBILL",
                columns: table => new
                {
                    BILL_NO = table.Column<string>(maxLength: 16, nullable: false),
                    CAR_NO = table.Column<string>(maxLength: 10, nullable: true),
                    QUERY_DATETIME = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SPOILSBILL", x => x.BILL_NO);
                });

            migrationBuilder.CreateTable(
                name: "M_SYSTEM",
                columns: table => new
                {
                    SEQ_NO = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SYS_NAME = table.Column<string>(maxLength: 50, nullable: true),
                    VER_NO = table.Column<string>(maxLength: 10, nullable: true),
                    PRT_CONTRAST = table.Column<string>(maxLength: 1, nullable: true),
                    PRT_NB_WIDTH = table.Column<string>(maxLength: 1, nullable: true),
                    PRT_RATIO = table.Column<string>(maxLength: 1, nullable: true),
                    PRT_SPEED = table.Column<string>(maxLength: 1, nullable: true),
                    RCV_ID = table.Column<string>(maxLength: 3, nullable: true),
                    FREE_ID = table.Column<string>(maxLength: 2, nullable: true),
                    LARGE_GIRD = table.Column<string>(maxLength: 1, nullable: true),
                    TIMESRV_IP = table.Column<string>(maxLength: 50, nullable: true),
                    TIMESRV_PORT = table.Column<string>(maxLength: 6, nullable: true),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_SYSTEM", x => x.SEQ_NO);
                });

            migrationBuilder.CreateTable(
                name: "M_TICKET",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    YEAR = table.Column<string>(maxLength: 6, nullable: true),
                    IDENTITY_NO = table.Column<string>(maxLength: 8, nullable: true),
                    CAR_NO = table.Column<string>(maxLength: 10, nullable: true),
                    T_START_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    T_END_DATE = table.Column<string>(maxLength: 8, nullable: true),
                    ROAD_NO = table.Column<string>(maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_TICKET", x => x.PKID);
                });

            migrationBuilder.CreateTable(
                name: "M_USERNM",
                columns: table => new
                {
                    PKID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LAST_MODIFIED = table.Column<DateTime>(nullable: false),
                    LAST_MODIFYBY = table.Column<string>(maxLength: 20, nullable: true),
                    CREATED = table.Column<DateTime>(nullable: false),
                    CREATEBY = table.Column<string>(maxLength: 20, nullable: true),
                    EMPY_NO = table.Column<string>(maxLength: 20, nullable: true),
                    CNAME = table.Column<string>(maxLength: 50, nullable: true),
                    PSWD = table.Column<string>(maxLength: 40, nullable: true),
                    PDA_NO = table.Column<string>(maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_USERNM", x => x.PKID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M_AGECY_SYS_DATA_SEQ",
                table: "M_AGECY_SYS_DATA",
                column: "SEQ",
                unique: true,
                filter: "[SEQ] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_BILL_BT_NO_BILL_NO",
                table: "M_BILL",
                columns: new[] { "BT_NO", "BILL_NO" },
                unique: true,
                filter: "[BT_NO] IS NOT NULL AND [BILL_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_BILL_REC_SEQ_NO_BILL_NO",
                table: "M_BILL_REC",
                columns: new[] { "SEQ_NO", "BILL_NO" },
                unique: true,
                filter: "[SEQ_NO] IS NOT NULL AND [BILL_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_CAR_KIND_CK_NO_CK_NAME",
                table: "M_CAR_KIND",
                columns: new[] { "CK_NO", "CK_NAME" },
                unique: true,
                filter: "[CK_NO] IS NOT NULL AND [CK_NAME] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_CLASS_CLASS_NO",
                table: "M_CLASS",
                column: "CLASS_NO",
                unique: true,
                filter: "[CLASS_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_COLOR_CLR_NO",
                table: "M_COLOR",
                column: "CLR_NO",
                unique: true,
                filter: "[CLR_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_FREE_CAR_YEAR_FK_NO_PARK_NO",
                table: "M_FREE_CAR",
                columns: new[] { "YEAR", "FK_NO", "PARK_NO" },
                unique: true,
                filter: "[YEAR] IS NOT NULL AND [FK_NO] IS NOT NULL AND [PARK_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_FREE_KIND_FK_NO",
                table: "M_FREE_KIND",
                column: "FK_NO",
                unique: true,
                filter: "[FK_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_GIRD_GIRD_NO",
                table: "M_GIRD",
                column: "GIRD_NO",
                unique: true,
                filter: "[GIRD_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_GIRD_TYPE_GT_NO",
                table: "M_GIRD_TYPE",
                column: "GT_NO",
                unique: true,
                filter: "[GT_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_KIND_KIND_NO",
                table: "M_KIND",
                column: "KIND_NO",
                unique: true,
                filter: "[KIND_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_PDA_CLASS_WEAVE_C_DATE_EMPY_NO_ROAD_NO_CLASS_NO",
                table: "M_PDA_CLASS_WEAVE",
                columns: new[] { "C_DATE", "EMPY_NO", "ROAD_NO", "CLASS_NO" },
                unique: true,
                filter: "[C_DATE] IS NOT NULL AND [EMPY_NO] IS NOT NULL AND [ROAD_NO] IS NOT NULL AND [CLASS_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_PDA_GROUP_PDA_NO_EMPY_NO",
                table: "M_PDA_GROUP",
                columns: new[] { "PDA_NO", "EMPY_NO" },
                unique: true,
                filter: "[PDA_NO] IS NOT NULL AND [EMPY_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_PDA_PARAMETER_SYS_CODE_CODE",
                table: "M_PDA_PARAMETER",
                columns: new[] { "SYS_CODE", "CODE" },
                unique: true,
                filter: "[SYS_CODE] IS NOT NULL AND [CODE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_PDA_PASSWORD_C_DATE",
                table: "M_PDA_PASSWORD",
                column: "C_DATE",
                unique: true,
                filter: "[C_DATE] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_ROAD_ROAD_NO",
                table: "M_ROAD",
                column: "ROAD_NO",
                unique: true,
                filter: "[ROAD_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_SEQNO_PDA_NO",
                table: "M_SEQNO",
                column: "PDA_NO",
                unique: true,
                filter: "[PDA_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_TICKET_YEAR_IDENTITY_NO",
                table: "M_TICKET",
                columns: new[] { "YEAR", "IDENTITY_NO" },
                unique: true,
                filter: "[YEAR] IS NOT NULL AND [IDENTITY_NO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_M_USERNM_EMPY_NO",
                table: "M_USERNM",
                column: "EMPY_NO",
                unique: true,
                filter: "[EMPY_NO] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_AGECY_SYS_DATA");

            migrationBuilder.DropTable(
                name: "M_BILL");

            migrationBuilder.DropTable(
                name: "M_BILL_REC");

            migrationBuilder.DropTable(
                name: "M_CAR_KIND");

            migrationBuilder.DropTable(
                name: "M_CLASS");

            migrationBuilder.DropTable(
                name: "M_COLOR");

            migrationBuilder.DropTable(
                name: "M_DEFECTIVE_CAR");

            migrationBuilder.DropTable(
                name: "M_DEFECTIVE_USE");

            migrationBuilder.DropTable(
                name: "M_FREE_CAR");

            migrationBuilder.DropTable(
                name: "M_FREE_KIND");

            migrationBuilder.DropTable(
                name: "M_GIRD");

            migrationBuilder.DropTable(
                name: "M_GIRD_TYPE");

            migrationBuilder.DropTable(
                name: "M_KIND");

            migrationBuilder.DropTable(
                name: "M_PDA_CLASS_WEAVE");

            migrationBuilder.DropTable(
                name: "M_PDA_GROUP");

            migrationBuilder.DropTable(
                name: "M_PDA_PARAMETER");

            migrationBuilder.DropTable(
                name: "M_PDA_PASSWORD");

            migrationBuilder.DropTable(
                name: "M_ROAD");

            migrationBuilder.DropTable(
                name: "M_SEQNO");

            migrationBuilder.DropTable(
                name: "M_SPOILS_CAR");

            migrationBuilder.DropTable(
                name: "M_SPOILSBILL");

            migrationBuilder.DropTable(
                name: "M_SYSTEM");

            migrationBuilder.DropTable(
                name: "M_TICKET");

            migrationBuilder.DropTable(
                name: "M_USERNM");
        }
    }
}
