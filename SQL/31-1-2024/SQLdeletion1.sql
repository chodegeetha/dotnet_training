use WordVoyager
create procedure deleteattach
@AttachmentId int
as
begin
delete from Attachment_Table where AttachmentId=@AttachmentId
end
 exec deleteattach 3 