CREATE PROCEDURE [dbo].[spUser_Update]
	@id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
update dbo.[User] set FirstName = @FirstName ,
LastName = @LastName 
where Id = @id;

end