USE Polyclinic;

CREATE TABLE StreetName
(
	id int IDENTITY,
	[name] nvarchar(100) NOT NULL,
	CONSTRAINT PK_StreetName PRIMARY KEY (id)
);

CREATE TABLE StreetType
(
	id int IDENTITY,
	[type] nvarchar(20) NOT NULL,
	CONSTRAINT PK_StreetType PRIMARY KEY (id)
);

CREATE TABLE Region
(
	id int IDENTITY,
	[name] nvarchar(100) NOT NULL,
	CONSTRAINT PK_Region PRIMARY KEY (id)
);

CREATE TABLE City
(
	id int IDENTITY,
	[name] nvarchar(100) NOT NULL,
	CONSTRAINT PK_City PRIMARY KEY (id)
);

CREATE TABLE CityType
(
	id int IDENTITY,
	[type] nvarchar(10) NOT NULL,
	CONSTRAINT PK_CityType PRIMARY KEY (id)
);

CREATE TABLE BuildingNumber
(
	id int IDENTITY,
	number nvarchar(10) NOT NULL,
	CONSTRAINT PK_BuildingNumber PRIMARY KEY (id)
);

CREATE TABLE [Address]
(
	id int IDENTITY,
	cityId int,
	cityTypeId int,
	regionId int,
	streetTypeId int,
	streetNameId int,
	buildingNumberId int,
	CONSTRAINT FK_CityId_Address FOREIGN KEY (cityId) REFERENCES City(id),
	CONSTRAINT FK_CityTypeId_Address FOREIGN KEY (cityTypeId) REFERENCES CityType(id),
	CONSTRAINT FK_RegionId_Address FOREIGN KEY (regionId) REFERENCES Region(id),
	CONSTRAINT FK_StreetTypeId_Address FOREIGN KEY (streetTypeId) REFERENCES StreetType(id),
	CONSTRAINT FK_StreetNameId_Address FOREIGN KEY (streetNameId) REFERENCES StreetName(id),
	CONSTRAINT FK_BuildingNumberId_Address FOREIGN KEY (buildingNumberId) REFERENCES BuildingNumber(id),
	CONSTRAINT PK_Address PRIMARY KEY (id)
);

CREATE TABLE PhoneNumbers
(
	id int IDENTITY,
	phoneNumber char(13) NOT NULL
	CONSTRAINT PK_PhoneNumbers PRIMARY KEY (id)
);

CREATE TABLE PersonalInfo
(
	id int IDENTITY,
	birthDate date NOT NULL,
	deleted bit NOT NULL,
	email varchar(40) NOT NULL,
	addressId int NOT NULL,
	CONSTRAINT FK_AddressId_PersonalInfo FOREIGN KEY (addressId) REFERENCES [Address](id),
	CONSTRAINT PK_PersonalInfo PRIMARY KEY (id)
);

CREATE TRIGGER tr_PersonalInfo_Delete
ON PersonalInfo
INSTEAD OF DELETE
AS
UPDATE PersonalInfo SET deleted = 1 WHERE id IN (SELECT id FROM deleted);

CREATE TABLE LinkPersonalInfoAndPhoneNumbers
(
	personalInfoId int NOT NULL,
	phoneNumbersId int NOT NULL,
	CONSTRAINT FK_PersonalInfoId_LinkPersonalInfoAndPhoneNumbers FOREIGN KEY (personalInfoId) REFERENCES PersonalInfo(id),
	CONSTRAINT FK_PhoneNumbersId_LinkPersonalInfoAndPhoneNumbers FOREIGN KEY (phoneNumbersId) REFERENCES PhoneNumbers(id),
	CONSTRAINT PK_LinkPersonalInfoAndPhoneNumbers PRIMARY KEY (personalInfoId, phoneNumbersId)
);

CREATE TABLE Patient
(
	id int IDENTITY,
	fullName nvarchar(100) NOT NULL,
	deleted bit NOT NULL,
	personalInfoId int NOT NULL,
	CONSTRAINT PK_Patient PRIMARY KEY(id),
	CONSTRAINT FK_PersonalInfoId_Patient FOREIGN KEY (personalInfoId) REFERENCES PersonalInfo(id)
);

CREATE TRIGGER tr_Patient_Deleted
ON Patient
INSTEAD OF DELETE
AS
UPDATE Patient SET deleted = 1 WHERE id IN (SELECT id FROM deleted);

CREATE TABLE Hospital
(
	id int IDENTITY,
	deleted bit NOT NULL,
	[name] nvarchar(max) NOT NULL,
	addressId int NOT NULL,
	CONSTRAINT PK_Hospital PRIMARY KEY(id),
	CONSTRAINT FK_Address_Hospital FOREIGN KEY (addressId) REFERENCES [Address](id)
);

CREATE TRIGGER tr_Hospital_Deleted
ON Hospital
INSTEAD OF DELETE
AS
UPDATE Hospital SET deleted = 1 WHERE id IN (SELECT id FROM deleted);

CREATE TABLE DoctorSpecialization
(
	id int IDENTITY,
	[name] varchar(50) NOT NULL,
	CONSTRAINT PK_DoctorSpecialization PRIMARY KEY (id)
);

CREATE TABLE Doctor
(
	id int IDENTITY,
	deleted bit NOT NULL,
	fullName nvarchar(max) NOT NULL,
	hospitalId int NOT NULL,
	personalInfoId int NOT NULL,
	specializationId int NOT NULL,
	CONSTRAINT PK_Doctor PRIMARY KEY(id),
	CONSTRAINT FK_Hospital_Doctor FOREIGN KEY(hospitalId) REFERENCES Hospital(id),
	CONSTRAINT FK_PersonalInfo_Doctor FOREIGN KEY (personalInfoId) REFERENCES PersonalInfo(id),
	CONSTRAINT FK_DoctorSpecialization_Doctor FOREIGN KEY (specializationId) REFERENCES DoctorSpecialization(id)
);

CREATE TRIGGER tr_Doctor_Delete
ON Doctor
INSTEAD OF DELETE
AS
UPDATE Doctor SET deleted = 1 WHERE id IN (SELECT id FROM deleted);

CREATE TABLE LinkPatientDoctor
(
	patientId int NOT NULL,
	doctorId int NOT NULL,
	CONSTRAINT PK_LinkPatirntDoctor PRIMARY KEY (patientId, doctorId),
	CONSTRAINT FK_Patient_LinkPatientDoctor FOREIGN KEY(patientId) REFERENCES Patient(id),
	CONSTRAINT FK_Doctor_LinkPatientDoctor FOREIGN KEY(doctorId) REFERENCES Doctor(id)
);

CREATE TABLE DiseaseType
(
	id int IDENTITY,
	[type] nvarchar(max) NOT NULL
	CONSTRAINT PK_DiseaseType PRIMARY KEY(id)
);

CREATE TABLE Disease
(
	id int IDENTITY,
	[name] nvarchar(max) NOT NULL,
	diseaseTypeId int NOT NULL,
	CONSTRAINT PK_Disease PRIMARY KEY(id),
	CONSTRAINT FK_DiseaseType_Disease FOREIGN KEY(diseaseTypeId) REFERENCES DiseaseType(id)
);

CREATE TABLE IllnessCertificate
(
	id int IDENTITY,
	firstVisit date NOT NULL DEFAULT GETDATE(),
	lastVisit date NOT NULL DEFAULT GETDATE(),
	doctorId int NOT NULL,
	patientId int NOT NULL,
	diseaseId int NOT NULL,
	CONSTRAINT PK_IllnessCertificate PRIMARY KEY(id),
	CONSTRAINT FK_Doctor_IllnessCertificate FOREIGN KEY(doctorId) REFERENCES Doctor(id),
	CONSTRAINT FK_Patient_IllnessCertificate FOREIGN KEY(patientId) REFERENCES Patient(id),
	CONSTRAINT FK_Disease_IllnessCertificate FOREIGN KEY(diseaseId) REFERENCES Disease(id)
);

CREATE TABLE NoteIllnessCertificate
(
	id int IDENTITY,
	note nvarchar(max) NOT NULL,
	[date] date NOT NULL DEFAULT GETDATE(),
	illnessCerticateId int NOT NULL,
	CONSTRAINT PK_NoteIllnessCertificate PRIMARY KEY (id),
	CONSTRAINT FK_IllnessCertificate_NoteIllnessCertificate FOREIGN KEY (illnessCerticateId) REFERENCES IllnessCertificate(id)
);

CREATE VIEW AddressAsTable AS
SELECT 
	a.id,
	c.id AS cityId,
	c.[name] AS cityName,
	ct.id AS cityTypeId,
	ct.[type] AS cityType,
	r.id AS regionId,
	r.[name] AS regionName,
	st.id AS streetTypeId,
	st.[type] AS streetType,
	sn.id AS streetNameId,
	sn.[name] AS streetName,
	bn.id AS buildingNumberId,
	bn.[number] AS buildingNumber
FROM [Address] a
JOIN City c ON c.id = a.cityId
JOIN CityType ct ON ct.id = a.cityTypeId
JOIN Region r ON r.id = a.regionId
JOIN StreetType st ON st.id = a.streetTypeId
JOIN StreetName sn ON sn.id = a.streetNameId
JOIN BuildingNumber bn ON bn.id = a.buildingNumberId;

CREATE VIEW AddressAsString AS
SELECT 
	r.[name] + N' обл. ' + ct.[type] + ' ' + c.[name] + ' ' + st.[type] + ' ' + sn.[name] + ' ' + bn.number AS [address],
	a.id AS addressId
FROM [Address] a
JOIN City c ON c.id = a.cityId
JOIN CityType ct ON ct.id = a.cityTypeId
JOIN Region r ON r.id = a.regionId
JOIN StreetType st ON st.id = a.streetTypeId
JOIN StreetName sn ON sn.id = a.streetNameId
JOIN BuildingNumber bn ON bn.id = a.buildingNumberId;

CREATE VIEW AllInfo AS
SELECT * FROM IllnesCertificate