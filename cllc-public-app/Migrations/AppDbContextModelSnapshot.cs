﻿// <auto-generated />
using System;
using Gov.Lclb.Cllb.Public.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gov.Lclb.Cllb.Public.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Jurisdiction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("SelectMessage")
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.ToTable("Jurisdictions");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Newsletter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<string>("Slug");

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(2048);

                    b.Property<string>("Name")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.PolicyDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("Category");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("MenuText");

                    b.Property<string>("Slug");

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("PolicyDocuments");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.PostSurveyResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("clientId");

                    b.Property<string>("postId");

                    b.Property<string>("surveyResult");

                    b.HasKey("Id");

                    b.ToTable("PostSurveyResults");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(2048);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.RolePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("PermissionId");

                    b.Property<Guid?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Subscriber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(512);

                    b.Property<Guid?>("NewsletterId");

                    b.HasKey("Id");

                    b.HasIndex("NewsletterId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.User", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.Property<bool>("Active");

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("GivenName")
                        .HasMaxLength(50);

                    b.Property<string>("Initials")
                        .HasMaxLength(10);

                    b.Property<string>("SiteMinderGuid")
                        .HasMaxLength(255);

                    b.Property<string>("SmUserId")
                        .HasMaxLength(255);

                    b.Property<string>("Surname")
                        .HasMaxLength(50);

                    b.Property<string>("UserType")
                        .HasMaxLength(255);

                    b.HasKey("ContactId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<DateTime?>("ExpiryDate");

                    b.Property<Guid?>("RoleId");

                    b.Property<Guid?>("UserContactId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserContactId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.VoteOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("Option")
                        .HasMaxLength(512);

                    b.Property<int>("TotalVotes");

                    b.Property<Guid?>("VoteQuestionId");

                    b.HasKey("Id");

                    b.HasIndex("VoteQuestionId");

                    b.ToTable("VoteOptions");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.VoteQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Question")
                        .HasMaxLength(512);

                    b.Property<string>("Slug");

                    b.Property<string>("Title")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("VoteQuestions");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.RolePermission", b =>
                {
                    b.HasOne("Gov.Lclb.Cllb.Public.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId");

                    b.HasOne("Gov.Lclb.Cllb.Public.Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.Subscriber", b =>
                {
                    b.HasOne("Gov.Lclb.Cllb.Public.Models.Newsletter")
                        .WithMany("Subscribers")
                        .HasForeignKey("NewsletterId");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.UserRole", b =>
                {
                    b.HasOne("Gov.Lclb.Cllb.Public.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Gov.Lclb.Cllb.Public.Models.User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserContactId");
                });

            modelBuilder.Entity("Gov.Lclb.Cllb.Public.Models.VoteOption", b =>
                {
                    b.HasOne("Gov.Lclb.Cllb.Public.Models.VoteQuestion")
                        .WithMany("Options")
                        .HasForeignKey("VoteQuestionId");
                });
#pragma warning restore 612, 618
        }
    }
}
