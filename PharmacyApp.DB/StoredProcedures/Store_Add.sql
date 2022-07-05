CREATE PROCEDURE [dbo].[Store_Add]
  @Name varchar(50), 
  @PharmacyId varchar(100) AS BEGIN
INSERT INTO
  dbo.Stores ([Name], PharmacyId)
VALUES
  (@Name, @PharmacyId)
SELECT
  scope_identity()
END
