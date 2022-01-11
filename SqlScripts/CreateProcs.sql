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

CREATE PROCEDURE [dbo].[proc_CityType@Read] @xmlData xml, @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    DECLARE @Id int

    SELECT @Id = CAST(n.value('(./value)[1]', 'int') AS int)
    FROM @xmlData.nodes('/Data') t(n)
    
    SET @xmlResult = CAST(
        (SELECT id as 'Id', [type] AS 'Type' FROM CityType FOR XML PATH('CityType')) AS nvarchar(4000))
END

CREATE PROCEDURE [dbo].[proc_CityType@ReadAll] @xmlResult nvarchar(4000) OUTPUT 
AS
BEGIN
    SET @xmlResult = CAST(
            (SELECT id as 'Id', [type] AS 'Type' FROM CityType FOR XML PATH('CityType'), ROOT('Data')) AS nvarchar(4000))
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




