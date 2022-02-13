CREATE PROCEDURE [dbo].[proc_StreetType@Update] @xmlData xml
AS
BEGIN
	DECLARE @Type nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Type = CAST(n.value('(./Type)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/StreetType') t(n)

	UPDATE StreetType SET [type] = @Type WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_StreetType@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [type] AS 'Type' FROM StreetType FOR XML PATH('StreetType'), ROOT('StreetTypes')) AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_StreetType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [type] AS 'Type' FROM StreetType WHERE id = @Id FOR XML PATH('StreetType')) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_StreetType@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM StreetType WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_StreetType@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Type nvarchar(50)

	SET @Type = CAST((SELECT n.value('(./Type)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/StreetType') t(n)) AS nvarchar(50))

	INSERT INTO StreetType ([type]) VALUES (@Type)

	SET @newId = @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[proc_StreetName@Update] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Name = CAST(n.value('(./Name)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/StreetName') t(n)

	UPDATE StreetName SET [name] = @Name WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_StreetName@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [name] AS 'Name' FROM StreetName FOR XML PATH('StreetName'), ROOT('StreetNames')) AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_StreetName@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM StreetName WHERE id = @Id FOR XML PATH('StreetName')) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_StreetName@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM StreetName WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_StreetName@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/StreetName') t(n)) AS nvarchar(50))

	INSERT INTO StreetName ([name]) VALUES (@Name)

	SET @newId = @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[proc_Region@Update] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Name = CAST(n.value('(./Name)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/Region') t(n)

	UPDATE Region SET [name] = @Name WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_Region@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [name] AS 'Name' FROM Region FOR XML PATH('Region'), ROOT('Regions')) AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_Region@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM Region WHERE id = @Id FOR XML PATH('Region')) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_Region@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM Region WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_Region@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/Region') t(n)) AS nvarchar(50))

	INSERT INTO Region ([name]) VALUES (@Name)

	SET @newId = @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[proc_ReadAllAddressesAsString] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<Data>' + CAST(
		(
		SELECT
			[address] AS 'Address',
			[addressId] AS 'AddressId'
		FROM AddressAsString
		FOR XML PATH('AddressAsString'), ROOT('AddressesAsString')
		) AS nvarchar(4000)) + '</Data>' 
END
GO

CREATE PROCEDURE [dbo].[proc_PersonalInfo@Update] @xmlData xml
AS
BEGIN
	DECLARE @isDoctor bit
	
	SELECT @isDoctor = ISNULL(CAST(n.value('(./SpecializationId)[1]', 'int') AS bit), 0)
    FROM @xmlData.nodes('/Doctor') t(n)

	DECLARE @PiId int, @Id int, @addressId int, @birthDate date, @email varchar(100), @fullName nvarchar(100)

	IF(@isDoctor = 1)
	BEGIN
		DECLARE @specializationId int, @hospitalId int

		SELECT
			@addressId = n.value('(./AddressId)[1]', 'int'),
			@birthDate = n.value('(./BirthDate)[1]', 'date'),
			@email = n.value('(./Email)[1]', 'varchar(100)'),
			@fullName = n.value('(./FullName)[1]', 'nvarchar(100)'),
			@specializationId = n.value('(./SpecializationId)[1]', 'int'),
			@hospitalId = n.value('(./HospitalId)[1]', 'int'),
			@Id = n.value('(./Id)[1]', 'int')
		FROM @xmlData.nodes('/Doctor') t(n)

		SET @PiId = (SELECT [personalInfoId] FROM Doctor WHERE [id] = @Id)

		UPDATE PersonalInfo SET 
			[addressId] = @addressId,
			[birthDate] = @birthDate,
			[email] = @email
		WHERE [id] = @PiId

		UPDATE Doctor SET 
			[fullName] = @fullName,
			[specializationId] = @specializationId,
			[hospitalId] = @hospitalId
		WHERE [id] = @Id
	END
	ELSE
	BEGIN
		SELECT
			@addressId = n.value('(./AddressId)[1]', 'int'),
			@birthDate = n.value('(./BirthDate)[1]', 'date'),
			@email = n.value('(./Email)[1]', 'varchar(100)'),
			@fullName = n.value('(./FullName)[1]', 'nvarchar(100)'),
			@Id = n.value('(./Id)[1]', 'int')
		FROM @xmlData.nodes('/Patient') t(n)

		
		SET @PiId = (SELECT [personalInfoId] FROM Patient WHERE [id] = @Id)

		UPDATE PersonalInfo SET 
			[addressId] = @addressId,
			[birthDate] = @birthDate,
			[email] = @email
		WHERE [id] = @PiId

		UPDATE Patient SET 
			[fullName] = @fullName
		WHERE [id] = @Id
	END
END
GO

CREATE PROCEDURE [dbo].[proc_PersonalInfo@ReadAll] @xmlData xml, @xmlResult  nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @isDoctor bit

	SELECT @isDoctor = CAST(n.value('(./value0)[1]', 'bit') AS bit)
    FROM @xmlData.nodes('/Data') t(n)

	IF(@isDoctor = 1)
	BEGIN
		SET @xmlResult = '<Data>' +
			CAST(
				(SELECT
					d.id AS 'Id',
					d.fullName AS 'FullName',
					d.hospitalId AS 'HospitalId',
					d.specializationId AS 'SpecializationId',
					d.deleted AS 'Deleted',
					p.addressId AS 'AddressId',
					p.birthDate AS 'BirthDate',
					p.email AS 'Email'
				 FROM Doctor d
				 INNER JOIN PersonalInfo p ON p.id = d.personalInfoId
				 FOR XML PATH('Doctor'), ROOT('Doctors')) 
				AS nvarchar(4000)) + '</Data>'
	END
	ELSE
	BEGIN
		SET @xmlResult = '<Data>' +
			CAST(
				(SELECT
					pa.id AS 'Id',
					pa.fullName AS 'FullName',
					pa.deleted AS 'Deleted',
					p.addressId AS 'AddressId',
					p.birthDate AS 'BirthDate',
					p.email AS 'Email'
				 FROM Patient pa
				 INNER JOIN PersonalInfo p ON p.id = pa.personalInfoId
				 FOR XML PATH('Patient'), ROOT('Patients')) 
				AS nvarchar(4000)) + '</Data>'
	END
END
GO

CREATE PROCEDURE [dbo].[proc_PersonalInfo@Read] @xmlData xml, @xmlResult  nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int
	DECLARE @isDoctor bit

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int), @isDoctor = CAST(n.value('(./value0)[1]', 'bit') AS bit)
    FROM @xmlData.nodes('/Data') t(n)

	IF(@isDoctor = 1)
	BEGIN
		SET @xmlResult = 
			CAST(
				(SELECT
					d.id AS 'Id',
					d.fullName AS 'FullName',
					d.hospitalId AS 'HospitalId',
					d.specializationId AS 'SpecializationId',
					d.deleted AS 'Deleted',
					p.addressId AS 'AddressId',
					p.birthDate AS 'BirthDate',
					p.email AS 'Email'
				 FROM Doctor d
				 INNER JOIN PersonalInfo p ON p.id = d.personalInfoId
				 WHERE d.id = @id
				 FOR XML PATH('Doctor')) 
				AS nvarchar(4000))
	END
	ELSE
	BEGIN
		SET @xmlResult = 
			CAST(
				(SELECT
					pa.id AS 'Id',
					pa.fullName AS 'FullName',
					pa.deleted AS 'Deleted',
					p.addressId AS 'AddressId',
					p.birthDate AS 'BirthDate',
					p.email AS 'Email'
				 FROM Patient pa
				 INNER JOIN PersonalInfo p ON p.id = pa.personalInfoId
				 WHERE pa.id = @id
				 FOR XML PATH('Patient')) 
				AS nvarchar(4000))
	END
END
GO

CREATE PROCEDURE [dbo].[proc_PersonalInfo@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int, @isDoctor bit

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int), @isDoctor = CAST(n.value('(./value0)[1]', 'bit') AS bit)
    FROM @xmlData.nodes('/Data') t(n)

	IF(@isDoctor = 1)
		DELETE FROM Doctor WHERE id = @id
	ELSE 
		DELETE FROM Patient WHERE id = @id
END
GO

CREATE PROCEDURE [dbo].[proc_PersonalInfo@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @isDoctor bit
	
	SELECT @isDoctor = ISNULL(CAST(n.value('(./SpecializationId)[1]', 'int') AS bit), 0)
    FROM @xmlData.nodes('/Doctor') t(n)

	IF(@isDoctor = 1)
	BEGIN
		INSERT INTO PersonalInfo (addressId, birthDate, email, deleted)
		SELECT
			n.value('(./AddressId)[1]', 'int'),
			n.value('(./BirthDate)[1]', 'date'),
			n.value('(./Email)[1]', 'varchar(100)'),
			0
		FROM @xmlData.nodes('/Doctor') t(n)

		DECLARE @pdId int = SCOPE_IDENTITY()

		INSERT INTO Doctor (fullName, specializationId, hospitalId, personalInfoId, deleted)
		SELECT
			n.value('(./FullName)[1]', 'nvarchar(100)'),
			n.value('(./SpecializationId)[1]', 'int'),
			n.value('(./HospitalId)[1]', 'int'),
			@pdId,
			0
		FROM @xmlData.nodes('/Doctor') t(n)
		
		SET @newId = SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		INSERT INTO PersonalInfo (addressId, birthDate, email, deleted)
		SELECT
			n.value('(./AddressId)[1]', 'int'),
			n.value('(./BirthDate)[1]', 'date'),
			n.value('(./Email)[1]', 'varchar(100)'),
			0
		FROM @xmlData.nodes('/Patient') t(n)

		DECLARE @ppId int = SCOPE_IDENTITY()

		INSERT INTO Patient(fullName, personalInfoId, deleted)
		SELECT
			n.value('(./FullName)[1]', 'nvarchar(100)'),
			@ppId,
			0
		FROM @xmlData.nodes('/Patient') t(n)

		SET @newId = SCOPE_IDENTITY()
	END
END
GO

CREATE PROCEDURE [dbo].[proc_NoteIllnessCertificate@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<Data>' + CAST(
		(SELECT
			[id] AS 'Id',
			[note] AS 'Note',
			[date] AS 'Date',
			[illnessCerticateId] AS 'IllnessCertificateId'
		FROM NoteIllnessCertificate
		FOR XML PATH('NoteIllnessCertificate'), ROOT('NotesIllnessCertificate')) 
		AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_NoteIllnessCertificate@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @illnessCertificateId int

	SELECT @illnessCertificateId = n.value('(./IllnessCertificateId)[1]', 'int') FROM @xmlData.nodes('/NoteIllnessCertificate') t(n)

	UPDATE IllnessCertificate SET [lastVisit] = GETDATE() WHERE [id] = @illnessCertificateId

	INSERT INTO NoteIllnessCertificate ([note], [date], [illnessCerticateId])
	SELECT 
		n.value('(./Note)[1]', 'nvarchar(max)'),
		GETDATE(),
		@illnessCertificateId
	FROM @xmlData.nodes('./NoteIllnessCertificate') t(n)

	SET @newId = @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[proc_IllnessCertificate@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<Data>' + CAST(
		(SELECT
			[id] AS 'Id',
			[firstVisit] AS 'FirstVisit',
			[lastVisit] AS 'LastVisit',
			[doctorId] AS 'DoctorId',
			[patientId] AS 'PatientId',
			[diseaseId] AS 'DiseaseId'
 		 FROM IllnessCertificate
		 FOR XML PATH('IllnessCertificate'), ROOT('IllnessCertificates')) 
		AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_IllnessCertificate@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('/Data') t(n)

	SET @xmlResult = CAST(
		(SELECT
			[id] AS 'Id',
			[firstVisit] AS 'FirstVisit',
			[lastVisit] AS 'LastVisit',
			[doctorId] AS 'DoctorId',
			[patientId] AS 'PatientId',
			[diseaseId] AS 'DiseaseId'
 		 FROM IllnessCertificate
		 WHERE [id] = @id
		 FOR XML PATH('IllnessCertificate')) 
		AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_IllnessCertificate@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM NoteIllnessCertificate WHERE [illnessCerticateId] = @id
	DELETE FROM IllnessCertificate WHERE [id] = @id
END
GO

CREATE PROCEDURE [dbo].[proc_IllnessCertificate@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	INSERT INTO IllnessCertificate ([firstVisit], [lastVisit], [doctorId], [patientId], [diseaseId])
	SELECT
		GETDATE(),
		GETDATE(),
		n.value('(./DoctorId)[1]', 'int'),
		n.value('(./PatientId)[1]', 'int'),
		n.value('(./DiseaseId)[1]', 'int')
	FROM @xmlData.nodes('./IllnessCertificate') t(n)

	SET @newId = @@IDENTITY
END
GO

CREATE PROCEDURE [dbo].[proc_Hospital@Update] @xmlData xml
AS
BEGIN
	DECLARE 
		@id int, 
		@name nvarchar(max),
		@addressId int

	SELECT
		@name = n.value('(./Name)[1]', 'nvarchar(max)'),
		@id = n.value('(./Id)[1]', 'int'),
		@addressId = n.value('(./AddressId)[1]', 'int')
	FROM @xmlData.nodes('/Hospital') t(n)

	UPDATE [Hospital] SET
		[Name] = @name,
		[AddressId] = @addressId
	WHERE Id = @id
END
GO


CREATE PROCEDURE [dbo].[proc_Hospital@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN 
	SET @xmlResult = '<Data>' +
	CAST((SELECT
		h.id AS 'Id',
		h.[name] AS 'Name',
		h.deleted AS 'Deleted',
		a.[address] AS 'Address',
		h.addressId AS 'AddressId'
	FROM [Hospital] h
	INNER JOIN [AddressAsString] a ON a.addressId = h.addressId
	FOR XML PATH('Hospital'), ROOT('Hospitals')) AS nvarchar(4000)) + '</Data>' 
END
GO

CREATE PROCEDURE [dbo].[proc_Hospital@Read] @xmlData xml, @xmlResult  nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	SET @xmlResult = 
	CAST((SELECT
		h.id AS 'Id',
		h.[name] AS 'Name',
		h.deleted AS 'Deleted',
		a.[address] AS 'Address',
		h.addressId AS 'AddressId'
	FROM [Hospital] h
	INNER JOIN [AddressAsString] a ON a.addressId = h.addressId
	WHERE h.id = @id
	FOR XML PATH('Hospital')) AS nvarchar(4000)) 
END
GO

CREATE PROCEDURE [dbo].[proc_Hospital@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM [Hospital] WHERE [id] = @id
END
GO


CREATE PROCEDURE [dbo].[proc_Hospital@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @name nvarchar(max), @addressId int

	SELECT
		@name = n.value('(./Name)[1]', 'nvarchar(max)'),
		@addressId = n.value('(./AddressId)[1]', 'int')
	FROM @xmlData.nodes('/Hospital') t(n)

	INSERT INTO Hospital ([name], [addressId]) VALUES (@name, @addressId)

	SET @newId = @@Identity
END
GO

CREATE PROCEDURE [dbo].[proc_DoctorSpecialization@Update] @xmlData xml
AS
BEGIN
	DECLARE @name nvarchar(50), @id int

	SELECT 
		@name = n.value('(./Name)[1]', 'nvarchar(50)'),
		@id = n.value('(./Id)[1]', 'int')
	FROM @xmlData.nodes('/DoctorSpecialization') t(n)

	UPDATE DoctorSpecialization SET [name] = @name WHERE [id] = @id
END
GO

CREATE PROCEDURE [dbo].[proc_DoctorSpecialization@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<Data>' +
		CAST(
			(SELECT 
				[id] AS 'Id',
				[name] AS 'Name'
			FROM [DoctorSpecialization] FOR XML PATH('DoctorSpecialization'), ROOT('DoctorSpecializations'))
		AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_DoctorSpecialization@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	SET @xmlResult = 
	CAST((
		SELECT 
			[id] AS 'Id',
			[name] AS 'Name'
		FROM [DoctorSpecialization] 
		WHERE [id] = @id
		FOR XML PATH('DoctorSpecialization')
	) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_DoctorSpecialization@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int

	SELECT @id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM [DoctorSpecialization] WHERE [id] = @id
END
GO

CREATE PROCEDURE [dbo].[proc_DoctorSpecialization@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @name nvarchar(50)

	SELECT @name = n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/DoctorSpecialization') t(n);

	INSERT INTO [DoctorSpecialization] ([name]) VALUES (@name)

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_DiseaseType@Update] @xmlData xml
AS
BEGIN
	DECLARE @id int, @type nvarchar(100)

	SELECT
		@id = n.value('(./Id)[1]', 'int'),
		@type = n.value('(./Type)[1]', 'nvarchar(100)')
	FROM @xmlData.nodes('/DiseaseType') t(n)

	UPDATE DiseaseType SET [type] = @type WHERE [id] = @id
END
GO


CREATE PROCEDURE [dbo].[proc_DiseaseType@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult ='<Data>' + CAST((
		SELECT
			[id] AS 'Id',
			[type] AS 'Type'
		FROM DiseaseType
		FOR XML PATH('DiseaseType'), ROOT('DiseaseTypes')
	) AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_DiseaseType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('./Data') t(n)

	SET @xmlResult = CAST((
		SELECT
			[id] AS 'Id',
			[type] AS 'Type'
		FROM DiseaseType
		WHERE [id] = @id
		FOR XML PATH('DiseaseType')
	) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_DiseaseType@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('./Data') t(n)

	DELETE FROM DiseaseType WHERE [id] = @id
END
GO


CREATE PROCEDURE [dbo].[proc_DiseaseType@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	INSERT INTO DiseaseType ([type])
	SELECT
		n.value('(./Type)[1]', 'nvarchar(100)')
	FROM @xmlData.nodes('/DiseaseType') t(n)

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_Disease@Update] @xmlData xml
AS
BEGIN
	DECLARE @id int, @diseaseTypeId int, @name nvarchar(100)

	SELECT
		@id = n.value('(./Id)[1]', 'int'),
		@diseaseTypeId = n.value('(./DiseaseTypeId)[1]', 'int'),
		@name = n.value('(./Name)[1]', 'nvarchar(100)')
	FROM @xmlData.nodes('/Disease') t(n)

	UPDATE Disease SET [diseaseTypeId] = @diseaseTypeId, [name] = @name WHERE [id] = @id
END
GO


CREATE PROCEDURE [dbo].[proc_Disease@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult ='<Data>' + CAST((
		SELECT
			[id] AS 'Id',
			[diseaseTypeId] AS 'DiseaseTypeId',
			[name] AS 'Name'
		FROM Disease
		FOR XML PATH('Disease'), ROOT('Diseases')
	) AS nvarchar(4000)) + '</Data>'
END
GO


CREATE PROCEDURE [dbo].[proc_Disease@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('./Data') t(n)

	SET @xmlResult = CAST((
		SELECT
			[id] AS 'Id',
			[diseaseTypeId] AS 'DiseaseTypeId',
			[name] AS 'Name'
		FROM Disease
		WHERE [id] = @id
		FOR XML PATH('Disease')
	) AS nvarchar(4000))
END
GO


CREATE PROCEDURE [dbo].[proc_Disease@Delete] @xmlData xml
AS
BEGIN
	DECLARE @id int

	SELECT @id = n.value('(./value)[1]', 'int') FROM @xmlData.nodes('./Data') t(n)

	DELETE FROM Disease WHERE [id] = @id
END
GO


CREATE PROCEDURE [dbo].[proc_Disease@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	INSERT INTO Disease ([diseaseTypeId], [name])
	SELECT
		n.value('(./DiseaseTypeId)[1]', 'int'),
		n.value('(./Name)[1]', 'nvarchar(100)')
	FROM @xmlData.nodes('/Disease') t(n)

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_CityType@Update] @xmlData xml
AS
BEGIN
	DECLARE @Type nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Type = CAST(n.value('(./Type)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/CityType') t(n)

	UPDATE CityType SET [type] = @Type WHERE id = @Id
END
GO



CREATE PROCEDURE [dbo].[proc_CityType@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [type] AS 'Type' FROM CityType FOR XML PATH('CityType'), ROOT('CityTypes')) AS nvarchar(4000)) + '</Data>'
END
GO


CREATE PROCEDURE [dbo].[proc_CityType@Read2] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<CityType><Id>12345</Id><Type>Test Type</Type></CityType>'
END
GO


CREATE PROCEDURE [dbo].[proc_CityType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [type] AS 'Type' FROM CityType  WHERE id = @Id FOR XML PATH('CityType')) AS nvarchar(4000))
END
GO


CREATE PROCEDURE [dbo].[proc_CityType@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM CityType WHERE id = @Id
END
GO


CREATE PROCEDURE [dbo].[proc_CityType@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Type nvarchar(50)

	SET @Type = CAST((SELECT n.value('(./Type)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/CityType') t(n)) AS nvarchar(50))

	INSERT INTO CityType ([type]) VALUES (@Type) 

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_CityName@Update] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Name = CAST(n.value('(./Name)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/CityName') t(n)

	UPDATE City SET [name] = @Name WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_CityName@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [name] AS 'Name' FROM City FOR XML PATH('CityName'), ROOT('CityNames')) AS nvarchar(4000)) + '</Data>'
END
GO


CREATE PROCEDURE [dbo].[proc_CityName@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM City WHERE id = @Id FOR XML PATH('CityName')) AS nvarchar(4000))
END
GO


CREATE PROCEDURE [dbo].[proc_CityName@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM City WHERE id = @Id
END
GO


CREATE PROCEDURE [dbo].[proc_CityName@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/CityName') t(n)) AS nvarchar(50))

	INSERT INTO City ([name]) VALUES (@Name)

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_BuildingNumber@Update] @xmlData xml
AS
BEGIN
	DECLARE @Number nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Number = CAST(n.value('(./Number)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/BuildingNumber') t(n)

	UPDATE BuildingNumber SET [number] = @Number WHERE id = @Id
END
GO


CREATE PROCEDURE [dbo].[proc_BuildingNumber@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [number] AS 'Number' FROM BuildingNumber FOR XML PATH('BuildingNumber'), ROOT('BuildingNumbers')) AS nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_BuildingNumber@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [number] AS 'Number' FROM BuildingNumber WHERE id = @Id FOR XML PATH('BuildingNumber')) AS nvarchar(4000))
END
GO

CREATE PROCEDURE [dbo].[proc_BuildingNumber@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM BuildingNumber WHERE id = @Id
END
GO


CREATE PROCEDURE [dbo].[proc_BuildingNumber@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @Number nvarchar(50)

	SET @Number = CAST((SELECT n.value('(./Number)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/BuildingNumber') t(n)) AS nvarchar(50))

	INSERT INTO BuildingNumber (number) VALUES (@Number)

	SET @newId = @@IDENTITY
END
GO


CREATE PROCEDURE [dbo].[proc_AllInfo@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<Data>' + CAST(
		(SELECT
			certificateId AS 'CertificateId',
			firstVisit AS 'FirstVisit',
			lastVisit AS 'LastVisit',
			diseaseName AS 'DiseaseName',
			diseaseType AS 'DiseaseType',
			patientName AS 'PatientName',
			patientEmail AS 'PatientEmail',
			patientBirthDate AS 'PatientBirthDate',
			doctorName AS 'DoctorName',
			doctorSpecialization AS 'DoctorSpecialization',
			hospitalName AS 'HospitalName',
			hospitalAddress AS 'HospitalAddress'
		FROM AllInfo
		FOR XML PATH('Info'), ROOT('Infoses')) 
		AS nvarchar(4000)) + '</Data>'
END
GO


CREATE PROCEDURE [dbo].[proc_Address@Update] @xmlData xml
AS
BEGIN
	DECLARE @RegionId int,
			@CityTypeId int,
			@CityNameId int,
			@StreetTypeId int,
			@StreetNameId int,
			@BuildingNumberId int,
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@RegionId = CAST(n.value('(./Region/Id)[1]', 'int') AS int),
		@CityTypeId = CAST(n.value('(./CityType/Id)[1]', 'int') AS int),
		@CityNameId = CAST(n.value('(./CityName/Id)[1]', 'int') AS int),
		@StreetTypeId = CAST(n.value('(./StreetType/Id)[1]', 'int') AS int),
		@StreetNameId = CAST(n.value('(./StreetName/Id)[1]', 'int') AS int),
		@BuildingNumberId = CAST(n.value('(./BuildingNumber/Id)[1]','int') AS int)
	FROM @xmlData.nodes('/Address') t(n)

	UPDATE Address SET regionId = @RegionId, cityTypeId = @CityTypeId, cityId = @CityNameId, streetNameId = @StreetNameId, streetTypeId = @StreetTypeId, buildingNumberId = @BuildingNumberId
	WHERE id = @Id
END
GO


CREATE PROCEDURE [dbo].[proc_Address@ReadAll] @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult ='<Data>' + CAST((SELECT 
		id AS 'Id',
		cityTypeId AS 'CityType/Id',
		cityType AS 'CityType/Type',
		cityId AS 'CityName/Id',
		cityName AS 'CityName/Name',
		streetTypeId AS 'StreetType/Id',
		streetType AS 'StreetType/Type',
		streetNameId AS 'StreetName/Id',
		streetName AS 'StreetName/Name',
		regionId AS 'Region/Id',
		regionName AS 'Region/Name',
		buildingNumberId AS 'BuildingNumber/Id',
		buildingNumber AS 'BuildingNumber/Number'
	 FROM AddressAsTable 
	 FOR XML PATH('Address'), ROOT('Addresses')) as nvarchar(4000)) + '</Data>'
END
GO

CREATE PROCEDURE [dbo].[proc_Address@Read] @xmlData xml, @xmlResult nvarchar(1000) OUTPUT
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
	FROM @xmlData.nodes('/Data') t(n)

	SET @xmlResult = CAST((SELECT 
		id AS 'Id',
		cityTypeId AS 'CityType/Id',
		cityType AS 'CityType/Type',
		cityId AS 'CityName/Id',
		cityName AS 'CityName/Name',
		streetTypeId AS 'StreetType/Id',
		streetType AS 'StreetType/Type',
		streetNameId AS 'StreetName/Id',
		streetName AS 'StreetName/Type',
		regionId AS 'Region/Id',
		regionName AS 'Region/Name',
		buildingNumberId AS 'BuildingNumber/Id',
		buildingNumber AS 'BuildingNumber/Number'
	 FROM AddressAsTable 
	 WHERE id = @Id
	 FOR XML PATH('Address')) as nvarchar(1000))
END
GO

CREATE PROCEDURE [dbo].[proc_Address@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
	FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM [Address] WHERE id = @Id
END
GO

CREATE PROCEDURE [dbo].[proc_Address@Create] @xmlData xml, @newId int OUTPUT
AS
BEGIN
	DECLARE @RegionId int,
			@CityTypeId int,
			@CityNameId int,
			@StreetTypeId int,
			@StreetNameId int,
			@BuildingNumberId int

	SELECT
		@RegionId = CAST(n.value('(./Region/Id)[1]', 'int') AS int),
		@CityTypeId = CAST(n.value('(./CityType/Id)[1]', 'int') AS int),
		@CityNameId = CAST(n.value('(./CityName/Id)[1]','int') AS int),
		@StreetTypeId = CAST(n.value('(./StreetType/Id)[1]','int') AS int),
		@StreetNameId = CAST(n.value('(./StreetName/Id)[1]','int') AS int),
		@BuildingNumberId = CAST(n.value('(./BuildingNumber/Id)[1]','int') AS int)
	FROM @xmlData.nodes('/Address') t(n)

	INSERT INTO Address (regionId, cityTypeId, cityId, streetTypeId, streetNameId, buildingNumberId) 
	VALUES (@RegionId, @CityTypeId, @CityNameId, @StreetTypeId, @StreetNameId, @BuildingNumberId)

	SET @newId = @@IDENTITY
END
GO

