
create procedure deleteattach
@AttachmentId int
as
begin
delete from Attachment_Table where AttachmentId=@AttachmentId
end
 exec deleteattach 3 


create procedure deletearticle
@ArticleId int
as
begin
delete from Article_Table where ArticleId=@ArticleId
end
 exec deletearticle 244

 
 create procedure deleteuser
@UserId int
as
begin
delete from User_Table where UserId=@UserId;
end
 exec deleteuser 15
 select * from Article_Table


