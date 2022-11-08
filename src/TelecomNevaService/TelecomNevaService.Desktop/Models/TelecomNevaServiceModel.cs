using System.Data.Entity;

namespace TelecomNevaService.Desktop.Models;

public partial class TelecomNevaServiceModel : DbContext
{
    public TelecomNevaServiceModel()
        : base("name=TNSModel")
    {
    }

    public virtual DbSet<AccessNetworkEquipment> AccessNetworkEquipment { get; set; }
    public virtual DbSet<AntennaType> AntennaType { get; set; }
    public virtual DbSet<Application> Application { get; set; }
    public virtual DbSet<ApplicationStatus> ApplicationStatus { get; set; }
    public virtual DbSet<ApplicationSubtype> ApplicationSubtype { get; set; }
    public virtual DbSet<ApplicationType> ApplicationType { get; set; }
    public virtual DbSet<BaseStation> BaseStation { get; set; }
    public virtual DbSet<BaseStationLocation> BaseStationLocation { get; set; }
    public virtual DbSet<Billings> Billings { get; set; }
    public virtual DbSet<BuildingType> BuildingType { get; set; }
    public virtual DbSet<ClientAdress> ClientAdress { get; set; }
    public virtual DbSet<ClientComboRate> ClientComboRate { get; set; }
    public virtual DbSet<ClientEquipment> ClientEquipment { get; set; }
    public virtual DbSet<ClientEquipmentPort> ClientEquipmentPort { get; set; }
    public virtual DbSet<ClientRate> ClientRate { get; set; }
    public virtual DbSet<ComboRate> ComboRate { get; set; }
    public virtual DbSet<ContractInfo> ContractInfo { get; set; }
    public virtual DbSet<ContractTerminationReason> ContractTerminationReason { get; set; }
    public virtual DbSet<DataTransmissionStandart> DataTransmissionStandart { get; set; }
    public virtual DbSet<DataTransmissionTechnolony> DataTransmissionTechnolony { get; set; }
    public virtual DbSet<District> District { get; set; }
    public virtual DbSet<EmployeeReportCard> EmployeeReportCard { get; set; }
    public virtual DbSet<EmployeeVacation> EmployeeVacation { get; set; }
    public virtual DbSet<Equipment> Equipment { get; set; }
    public virtual DbSet<EquipmentType> EquipmentType { get; set; }
    public virtual DbSet<Gender> Gender { get; set; }
    public virtual DbSet<HighwayEquipment> HighwayEquipment { get; set; }
    public virtual DbSet<Interface> Interface { get; set; }
    public virtual DbSet<InterfaceAccessNetworkEquipment> InterfaceAccessNetworkEquipment { get; set; }
    public virtual DbSet<IssueType> IssueType { get; set; }
    public virtual DbSet<PassportGivingInfo> PassportGivingInfo { get; set; }
    public virtual DbSet<PortType> PortType { get; set; }
    public virtual DbSet<Rate> Rate { get; set; }
    public virtual DbSet<Service> Service { get; set; }
    public virtual DbSet<StaffInfo> StaffInfo { get; set; }
    public virtual DbSet<User> User { get; set; }
    public virtual DbSet<UserInfo> UserInfo { get; set; }
    public virtual DbSet<UserPassportData> UserPassportData { get; set; }
    public virtual DbSet<UserRole> UserRole { get; set; }
    public virtual DbSet<UserService> UserService { get; set; }
    public virtual DbSet<WirelessCommunicationStandart> WirelessCommunicationStandart { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessNetworkEquipment>()
            .Property(e => e.Frequency)
            .HasPrecision(4, 2);

        modelBuilder.Entity<AccessNetworkEquipment>()
            .HasMany(e => e.InterfaceAccessNetworkEquipment)
            .WithRequired(e => e.AccessNetworkEquipment)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<AntennaType>()
            .HasMany(e => e.BaseStation)
            .WithRequired(e => e.AntennaType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Application>()
            .HasMany(e => e.EmployeeReportCard)
            .WithRequired(e => e.Application)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ApplicationStatus>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.ApplicationStatus)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ApplicationSubtype>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.ApplicationSubtype)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ApplicationType>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.ApplicationType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<BaseStation>()
            .Property(e => e.CoverageArea)
            .HasPrecision(3, 2);

        modelBuilder.Entity<BaseStation>()
            .HasMany(e => e.BaseStationLocation)
            .WithRequired(e => e.BaseStation)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Billings>()
            .Property(e => e.PaymentSum)
            .HasPrecision(19, 2);

        modelBuilder.Entity<Billings>()
            .Property(e => e.ClientBalance)
            .HasPrecision(19, 2);

        modelBuilder.Entity<Billings>()
            .Property(e => e.ClientDebt)
            .HasPrecision(19, 2);

        modelBuilder.Entity<BuildingType>()
            .HasMany(e => e.District)
            .WithRequired(e => e.BuildingType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ClientAdress>()
            .HasMany(e => e.ClientEquipment)
            .WithRequired(e => e.ClientAdress)
            .HasForeignKey(e => e.ClientAddress)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ClientEquipment>()
            .HasMany(e => e.ClientEquipmentPort)
            .WithRequired(e => e.ClientEquipment)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ComboRate>()
            .Property(e => e.Cost)
            .HasPrecision(10, 2);

        modelBuilder.Entity<ComboRate>()
            .HasMany(e => e.ClientComboRate)
            .WithRequired(e => e.ComboRate)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ContractInfo>()
            .HasMany(e => e.ClientComboRate)
            .WithRequired(e => e.ContractInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ContractInfo>()
            .HasMany(e => e.ClientRate)
            .WithRequired(e => e.ContractInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<ContractInfo>()
            .HasMany(e => e.UserService)
            .WithRequired(e => e.ContractInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<DataTransmissionStandart>()
            .HasMany(e => e.AccessNetworkEquipment)
            .WithRequired(e => e.DataTransmissionStandart)
            .HasForeignKey(e => e.DataTransmissonStandartID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<DataTransmissionStandart>()
            .HasMany(e => e.ClientEquipment)
            .WithRequired(e => e.DataTransmissionStandart)
            .HasForeignKey(e => e.DataTransmissonStandartID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<DataTransmissionTechnolony>()
            .HasMany(e => e.HighwayEquipment)
            .WithRequired(e => e.DataTransmissionTechnolony)
            .HasForeignKey(e => e.DataTransmissionTechnologyID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<District>()
            .Property(e => e.Area)
            .HasPrecision(10, 2);

        modelBuilder.Entity<District>()
            .HasMany(e => e.BaseStationLocation)
            .WithRequired(e => e.District)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Equipment>()
            .HasMany(e => e.AccessNetworkEquipment)
            .WithRequired(e => e.Equipment)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Equipment>()
            .HasMany(e => e.HighwayEquipment)
            .WithRequired(e => e.Equipment)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<EquipmentType>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.EquipmentType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<EquipmentType>()
            .HasMany(e => e.Equipment)
            .WithRequired(e => e.EquipmentType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Gender>()
            .HasMany(e => e.UserInfo)
            .WithRequired(e => e.Gender)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Interface>()
            .HasMany(e => e.InterfaceAccessNetworkEquipment)
            .WithRequired(e => e.Interface)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<IssueType>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.IssueType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<PassportGivingInfo>()
            .Property(e => e.DivisionCode)
            .IsUnicode(false);

        modelBuilder.Entity<PassportGivingInfo>()
            .HasMany(e => e.UserPassportData)
            .WithRequired(e => e.PassportGivingInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<PortType>()
            .HasMany(e => e.ClientEquipmentPort)
            .WithRequired(e => e.PortType)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Rate>()
            .Property(e => e.Cost)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Rate>()
            .HasMany(e => e.ClientRate)
            .WithRequired(e => e.Rate)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Service>()
            .HasMany(e => e.Application)
            .WithRequired(e => e.Service)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Service>()
            .HasMany(e => e.Rate)
            .WithRequired(e => e.Service)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<Service>()
            .HasMany(e => e.UserService)
            .WithRequired(e => e.Service)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<User>()
            .HasMany(e => e.Billings)
            .WithRequired(e => e.User)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<User>()
            .HasMany(e => e.EmployeeReportCard)
            .WithRequired(e => e.User)
            .HasForeignKey(e => e.EmployeeID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<User>()
            .HasMany(e => e.EmployeeVacation)
            .WithRequired(e => e.User)
            .HasForeignKey(e => e.EmployeeID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserInfo>()
            .Property(e => e.PhoneNumber)
            .IsUnicode(false);

        modelBuilder.Entity<UserInfo>()
            .HasMany(e => e.ClientAdress)
            .WithRequired(e => e.UserInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserInfo>()
            .HasMany(e => e.ContractInfo)
            .WithRequired(e => e.UserInfo)
            .HasForeignKey(e => e.UserID)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserInfo>()
            .HasMany(e => e.User)
            .WithRequired(e => e.UserInfo)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserPassportData>()
            .HasMany(e => e.UserInfo)
            .WithRequired(e => e.UserPassportData)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserRole>()
            .HasMany(e => e.StaffInfo)
            .WithRequired(e => e.UserRole)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<UserRole>()
            .HasMany(e => e.User)
            .WithRequired(e => e.UserRole)
            .WillCascadeOnDelete(false);

        modelBuilder.Entity<WirelessCommunicationStandart>()
            .HasMany(e => e.BaseStation)
            .WithRequired(e => e.WirelessCommunicationStandart)
            .WillCascadeOnDelete(false);
    }
}
