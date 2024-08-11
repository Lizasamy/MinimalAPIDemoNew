CREATE PROCEDURE [dbo].[SP_UserGetAll]
As
begin
select Id,FirstName,LastName
from dbo.[User];
end