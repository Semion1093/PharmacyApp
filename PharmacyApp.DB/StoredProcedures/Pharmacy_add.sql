CREATE PROCEDURE [dbo].[Pharmacy_Add] 
  @Name varchar(50), 
  @Adress varchar(100), 
  @Phone varchar(12)  AS BEGIN
INSERT INTO
  dbo.Pharmacies ([Name], Adress, Phone)
VALUES
  (@Name, @Adress, @Phone)
SELECT
  scope_identity()
END
