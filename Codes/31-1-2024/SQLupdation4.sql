create procedure updatedetails
@UserId INT,
  @Username  NVARCHAR(100),
  @Email NVARCHAR(100)
as
begin
update User_Table 
set 
UserName=@Username,Email=@Email where 
UserId=@UserId
end
exec updatedetails 11,'kajal','kajal23@gmail.com';