INSERT INTO Region ([name]) VALUES (N'Київська');
INSERT INTO CityType ([type]) VALUES (N'м.');
INSERT INTO City ([name]) VALUES (N'Київ');
INSERT INTO StreetType ([type]) VALUES (N'вул.');
INSERT INTO StreetName ([name]) VALUES (N'Генерала Потапова');
INSERT INTO BuildingNumber ([number]) VALUES ('4');
INSERT INTO [Address] (cityId, cityTypeId, regionId, streetTypeId, streetNameId, buildingNumberId) VALUES (1, 1, 1, 1, 1, 1);