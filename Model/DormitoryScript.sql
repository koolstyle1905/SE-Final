/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/30/2016 10:45:52 PM                       */
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
   where r.fkeyid = object_id('LeaseDetails') and o.name = 'FK_LEASEDET_LEASEDETA_EMPLOYEE')
alter table LeaseDetails
   drop constraint FK_LEASEDET_LEASEDETA_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LeaseDetails') and o.name = 'FK_LEASEDET_LEASEDETA_LEASECON')
alter table LeaseDetails
   drop constraint FK_LEASEDET_LEASEDETA_LEASECON
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ParkingDetails') and o.name = 'FK_PARKINGD_PARKINGDE_EMPLOYEE')
alter table ParkingDetails
   drop constraint FK_PARKINGD_PARKINGDE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ParkingDetails') and o.name = 'FK_PARKINGD_PARKINGDE_PARKINGT')
alter table ParkingDetails
   drop constraint FK_PARKINGD_PARKINGDE_PARKINGT
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
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ViolationRecord') and o.name = 'FK_VIOLATIO_RELATIONS_STUDENTS')
alter table ViolationRecord
   drop constraint FK_VIOLATIO_RELATIONS_STUDENTS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ViolationRecord') and o.name = 'FK_VIOLATIO_RELATIONS_EMPLOYEE')
alter table ViolationRecord
   drop constraint FK_VIOLATIO_RELATIONS_EMPLOYEE
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
           where  id    = object_id('LeaseDetails')
            and   name  = 'LEASEDETAILS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index LeaseDetails.LEASEDETAILS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LeaseDetails')
            and   name  = 'LEASEDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LeaseDetails.LEASEDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LeaseDetails')
            and   type = 'U')
   drop table LeaseDetails
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ParkingDetails')
            and   name  = 'PARKINGDETAILS_FK2'
            and   indid > 0
            and   indid < 255)
   drop index ParkingDetails.PARKINGDETAILS_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ParkingDetails')
            and   name  = 'PARKINGDETAILS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ParkingDetails.PARKINGDETAILS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ParkingDetails')
            and   type = 'U')
   drop table ParkingDetails
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

if exists (select 1
            from  sysindexes
           where  id    = object_id('ViolationRecord')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index ViolationRecord.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ViolationRecord')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index ViolationRecord.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ViolationRecord')
            and   type = 'U')
   drop table ViolationRecord
go

if exists(select 1 from systypes where name='ID_10')
   drop type ID_10
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
/* Domain: ID_10                                                */
/*==============================================================*/
create type ID_10
   from nvarchar(10) not null
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
   AttendanceId         ID_10                not null,
   EmployeeId           ID_10                null,
   CreatedDate          NDATE                not null,
   constraint PK_ATTENDANCE primary key nonclustered (AttendanceId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on Attendance (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: AttendanceDetail                                      */
/*==============================================================*/
create table AttendanceDetail (
   AttendanceId         ID_10                not null,
   StudentId            ID_10                not null,
   constraint PK_ATTENDANCEDETAIL primary key (AttendanceId, StudentId)
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
StudentId ASC
)
go

/*==============================================================*/
/* Table: Buildings                                             */
/*==============================================================*/
create table Buildings (
   BuildingId           ID_10                not null,
   constraint PK_BUILDINGS primary key nonclustered (BuildingId)
)
go

/*==============================================================*/
/* Table: Carer                                                 */
/*==============================================================*/
create table Carer (
   CarerId              ID_10                not null,
   StudentId            ID_10                null,
   Name                 NVARCHAR50           null,
   Gender               NVARCHAR20           null,
   DateOfBirth          NDATE                not null,
   SSN                  NVARCHAR20           null,
   Address              NTEXT1               null,
   Phone                NUMBER12             not null,
   Job                  NVARCHAR50           null,
   constraint PK_CARER primary key nonclustered (CarerId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_13_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_13_FK on Carer (
StudentId ASC
)
go

/*==============================================================*/
/* Table: Classes                                               */
/*==============================================================*/
create table Classes (
   ClassId              ID_10                not null,
   FacultyId            ID_10                null,
   constraint PK_CLASSES primary key nonclustered (ClassId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on Classes (
FacultyId ASC
)
go

/*==============================================================*/
/* Table: Clubs                                                 */
/*==============================================================*/
create table Clubs (
   ClubId               ID_10                not null,
   Name                 NVARCHAR50           null,
   constraint PK_CLUBS primary key nonclustered (ClubId)
)
go

/*==============================================================*/
/* Table: Employees                                             */
/*==============================================================*/
create table Employees (
   EmployeeId           ID_10                not null,
   Name                 NVARCHAR50           null,
   Gender               NVARCHAR20           null,
   DateOfBirth          NDATE                not null,
   SSN                  NVARCHAR20           null,
   Address              NTEXT1               null,
   Phone                NUMBER12             not null,
   Username             NVARCHAR20           null,
   Password             NVARCHAR20           null,
   Position             NVARCHAR20           null,
   constraint PK_EMPLOYEES primary key nonclustered (EmployeeId)
)
go

/*==============================================================*/
/* Table: Faculties                                             */
/*==============================================================*/
create table Faculties (
   FacultyId            ID_10                not null,
   Name                 NVARCHAR50           null,
   constraint PK_FACULTIES primary key nonclustered (FacultyId)
)
go

/*==============================================================*/
/* Table: Floors                                                */
/*==============================================================*/
create table Floors (
   FloorId              ID_10                not null,
   BuildingId           ID_10                null,
   constraint PK_FLOORS primary key nonclustered (FloorId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on Floors (
BuildingId ASC
)
go

/*==============================================================*/
/* Table: LateArrivalInfo                                       */
/*==============================================================*/
create table LateArrivalInfo (
   LateId               ID_10                not null,
   StudentId            ID_10                null,
   WorkingAddress       NTEXT1               null,
   ArrivalTime          NDATE                not null,
   CreatedDate          NDATE                not null,
   Reason               NTEXT1               null,
   constraint PK_LATEARRIVALINFO primary key nonclustered (LateId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on LateArrivalInfo (
StudentId ASC
)
go

/*==============================================================*/
/* Table: LeaseContracts                                        */
/*==============================================================*/
create table LeaseContracts (
   ContractId           ID_10                not null,
   StudentId            ID_10                null,
   CreatedDate          NDATE                not null,
   constraint PK_LEASECONTRACTS primary key nonclustered (ContractId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on LeaseContracts (
StudentId ASC
)
go

/*==============================================================*/
/* Table: LeaseDetails                                          */
/*==============================================================*/
create table LeaseDetails (
   EmployeeId           ID_10                not null,
   ContractId           ID_10                not null,
   StartDate            NDATE                not null,
   EndDate              NDATE                not null,
   Amount               money                null,
   constraint PK_LEASEDETAILS primary key (EmployeeId, ContractId)
)
go

/*==============================================================*/
/* Index: LEASEDETAILS_FK                                       */
/*==============================================================*/
create index LEASEDETAILS_FK on LeaseDetails (
EmployeeId ASC
)
go

/*==============================================================*/
/* Index: LEASEDETAILS_FK2                                      */
/*==============================================================*/
create index LEASEDETAILS_FK2 on LeaseDetails (
ContractId ASC
)
go

/*==============================================================*/
/* Table: ParkingDetails                                        */
/*==============================================================*/
create table ParkingDetails (
   TicketId             ID_10                not null,
   EmployeeId           ID_10                not null,
   StartDate            NDATE                not null,
   EndDate              NDATE                not null,
   Amount               money                not null,
   constraint PK_PARKINGDETAILS primary key (TicketId, EmployeeId)
)
go

/*==============================================================*/
/* Index: PARKINGDETAILS_FK                                     */
/*==============================================================*/
create index PARKINGDETAILS_FK on ParkingDetails (
TicketId ASC
)
go

/*==============================================================*/
/* Index: PARKINGDETAILS_FK2                                    */
/*==============================================================*/
create index PARKINGDETAILS_FK2 on ParkingDetails (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: ParkingTickets                                        */
/*==============================================================*/
create table ParkingTickets (
   TicketId             ID_10                not null,
   StudentId            ID_10                null,
   OwnerName            NVARCHAR50           null,
   OwnerAddress         NTEXT1               null,
   VehicleType          NVARCHAR50           null,
   Color                NVARCHAR50           null,
   LicensePlates        NVARCHAR20           null,
   EngineModel          NVARCHAR20           null,
   VINNumber            NVARCHAR20           null,
   constraint PK_PARKINGTICKETS primary key nonclustered (TicketId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on ParkingTickets (
StudentId ASC
)
go

/*==============================================================*/
/* Table: Priorities                                            */
/*==============================================================*/
create table Priorities (
   PriorityId           ID_10                not null,
   Content              NTEXT1               null,
   constraint PK_PRIORITIES primary key nonclustered (PriorityId)
)
go

/*==============================================================*/
/* Table: PriorityTarget                                        */
/*==============================================================*/
create table PriorityTarget (
   StudentId            ID_10                not null,
   PriorityId           ID_10                not null,
   constraint PK_PRIORITYTARGET primary key (StudentId, PriorityId)
)
go

/*==============================================================*/
/* Index: PRIORITYTARGET_FK                                     */
/*==============================================================*/
create index PRIORITYTARGET_FK on PriorityTarget (
StudentId ASC
)
go

/*==============================================================*/
/* Index: PRIORITYTARGET_FK2                                    */
/*==============================================================*/
create index PRIORITYTARGET_FK2 on PriorityTarget (
PriorityId ASC
)
go

/*==============================================================*/
/* Table: Rooms                                                 */
/*==============================================================*/
create table Rooms (
   RoomId               ID_10                not null,
   FloorId              ID_10                null,
   constraint PK_ROOMS primary key nonclustered (RoomId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on Rooms (
FloorId ASC
)
go

/*==============================================================*/
/* Table: ServiceBills                                          */
/*==============================================================*/
create table ServiceBills (
   BillId               ID_10                not null,
   RoomId               ID_10                null,
   EmployeeId           ID_10                null,
   CreatedDate          NDATE                not null,
   Amount               money                not null,
   constraint PK_SERVICEBILLS primary key nonclustered (BillId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_24_FK on ServiceBills (
EmployeeId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on ServiceBills (
RoomId ASC
)
go

/*==============================================================*/
/* Table: Students                                              */
/*==============================================================*/
create table Students (
   StudentId            ID_10                not null,
   ClubId               ID_10                null,
   ClassId              ID_10                null,
   RoomId               ID_10                null,
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
   constraint PK_STUDENTS primary key nonclustered (StudentId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on Students (
RoomId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_12_FK on Students (
ClassId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on Students (
ClubId ASC
)
go

/*==============================================================*/
/* Table: TemporaryAbsences                                     */
/*==============================================================*/
create table TemporaryAbsences (
   AbsenceId            ID_10                not null,
   EmployeeId           ID_10                null,
   StudentId            ID_10                null,
   StartDate            NDATE                not null,
   NumOfAbsence         int                  not null,
   Reason               NTEXT1               null,
   CreatedDate          NDATE                not null,
   constraint PK_TEMPORARYABSENCES primary key nonclustered (AbsenceId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on TemporaryAbsences (
StudentId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on TemporaryAbsences (
EmployeeId ASC
)
go

/*==============================================================*/
/* Table: ViolationRecord                                       */
/*==============================================================*/
create table ViolationRecord (
   ViolationId          ID_10                not null,
   EmployeeId           ID_10                null,
   StudentId            ID_10                null,
   Description          NTEXT1               null,
   CreatedDate          NDATE                not null,
   constraint PK_VIOLATIONRECORD primary key nonclustered (ViolationId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on ViolationRecord (
StudentId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on ViolationRecord (
EmployeeId ASC
)
go

alter table Attendance
   add constraint FK_ATTENDAN_RELATIONS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table AttendanceDetail
   add constraint FK_ATTENDAN_ATTENDANC_ATTENDAN foreign key (AttendanceId)
      references Attendance (AttendanceId)
go

alter table AttendanceDetail
   add constraint FK_ATTENDAN_ATTENDANC_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table Carer
   add constraint FK_CARER_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table Classes
   add constraint FK_CLASSES_RELATIONS_FACULTIE foreign key (FacultyId)
      references Faculties (FacultyId)
go

alter table Floors
   add constraint FK_FLOORS_RELATIONS_BUILDING foreign key (BuildingId)
      references Buildings (BuildingId)
go

alter table LateArrivalInfo
   add constraint FK_LATEARRI_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table LeaseContracts
   add constraint FK_LEASECON_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table LeaseDetails
   add constraint FK_LEASEDET_LEASEDETA_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table LeaseDetails
   add constraint FK_LEASEDET_LEASEDETA_LEASECON foreign key (ContractId)
      references LeaseContracts (ContractId)
go

alter table ParkingDetails
   add constraint FK_PARKINGD_PARKINGDE_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table ParkingDetails
   add constraint FK_PARKINGD_PARKINGDE_PARKINGT foreign key (TicketId)
      references ParkingTickets (TicketId)
go

alter table ParkingTickets
   add constraint FK_PARKINGT_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table PriorityTarget
   add constraint FK_PRIORITY_PRIORITYT_PRIORITI foreign key (PriorityId)
      references Priorities (PriorityId)
go

alter table PriorityTarget
   add constraint FK_PRIORITY_PRIORITYT_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table Rooms
   add constraint FK_ROOMS_RELATIONS_FLOORS foreign key (FloorId)
      references Floors (FloorId)
go

alter table ServiceBills
   add constraint FK_SERVICEB_RELATIONS_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table ServiceBills
   add constraint FK_SERVICEB_RELATIONS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_CLASSES foreign key (ClassId)
      references Classes (ClassId)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_CLUBS foreign key (ClubId)
      references Clubs (ClubId)
go

alter table Students
   add constraint FK_STUDENTS_RELATIONS_ROOMS foreign key (RoomId)
      references Rooms (RoomId)
go

alter table TemporaryAbsences
   add constraint FK_TEMPORAR_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table TemporaryAbsences
   add constraint FK_TEMPORAR_RELATIONS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

alter table ViolationRecord
   add constraint FK_VIOLATIO_RELATIONS_STUDENTS foreign key (StudentId)
      references Students (StudentId)
go

alter table ViolationRecord
   add constraint FK_VIOLATIO_RELATIONS_EMPLOYEE foreign key (EmployeeId)
      references Employees (EmployeeId)
go

