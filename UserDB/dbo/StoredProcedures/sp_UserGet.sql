CREATE PROCEDURE [dbo].[sp_UserGet]
	@id int
AS
	SELECT Id,FirstName,LastName
	from dbo.[User]
	where Id = @id;
RETURN 0
