using System;
using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace Bt.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeEligibilityCriteria",
                columns: table => new
                {
                    Session_Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(type: "int", nullable: true),
                    AgeLimit_Lower = table.Column<int>(type: "int", nullable: true),
                    AgeLimit_Upper = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeEligibilityCriteria", x => x.Session_Code);
                });

            migrationBuilder.CreateTable(
                name: "Applicants_AlliedCourses",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aplicant_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Permanent_State = table.Column<int>(type: "int", nullable: true),
                    Permanent_District = table.Column<int>(type: "int", nullable: true),
                    Permanent_Block = table.Column<int>(type: "int", nullable: true),
                    Permanent_Village = table.Column<int>(type: "int", nullable: true),
                    Permanent_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Present_State = table.Column<int>(type: "int", nullable: true),
                    Present_District = table.Column<int>(type: "int", nullable: true),
                    Present_Block = table.Column<int>(type: "int", nullable: true),
                    Present_Village = table.Column<int>(type: "int", nullable: true),
                    Present_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eMail = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Nationality = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    Religion = table.Column<int>(type: "int", nullable: true),
                    Passport_Photo = table.Column<byte[]>(type: "image", nullable: true),
                    PR_Cetificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Category_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AgeProof = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Marksheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Character_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Guardian_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guardian_Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guardian_EmployerCertificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    marks_Physics_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Physics_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Physics = table.Column<double>(type: "float", nullable: true),
                    marks_Chemistry_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Chemistry_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Chemistry = table.Column<double>(type: "float", nullable: true),
                    marks_Biology_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Biology_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Biology = table.Column<double>(type: "float", nullable: true),
                    marks_Mathematics_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Mathematics_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Mathematics = table.Column<double>(type: "float", nullable: true),
                    Percentage_XII = table.Column<double>(type: "float", nullable: true),
                    Percentage_PCB_XII = table.Column<double>(type: "float", nullable: true),
                    Percentage_PCM_XII = table.Column<double>(type: "float", nullable: true),
                    ScreeningCentre = table.Column<int>(type: "int", nullable: true),
                    ApplicationStatus = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataEntry_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataEntry_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgeAsOnCutOffDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants_AlliedCourses", x => x.Applicant_Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants_ANM",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aplicant_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Permanent_State = table.Column<int>(type: "int", nullable: true),
                    Permanent_District = table.Column<int>(type: "int", nullable: true),
                    Permanent_Block = table.Column<int>(type: "int", nullable: true),
                    Permanent_Village = table.Column<int>(type: "int", nullable: true),
                    Permanent_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Present_State = table.Column<int>(type: "int", nullable: true),
                    Present_District = table.Column<int>(type: "int", nullable: true),
                    Present_Block = table.Column<int>(type: "int", nullable: true),
                    Present_Village = table.Column<int>(type: "int", nullable: true),
                    Present_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eMail = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Nationality = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: true),
                    Religion = table.Column<int>(type: "int", nullable: true),
                    Passport_Photo = table.Column<byte[]>(type: "image", nullable: true),
                    PR_Cetificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Category_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AgeProof = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Marksheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Character_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Guardian_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guardian_Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guardian_EmployerCertificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Stream = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Percentage_XII = table.Column<double>(type: "float", nullable: true),
                    ApplicationStatus = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataEntry_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataEntry_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgeAsOnCutOffDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants_ANM", x => x.Applicant_Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants_GNM",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aplicant_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Permanent_State = table.Column<int>(type: "int", nullable: true),
                    Permanent_District = table.Column<int>(type: "int", nullable: true),
                    Permanent_Block = table.Column<int>(type: "int", nullable: true),
                    Permanent_Village = table.Column<int>(type: "int", nullable: true),
                    Permanent_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Present_State = table.Column<int>(type: "int", nullable: true),
                    Present_District = table.Column<int>(type: "int", nullable: true),
                    Present_Block = table.Column<int>(type: "int", nullable: true),
                    Present_Village = table.Column<int>(type: "int", nullable: true),
                    Present_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eMail = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Nationality = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Religion = table.Column<int>(type: "int", nullable: true),
                    Passport_Photo = table.Column<byte[]>(type: "image", nullable: true),
                    PR_Cetificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Category_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AgeProof = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Marksheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Character_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Guardian_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guardian_Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guardian_EmployerCertificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Stream = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Percentage_XII = table.Column<double>(type: "float", nullable: true),
                    PhysicalDisability = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Disability_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApplicationStatus = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataEntry_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataEntry_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgeAsOnCutOffDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants_GNM", x => x.Applicant_Id);
                });

            migrationBuilder.CreateTable(
                name: "Applicants_MBBS",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aplicant_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Permanent_State = table.Column<int>(type: "int", nullable: true),
                    Permanent_District = table.Column<int>(type: "int", nullable: true),
                    Permanent_Block = table.Column<int>(type: "int", nullable: true),
                    Permanent_Village = table.Column<int>(type: "int", nullable: true),
                    Permanent_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Present_State = table.Column<int>(type: "int", nullable: true),
                    Present_District = table.Column<int>(type: "int", nullable: true),
                    Present_Block = table.Column<int>(type: "int", nullable: true),
                    Present_Village = table.Column<int>(type: "int", nullable: true),
                    Present_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eMail = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Nationality = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Religion = table.Column<int>(type: "int", nullable: true),
                    Passport_Photo = table.Column<byte[]>(type: "image", nullable: true),
                    PR_Cetificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Category_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AgeProof = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Marksheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Character_Certificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Guardian_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guardian_Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Guardian_OfficeAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Guardian_EmployerCertificate = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    marks_Physics_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Physics_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Physics = table.Column<double>(type: "float", nullable: true),
                    marks_Chemistry_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Chemistry_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Chemistry = table.Column<double>(type: "float", nullable: true),
                    marks_Biology_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_Biology_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_Biology = table.Column<double>(type: "float", nullable: true),
                    marks_English_Theory = table.Column<double>(type: "float", nullable: true),
                    marks_English_Practical = table.Column<double>(type: "float", nullable: true),
                    fullmarks_English = table.Column<double>(type: "float", nullable: true),
                    Percentage_XII = table.Column<double>(type: "float", nullable: true),
                    Percentage_PCB_XII = table.Column<double>(type: "float", nullable: true),
                    Percentage_PCBE_XII = table.Column<double>(type: "float", nullable: true),
                    NEET_UG_CurrentScore = table.Column<double>(type: "float", nullable: true),
                    NEET_UG_Scoresheet = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApplicationStatus = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataEntry_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataEntry_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_Timestamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AgeAsOnCutOffDate = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants_MBBS", x => x.Applicant_Id);
                });

            migrationBuilder.CreateTable(
                name: "mApplicationStatus",
                columns: table => new
                {
                    ApplicationStatus = table.Column<int>(type: "int", nullable: false),
                    ApplicationStatus_Desc = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mApplicationStatus", x => x.ApplicationStatus);
                });

            migrationBuilder.CreateTable(
                name: "mApplicationType",
                columns: table => new
                {
                    ApplicationType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Application_Desc = table.Column<string>(type: "nchar(60)", fixedLength: true, maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mApplicationType", x => x.ApplicationType);
                });

            migrationBuilder.CreateTable(
                name: "mBlocks",
                columns: table => new
                {
                    Block_Code = table.Column<int>(type: "int", nullable: false),
                    State_Code = table.Column<int>(type: "int", nullable: false),
                    District_Code = table.Column<int>(type: "int", nullable: false),
                    Block_Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mBlocks", x => x.Block_Code);
                });

            migrationBuilder.CreateTable(
                name: "mCategory",
                columns: table => new
                {
                    Category = table.Column<int>(type: "int", nullable: true),
                    Category_Desc = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mCourses_AlliedCourses",
                columns: table => new
                {
                    AC_CourseCode = table.Column<int>(type: "int", nullable: false),
                    AC_CourseName = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mCourses_ANM",
                columns: table => new
                {
                    ANM_CourseCode = table.Column<int>(type: "int", nullable: true),
                    AMN_Course = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mCourses_GNM",
                columns: table => new
                {
                    GNM_CourseCode = table.Column<int>(type: "int", nullable: true),
                    GMN_Couse = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mCourses_MBBS",
                columns: table => new
                {
                    MBBS_CourseCode = table.Column<int>(type: "int", nullable: false),
                    MBBS_CouseName = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mDistricts",
                columns: table => new
                {
                    District_Code = table.Column<int>(type: "int", nullable: false),
                    State_Code = table.Column<int>(type: "int", nullable: false),
                    District_Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mDistricts_1", x => x.District_Code);
                });

            migrationBuilder.CreateTable(
                name: "mGender",
                columns: table => new
                {
                    Gender = table.Column<string>(type: "nchar(1)", fixedLength: true, maxLength: 1, nullable: false),
                    Gender_Desc = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mGender", x => x.Gender);
                });

            migrationBuilder.CreateTable(
                name: "mNationality",
                columns: table => new
                {
                    Nationality = table.Column<int>(type: "int", nullable: true),
                    Nationality_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mReligion",
                columns: table => new
                {
                    Religion = table.Column<int>(type: "int", nullable: false),
                    Religion_Desc = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mReligion", x => x.Religion);
                });

            migrationBuilder.CreateTable(
                name: "mScreeningCentre",
                columns: table => new
                {
                    ScreeningCentre = table.Column<int>(type: "int", nullable: true),
                    ScreeningCentre_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ApplicationType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mStates",
                columns: table => new
                {
                    State_Code = table.Column<int>(type: "int", nullable: false),
                    State_Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mStates", x => x.State_Code);
                });

            migrationBuilder.CreateTable(
                name: "mUsers",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_DisplayName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    User_eMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    User_mobile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    User_Password = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Created_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Last_Login = table.Column<DateTime>(type: "datetime", nullable: true),
                    Last_LoginIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Login_Attemps = table.Column<int>(type: "int", nullable: true),
                    User_Category = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUsers", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "mVillages",
                columns: table => new
                {
                    Village_Code = table.Column<int>(type: "int", nullable: false),
                    State_Code = table.Column<int>(type: "int", nullable: false),
                    District_Code = table.Column<int>(type: "int", nullable: false),
                    Block_Code = table.Column<int>(type: "int", nullable: false),
                    Village_Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mVillages_1", x => x.Village_Code);
                });

            migrationBuilder.CreateTable(
                name: "preference_AlliedCourses",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: true),
                    AC_CourseCode = table.Column<int>(type: "int", nullable: true),
                    Preference = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "preference_MBBS",
                columns: table => new
                {
                    Applicant_Id = table.Column<int>(type: "int", nullable: true),
                    MBBS_CourseCode = table.Column<int>(type: "int", nullable: true),
                    Preference = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Session_Code = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    State_Code = table.Column<int>(type: "int", nullable: true),
                    ApplicationType = table.Column<int>(type: "int", nullable: true),
                    AcademicSession = table.Column<string>(type: "nchar(7)", fixedLength: true, maxLength: 7, nullable: true),
                    DateAsOnforAgeCutOff = table.Column<DateTime>(type: "date", nullable: true),
                    Advertisement = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AdvNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdvtDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastDateForApplication = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeEligibilityCriteria");

            migrationBuilder.DropTable(
                name: "Applicants_AlliedCourses");

            migrationBuilder.DropTable(
                name: "Applicants_ANM");

            migrationBuilder.DropTable(
                name: "Applicants_GNM");

            migrationBuilder.DropTable(
                name: "Applicants_MBBS");

            migrationBuilder.DropTable(
                name: "mApplicationStatus");

            migrationBuilder.DropTable(
                name: "mApplicationType");

            migrationBuilder.DropTable(
                name: "mBlocks");

            migrationBuilder.DropTable(
                name: "mCategory");

            migrationBuilder.DropTable(
                name: "mCourses_AlliedCourses");

            migrationBuilder.DropTable(
                name: "mCourses_ANM");

            migrationBuilder.DropTable(
                name: "mCourses_GNM");

            migrationBuilder.DropTable(
                name: "mCourses_MBBS");

            migrationBuilder.DropTable(
                name: "mDistricts");

            migrationBuilder.DropTable(
                name: "mGender");

            migrationBuilder.DropTable(
                name: "mNationality");

            migrationBuilder.DropTable(
                name: "mReligion");

            migrationBuilder.DropTable(
                name: "mScreeningCentre");

            migrationBuilder.DropTable(
                name: "mStates");

            migrationBuilder.DropTable(
                name: "mUsers");

            migrationBuilder.DropTable(
                name: "mVillages");

            migrationBuilder.DropTable(
                name: "preference_AlliedCourses");

            migrationBuilder.DropTable(
                name: "preference_MBBS");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");
        }
    }
}
