﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smart.FA.Catalog.Infrastructure.Persistence;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20220427124642_Set_Default_Value_On_Training_StatusTypeId")]
    partial class Set_Default_Value_On_Training_StatusTypeId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Cfa")
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultLanguage")
                        .IsRequired()
                        .HasColumnType("nchar(2)");

                    b.Property<string>("Email")
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProfileImagePath")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Trainer", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainerAssignment", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "TrainerId");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("TrainingId", "TrainerId"));

                    b.HasIndex("TrainerId");

                    b.ToTable("TrainerAssignment", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainerSocialNetwork", b =>
                {
                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.Property<int>("SocialNetwork")
                        .HasColumnType("int")
                        .HasColumnName("SocialNetworkId");

                    b.Property<string>("UrlToProfile")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TrainerId", "SocialNetwork");

                    b.HasIndex("SocialNetwork");

                    b.ToTable("TrainerSocialNetwork", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("TrainingStatusTypeId");

                    b.HasKey("Id");

                    b.ToTable("Training", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingAttendance", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("AttendanceTypeId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "AttendanceTypeId");

                    b.ToTable("TrainingAttendance", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingLocalizedDetails", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("NCHAR(2)")
                        .HasColumnName("Language");

                    b.Property<string>("Goal")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Methodology")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("PracticalModalities")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("TrainingId", "Language");

                    b.ToTable("TrainingLocalizedDetails", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingTargetAudience", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("TargetAudienceTypeId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "TargetAudienceTypeId");

                    b.ToTable("TrainingTargetAudience", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingTopic", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "TopicId");

                    b.ToTable("TrainingTopic", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.VatExemptionClaim", b =>
                {
                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("VatExemptionTypeId")
                        .HasColumnType("int");

                    b.HasKey("TrainingId", "VatExemptionTypeId");

                    b.ToTable("VatExemptionClaim", "Cfa");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Trainer.SocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("SocialNetwork", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Twitter"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Instagram"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Facebook"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Github"
                        },
                        new
                        {
                            Id = 5,
                            Name = "LinkedIn"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Personal website"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Training.AttendanceType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AttendanceType", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Group"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Single"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Training.TargetAudienceType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TargetAudienceType", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Student"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Unemployed"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Training.Topic", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Topic", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "LanguageCourse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "InformationTechnology"
                        },
                        new
                        {
                            Id = 3,
                            Name = "SocialScience"
                        },
                        new
                        {
                            Id = 4,
                            Name = "School"
                        },
                        new
                        {
                            Id = 5,
                            Name = "HealthCare"
                        },
                        new
                        {
                            Id = 8,
                            Name = "EconomyMarketing"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Communication"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Culture"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Sport"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Training.TrainingStatusType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TrainingStatusType", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Draft"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PendingValidation"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Validated"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cancelled"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Shared.Domain.Enumerations.Training.VatExemptionType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("VatExemptionType", "Cfa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "LanguageCourse"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Professional"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ScholarTraining"
                        });
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.Trainer", b =>
                {
                    b.OwnsOne("Smart.FA.Catalog.Core.Domain.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<int>("TrainerId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("LastName");

                            b1.HasKey("TrainerId");

                            b1.ToTable("Trainer", "Cfa");

                            b1.WithOwner()
                                .HasForeignKey("TrainerId");
                        });

                    b.OwnsOne("Smart.FA.Catalog.Core.Domain.ValueObjects.TrainerIdentity", "Identity", b1 =>
                        {
                            b1.Property<int>("TrainerId")
                                .HasColumnType("int");

                            b1.Property<int>("ApplicationTypeId")
                                .HasMaxLength(200)
                                .HasColumnType("int")
                                .HasColumnName("ApplicationType");

                            b1.Property<string>("UserId")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("UserId");

                            b1.HasKey("TrainerId");

                            b1.ToTable("Trainer", "Cfa");

                            b1.WithOwner()
                                .HasForeignKey("TrainerId");
                        });

                    b.Navigation("Identity")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainerAssignment", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Trainer", "Trainer")
                        .WithMany("Assignments")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("TrainerAssignments")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainerSocialNetwork", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Trainer", "Trainer")
                        .WithMany("SocialNetworks")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingAttendance", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("Attendances")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingLocalizedDetails", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("Details")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingTargetAudience", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("Targets")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.TrainingTopic", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("Topics")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.VatExemptionClaim", b =>
                {
                    b.HasOne("Smart.FA.Catalog.Core.Domain.Training", "Training")
                        .WithMany("VatExemptionClaims")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.Trainer", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("SocialNetworks");
                });

            modelBuilder.Entity("Smart.FA.Catalog.Core.Domain.Training", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Details");

                    b.Navigation("Targets");

                    b.Navigation("Topics");

                    b.Navigation("TrainerAssignments");

                    b.Navigation("VatExemptionClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
