﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using onlinelearningbackend.Data;

namespace onlinelearningbackend.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnrollmentKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IntervalInDays")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("TopicId");

                    b.HasIndex("TrackId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.CourseMaterialModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("PathOnServer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseMaterialModels");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.CourseMyUserModel", b =>
                {
                    b.Property<int>("CourseMyUserModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("MyUserModelId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseMyUserModelId");

                    b.HasIndex("CourseId");

                    b.HasIndex("MyUserModelId");

                    b.ToTable("CourseMyUserModel");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.LinkMaterial", b =>
                {
                    b.Property<int>("LinkMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("LinkMaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkMaterialId");

                    b.HasIndex("CourseId");

                    b.ToTable("LinkMaterials");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.MyRoleModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.MyUserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PrifleImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TrackId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.ProjectMaterialModel", b =>
                {
                    b.Property<int>("ProjectMaterialModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PathOnServer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("ProjectMaterialModelId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectMaterialModel");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.ProjectModel", b =>
                {
                    b.Property<int>("ProjectModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("ProjectModelId");

                    b.HasIndex("TrackId");

                    b.ToTable("ProjectModel");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TaskClass", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId");

                    b.HasIndex("CourseId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TaskSolution", b =>
                {
                    b.Property<int>("TaskSolutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MyUserModelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("TaskSolutionURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskSolutionId");

                    b.HasIndex("CourseId");

                    b.HasIndex("MyUserModelId");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskSolutions");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TextMaterial", b =>
                {
                    b.Property<int>("TextMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("TextMaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextMaterialId");

                    b.HasIndex("CourseId");

                    b.ToTable("TextMaterials");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TrackName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.HasIndex("BranchId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.UserProjectModel", b =>
                {
                    b.Property<int>("UserProjectModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.Property<int?>("ProjectModelId")
                        .HasColumnType("int");

                    b.Property<string>("myUserModelId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserProjectModelId");

                    b.HasIndex("ProjectModelId");

                    b.HasIndex("myUserModelId");

                    b.ToTable("UserProjectModel");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.VideoMaterial", b =>
                {
                    b.Property<int>("VideoMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoMaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoMaterialId");

                    b.HasIndex("CourseId");

                    b.ToTable("VideoMaterials");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.MyRoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.MyUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.MyUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.MyRoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onlinelearningbackend.Models.MyUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.MyUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Course", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("TopicId");

                    b.HasOne("onlinelearningbackend.Models.Track", "Track")
                        .WithMany("Courses")
                        .HasForeignKey("TrackId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.CourseMaterialModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("CourseMaterialModels")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlinelearningbackend.Models.CourseMyUserModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("CourseMyUserModels")
                        .HasForeignKey("CourseId");

                    b.HasOne("onlinelearningbackend.Models.MyUserModel", "MyUserModel")
                        .WithMany("CourseMyUserModels")
                        .HasForeignKey("MyUserModelId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.LinkMaterial", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("LinkMaterials")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.MyUserModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Branch", "Branch")
                        .WithMany("MyUserModels")
                        .HasForeignKey("BranchId");

                    b.HasOne("onlinelearningbackend.Models.Track", "Track")
                        .WithMany("MyUserModels")
                        .HasForeignKey("TrackId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.ProjectMaterialModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.ProjectModel", "Project")
                        .WithMany("ProjectMaterialModels")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlinelearningbackend.Models.ProjectModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Track", "Track")
                        .WithMany("ProjectModels")
                        .HasForeignKey("TrackId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TaskClass", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("Tasks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TaskSolution", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("TaskSolutions")
                        .HasForeignKey("CourseId");

                    b.HasOne("onlinelearningbackend.Models.MyUserModel", "MyUserModel")
                        .WithMany("TaskSolutions")
                        .HasForeignKey("MyUserModelId");

                    b.HasOne("onlinelearningbackend.Models.TaskClass", "Task")
                        .WithMany("TaskSolutions")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.TextMaterial", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("TextMaterials")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("onlinelearningbackend.Models.Track", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Branch", "Branch")
                        .WithMany("Tracks")
                        .HasForeignKey("BranchId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.UserProjectModel", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.ProjectModel", "projectModel")
                        .WithMany("UserProjectModels")
                        .HasForeignKey("ProjectModelId");

                    b.HasOne("onlinelearningbackend.Models.MyUserModel", "myUserModel")
                        .WithMany("UserProjectModels")
                        .HasForeignKey("myUserModelId");
                });

            modelBuilder.Entity("onlinelearningbackend.Models.VideoMaterial", b =>
                {
                    b.HasOne("onlinelearningbackend.Models.Course", "Course")
                        .WithMany("VideoMaterials")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
