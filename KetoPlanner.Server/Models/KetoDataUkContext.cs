using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KetoPlanner.Server.Models;

public partial class KetoDataUkContext : DbContext
{
    public KetoDataUkContext()
    {
    }

    public KetoDataUkContext(DbContextOptions<KetoDataUkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<InvalidPatientEmail> InvalidPatientEmails { get; set; }

    public virtual DbSet<MenuMaster> MenuMasters { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<SilverpopPostingLog> SilverpopPostingLogs { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<TblActualFeeding> TblActualFeedings { get; set; }

    public virtual DbSet<TblActualFood> TblActualFoods { get; set; }

    public virtual DbSet<TblActualMeal> TblActualMeals { get; set; }

    public virtual DbSet<TblActualSchedule> TblActualSchedules { get; set; }

    public virtual DbSet<TblActualSnack> TblActualSnacks { get; set; }

    public virtual DbSet<TblActualSnackFood> TblActualSnackFoods { get; set; }

    public virtual DbSet<TblClientMedication> TblClientMedications { get; set; }

    public virtual DbSet<TblConfig> TblConfigs { get; set; }

    public virtual DbSet<TblDiet> TblDiets { get; set; }

    public virtual DbSet<TblDietsSnack> TblDietsSnacks { get; set; }

    public virtual DbSet<TblEvent> TblEvents { get; set; }

    public virtual DbSet<TblFaceSheet> TblFaceSheets { get; set; }

    public virtual DbSet<TblFaq> TblFaqs { get; set; }

    public virtual DbSet<TblFood> TblFoods { get; set; }

    public virtual DbSet<TblHcpinvitation> TblHcpinvitations { get; set; }

    public virtual DbSet<TblHelpLine> TblHelpLines { get; set; }

    public virtual DbSet<TblLabsPerPatient> TblLabsPerPatients { get; set; }

    public virtual DbSet<TblLabsPerPatientDetail> TblLabsPerPatientDetails { get; set; }

    public virtual DbSet<TblMealCalendar> TblMealCalendars { get; set; }

    public virtual DbSet<TblMedicationsPerPatient> TblMedicationsPerPatients { get; set; }

    public virtual DbSet<TblMessageBoard> TblMessageBoards { get; set; }

    public virtual DbSet<TblOrgPatientRequest> TblOrgPatientRequests { get; set; }

    public virtual DbSet<TblOrganization> TblOrganizations { get; set; }

    public virtual DbSet<TblPatient> TblPatients { get; set; }

    public virtual DbSet<TblPatientOrg> TblPatientOrgs { get; set; }

    public virtual DbSet<TblPatientOrgRequest> TblPatientOrgRequests { get; set; }

    public virtual DbSet<TblRecipe> TblRecipes { get; set; }

    public virtual DbSet<TblRecipeCalendar> TblRecipeCalendars { get; set; }

    public virtual DbSet<TblRecipeCategory> TblRecipeCategories { get; set; }

    public virtual DbSet<TblRecipeIngredient> TblRecipeIngredients { get; set; }

    public virtual DbSet<TblRecipeToAssignPatient> TblRecipeToAssignPatients { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblSharedRecipe> TblSharedRecipes { get; set; }

    public virtual DbSet<TblSupplementsPerPatient> TblSupplementsPerPatients { get; set; }

    public virtual DbSet<TblUserSavedRecipe> TblUserSavedRecipes { get; set; }

    public virtual DbSet<TempVwDietCurrent> TempVwDietCurrents { get; set; }

    public virtual DbSet<TlkpAgeRange> TlkpAgeRanges { get; set; }

    public virtual DbSet<TlkpCategory> TlkpCategories { get; set; }

    public virtual DbSet<TlkpDriageRange> TlkpDriageRanges { get; set; }

    public virtual DbSet<TlkpDrirec> TlkpDrirecs { get; set; }

    public virtual DbSet<TlkpFaqCategory> TlkpFaqCategories { get; set; }

    public virtual DbSet<TlkpFaqSubCategory> TlkpFaqSubCategories { get; set; }

    public virtual DbSet<TlkpFraction> TlkpFractions { get; set; }

    public virtual DbSet<TlkpHandout> TlkpHandouts { get; set; }

    public virtual DbSet<TlkpHour> TlkpHours { get; set; }

    public virtual DbSet<TlkpMaintenance> TlkpMaintenances { get; set; }

    public virtual DbSet<TlkpMeal> TlkpMeals { get; set; }

    public virtual DbSet<TlkpMealCode> TlkpMealCodes { get; set; }

    public virtual DbSet<TlkpMealDay> TlkpMealDays { get; set; }

    public virtual DbSet<TlkpMealFood> TlkpMealFoods { get; set; }

    public virtual DbSet<TlkpMedication> TlkpMedications { get; set; }

    public virtual DbSet<TlkpRatio> TlkpRatios { get; set; }

    public virtual DbSet<TlkpRecipeCode> TlkpRecipeCodes { get; set; }

    public virtual DbSet<TlkpSnack> TlkpSnacks { get; set; }

    public virtual DbSet<TlkpSnackFood> TlkpSnackFoods { get; set; }

    public virtual DbSet<TlkpStandardFeeding> TlkpStandardFeedings { get; set; }

    public virtual DbSet<TlkpStandardLabDetail> TlkpStandardLabDetails { get; set; }

    public virtual DbSet<TlkpStandardLabType> TlkpStandardLabTypes { get; set; }

    public virtual DbSet<TlkpStandardSupplement> TlkpStandardSupplements { get; set; }

    public virtual DbSet<TlkpStatus> TlkpStatuses { get; set; }

    public virtual DbSet<TlkpSupplement> TlkpSupplements { get; set; }

    public virtual DbSet<TlkpUnit> TlkpUnits { get; set; }

    public virtual DbSet<TlkpValuePerSupplement> TlkpValuePerSupplements { get; set; }

    public virtual DbSet<TlkpVitMin> TlkpVitMins { get; set; }

    public virtual DbSet<TlkpYear> TlkpYears { get; set; }

    public virtual DbSet<VwActuaRecipeFood> VwActuaRecipeFoods { get; set; }

    public virtual DbSet<VwActualFoodTotal> VwActualFoodTotals { get; set; }

    public virtual DbSet<VwActualLab> VwActualLabs { get; set; }

    public virtual DbSet<VwActualMeal> VwActualMeals { get; set; }

    public virtual DbSet<VwActualMealFood> VwActualMealFoods { get; set; }

    public virtual DbSet<VwActualMealsVerified> VwActualMealsVerifieds { get; set; }

    public virtual DbSet<VwActualRecipe> VwActualRecipes { get; set; }

    public virtual DbSet<VwActualRecipeFood> VwActualRecipeFoods { get; set; }

    public virtual DbSet<VwActualSchedule> VwActualSchedules { get; set; }

    public virtual DbSet<VwActualSchedulePrint> VwActualSchedulePrints { get; set; }

    public virtual DbSet<VwActualSnack> VwActualSnacks { get; set; }

    public virtual DbSet<VwActualSnackFood> VwActualSnackFoods { get; set; }

    public virtual DbSet<VwActualSnackFoodTotal> VwActualSnackFoodTotals { get; set; }

    public virtual DbSet<VwActualSnacksVerified> VwActualSnacksVerifieds { get; set; }

    public virtual DbSet<VwCalcage> VwCalcages { get; set; }

    public virtual DbSet<VwDietCurrent> VwDietCurrents { get; set; }

    public virtual DbSet<VwDietCurrentPatient> VwDietCurrentPatients { get; set; }

    public virtual DbSet<VwDietHistory> VwDietHistories { get; set; }

    public virtual DbSet<VwDietHistoryDetail> VwDietHistoryDetails { get; set; }

    public virtual DbSet<VwDribyAge> VwDribyAges { get; set; }

    public virtual DbSet<VwFaceSheetAndDiet> VwFaceSheetAndDiets { get; set; }

    public virtual DbSet<VwFaceSheetAndDietLogo> VwFaceSheetAndDietLogos { get; set; }

    public virtual DbSet<VwFaqList> VwFaqLists { get; set; }

    public virtual DbSet<VwFoodsAndCategory> VwFoodsAndCategories { get; set; }

    public virtual DbSet<VwMealCalendar> VwMealCalendars { get; set; }

    public virtual DbSet<VwMealPlannerMatrix> VwMealPlannerMatrices { get; set; }

    public virtual DbSet<VwMealsStdWithFood> VwMealsStdWithFoods { get; set; }

    public virtual DbSet<VwMedicationsPerPatient> VwMedicationsPerPatients { get; set; }

    public virtual DbSet<VwRecipeCalendar> VwRecipeCalendars { get; set; }

    public virtual DbSet<VwRecipeDietCurrent> VwRecipeDietCurrents { get; set; }

    public virtual DbSet<VwRecipePlannerMatrix> VwRecipePlannerMatrices { get; set; }

    public virtual DbSet<VwSnackDietCurrent> VwSnackDietCurrents { get; set; }

    public virtual DbSet<VwSnackStdWithFood> VwSnackStdWithFoods { get; set; }

    public virtual DbSet<VwSupStdWithVitMin> VwSupStdWithVitMins { get; set; }

    public virtual DbSet<VwSupplementsByAge> VwSupplementsByAges { get; set; }

    public virtual DbSet<VwSupplementsCurrent> VwSupplementsCurrents { get; set; }

    public virtual DbSet<VwSupplementsPerPatient> VwSupplementsPerPatients { get; set; }

    public virtual DbSet<VwTblLabsPerPatientByDate> VwTblLabsPerPatientByDates { get; set; }

    public virtual DbSet<VwUnverifiedMeal> VwUnverifiedMeals { get; set; }

    public virtual DbSet<VwUnverifiedSnack> VwUnverifiedSnacks { get; set; }

    public virtual DbSet<VwVitMinValuesCurrent> VwVitMinValuesCurrents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=KetoData_UK;Integrated Security=True;Trust Server Certificate=True");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("City");

            entity.Property(e => e.CityName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.State).WithMany()
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__City__StateId__384F51F2");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("CountryGUID");
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(1);
            entity.Property(e => e.ExtensionData).HasColumnType("ntext");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.NumericIsocode)
                .HasMaxLength(3)
                .HasColumnName("NumericISOCode");
            entity.Property(e => e.PostalCodeExample).HasMaxLength(50);
            entity.Property(e => e.PostalCodeRegex).HasMaxLength(4000);
            entity.Property(e => e.PostalCodeRequired).HasDefaultValue((byte)1);
            entity.Property(e => e.Published).HasDefaultValue((byte)1);
            entity.Property(e => e.ThreeLetterIsocode)
                .HasMaxLength(3)
                .HasColumnName("ThreeLetterISOCode");
            entity.Property(e => e.TwoLetterIsocode)
                .HasMaxLength(2)
                .HasColumnName("TwoLetterISOCode");
        });

        modelBuilder.Entity<InvalidPatientEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Invalid_Patient_Emails");

            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.PatientId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PatientID");
        });

        modelBuilder.Entity<MenuMaster>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("menuMaster");

            entity.Property(e => e.MenuId)
                .ValueGeneratedNever()
                .HasColumnName("menu_id");
            entity.Property(e => e.MenuName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("menu_name");
            entity.Property(e => e.MenuParentId).HasColumnName("menu_parent_id");
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("menu_url");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.ToTable("Rating");

            entity.Property(e => e.Rating1).HasColumnName("Rating");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.Supplement).HasMaxLength(50);
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sheet1$");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.FoodCarb).HasMaxLength(255);
            entity.Property(e => e.FoodCode).HasMaxLength(255);
            entity.Property(e => e.FoodFat).HasMaxLength(255);
            entity.Property(e => e.FoodItem).HasMaxLength(255);
            entity.Property(e => e.FoodPro).HasMaxLength(255);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<SilverpopPostingLog>(entity =>
        {
            entity.ToTable("SilverpopPostingLog");

            entity.Property(e => e.DateTimeStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Error).HasMaxLength(1024);
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("State");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Abbreviation).HasMaxLength(5);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DisplayOrder).HasDefaultValue(1);
            entity.Property(e => e.ExtensionData).HasColumnType("ntext");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Published).HasDefaultValue((byte)1);
            entity.Property(e => e.StateGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("StateGUID");
        });

        modelBuilder.Entity<TblActualFeeding>(entity =>
        {
            entity.HasKey(e => new { e.FeedId, e.PatientId }).IsClustered(false);

            entity.ToTable("tblActualFeeding", tb => tb.HasTrigger("trgDeleteFeeding"));

            entity.Property(e => e.FeedId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FeedID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Comments).HasMaxLength(1000);
            entity.Property(e => e.FeedDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblActualFood>(entity =>
        {
            entity.HasKey(e => new { e.MealId, e.FoodId });

            entity.ToTable("tblActualFoods");

            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
        });

        modelBuilder.Entity<TblActualMeal>(entity =>
        {
            entity.HasKey(e => e.MealId).IsClustered(false);

            entity.ToTable("tblActualMeals", tb => tb.HasTrigger("trgDeleteMeal"));

            entity.HasIndex(e => e.PatientId, "PatientID").HasFillFactor(90);

            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MealName).HasMaxLength(50);
            entity.Property(e => e.MealNumber).HasDefaultValue(0);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblActualSchedule>(entity =>
        {
            entity.HasKey(e => new { e.FeedId, e.HourId });

            entity.ToTable("tblActualSchedule");

            entity.Property(e => e.FeedId).HasColumnName("FeedID");
            entity.Property(e => e.HourId).HasColumnName("HourID");
            entity.Property(e => e.CarbLiquid).HasDefaultValue((short)0);
            entity.Property(e => e.Liquid).HasDefaultValue((short)0);
            entity.Property(e => e.Medications).HasMaxLength(250);
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.StanMeal).HasMaxLength(300);
            entity.Property(e => e.Supplement).HasMaxLength(250);
        });

        modelBuilder.Entity<TblActualSnack>(entity =>
        {
            entity.HasKey(e => e.SnackId).IsClustered(false);

            entity.ToTable("tblActualSnacks", tb => tb.HasTrigger("trgDeleteSnack"));

            entity.Property(e => e.SnackId).HasColumnName("SnackID");
            entity.Property(e => e.Caregiver).HasDefaultValue(false);
            entity.Property(e => e.DietSnackId).HasColumnName("DietSnackID");
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SnackName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblActualSnackFood>(entity =>
        {
            entity.HasKey(e => new { e.SnackId, e.FoodId });

            entity.ToTable("tblActualSnackFoods");

            entity.Property(e => e.SnackId).HasColumnName("SnackID");
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
        });

        modelBuilder.Entity<TblClientMedication>(entity =>
        {
            entity.HasKey(e => e.MedicationId);

            entity.ToTable("tblClientMedications");

            entity.HasIndex(e => e.PatientId, "PatientID").HasFillFactor(90);

            entity.Property(e => e.MedicationId).HasColumnName("MedicationID");
            entity.Property(e => e.CarbContent).HasMaxLength(10);
            entity.Property(e => e.Dosage).HasMaxLength(30);
            entity.Property(e => e.Medication).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblConfig>(entity =>
        {
            entity.ToTable("tblConfig");

            entity.Property(e => e.Id)
                .HasDefaultValue(1)
                .HasColumnName("ID");
            entity.Property(e => e.ErrorEmail).HasMaxLength(100);
            entity.Property(e => e.FeedingComment).HasMaxLength(500);
            entity.Property(e => e.Fluids).HasMaxLength(250);
            entity.Property(e => e.GenMedications).HasColumnName("Gen_Medications");
            entity.Property(e => e.Ketones).HasMaxLength(250);
            entity.Property(e => e.LastUpdate).HasColumnType("smalldatetime");
            entity.Property(e => e.Medications).HasMaxLength(4000);
            entity.Property(e => e.OrderEmail).HasMaxLength(100);
            entity.Property(e => e.SmtpServer).HasMaxLength(100);
            entity.Property(e => e.WordViewUrl)
                .HasMaxLength(150)
                .HasColumnName("WordViewURL");
        });

        modelBuilder.Entity<TblDiet>(entity =>
        {
            entity.HasKey(e => e.DietId).IsClustered(false);

            entity.ToTable("tblDiets", tb => tb.HasTrigger("trgUpdateCurrentDiet"));

            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DailyLct).HasColumnName("DailyLCT");
            entity.Property(e => e.DailyMct).HasColumnName("DailyMCT");
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.IsManualtarget).HasDefaultValue(false);
            entity.Property(e => e.IsManualtargetOnly).HasDefaultValue(false);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblDietsSnack>(entity =>
        {
            entity.HasKey(e => e.DietSnackId).IsClustered(false);

            entity.ToTable("tblDietsSnack", tb => tb.HasTrigger("trgUpdateCurrentSnackDiet"));

            entity.Property(e => e.DietSnackId).HasColumnName("DietSnackID");
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackOld).HasDefaultValue(false);
            entity.Property(e => e.SnackStart).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblEvent>(entity =>
        {
            entity.HasKey(e => e.EvId);

            entity.ToTable("tblEvents");

            entity.HasIndex(e => e.EvDate, "IX_EvDate").HasFillFactor(90);

            entity.Property(e => e.EvId).HasColumnName("EvID");
            entity.Property(e => e.EvAbbr)
                .HasMaxLength(30)
                .HasComment("Abbreviated event name for calendar");
            entity.Property(e => e.EvCity)
                .HasMaxLength(30)
                .HasComment("City of event");
            entity.Property(e => e.EvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EvLink)
                .HasMaxLength(150)
                .HasComment("hyperlink for event related site (if any)");
            entity.Property(e => e.EvLocation)
                .HasMaxLength(100)
                .HasComment("Location of event");
            entity.Property(e => e.EvNotes).HasColumnType("ntext");
            entity.Property(e => e.EvPhone)
                .HasMaxLength(20)
                .HasComment("Event phone number");
            entity.Property(e => e.EvState)
                .HasMaxLength(30)
                .HasComment("State/Province of event");
            entity.Property(e => e.EvTitle)
                .HasMaxLength(100)
                .HasComment("Full event title");
            entity.Property(e => e.OnlineRegister).HasComment("Is there online registration?");
            entity.Property(e => e.OrgId)
                .HasComment("Org to show this event (0=all)")
                .HasColumnName("OrgID");
        });

        modelBuilder.Entity<TblFaceSheet>(entity =>
        {
            entity.HasKey(e => e.PatientId).IsClustered(false);

            entity.ToTable("tblFaceSheet");

            entity.Property(e => e.PatientId)
                .ValueGeneratedNever()
                .HasColumnName("PatientID");
            entity.Property(e => e.Fluids).HasMaxLength(250);
            entity.Property(e => e.Ketones).HasMaxLength(250);
            entity.Property(e => e.Medications).HasMaxLength(4000);
            entity.Property(e => e.SheetDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblFaq>(entity =>
        {
            entity.HasKey(e => e.FaqId);

            entity.ToTable("tblFaqs");

            entity.Property(e => e.FaqId).HasColumnName("FaqID");
            entity.Property(e => e.FaqCatId).HasColumnName("FaqCatID");
            entity.Property(e => e.FaqHelp).HasComment("Include in screen help?");
            entity.Property(e => e.FaqQuestion).HasMaxLength(100);
            entity.Property(e => e.FaqResponse).HasMaxLength(4000);
            entity.Property(e => e.FaqSubCatId).HasColumnName("FaqSubCatID");
        });

        modelBuilder.Entity<TblFood>(entity =>
        {
            entity.HasKey(e => e.FoodId).IsClustered(false);

            entity.ToTable("tblFoods");

            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.FoodCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FoodItem).HasMaxLength(255);
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.OrgId)
                .HasDefaultValue(0)
                .HasColumnName("OrgID");
            entity.Property(e => e.PatientId)
                .HasDefaultValue(0)
                .HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblHcpinvitation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblHCPInvitation");

            entity.Property(e => e.Hcpemail)
                .HasMaxLength(256)
                .HasColumnName("HCPEmail");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InvitedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientEmail).HasMaxLength(256);
        });

        modelBuilder.Entity<TblHelpLine>(entity =>
        {
            entity.HasKey(e => e.HelplineId);

            entity.ToTable("tblHelpLine");

            entity.Property(e => e.HelplineId).HasColumnName("HelplineID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.Question).HasMaxLength(2000);
            entity.Property(e => e.QuestionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Response).HasMaxLength(4000);
            entity.Property(e => e.UserAsking).HasMaxLength(50);
        });

        modelBuilder.Entity<TblLabsPerPatient>(entity =>
        {
            entity.HasKey(e => e.PatientLabId).HasName("PK_tblLabByPatient");

            entity.ToTable("tblLabsPerPatient", tb => tb.HasTrigger("trgDeleteLabsPerPatient"));

            entity.Property(e => e.PatientLabId).HasColumnName("PatientLabID");
            entity.Property(e => e.LabDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblLabsPerPatientDetail>(entity =>
        {
            entity.HasKey(e => new { e.PatientLabId, e.LabId }).HasName("PK_tblLabByPatientDetail");

            entity.ToTable("tblLabsPerPatientDetail");

            entity.Property(e => e.PatientLabId).HasColumnName("PatientLabID");
            entity.Property(e => e.LabId).HasColumnName("LabID");
        });

        modelBuilder.Entity<TblMealCalendar>(entity =>
        {
            entity.HasKey(e => e.CalendarId);

            entity.ToTable("tblMealCalendar");

            entity.HasIndex(e => e.CalendarId, "IX_tblMealCalendar_PatientID");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.MealCodeId).HasColumnName("MealCodeID");
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackId).HasColumnName("SnackID");
        });

        modelBuilder.Entity<TblMedicationsPerPatient>(entity =>
        {
            entity.HasKey(e => new { e.PatientId, e.MedicationId });

            entity.ToTable("tblMedicationsPerPatient");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.MedicationId).HasColumnName("MedicationID");
        });

        modelBuilder.Entity<TblMessageBoard>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("tblMessageBoard");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.Hcpid).HasColumnName("HCPID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.ReadOn).HasColumnType("datetime");
            entity.Property(e => e.Sender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblOrgPatientRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblOrgPa__3213E83F3AE6784C");

            entity.ToTable("tblOrgPatientRequest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InviteEmail).HasMaxLength(1024);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("pending");
        });

        modelBuilder.Entity<TblOrganization>(entity =>
        {
            entity.HasKey(e => e.OrgId).IsClustered(false);

            entity.ToTable("tblOrganization");

            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.AllowedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.Expiration).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName).HasMaxLength(256);
            entity.Property(e => e.InActive).HasMaxLength(50);
            entity.Property(e => e.IsCookies).HasColumnName("isCookies");
            entity.Property(e => e.IsEmployee).HasDefaultValue(false);
            entity.Property(e => e.IsRecipes).HasColumnName("isRecipes");
            entity.Property(e => e.IsRecipesDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("isRecipesDate");
            entity.Property(e => e.LastLogon).HasColumnType("smalldatetime");
            entity.Property(e => e.LastName).HasMaxLength(256);
            entity.Property(e => e.LogoFileName).HasMaxLength(50);
            entity.Property(e => e.OrgAddress).HasMaxLength(256);
            entity.Property(e => e.OrgAddress2).HasMaxLength(256);
            entity.Property(e => e.OrgCity).HasMaxLength(256);
            entity.Property(e => e.OrgContact).HasMaxLength(256);
            entity.Property(e => e.OrgCountry).HasMaxLength(50);
            entity.Property(e => e.OrgEmail).HasMaxLength(256);
            entity.Property(e => e.OrgIdshs)
                .HasMaxLength(128)
                .HasColumnName("OrgIDSHS");
            entity.Property(e => e.OrgPhone).HasMaxLength(128);
            entity.Property(e => e.OrgPostalCode).HasMaxLength(128);
            entity.Property(e => e.OrgPword).HasMaxLength(128);
            entity.Property(e => e.OrgState).HasMaxLength(50);
            entity.Property(e => e.OrgUserName).HasMaxLength(256);
            entity.Property(e => e.Organization).HasMaxLength(512);
            entity.Property(e => e.SilverPopRecipientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SilverPopRecipientID");
            entity.Property(e => e.UpcomingEvents).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblPatient>(entity =>
        {
            entity.HasKey(e => e.PatientId).IsClustered(false);

            entity.ToTable("tblPatients", tb => tb.HasTrigger("trgDeletePatient"));

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.CaregiverFirstName).HasMaxLength(128);
            entity.Property(e => e.CaregiverLastName).HasMaxLength(128);
            entity.Property(e => e.CaregiverLogin).HasMaxLength(20);
            entity.Property(e => e.CaregiverPw)
                .HasMaxLength(128)
                .HasColumnName("CaregiverPW");
            entity.Property(e => e.City).HasMaxLength(256);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.DietRatio)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DietVersion).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(1024);
            entity.Property(e => e.EndDiet).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.Gender).HasMaxLength(128);
            entity.Property(e => e.InActive)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsCookies).HasColumnName("isCookies");
            entity.Property(e => e.IsRecipes).HasColumnName("isRecipes");
            entity.Property(e => e.IsRecipesDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("isRecipesDate");
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.OrgIdOld).HasColumnName("OrgID_old");
            entity.Property(e => e.SilverPopRecipientId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SilverPopRecipientID");
            entity.Property(e => e.StartDiet).HasColumnType("smalldatetime");
            entity.Property(e => e.State).HasMaxLength(256);
            entity.Property(e => e.StatusId)
                .HasDefaultValue((short)1)
                .HasColumnName("StatusID");
            entity.Property(e => e.UpcomingEvents).HasDefaultValue(false);
            entity.Property(e => e.ZipCode).HasMaxLength(128);
        });

        modelBuilder.Entity<TblPatientOrg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPatientOrg");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<TblPatientOrgRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblPatie__3214EC2709819A71");

            entity.ToTable("tblPatientOrgRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Status)
                .HasMaxLength(55)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRecipe>(entity =>
        {
            entity.HasKey(e => e.RecipeId);

            entity.ToTable("tblRecipes");

            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.ImageFileName).HasColumnType("ntext");
            entity.Property(e => e.ImageName).HasColumnType("ntext");
            entity.Property(e => e.IsAccept).HasDefaultValue(false);
            entity.Property(e => e.IsAgree).HasDefaultValue(false);
            entity.Property(e => e.IsFavoriteRecipe).HasDefaultValue(false);
            entity.Property(e => e.IsHhunit).HasColumnName("IsHHUnit");
            entity.Property(e => e.IsVerifyMailHcp).HasColumnName("IsVerifyMailHCP");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Ratio).HasMaxLength(10);
            entity.Property(e => e.RecipeCategoryId).HasColumnName("RecipeCategoryID");
            entity.Property(e => e.ReviewedOn).HasColumnType("datetime");
            entity.Property(e => e.Tags).HasMaxLength(200);
            entity.Property(e => e.TargetRatio).HasMaxLength(20);
            entity.Property(e => e.TargetType).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(300);
        });

        modelBuilder.Entity<TblRecipeCalendar>(entity =>
        {
            entity.HasKey(e => e.CalendarId);

            entity.ToTable("tblRecipeCalendar");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RecipeCodeId).HasColumnName("RecipeCodeID");
            entity.Property(e => e.RecipeDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
        });

        modelBuilder.Entity<TblRecipeCategory>(entity =>
        {
            entity.HasKey(e => e.RecipeCategoryId);

            entity.ToTable("tblRecipeCategory");

            entity.Property(e => e.RecipeCategoryId).HasColumnName("RecipeCategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblRecipeIngredient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRecipeIngredients");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(200);
            entity.Property(e => e.IngredientId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IngredientID");
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblRecipeToAssignPatient>(entity =>
        {
            entity.HasKey(e => e.PatientRecipeId);

            entity.ToTable("tblRecipeToAssignPatient");

            entity.Property(e => e.PatientRecipeId).HasColumnName("PatientRecipeID");
            entity.Property(e => e.CalRatio).HasMaxLength(20);
            entity.Property(e => e.NewRecipeId).HasColumnName("NewRecipeID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RecipeDate).HasColumnType("datetime");
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.RecipeUnits).HasMaxLength(20);
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tblRole");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<TblSharedRecipe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSharedRecipes");

            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSupplementsPerPatient>(entity =>
        {
            entity.HasKey(e => new { e.PatientId, e.SupplementId });

            entity.ToTable("tblSupplementsPerPatient");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.SuppleValue).HasDefaultValue(0f);
        });

        modelBuilder.Entity<TblUserSavedRecipe>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RecipeId });

            entity.ToTable("tblUserSavedRecipes");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.UserSavedRecipeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserSavedRecipeID");
        });

        modelBuilder.Entity<TempVwDietCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp_vw_DietCurrent");

            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.AgeRange).HasMaxLength(50);
            entity.Property(e => e.AgeRangeList).HasMaxLength(83);
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
        });

        modelBuilder.Entity<TlkpAgeRange>(entity =>
        {
            entity.HasKey(e => e.AgeId)
                .HasName("PK_tlkpRDAAge")
                .IsClustered(false);

            entity.ToTable("tlkpAgeRange");

            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.AgeFrom).HasColumnType("smallmoney");
            entity.Property(e => e.AgeRange).HasMaxLength(50);
            entity.Property(e => e.AgeTo).HasColumnType("smallmoney");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TlkpCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpCategory");

            entity.Property(e => e.CatDesc).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        });

        modelBuilder.Entity<TlkpDriageRange>(entity =>
        {
            entity.HasKey(e => e.DriageId).IsClustered(false);

            entity.ToTable("tlkpDRIAgeRange");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.DriageRange)
                .HasMaxLength(10)
                .HasColumnName("DRIAgeRange");
        });

        modelBuilder.Entity<TlkpDrirec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpDRIRec");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.Drihigh)
                .HasDefaultValue(0f)
                .HasColumnName("DRIHigh");
            entity.Property(e => e.Drilow)
                .HasDefaultValue(0f)
                .HasColumnName("DRILow");
            entity.Property(e => e.VitMinId).HasColumnName("VitMinID");
        });

        modelBuilder.Entity<TlkpFaqCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpFaqCategories");

            entity.Property(e => e.FaqCatId).HasColumnName("FaqCatID");
            entity.Property(e => e.FaqCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpFaqSubCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpFaqSubCategories");

            entity.Property(e => e.FaqSubCatId).HasColumnName("FaqSubCatID");
            entity.Property(e => e.FaqSubCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpFraction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpFractions");

            entity.Property(e => e.FractionText).HasMaxLength(4);
        });

        modelBuilder.Entity<TlkpHandout>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("tlkpHandouts");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.HandDocLoc).HasMaxLength(100);
            entity.Property(e => e.HandTitle).HasMaxLength(150);
        });

        modelBuilder.Entity<TlkpHour>(entity =>
        {
            entity.HasKey(e => e.HourId);

            entity.ToTable("tlkpHours");

            entity.Property(e => e.HourId)
                .ValueGeneratedNever()
                .HasColumnName("HourID");
            entity.Property(e => e.DefHours).HasColumnType("datetime");
        });

        modelBuilder.Entity<TlkpMaintenance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpMaintenance");

            entity.Property(e => e.MaintainName).HasMaxLength(75);
            entity.Property(e => e.PageName).HasMaxLength(60);
            entity.Property(e => e.TableName).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpMeal>(entity =>
        {
            entity.HasKey(e => e.StanMeal).IsClustered(false);

            entity.ToTable("tlkpMeals", tb => tb.HasTrigger("trgDeleteStandardMeal"));

            entity.Property(e => e.Instructions).HasColumnType("ntext");
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.MealName).HasMaxLength(50);
            entity.Property(e => e.MealType).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<TlkpMealCode>(entity =>
        {
            entity.HasKey(e => e.MealCodeId);

            entity.ToTable("tlkpMealCodes");

            entity.Property(e => e.MealCodeId).HasColumnName("MealCodeID");
            entity.Property(e => e.MealCode).HasMaxLength(25);
        });

        modelBuilder.Entity<TlkpMealDay>(entity =>
        {
            entity.HasKey(e => e.DayNumber);

            entity.ToTable("tlkpMealDays");

            entity.Property(e => e.DayNumber).ValueGeneratedNever();
            entity.Property(e => e.DayDesc)
                .HasMaxLength(4)
                .IsFixedLength();
        });

        modelBuilder.Entity<TlkpMealFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpMealFoods");

            entity.HasIndex(e => e.FoodId, "foodid").HasFillFactor(90);

            entity.HasIndex(e => e.StanMeal, "stanmeal").HasFillFactor(90);

            entity.Property(e => e.FoodId).HasColumnName("FoodID");
        });

        modelBuilder.Entity<TlkpMedication>(entity =>
        {
            entity.HasKey(e => e.MedicationId);

            entity.ToTable("tlkpMedications");

            entity.Property(e => e.MedicationId).HasColumnName("MedicationID");
            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.Medication).HasMaxLength(50);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.Prescription).HasMaxLength(10);
            entity.Property(e => e.Units).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpRatio>(entity =>
        {
            entity.HasKey(e => e.DietRatio).IsClustered(false);

            entity.ToTable("tlkpRatio");

            entity.Property(e => e.DietRatio).HasMaxLength(50);
            entity.Property(e => e.Cpu).HasColumnName("CPU");
            entity.Property(e => e.RatioId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RatioID");
        });

        modelBuilder.Entity<TlkpRecipeCode>(entity =>
        {
            entity.HasKey(e => e.RecipeCodeId);

            entity.ToTable("tlkpRecipeCodes");

            entity.Property(e => e.RecipeCodeId).HasColumnName("RecipeCodeID");
            entity.Property(e => e.RecipeCode).HasMaxLength(25);
        });

        modelBuilder.Entity<TlkpSnack>(entity =>
        {
            entity.HasKey(e => e.StanSnack).IsClustered(false);

            entity.ToTable("tlkpSnacks");

            entity.Property(e => e.Instructions).HasColumnType("ntext");
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.StanName).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpSnackFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpSnackFoods");

            entity.Property(e => e.DefGrams).HasDefaultValue(0f);
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
        });

        modelBuilder.Entity<TlkpStandardFeeding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpStandardFeeding");

            entity.Property(e => e.HourFeeding).HasColumnType("datetime");
            entity.Property(e => e.Medications).HasMaxLength(250);
            entity.Property(e => e.Supplement).HasMaxLength(250);
        });

        modelBuilder.Entity<TlkpStandardLabDetail>(entity =>
        {
            entity.HasKey(e => e.LabId).HasName("PK_tlkpLabDetails");

            entity.ToTable("tlkpStandardLabDetails");

            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.LabName).HasMaxLength(50);
            entity.Property(e => e.LabTypeId).HasColumnName("LabTypeID");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.Range).HasMaxLength(20);
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<TlkpStandardLabType>(entity =>
        {
            entity.HasKey(e => e.LabTypeId).HasName("PK_tlkpLabTypes");

            entity.ToTable("tlkpStandardLabTypes", tb => tb.HasTrigger("trgDeleteStandardLabTypes"));

            entity.Property(e => e.LabTypeId).HasColumnName("LabTypeID");
            entity.Property(e => e.LabType).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpStandardSupplement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpStandardSupplements");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.SupAmount).HasDefaultValue(0f);
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
        });

        modelBuilder.Entity<TlkpStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).IsClustered(false);

            entity.ToTable("tlkpStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusDesc).HasMaxLength(15);
        });

        modelBuilder.Entity<TlkpSupplement>(entity =>
        {
            entity.HasKey(e => e.SupplementId).IsClustered(false);

            entity.ToTable("tlkpSupplements");

            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.OrgId)
                .HasDefaultValue(0)
                .HasColumnName("OrgID");
            entity.Property(e => e.SupAmount).HasDefaultValue(1f);
            entity.Property(e => e.Supplement).HasMaxLength(75);
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<TlkpUnit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpUnits");

            entity.Property(e => e.UnitText).HasMaxLength(15);
            entity.Property(e => e.Units).HasMaxLength(4);
        });

        modelBuilder.Entity<TlkpValuePerSupplement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpValuePerSupplement");

            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.VitMinId).HasColumnName("VitMinID");
        });

        modelBuilder.Entity<TlkpVitMin>(entity =>
        {
            entity.HasKey(e => e.VitMinId).IsClustered(false);

            entity.ToTable("tlkpVitMin");

            entity.Property(e => e.VitMinId).HasColumnName("VitMinID");
            entity.Property(e => e.VitMinDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<TlkpYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tlkpYear");

            entity.Property(e => e.PickYear).HasMaxLength(4);
        });

        modelBuilder.Entity<VwActuaRecipeFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActuaRecipeFoods");

            entity.Property(e => e.CatDesc).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.FoodFacts).HasMaxLength(83);
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(200);
            entity.Property(e => e.IngredientId).HasColumnName("IngredientID");
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.Title).HasMaxLength(300);
            entity.Property(e => e.Units)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwActualFoodTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualFoodTotals");

            entity.Property(e => e.MealId).HasColumnName("MealID");
        });

        modelBuilder.Entity<VwActualLab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualLabs");

            entity.Property(e => e.LabDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LabId).HasColumnName("LabID");
            entity.Property(e => e.LabName).HasMaxLength(50);
            entity.Property(e => e.LabTypeId).HasColumnName("LabTypeID");
            entity.Property(e => e.PatientLabId).HasColumnName("PatientLabID");
            entity.Property(e => e.Range).HasMaxLength(20);
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<VwActualMeal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualMeal");

            entity.Property(e => e.ClientName).HasMaxLength(51);
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MealDisplay).HasMaxLength(54);
            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.MealName).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<VwActualMealFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualMealFoods");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ClientName).HasMaxLength(51);
            entity.Property(e => e.FoodFacts).HasMaxLength(83);
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.MealName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwActualMealsVerified>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualMealsVerified");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.LogoFileName).HasMaxLength(50);
            entity.Property(e => e.MealId).HasColumnName("MealID");
            entity.Property(e => e.MealName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.Organization).HasMaxLength(150);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<VwActualRecipe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualRecipe");

            entity.Property(e => e.AddedOn).HasColumnType("datetime");
            entity.Property(e => e.ImageFileName).HasColumnType("ntext");
            entity.Property(e => e.ImageName).HasColumnType("ntext");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Ratio).HasMaxLength(10);
            entity.Property(e => e.RecipeCategoryId).HasColumnName("RecipeCategoryID");
            entity.Property(e => e.RecipeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecipeID");
            entity.Property(e => e.Tags).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(300);
        });

        modelBuilder.Entity<VwActualRecipeFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualRecipeFoods");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<VwActualSchedule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSchedule");

            entity.Property(e => e.Comments).HasMaxLength(1000);
            entity.Property(e => e.DefHours).HasColumnType("datetime");
            entity.Property(e => e.FeedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FeedId).HasColumnName("FeedID");
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.HourId).HasColumnName("HourID");
            entity.Property(e => e.Medications).HasMaxLength(250);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RecCc)
                .HasMaxLength(1000)
                .HasColumnName("RecCC");
            entity.Property(e => e.RecFluid)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.RecipeId).HasColumnName("RecipeID");
            entity.Property(e => e.RecipeName).HasMaxLength(300);
            entity.Property(e => e.StanMeal).HasMaxLength(300);
            entity.Property(e => e.Supplement).HasMaxLength(250);
        });

        modelBuilder.Entity<VwActualSchedulePrint>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSchedulePrint");

            entity.Property(e => e.Comments).HasMaxLength(1000);
            entity.Property(e => e.DefHours).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FeedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FeedId).HasColumnName("FeedID");
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.HourId).HasColumnName("HourID");
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.LogoFileName).HasMaxLength(50);
            entity.Property(e => e.Medications).HasMaxLength(250);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.Organization).HasMaxLength(150);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RecCc).HasColumnName("RecCC");
            entity.Property(e => e.RecFluid)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.Supplement).HasMaxLength(250);
        });

        modelBuilder.Entity<VwActualSnack>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSnack");

            entity.Property(e => e.ClientName).HasMaxLength(51);
            entity.Property(e => e.DietSnackId).HasColumnName("DietSnackID");
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SnackDisplay).HasMaxLength(54);
            entity.Property(e => e.SnackId).HasColumnName("SnackID");
            entity.Property(e => e.SnackName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwActualSnackFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSnackFoods");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ClientName).HasMaxLength(51);
            entity.Property(e => e.FoodFacts).HasMaxLength(83);
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackDate).HasColumnType("smalldatetime");
            entity.Property(e => e.SnackId).HasColumnName("SnackID");
            entity.Property(e => e.SnackName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwActualSnackFoodTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSnackFoodTotals");

            entity.Property(e => e.SnackId).HasColumnName("SnackID");
        });

        modelBuilder.Entity<VwActualSnacksVerified>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ActualSnacksVerified");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasMaxLength(4000);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.LogoFileName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.Organization).HasMaxLength(150);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SnackId).HasColumnName("SnackID");
            entity.Property(e => e.SnackName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwCalcage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Calcage");

            entity.Property(e => e.Checkday).HasColumnName("checkday");
            entity.Property(e => e.Checkmo).HasColumnName("checkmo");
            entity.Property(e => e.Checkyear).HasColumnName("checkyear");
            entity.Property(e => e.DefaultAgeId).HasColumnName("DefaultAgeID");
            entity.Property(e => e.DefaultDriageId).HasColumnName("DefaultDRIAgeID");
            entity.Property(e => e.Dob)
                .HasColumnType("smalldatetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PatientId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PatientID");
        });

        modelBuilder.Entity<VwDietCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DietCurrent");

            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.AgeRange).HasMaxLength(50);
            entity.Property(e => e.AgeRangeList).HasMaxLength(83);
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DailyLct).HasColumnName("DailyLCT");
            entity.Property(e => e.DailyMct).HasColumnName("DailyMCT");
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
        });

        modelBuilder.Entity<VwDietCurrentPatient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DietCurrentPatient");

            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.AgeRange).HasMaxLength(50);
            entity.Property(e => e.AgeRangeList).HasMaxLength(83);
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
        });

        modelBuilder.Entity<VwDietHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DietHistory");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DietId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DietID");
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<VwDietHistoryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DietHistoryDetail");

            entity.Property(e => e.AgeId).HasColumnName("AgeID");
            entity.Property(e => e.AgeRange).HasMaxLength(50);
            entity.Property(e => e.AgeRangeList).HasMaxLength(83);
            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.DailyLct).HasColumnName("DailyLCT");
            entity.Property(e => e.DailyMct).HasColumnName("DailyMCT");
            entity.Property(e => e.DietDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DietId).HasColumnName("DietID");
            entity.Property(e => e.Email).HasMaxLength(1024);
            entity.Property(e => e.FeedRoute).HasMaxLength(10);
            entity.Property(e => e.FirstName).HasMaxLength(128);
            entity.Property(e => e.LastName).HasMaxLength(128);
            entity.Property(e => e.MiddleName).HasMaxLength(128);
            entity.Property(e => e.OrgEmail).HasMaxLength(256);
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
        });

        modelBuilder.Entity<VwDribyAge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DRIByAge");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.Drihigh).HasColumnName("DRIHigh");
            entity.Property(e => e.Drilow).HasColumnName("DRILow");
            entity.Property(e => e.VitMinDesc).HasMaxLength(50);
            entity.Property(e => e.VitMinId).HasColumnName("VitMinID");
        });

        modelBuilder.Entity<VwFaceSheetAndDiet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FaceSheetAndDiet");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Fluids).HasMaxLength(250);
            entity.Property(e => e.Ketones).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.Medications).HasMaxLength(4000);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SheetDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwFaceSheetAndDietLogo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FaceSheetAndDietLogo");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Fluids).HasMaxLength(250);
            entity.Property(e => e.Ketones).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.LogoFileName).HasMaxLength(50);
            entity.Property(e => e.Medications).HasMaxLength(4000);
            entity.Property(e => e.MiddleName).HasMaxLength(20);
            entity.Property(e => e.OrgEmail).HasMaxLength(100);
            entity.Property(e => e.Organization).HasMaxLength(150);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.SheetDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwFaqList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FaqList");

            entity.Property(e => e.FaqCatId).HasColumnName("FaqCatID");
            entity.Property(e => e.FaqCategory).HasMaxLength(50);
            entity.Property(e => e.FaqId).HasColumnName("FaqID");
            entity.Property(e => e.FaqQuestion).HasMaxLength(100);
            entity.Property(e => e.FaqResponse).HasMaxLength(4000);
            entity.Property(e => e.FaqSubCatId).HasColumnName("FaqSubCatID");
        });

        modelBuilder.Entity<VwFoodsAndCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FoodsAndCategory");

            entity.Property(e => e.CatDesc).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.OrgId).HasColumnName("OrgID");
        });

        modelBuilder.Entity<VwMealCalendar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MealCalendar");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.DayDesc)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.MealCode).HasMaxLength(25);
            entity.Property(e => e.MealCodeSort).HasMaxLength(26);
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrintMeal).HasMaxLength(83);
        });

        modelBuilder.Entity<VwMealPlannerMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MealPlannerMatrix");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.MealCode).HasMaxLength(25);
            entity.Property(e => e.MealDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrintMeal).HasMaxLength(83);
        });

        modelBuilder.Entity<VwMealsStdWithFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MealsStdWithFoods");

            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasColumnType("ntext");
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.MealName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwMedicationsPerPatient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MedicationsPerPatient");

            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.Medication).HasMaxLength(50);
            entity.Property(e => e.MedicationId).HasColumnName("MedicationID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Prescription).HasMaxLength(10);
            entity.Property(e => e.Units).HasMaxLength(50);
        });

        modelBuilder.Entity<VwRecipeCalendar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RecipeCalendar");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.DayDesc)
                .HasMaxLength(4)
                .IsFixedLength();
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrintMeal).HasMaxLength(300);
            entity.Property(e => e.RecipeCode).HasMaxLength(25);
            entity.Property(e => e.RecipeCodeSort).HasMaxLength(26);
            entity.Property(e => e.RecipeDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwRecipeDietCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RecipeDietCurrent");

            entity.Property(e => e.CalRatio).HasMaxLength(20);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientRecipeId).HasColumnName("PatientRecipeID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
            entity.Property(e => e.RecipeDate).HasColumnType("datetime");
            entity.Property(e => e.RecipeUnits).HasMaxLength(20);
        });

        modelBuilder.Entity<VwRecipePlannerMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_RecipePlannerMatrix");

            entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PrintMeal).HasMaxLength(300);
            entity.Property(e => e.RecipeCode).HasMaxLength(25);
            entity.Property(e => e.RecipeDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwSnackDietCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SnackDietCurrent");

            entity.Property(e => e.CalRatio).HasMaxLength(50);
            entity.Property(e => e.DietSnackId).HasColumnName("DietSnackID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RatioList).HasMaxLength(155);
            entity.Property(e => e.SnackStart).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VwSnackStdWithFood>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SnackStdWithFoods");

            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.FoodItem).HasMaxLength(55);
            entity.Property(e => e.Instructions).HasColumnType("ntext");
            entity.Property(e => e.StanName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwSupStdWithVitMin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SupStdWithVitMin");

            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");
            entity.Property(e => e.Supplement).HasMaxLength(75);
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.Units).HasMaxLength(10);
            entity.Property(e => e.VitMinDesc).HasMaxLength(50);
            entity.Property(e => e.VitMinId).HasColumnName("VitMinID");
        });

        modelBuilder.Entity<VwSupplementsByAge>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SupplementsByAge");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.Supplement).HasMaxLength(75);
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.UnitText).HasMaxLength(15);
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<VwSupplementsCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SupplementsCurrent");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Supplement).HasMaxLength(75);
            entity.Property(e => e.SupplementId).HasColumnName("SupplementID");
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<VwSupplementsPerPatient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_SupplementsPerPatient");

            entity.Property(e => e.Instructions).HasMaxLength(100);
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Supplement).HasMaxLength(75);
            entity.Property(e => e.Units).HasMaxLength(10);
        });

        modelBuilder.Entity<VwTblLabsPerPatientByDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_tblLabsPerPatientByDate");

            entity.Property(e => e.LabDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PatientLabId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PatientLabID");
        });

        modelBuilder.Entity<VwUnverifiedMeal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UnverifiedMeals");

            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientName).HasMaxLength(51);
        });

        modelBuilder.Entity<VwUnverifiedSnack>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UnverifiedSnacks");

            entity.Property(e => e.OrgId).HasColumnName("OrgID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.PatientName).HasMaxLength(51);
        });

        modelBuilder.Entity<VwVitMinValuesCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_VitMinValuesCurrent");

            entity.Property(e => e.DriageId).HasColumnName("DRIAgeID");
            entity.Property(e => e.Drihigh).HasColumnName("DRIHigh");
            entity.Property(e => e.Drilow).HasColumnName("DRILow");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.VitMinDesc).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
