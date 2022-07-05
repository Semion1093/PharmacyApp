CREATE PROCEDURE [dbo].[Store_Delete]
  @Id int AS BEGIN
DELETE FROM
  dbo.Stores
WHERE
  @Id = Id
END
