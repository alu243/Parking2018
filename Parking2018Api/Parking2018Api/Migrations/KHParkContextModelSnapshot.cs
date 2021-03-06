﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parking2018Api.EF;

namespace Parking2018Api.Migrations
{
    [DbContext(typeof(KHParkContext))]
    partial class KHParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parking2018Api.Models.M_AGECY_SYS_DATA", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AGECY_DAY");

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("SEQ")
                        .HasMaxLength(10);

                    b.HasKey("PKID");

                    b.HasIndex("SEQ")
                        .IsUnique()
                        .HasFilter("[SEQ] IS NOT NULL");

                    b.ToTable("M_AGECY_SYS_DATA");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_BILL", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AMOUNT");

                    b.Property<string>("BILL_NO")
                        .HasMaxLength(16);

                    b.Property<string>("BT_NO")
                        .HasMaxLength(1);

                    b.Property<string>("CANCEL_YN")
                        .HasMaxLength(1);

                    b.Property<string>("CAR_NO");

                    b.Property<string>("CK_NO")
                        .HasMaxLength(3);

                    b.Property<string>("CLR_NO")
                        .HasMaxLength(2);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("EMPY_NO")
                        .HasMaxLength(20);

                    b.Property<string>("END_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("END_TIME")
                        .HasMaxLength(4);

                    b.Property<string>("FINISH_YN")
                        .HasMaxLength(1);

                    b.Property<string>("FK_NO")
                        .HasMaxLength(2);

                    b.Property<string>("GIRD_NO")
                        .HasMaxLength(11);

                    b.Property<string>("KEY_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("KIND_NO")
                        .HasMaxLength(3);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PDA_NO")
                        .HasMaxLength(16);

                    b.Property<string>("PDA_PRINT")
                        .HasMaxLength(1);

                    b.Property<int>("PRINT_CNT");

                    b.Property<int>("RATE");

                    b.Property<string>("ROAD_NO")
                        .HasMaxLength(6);

                    b.Property<string>("START_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("START_TIME")
                        .HasMaxLength(4);

                    b.Property<int>("TIME_QTY");

                    b.HasKey("PKID");

                    b.HasIndex("BT_NO", "BILL_NO")
                        .IsUnique()
                        .HasFilter("[BT_NO] IS NOT NULL AND [BILL_NO] IS NOT NULL");

                    b.ToTable("M_BILL");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_BILL_REC", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BILL_NO")
                        .HasMaxLength(16);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("END_TIME")
                        .HasMaxLength(4);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("SEQ_NO")
                        .HasMaxLength(3);

                    b.HasKey("PKID");

                    b.HasIndex("SEQ_NO", "BILL_NO")
                        .IsUnique()
                        .HasFilter("[SEQ_NO] IS NOT NULL AND [BILL_NO] IS NOT NULL");

                    b.ToTable("M_BILL_REC");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_CAR_KIND", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CK_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("CK_NO")
                        .HasMaxLength(3);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("CK_NO", "CK_NAME")
                        .IsUnique()
                        .HasFilter("[CK_NO] IS NOT NULL AND [CK_NAME] IS NOT NULL");

                    b.ToTable("M_CAR_KIND");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_CLASS", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CLASS_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("CLASS_NO")
                        .HasMaxLength(1);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<int>("END_TIME")
                        .HasMaxLength(4);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<int>("START_TIME")
                        .HasMaxLength(4);

                    b.Property<int>("WORK_TIME");

                    b.HasKey("PKID");

                    b.HasIndex("CLASS_NO")
                        .IsUnique()
                        .HasFilter("[CLASS_NO] IS NOT NULL");

                    b.ToTable("M_CLASS");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_COLOR", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CLR_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("CLR_NO")
                        .HasMaxLength(4);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("CLR_NO")
                        .IsUnique()
                        .HasFilter("[CLR_NO] IS NOT NULL");

                    b.ToTable("M_COLOR");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_DEFECTIVE_CAR", b =>
                {
                    b.Property<string>("SEQ")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11);

                    b.Property<string>("AREA_CODE")
                        .HasMaxLength(2);

                    b.Property<string>("CAR_NO")
                        .HasMaxLength(10);

                    b.Property<string>("CERTIFIED_NO")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("END_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("START_DATE")
                        .HasMaxLength(8);

                    b.HasKey("SEQ");

                    b.ToTable("M_DEFECTIVE_CAR");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_DEFECTIVE_USE", b =>
                {
                    b.Property<string>("BILL_NO")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(16);

                    b.Property<string>("CAR_NO1")
                        .HasMaxLength(10);

                    b.Property<string>("CAR_NO2")
                        .HasMaxLength(10);

                    b.Property<string>("CERTIFIED_NO")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("USE_TYPE")
                        .HasMaxLength(1);

                    b.HasKey("BILL_NO");

                    b.ToTable("M_DEFECTIVE_USE");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_FREE_CAR", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CAR_NO")
                        .HasMaxLength(10);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("FK_NO")
                        .HasMaxLength(2);

                    b.Property<string>("KIND_NO")
                        .HasMaxLength(3);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PARK_NO")
                        .HasMaxLength(9);

                    b.Property<string>("P_END_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("P_START_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("YEAR")
                        .HasMaxLength(4);

                    b.HasKey("PKID");

                    b.HasIndex("YEAR", "FK_NO", "PARK_NO")
                        .IsUnique()
                        .HasFilter("[YEAR] IS NOT NULL AND [FK_NO] IS NOT NULL AND [PARK_NO] IS NOT NULL");

                    b.ToTable("M_FREE_CAR");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_FREE_KIND", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("FK_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("FK_NO")
                        .HasMaxLength(2);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("FK_NO")
                        .IsUnique()
                        .HasFilter("[FK_NO] IS NOT NULL");

                    b.ToTable("M_FREE_KIND");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_GIRD", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AMOUNT");

                    b.Property<string>("AMOUNT_TYPE")
                        .HasMaxLength(1);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("GIRD_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("GIRD_NO")
                        .HasMaxLength(11);

                    b.Property<string>("GT_NO")
                        .HasMaxLength(1);

                    b.Property<int>("G_LEVEL");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<int>("MAX_HOUR");

                    b.Property<int>("SPEC_AMOUNT");

                    b.HasKey("PKID");

                    b.HasIndex("GIRD_NO")
                        .IsUnique()
                        .HasFilter("[GIRD_NO] IS NOT NULL");

                    b.ToTable("M_GIRD");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_GIRD_TYPE", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("GT_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("GT_NO")
                        .HasMaxLength(1);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("QTY_YN")
                        .HasMaxLength(1);

                    b.HasKey("PKID");

                    b.HasIndex("GT_NO")
                        .IsUnique()
                        .HasFilter("[GT_NO] IS NOT NULL");

                    b.ToTable("M_GIRD_TYPE");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_KIND", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AMOUNT1");

                    b.Property<int>("AMOUNT2");

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("KIND_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("KIND_NO")
                        .HasMaxLength(3);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("KIND_NO")
                        .IsUnique()
                        .HasFilter("[KIND_NO] IS NOT NULL");

                    b.ToTable("M_KIND");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_PDA_CLASS_WEAVE", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CLASS_NO")
                        .HasMaxLength(1);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("C_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("EMPY_NO")
                        .HasMaxLength(20);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("ROAD_NO")
                        .HasMaxLength(6);

                    b.HasKey("PKID");

                    b.HasIndex("C_DATE", "EMPY_NO", "ROAD_NO", "CLASS_NO")
                        .IsUnique()
                        .HasFilter("[C_DATE] IS NOT NULL AND [EMPY_NO] IS NOT NULL AND [ROAD_NO] IS NOT NULL AND [CLASS_NO] IS NOT NULL");

                    b.ToTable("M_PDA_CLASS_WEAVE");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_PDA_GROUP", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("EMPY_NO")
                        .HasMaxLength(20);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PDA_NO")
                        .HasMaxLength(16);

                    b.HasKey("PKID");

                    b.HasIndex("PDA_NO", "EMPY_NO")
                        .IsUnique()
                        .HasFilter("[PDA_NO] IS NOT NULL AND [EMPY_NO] IS NOT NULL");

                    b.ToTable("M_PDA_GROUP");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_PDA_PARAMETER", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("C1")
                        .HasMaxLength(50);

                    b.Property<string>("C2")
                        .HasMaxLength(5);

                    b.Property<string>("C3")
                        .HasMaxLength(50);

                    b.Property<string>("CODE")
                        .HasMaxLength(2);

                    b.Property<string>("ETIME")
                        .HasMaxLength(6);

                    b.Property<int>("FREES_MINUTE");

                    b.Property<int>("FREE_MINUTE");

                    b.Property<string>("HOLIDAY_TYPE")
                        .HasMaxLength(1);

                    b.Property<int>("I1");

                    b.Property<int>("I2");

                    b.Property<int>("I3");

                    b.Property<string>("STIME")
                        .HasMaxLength(6);

                    b.Property<string>("SYS_CODE")
                        .HasMaxLength(10);

                    b.HasKey("PKID");

                    b.HasIndex("SYS_CODE", "CODE")
                        .IsUnique()
                        .HasFilter("[SYS_CODE] IS NOT NULL AND [CODE] IS NOT NULL");

                    b.ToTable("M_PDA_PARAMETER");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_PDA_PASSWORD", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("C_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("C_PASSWORD")
                        .HasMaxLength(40);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("C_DATE")
                        .IsUnique()
                        .HasFilter("[C_DATE] IS NOT NULL");

                    b.ToTable("M_PDA_PASSWORD");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_ROAD", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CELL_NO")
                        .HasMaxLength(3);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("ROAD_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("ROAD_NO")
                        .HasMaxLength(6);

                    b.Property<int>("ROAD_NUM");

                    b.Property<string>("ROAD_RANGE")
                        .HasMaxLength(80);

                    b.Property<string>("ROAD_TYPE")
                        .HasMaxLength(1);

                    b.HasKey("PKID");

                    b.HasIndex("ROAD_NO")
                        .IsUnique()
                        .HasFilter("[ROAD_NO] IS NOT NULL");

                    b.ToTable("M_ROAD");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_SEQNO", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PDA_NO")
                        .HasMaxLength(16);

                    b.Property<string>("SEQ_NO")
                        .HasMaxLength(20);

                    b.HasKey("PKID");

                    b.HasIndex("PDA_NO")
                        .IsUnique()
                        .HasFilter("[PDA_NO] IS NOT NULL");

                    b.ToTable("M_SEQNO");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_SPOILS_CAR", b =>
                {
                    b.Property<string>("CAR_NO")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<DateTime>("CREATED");

                    b.HasKey("CAR_NO");

                    b.ToTable("M_SPOILS_CAR");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_SPOILSBILL", b =>
                {
                    b.Property<string>("BILL_NO")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(16);

                    b.Property<string>("CAR_NO")
                        .HasMaxLength(10);

                    b.Property<DateTime>("QUERY_DATETIME");

                    b.HasKey("BILL_NO");

                    b.ToTable("M_SPOILSBILL");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_SYSTEM", b =>
                {
                    b.Property<long>("SEQ_NO")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("FREE_ID")
                        .HasMaxLength(2);

                    b.Property<string>("LARGE_GIRD")
                        .HasMaxLength(1);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PRT_CONTRAST")
                        .HasMaxLength(1);

                    b.Property<string>("PRT_NB_WIDTH")
                        .HasMaxLength(1);

                    b.Property<string>("PRT_RATIO")
                        .HasMaxLength(1);

                    b.Property<string>("PRT_SPEED")
                        .HasMaxLength(1);

                    b.Property<string>("RCV_ID")
                        .HasMaxLength(3);

                    b.Property<string>("SYS_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("TIMESRV_IP")
                        .HasMaxLength(50);

                    b.Property<string>("TIMESRV_PORT")
                        .HasMaxLength(6);

                    b.Property<string>("VER_NO")
                        .HasMaxLength(10);

                    b.HasKey("SEQ_NO");

                    b.ToTable("M_SYSTEM");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_TICKET", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CAR_NO")
                        .HasMaxLength(10);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("IDENTITY_NO")
                        .HasMaxLength(8);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("ROAD_NO")
                        .HasMaxLength(6);

                    b.Property<string>("T_END_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("T_START_DATE")
                        .HasMaxLength(8);

                    b.Property<string>("YEAR")
                        .HasMaxLength(6);

                    b.HasKey("PKID");

                    b.HasIndex("YEAR", "IDENTITY_NO")
                        .IsUnique()
                        .HasFilter("[YEAR] IS NOT NULL AND [IDENTITY_NO] IS NOT NULL");

                    b.ToTable("M_TICKET");
                });

            modelBuilder.Entity("Parking2018Api.Models.M_USERNM", b =>
                {
                    b.Property<long>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNAME")
                        .HasMaxLength(50);

                    b.Property<string>("CREATEBY")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CREATED");

                    b.Property<string>("EMPY_NO")
                        .HasMaxLength(20);

                    b.Property<DateTime>("LAST_MODIFIED");

                    b.Property<string>("LAST_MODIFYBY")
                        .HasMaxLength(20);

                    b.Property<string>("PDA_NO")
                        .HasMaxLength(16);

                    b.Property<string>("PSWD")
                        .HasMaxLength(40);

                    b.HasKey("PKID");

                    b.HasIndex("EMPY_NO")
                        .IsUnique()
                        .HasFilter("[EMPY_NO] IS NOT NULL");

                    b.ToTable("M_USERNM");
                });
#pragma warning restore 612, 618
        }
    }
}
