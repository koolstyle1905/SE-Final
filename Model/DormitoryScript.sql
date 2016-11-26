/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/26/2016 8:04:55 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Attendance') and o.name = 'FK_ATTENDAN_RELATIONS_EMPLOYEE')
alter table Attendance
   drop constraint FK_ATTENDAN_RELATIONS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AttendanceDetail') and o.name = 'FK_ATTENDAN_ATTENDANC_ATTENDAN')
alter table AttendanceDetail
   drop constraint FK_ATTENDAN_ATTENDANC_ATTENDAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AttendanceDetail') and o.name = 'FK_ATTENDAN_ATTENDANC_STUDENTS')
alter table AttendanceDetail
   drop constraint FK_ATTENDAN_ATTENDANC_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Carer') and o.name = 'FK_CARER_RELATIONS_STUDENTS')
alter table Carer
   drop constraint FK_CARER_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Classes') and o.name = 'FK_CLASSES_RELATIONS_FACULTIE')
alter table Classes
   drop constraint FK_CLASSES_RELATIONS_FACULTIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DamageClaim') and o.name = 'FK_DAMAGECL_RELATIONS_STUDENTS')
alter table DamageClaim
   drop constraint FK_DAMAGECL_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DamageClaim') and o.name = 'FK_DAMAGECL_RELATIONS_EMPLOYEE')
alter table DamageClaim
   drop constraint FK_DAMAGECL_RELATIONS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Discipline') and o.name = 'FK_DISCIPLI_RELATIONS_STUDENTS')
alter table Discipline
   drop constraint FK_DISCIPLI_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Discipline') and o.name = 'FK_DISCIPLI_RELATIONS_EMPLOYEE')
alter table Discipline
   drop constraint FK_DISCIPLI_RELATIONS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Floors') and o.name = 'FK_FLOORS_RELATIONS_BUILDING')
alter table Floors
   drop constraint FK_FLOORS_RELATIONS_BUILDING
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LateArrivalInfo') and o.name = 'FK_LATEARRI_RELATIONS_STUDENTS')
alter table LateArrivalInfo
   drop constraint FK_LATEARRI_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LeaseContracts') and o.name = 'FK_LEASECON_RELATIONS_STUDENTS')
alter table LeaseContracts
   drop constraint FK_LEASECON_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LeaseReceipts') and o.name = 'FK_LEASEREC_LEASERECE_EMPLOYEE')
alter table LeaseReceipts
   drop constraint FK_LEASEREC_LEASERECE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LeaseReceipts') and o.name = 'FK_LEASEREC_LEASERECE_LEASECON')
alter table LeaseReceipts
   drop constraint FK_LEASEREC_LEASERECE_LEASECON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ParkingReceipts') and o.name = 'FK_PARKINGR_PARKINGRE_EMPLOYEE')
alter table ParkingReceipts
   drop constraint FK_PARKINGR_PARKINGRE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ParkingReceipts') and o.name = 'FK_PARKINGR_PARKINGRE_PARKINGT')
alter table ParkingReceipts
   drop constraint FK_PARKINGR_PARKINGRE_PARKINGT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ParkingTickets') and o.name = 'FK_PARKINGT_RELATIONS_STUDENTS')
alter table ParkingTickets
   drop constraint FK_PARKINGT_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PriorityTarget') and o.name = 'FK_PRIORITY_PRIORITYT_PRIORITI')
alter table PriorityTarget
   drop constraint FK_PRIORITY_PRIORITYT_PRIORITI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PriorityTarget') and o.name = 'FK_PRIORITY_PRIORITYT_STUDENTS')
alter table PriorityTarget
   drop constraint FK_PRIORITY_PRIORITYT_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Rooms') and o.name = 'FK_ROOMS_RELATIONS_FLOORS')
alter table Rooms
   drop constraint FK_ROOMS_RELATIONS_FLOORS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceBills') and o.name = 'FK_SERVICEB_RELATIONS_ROOMS')
alter table ServiceBills
   drop constraint FK_SERVICEB_RELATIONS_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ServiceBills') and o.name = 'FK_SERVICEB_RELATIONS_EMPLOYEE')
alter table ServiceBills
   drop constraint FK_SERVICEB_RELATIONS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Students') and o.name = 'FK_STUDENTS_RELATIONS_CLASSES')
alter table Students
   drop constraint FK_STUDENTS_RELATIONS_CLASSES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Students') and o.name = 'FK_STUDENTS_RELATIONS_CLUBS')
alter table Students
   drop constraint FK_STUDENTS_RELATIONS_CLUBS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Students') and o.name = 'FK_STUDENTS_RELATIONS_ROOMS')
alter table Students
   drop constraint FK_STUDENTS_RELATIONS_ROOMS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TemporaryAbsences') and o.name = 'FK_TEMPORAR_RELATIONS_STUDENTS')
alter table TemporaryAbsences
   drop constraint FK_TEMPORAR_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TemporaryAbsences') and o.name = 'FK_TEMPORAR_RELATIONS_EMPLOYEE')
alter table TemporaryAbsences
   drop constraint FK_TEMPORAR_RELATIONS_EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Attendance')
            and   name  = 'RELATIONSHIP_16_FK'
            and   indid > 0
            and   indid < 255)
   drop index Attendance.RELATIONSHIP_16_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Attendance')
            and   type = 'U')
   drop table Attendance
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AttendanceDetail')
            and   name  = 'ATTENDANCEDETAIL_FK2'
            and   indid > 0
            and   indid < 255)
   drop index AttendanceDetail.ATTENDANCEDETAIL_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AttendanceDetail')
            and   name  = 'ATTENDANCEDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index AttendanceDetail.ATTENDANCEDETAIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AttendanceDetail')
            and   type = 'U')
   drop table AttendanceDetail
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Buildings')
            and   type = 'U')
   drop table Buildings
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Carer')
            and   name  = 'RELATIONSHIP_13_FK'
            and   indid > 0
            and   indid < 255)
   drop index Carer.RELATIONSHIP_13_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Carer')
            and   type = 'U')
   drop table Carer
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Classes')
            and   name  = 'RELATIONSHIP_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index Classes.RELATIONSHIP_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Classes')
            and   type = 'U')
   drop table Classes
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Clubs')
            and   type = 'U')
   drop table Clubs
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DamageClaim')
            and   name  = 'RELATIONSHIP_23_FK'
            and   indid > 0
            and   indid < 255)
   drop index DamageClaim.RELATIONSHIP_23_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DamageClaim')
            and   name  = 'RELATIONSHIP_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index DamageClaim.RELATIONSHIP_22_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DamageClaim')
            and   type = 'U')
   drop table DamageClaim
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Discipline')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index Discipline.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Discipline')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index Discipline.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Discipline')
            and   type = 'U')
   drop table Discipline
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employees')
            and   type = 'U')
   drop table Employees
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Faculties')
            and   type = 'U')
   drop table Faculties
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Floors')
            and   name  = 'RELATIONSHIP_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index Floors.RELATIONSHIP_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Floors')
            and   type = 'U')
   drop table Floors
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LateArrivalInfo')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index LateArrivalInfo.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LateArrivalInfo')
            and   type = 'U')
   drop table LateArrivalInfo
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LeaseContracts')
            and   name  = 'RELATIONSHIP_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index LeaseContracts.RELATIONSHIP_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LeaseContracts')
            and   type = 'U')
   drop table LeaseContracts
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LeaseReceipts')
            and   name  = 'LEASERECEIPTS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index LeaseReceipts.LEASERECEIPTS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LeaseReceipts')
            and   name  = 'LEASERECEIPTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LeaseReceipts.LEASERECEIPTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LeaseReceipts')
            and   type = 'U')
   drop table LeaseReceipts
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ParkingReceipts')
            and   name  = 'PARKINGRECEIPTS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index ParkingReceipts.PARKINGRECEIPTS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ParkingReceipts')
            and   name  = 'PARKINGRECEIPTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ParkingReceipts.PARKINGRECEIPTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ParkingReceipts')
            and   type = 'U')
   drop table ParkingReceipts
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ParkingTickets')
            and   name  = 'RELATIONSHIP_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index ParkingTickets.RELATIONSHIP_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ParkingTickets')
            and   type = 'U')
   drop table ParkingTickets
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Priorities')
            and   type = 'U')
   drop table Priorities
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PriorityTarget')
            and   name  = 'PRIORITYTARGET_FK2'
            and   indid > 0
            and   indid < 255)
   drop index PriorityTarget.PRIORITYTARGET_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PriorityTarget')
            and   name  = 'PRIORITYTARGET_FK'
            and   indid > 0
            and   indid < 255)
   drop index PriorityTarget.PRIORITYTARGET_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PriorityTarget')
            and   type = 'U')
   drop table PriorityTarget
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Rooms')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index Rooms.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Rooms')
            and   type = 'U')
   drop table Rooms
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ServiceBills')
            and   name  = 'RELATIONSHIP_20_FK'
            and   indid > 0
            and   indid < 255)
   drop index ServiceBills.RELATIONSHIP_20_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ServiceBills')
            and   name  = 'RELATIONSHIP_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index ServiceBills.RELATIONSHIP_24_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ServiceBills')
            and   type = 'U')
   drop table ServiceBills
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Students')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index Students.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Students')
            and   name  = 'RELATIONSHIP_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index Students.RELATIONSHIP_12_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Students')
            and   name  = 'RELATIONSHIP_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index Students.RELATIONSHIP_8_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Students')
            and   type = 'U')
   drop table Students
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TemporaryAbsences')
            and   name  = 'RELATIONSHIP_15_FK'
            and   indid > 0
            and   indid < 255)
   drop index TemporaryAbsences.RELATIONSHIP_15_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TemporaryAbsences')
            and   name  = 'RELATIONSHIP_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index TemporaryAbsences.RELATIONSHIP_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TemporaryAbsences')
            and   type = 'U')
   drop table TemporaryAbsences
go

if exists(select 1 from systypes where name='ID_INT')
   drop type ID_INT
go

if exists(select 1 from systypes where name='NDATE')
   drop type NDATE
go

if exists(select 1 from systypes where name='NTEXT1')
   drop type NTEXT1
go

if exists(select 1 from systypes where name='NUMBER12')
   drop type NUMBER12
go

if exists(select 1 from systypes where name='NVARCHAR20')
   drop type NVARCHAR20
go

if exists(select 1 from systypes where name='NVARCHAR200')
   drop type NVARCHAR200
go

if exists(select 1 from systypes where name='NVARCHAR50')
   drop type NVARCHAR50
go

/*==============================================================*/
/* Domain: ID_INT                                               */
/*==============================================================*/
create type ID_INT
   from int not null
go

/*==============================================================*/
/* Domain: NDATE                                                */
/*==============================================================*/
create type NDATE
   from datetime not null
go

/*==============================================================*/
/* Domain: NTEXT1                                               */
/*==============================================================*/
create type NTEXT1
   from nText
go

/*==============================================================*/
/* Domain: NUMBER12                                             */
/*==============================================================*/
create type NUMBER12
   from numeric(12)
go

/*==============================================================*/
/* Domain: NVARCHAR20                                           */
/*==============================================================*/
create type NVARCHAR20
   from nvarchar(20)
go

/*==============================================================*/
/* Domain: NVARCHAR200                                          */
/*==============================================================*/
create type NVARCHAR200
   from nvarchar(200)
go

/*==============================================================*/
/* Domain: NVARCHAR50                                           */
/*==============================================================*/
create type NVARCHAR50
   from nvarchar(50)
go

/*==============================================================*/
/* Table: Attendance                                            */
/*==============================================================*/
create table Attendance (
   AttendanceId         ID_INT               not null,
   StudentID            ID_INT               null,
   CreatedDate          NDATE                not null,
   constraint PK_ATTENDANCE primary key nonclustered (AttendanceId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on Attendance (
StudentID ASC
)
go

/*==============================================================*/
/* Table: AttendanceDetail                                      */
/*==============================================================*/
create table AttendanceDetail (
   AttendanceId         ID_INT               not null,
   PersonID             ID_INT               not null,
   constraint PK_ATTENDANCEDETAIL primary key (AttendanceId, PersonID)
)
go

/*==============================================================*/
/* Index: ATTENDANCEDETAIL_FK                                   */
/*==============================================================*/
create index ATTENDANCEDETAIL_FK on AttendanceDetail (
AttendanceId ASC
)
go

/*==============================================================*/
/* Index: ATTENDANCEDETAIL_FK2                                  */
/*==============================================================*/
create index ATTENDANCEDETAIL_FK2 on AttendanceDetail (
PersonID ASC
)
go

/*==============================================================*/
/* Table: Buildings                                             */
/*==============================================================*/
create table Buildings (
   BuildingID           ID_INT               not null,
   constraint PK_BUILDINGS primary key nonclustered (BuildingID)
)
go

/*==============================================================*/
/* Table: Carer                                                 */
/*==============================================================*/
create table Carer (
   CareID               ID_INT               not null,
   StudentID            ID_INT               null,
   Job                  NVARCHAR50           null,
   Name                 NVARCHAR50           null,
   Gender               NVARCHAR20           null,
   DateOfBirth          NDATE                not null,
   SSN                  NVARCHAR20           null,
   Address              NTEXT1               null,
   Phone                NUMBER12             not null,
   constraint PK_CARER primary key (CareID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_13_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_13_FK on Carer (
StudentID ASC
)
go

/*==============================================================*/
/* Table: Classes                                               */
/*==============================================================*/
create table Classes (
   ClassID              ID_INT               not null,
   FacultyID            ID_INT               null,
   constraint PK_CLASSES primary key nonclustered (ClassID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on Classes (
FacultyID ASC
)
go

/*==============================================================*/
/* Table: Clubs                                                 */
/*==============================================================*/
create table Clubs (
   ClubID               ID_INT               not null,
   Name                 NVARCHAR50           null,
   constraint PK_CLUBS primary key nonclustered (ClubID)
)
go

/*==============================================================*/
/* Table: DamageClaim                                           */
/*==============================================================*/
create table DamageClaim (
   ClaimID              ID_INT               not null,
   StudentID            ID_INT               null,
   EmployeeID           ID_INT               null,
   CreatedDate          NDATE                not null,
   TotalPrice           money                not null,
   constraint PK_DAMAGECLAIM primary key nonclustered (ClaimID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_22_FK on DamageClaim (
StudentID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_23_FK on DamageClaim (
EmployeeID ASC
)
go

/*==============================================================*/
/* Table: Discipline                                            */
/*==============================================================*/
create table Discipline (
   DisciplineId         ID_INT               not null,
   StudentID            ID_INT               null,
   EmployeeID           ID_INT               null,
   Description          NTEXT1               null,
   CreatedDate          NDATE                not null,
   constraint PK_DISCIPLINE primary key nonclustered (DisciplineId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on Discipline (
StudentID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on Discipline (
EmployeeID ASC
)
go

/*==============================================================*/
/* Table: Employees                                             */
/*==============================================================*/
create table Employees (
   EmployeeID           ID_INT               not null,
   Username             NVARCHAR20           null,
   Password             NVARCHAR20           null,
   Position             NVARCHAR20           null,
   Name                 NVARCHAR50           null,
   Gender               NVARCHAR20           null,
   DateOfBirth          NDATE                not null,
   SSN                  NVARCHAR20           null,
   Address              NTEXT1               null,
   Phone                NUMBER12             not null,
   constraint PK_EMPLOYEES primary key (EmployeeID)
)
go

/*==============================================================*/
/* Table: Faculties                                             */
/*==============================================================*/
create table Faculties (
   FacultyID            ID_INT               not null,
   Name                 NVARCHAR50           null,
   constraint PK_FACULTIES primary key nonclustered (FacultyID)
)
go

/*==============================================================*/
/* Table: Floors                                                */
/*==============================================================*/
create table Floors (
   FloorID              ID_INT               not null,
   BuildingID           ID_INT               null,
   constraint PK_FLOORS primary key nonclustered (FloorID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on Floors (
BuildingID ASC
)
go

/*==============================================================*/
/* Table: LateArrivalInfo                                       */
/*==============================================================*/
create table LateArrivalInfo (
   LateID               ID_INT               not null,
   StudentID            ID_INT               null,
   WorkingAddress       NTEXT1               null,
   ArrivalTime          NDATE                not null,
   CreatedDate          NDATE                not null,
   Reason               NTEXT1               null,
   constraint PK_LATEARRIVALINFO primary key nonclustered (LateID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on LateArrivalInfo (
StudentID ASC
)
go

/*==============================================================*/
/* Table: LeaseContracts                                        */
/*==============================================================*/
create table LeaseContracts (
   ContractID           ID_INT               not null,
   StudentID            ID_INT               null,
   CreatedDate          NDATE                not null,
   constraint PK_LEASECONTRACTS primary key nonclustered (ContractID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on LeaseContracts (
StudentID ASC
)
go

/*==============================================================*/
/* Table: LeaseReceipts                                         */
/*==============================================================*/
create table LeaseReceipts (
   StudentID            ID_INT               not null,
   ContractID           ID_INT               not null,
   EndDate              NDATE                not null,
   TotalPrice           money                null,
   constraint PK_LEASERECEIPTS primary key (StudentID, ContractID)
)
go

/*==============================================================*/
/* Index: LEASERECEIPTS_FK                                      */
/*==============================================================*/
create index LEASERECEIPTS_FK on LeaseReceipts (
StudentID ASC
)
go

/*==============================================================*/
/* Index: LEASERECEIPTS_FK2                                     */
/*==============================================================*/
create index LEASERECEIPTS_FK2 on LeaseReceipts (
ContractID ASC
)
go

/*==============================================================*/
/* Table: ParkingReceipts                                       */
/*==============================================================*/
create table ParkingReceipts (
   TicketID             ID_INT               not null,
   EmployeeID           ID_INT               not null,
   TotalPrice           money                not null,
   EndDate              NDATE                not null,
   constraint PK_PARKINGRECEIPTS primary key (TicketID, EmployeeID)
)
go

/*==============================================================*/
/* Index: PARKINGRECEIPTS_FK                                    */
/*==============================================================*/
create index PARKINGRECEIPTS_FK on ParkingReceipts (
TicketID ASC
)
go

/*==============================================================*/
/* Index: PARKINGRECEIPTS_FK2                                   */
/*==============================================================*/
create index PARKINGRECEIPTS_FK2 on ParkingReceipts (
EmployeeID ASC
)
go

/*==============================================================*/
/* Table: ParkingTickets                                        */
/*==============================================================*/
create table ParkingTickets (
   TicketID             ID_INT               not null,
   StudentID            ID_INT               null,
   OwnerName            NVARCHAR50           null,
   OwnerAddress         NTEXT1               null,
   VehicleType          NVARCHAR50           null,
   Color                NVARCHAR50           null,
   LicensePlates        NVARCHAR20           null,
   EngineModel          NVARCHAR20           null,
   VINNumber            NVARCHAR20           null,
   constraint PK_PARKINGTICKETS primary key nonclustered (TicketID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on ParkingTickets (
StudentID ASC
)
go

/*==============================================================*/
/* Table: Priorities                                            */
/*==============================================================*/
create table Priorities (
   PriorityID           ID_INT               not null,
   Content              NTEXT1               null,
   constraint PK_PRIORITIES primary key nonclustered (PriorityID)
)
go

/*==============================================================*/
/* Table: PriorityTarget                                        */
/*==============================================================*/
create table PriorityTarget (
   StudentID            ID_INT               not null,
   PriorityID           ID_INT               not null,
   constraint PK_PRIORITYTARGET primary key (StudentID, PriorityID)
)
go

/*==============================================================*/
/* Index: PRIORITYTARGET_FK                                     */
/*==============================================================*/
create index PRIORITYTARGET_FK on PriorityTarget (
StudentID ASC
)
go

/*==============================================================*/
/* Index: PRIORITYTARGET_FK2                                    */
/*==============================================================*/
create index PRIORITYTARGET_FK2 on PriorityTarget (
PriorityID ASC
)
go

/*==============================================================*/
/* Table: Rooms                                                 */
/*==============================================================*/
create table Rooms (
   RoomID               ID_INT               not null,
   FloorID              ID_INT               null,
   NumOfStudent         int                  not null default 0
      constraint CKC_NUMOFSTUDENT_ROOMS check (NumOfStudent between 0 and 8),
   constraint PK_ROOMS primary key nonclustered (RoomID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on Rooms (
FloorID ASC
)
go

/*==============================================================*/
/* Table: ServiceBills                                          */
/*==============================================================*/
create table ServiceBills (
   BillID               ID_INT               not null,
   RoomID               ID_INT               null,
   StudentID            ID_INT               null,
   CreatedDate          NDATE                not null,
   TotalPrice           money                not null,
   constraint PK_SERVICEBILLS primary key nonclustered (BillID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_24_FK on ServiceBills (
StudentID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on ServiceBills (
RoomID ASC
)
go

/*==============================================================*/
/* Table: Students                                              */
/*==============================================================*/
create table Students (
   StudentID            ID_INT               not null,
   ClubID               ID_INT               null,
   ClassID              ID_INT               null,
   RoomID               ID_INT               null,
   Name                 NVARCHAR50           null,
   Gender               NVARCHAR20           null,
   DateOfBirth          NDATE                not null,
   SSN                  NVARCHAR20           null,
   Address              NTEXT1               null,
   Phone                NUMBER12             not null,
   PlaceOfBirth         NVARCHAR200          null,
   Nation               NVARCHAR50           null,
   Religion             NVARCHAR50           null,
   Course               int                  not null default 0
      constraint CKC_COURSE_STUDENTS check (Course >= 0),
   Position             NVARCHAR20           null,
   constraint PK_STUDENTS primary key (StudentID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on Students (
RoomID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_12_FK on Students (
ClassID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on Students (
ClubID ASC
)
go

/*==============================================================*/
/* Table: TemporaryAbsences                                     */
/*==============================================================*/
create table TemporaryAbsences (
   AbsenceID            ID_INT               not null,
   StudentID            ID_INT               null,
   EmployeeID           ID_INT               null,
   StartDate            NDATE                not null,
   NumOfAbsence         int                  not null,
   Reason               NTEXT1               null,
   constraint PK_TEMPORARYABSENCES primary key nonclustered (AbsenceID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on TemporaryAbsences (
StudentID ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on TemporaryAbsences (
EmployeeID ASC
)
go

alter table Attendance
   add constraint FK_ATTENDAN_RELATIONS_EMPLOYEE foreign key (StudentID)
      references Employees (EmployeeID)
go

alter table AttendanceDetail
   add constraint FK_ATTENDAN_ATTENDANC_ATTENDAN foreign key (AttendanceId)
      references Attendance (AttendanceId)
go

alter table AttendanceDetail
   add constraint FK_ATTENDAN_ATTENDANC_STUDENTS foreign key (PersonID)
      references Students (StudentID)
go

alter table Carer
   add constraint FK_CARER_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table Classes
   add constraint FK_CLASSES_RELATIONS_FACULTIE foreign key (FacultyID)
      references Faculties (FacultyID)
go

alter table DamageClaim
   add constraint FK_DAMAGECL_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table DamageClaim
   add constraint FK_DAMAGECL_RELATIONS_EMPLOYEE foreign key (EmployeeID)
      references Employees (EmployeeID)
go

alter table Discipline
   add constraint FK_DISCIPLI_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table Discipline
   add constraint FK_DISCIPLI_RELATIONS_EMPLOYEE foreign key (EmployeeID)
      references Employees (EmployeeID)
go

alter table Floors
   add constraint FK_FLOORS_RELATIONS_BUILDING foreign key (BuildingID)
      references Buildings (BuildingID)
go

alter table LateArrivalInfo
   add constraint FK_LATEARRI_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table LeaseContracts
   add constraint FK_LEASECON_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table LeaseReceipts
   add constraint FK_LEASEREC_LEASERECE_EMPLOYEE foreign key (StudentID)
      references Employees (EmployeeID)
go

alter table LeaseReceipts
   add constraint FK_LEASEREC_LEASERECE_LEASECON foreign key (ContractID)
      references LeaseContracts (ContractID)
go

alter table ParkingReceipts
   add constraint FK_PARKINGR_PARKINGRE_EMPLOYEE foreign key (EmployeeID)
      references Employees (EmployeeID)
go

alter table ParkingReceipts
   add constraint FK_PARKINGR_PARKINGRE_PARKINGT foreign key (TicketID)
      references ParkingTickets (TicketID)
go

alter table ParkingTickets
   add constraint FK_PARKINGT_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table PriorityTarget
   add constraint FK_PRIORITY_PRIORITYT_PRIORITI foreign key (PriorityID)
      references Priorities (PriorityID)
go

alter table PriorityTarget
   add constraint FK_PRIORITY_PRIORITYT_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table Rooms
   add constraint FK_ROOMS_RELATIONS_FLOORS foreign key (FloorID)
      references Floors (FloorID)
go

alter table ServiceBills
   add constraint FK_SERVICEB_RELATIONS_ROOMS foreign key (RoomID)
      references Rooms (RoomID)
go

alter table ServiceBills
   add constraint FK_SERVICEB_RELATIONS_EMPLOYEE foreign key (StudentID)
      references Employees (EmployeeID)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_CLASSES foreign key (ClassID)
      references Classes (ClassID)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_CLUBS foreign key (ClubID)
      references Clubs (ClubID)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_ROOMS foreign key (RoomID)
      references Rooms (RoomID)
go

alter table TemporaryAbsences
   add constraint FK_TEMPORAR_RELATIONS_STUDENTS foreign key (StudentID)
      references Students (StudentID)
go

alter table TemporaryAbsences
   add constraint FK_TEMPORAR_RELATIONS_EMPLOYEE foreign key (EmployeeID)
      references Employees (EmployeeID)
go

