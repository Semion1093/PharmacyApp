CREATE PROCEDURE [dbo].[Batch_Delete]
  @Id int AS BEGIN
DELETE FROM
  dbo.Pharmacies
WHERE
  @Id = Id
END
