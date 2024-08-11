CREATE PROCEDURE [dbo].[spUser_D]
@id int
AS
delete	from dbo.[User]
	where Id = @id;
RETURN 0
