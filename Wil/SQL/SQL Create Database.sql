USE OmegaFleetTracker

CREATE TABLE tblUserType
(UserTypeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
UserTypeName char(35),
UserTypeDesc char(100),
)

CREATE TABLE tblUser
(
UserID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
UserFirstName char(35),
UserLastName char(35),
UserCell char(10),
UserEmail char(35),
UserTypeID int NOT NULL,
FOREIGN KEY (UserTypeID) REFERENCES tblUserType(UserTypeID)
)

CREATE TABLE tblHours
(
HoursID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
EmployeeHours int,
UserID int,
FOREIGN KEY (UserID) REFERENCES tblUser(UserID)
)

CREATE TABLE tblAuth
(
AuthID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
AuthUserName char(35),
AuthPassword char(35),
UserID int,
FOREIGN KEY (UserID) REFERENCES tblUser(UserID)
)

CREATE TABLE tblCategory
(
CatID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
CatName char(35),
CatDesc char(100),
)

CREATE TABLE tblVehicleType
(
VehicleTypeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
VehicleTypeName char(35),
)

CREATE TABLE tblVehicle
(
VehicleID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
VehicleReg char(35),
VehicleVinNumber char(35),
VehicleDesc char(100),
VehicleKm char(10),
VehicleTypeID int NOT NULL,
CatID int NOT NULL,
FOREIGN KEY (VehicleTypeID) REFERENCES tblVehicleType(VehicleTypeID),
FOREIGN KEY (CatID) REFERENCES tblCategory(CatID)
)

CREATE TABLE tblService
(
ServiceID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
ServiceDate date,
PrecedureCode char(10),
VehicleID int,
Notes text,
FOREIGN KEY (VehicleID) REFERENCES tblVehicle(VehicleID),
)

CREATE TABLE tblScheduleTrip
(
TripID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
DOD date,
DOA date,
UserID int,
Destination char(50),
Notes text,
FOREIGN KEY (UserID) REFERENCES tblUser(UserID)
)

CREATE TABLE tblScheduleLine
(
ScheduleLineID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
VehicleID int,
TripID int,
FOREIGN KEY (VehicleID) REFERENCES tblVehicle(VehicleID),
FOREIGN KEY (TripID) REFERENCES tblScheduleTrip(TripID)
)

CREATE TABLE tblIncident
(
IncidentID int  IDENTITY(1,1) NOT NULL PRIMARY KEY,
Notes text,
ScheduleLineID int,
FOREIGN KEY (ScheduleLineID) REFERENCES tblScheduleLine(ScheduleLineID)
)

CREATE TABLE tblPostTrip
(
PostTripID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
TripID int,
FuelUsage int,
FOREIGN KEY (TripID) REFERENCES tblScheduleTrip(TripID)
)

--Notes--
/*
The vehicle registration needs to be less than 35?
*/