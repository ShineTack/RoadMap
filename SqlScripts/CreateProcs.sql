CREATE PROCEDURE [dbo].[proc_Address@Create] @xmlData xml
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
END

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

CREATE PROCEDURE [dbo].[proc_Address@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
	FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM [Address] WHERE id = @Id
END

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
		streetName AS 'StreetName/Type',
		regionId AS 'Region/Id',
		regionName AS 'Region/Name',
		buildingNumberId AS 'BuildingNumber/Id',
		buildingNumber AS 'BuildingNumber/Number'
	 FROM AddressAsTable 
	 FOR XML PATH('Address'), ROOT('Addresses')) as nvarchar(4000)) + '</Data>'
END


-- City Type
CREATE PROCEDURE [dbo].[proc_CityType@Create] @xmlData xml
AS
BEGIN
	DECLARE @Type nvarchar(50)

	SET @Type = CAST((SELECT n.value('(./Type)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/CityType') t(n)) AS nvarchar(50))

	INSERT INTO CityType ([type]) VALUES (@Type) 
END

CREATE PROCEDURE [dbo].[proc_CityType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [type] AS 'Type' FROM CityType  WHERE id = @Id FOR XML PATH('CityType')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_CityType@Read2] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT
AS
BEGIN
	SET @xmlResult = '<CityType><Id>12345</Id><Type>Test Type</Type></CityType>'
END

CREATE PROCEDURE [dbo].[proc_CityType@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [type] AS 'Type' FROM CityType FOR XML PATH('CityType'), ROOT('CityTypes')) AS nvarchar(4000)) + '</Data>'
END

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

CREATE PROCEDURE [dbo].[proc_CityType@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM CityType WHERE id = @Id
END
-- City Name
CREATE PROCEDURE [dbo].[proc_CityName@Create] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/CityName') t(n)) AS nvarchar(50))

	INSERT INTO City ([name]) VALUES (@Name)
END

CREATE PROCEDURE [dbo].[proc_CityName@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM City WHERE id = @Id FOR XML PATH('CityName')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_CityName@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [name] AS 'Type' FROM City FOR XML PATH('CityName'), ROOT('CityNames')) AS nvarchar(4000)) + '</Data>'
END

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

CREATE PROCEDURE [dbo].[proc_CityName@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM City WHERE id = @Id
END
--Region
CREATE PROCEDURE [dbo].[proc_Region@Create] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/Region') t(n)) AS nvarchar(50))

	INSERT INTO Region ([name]) VALUES (@Name)
END

CREATE PROCEDURE [dbo].[proc_Region@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM Region WHERE id = @Id FOR XML PATH('Region')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_Region@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [type] AS 'Name' FROM CityType FOR XML PATH('Region'), ROOT('Regions')) AS nvarchar(4000)) + '</Data>'
END

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

CREATE PROCEDURE [dbo].[proc_Region@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM Region WHERE id = @Id
END
--Street Name
CREATE PROCEDURE [dbo].[proc_StreetName@Create] @xmlData xml
AS
BEGIN
	DECLARE @Name nvarchar(50)

	SET @Name = CAST((SELECT n.value('(./Name)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/StreetName') t(n)) AS nvarchar(50))

	INSERT INTO StreetName ([name]) VALUES (@Name)
END

CREATE PROCEDURE [dbo].[proc_StreetName@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [name] AS 'Name' FROM StreetName WHERE id = @Id FOR XML PATH('StreetName')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_StreetName@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [name] AS 'Name' FROM StreetName FOR XML PATH('StreetName'), ROOT('StreetNames')) AS nvarchar(4000)) + '</Data>'
END

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

CREATE PROCEDURE [dbo].[proc_StreetName@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM StreetName WHERE id = @Id
END
--Street Type
CREATE PROCEDURE [dbo].[proc_StreetType@Create] @xmlData xml
AS
BEGIN
	DECLARE @Type nvarchar(50)

	SET @Type = CAST((SELECT n.value('(./Type)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/StreetType') t(n)) AS nvarchar(50))

	INSERT INTO StreetType ([type]) VALUES (@Type)
END

CREATE PROCEDURE [dbo].[proc_StreetType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [type] AS 'Type' FROM StreetType WHERE id = @Id FOR XML PATH('StreetType')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_StreetType@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [type] AS 'Type' FROM StreetType FOR XML PATH('StreetType'), ROOT('StreetTypes')) AS nvarchar(4000)) + '</Data>'
END

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

CREATE PROCEDURE [dbo].[proc_StreetType@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM StreetType WHERE id = @Id
END
-- BUILDING NUMBER
CREATE PROCEDURE [dbo].[proc_BuildingNumber@Create] @xmlData xml
AS
BEGIN
	DECLARE @Number nvarchar(50)

	SET @Number = CAST((SELECT n.value('(./Number)[1]', 'nvarchar(50)') FROM @xmlData.nodes('/BuildingNumber') t(n)) AS nvarchar(50))

	INSERT INTO BuildingNumber (number) VALUES (@Number)
END

CREATE PROCEDURE [dbo].[proc_BuildingNumber@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [number] AS 'Number' FROM BuildingNumber WHERE id = @Id FOR XML PATH('BuildingNumber')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_BuildingNumber@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = '<Data>' + CAST(
            (SELECT id as 'Id', [number] AS 'Type' FROM BuildingNumber FOR XML PATH('BuildingNumber'), ROOT('BuildingNumbers')) AS nvarchar(4000)) + '</Data>'
END

CREATE PROCEDURE [dbo].[proc_BuildingNumber@Update] @xmlData xml
AS
BEGIN
	DECLARE @Number nvarchar(50),
			@Id int

	SELECT
		@Id = CAST(n.value('(./Id)[1]', 'int') AS int),
		@Number = CAST(n.value('(./Number)[1]', 'nvarchar(50)') AS nvarchar(50))
	FROM @xmlData.nodes('/BuildingNumber') t(n)

	UPDATE CityType SET [type] = @Number WHERE id = @Id
END

CREATE PROCEDURE [dbo].[proc_BuildingNumber@Delete] @xmlData xml
AS
BEGIN
	DECLARE @Id int

	SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)

	DELETE FROM BuildingNumber WHERE id = @Id
END

