
use WordVoyager
create procedure getuserdetails
	@UserId int,
	@UserName nvarchar(100),
	@Email nvarchar(100),
	@PasswordHash varchar(100),
	@RegistrationDate datetime
as
begin
	insert into User_Table(UserId,UserName,Email,PasswordHash,RegistrationDate) 
	values (@UserId,@UserName,@Email,@PasswordHash,@RegistrationDate)
end;
 
--- Executing the  proceedure to add value to User_Table
exec getuserdetails 10,'Sindu','sindu@epam.com','yjkl12','2024-11-23';
exec getuserdetails 11,'Jyothi','jyothi@epam.com','adfrts123','2024-10-13';
exec getuserdetails 12,'Ramya','ramya@epam.com','mnokl23','2024-01-25';
exec getuserdetails 13,'Sita','sita@epam.com','agaha67','2024-01-12';
exec getuserdetails 14,'Ram','ram@epam.com','kl	oqoqh23','2024-01-11';
exec getuserdetails 15,'Jashu','jashu@epam.com','cguiwg81','2024-11-19';



create procedure Tagdetails
	@TagId int,
	@Name nvarchar(100)
	
as
begin
	insert into Tag_Table(TagId,Name)
	values (@TagId,@Name)
end;
 
---- Executing the proceedure to add values to Tag_Table
exec Tagdetails 1,'Fitness Tips';
exec Tagdetails 2,'Healthy Living';
exec Tagdetails 3,'Programming';




create procedure commentdetails
	@CommentId int,
	@Content text,
	@CommentDate datetime,
	@ArticleId int,
	@UserId int
as
begin
	insert into Comment_Table(CommentId,Content,CommentDate,ArticleId,UserId) 
	values (@CommentId,@Content,@CommentDate,@ArticleId,@UserId)
end;
 
-- Executing the  proceedure to add value to Comment_Table
exec commentdetails 1,'xxxxxxx', '2024-01-31 12:34:56', 123, 13;
exec commentdetails 2,'yyyyyyy','2024-05-20 08:55:22', 456, 11;
exec commentdetails 3,'zzzzzzzz', '2024-07-12 11:08:17', 789, 10;


create procedure categorydetails
	@CategoryId int,
	@Name nvarchar(100),
	@Description text
	
as
begin
	insert into Category_Table(CategoryId,Name,Description)
	values (@CategoryId,@Name,@Description)
end;
 
---- Executing the proceedure to add values to Category_Table
exec categorydetails 11, 'Health', 'Tips and information to maintain a healthy lifestyle.'
exec categorydetails 22, 'Fitness', 'Workouts and tips for staying fit and active.'
exec categorydetails 32, 'Science', 'Discoveries and developments in the world of science.'


create procedure Attachmentdetails
	@AttachmentId INT,
    @FileName NVARCHAR(100),
    @FileType NVARCHAR(100),
    @FilePath NVARCHAR(100),
    @UploadDate DATETIME,
    @ArticleId INT
as
begin
	insert into Attachment_Table(AttachmentId,FileName,FileType,FilePath,UploadDate,ArticleId) 
	values (@AttachmentId,@FileName,@FileType, @FilePath, @UploadDate, @ArticleId)
end;
 
--- Executing the  proceedure to add value to Attachment_Table
exec Attachmentdetails 1, 'data.csv', 'CSV', '/uploads/data/data.csv', '2024-04-10 15:10:05', 123
exec Attachmentdetails 2, 'video.mp4', 'MP4', '/uploads/videos/video.mp4', '2024-08-22 17:40:55', 789
exec Attachmentdetails 3, 'photo.jpg', 'JPEG', '/uploads/images/photo.jpg', '2024-06-05 14:27:40', 233
exec Attachmentdetails 4, 'code.py', 'Python', '/uploads/code/code.py', '2024-05-20 08:55:22', 456



create procedure ArticleTagdetails
    @ArticleId int,
	@TagId int
	
	
as
begin
	insert into ArticleTag(ArticleId,TagId)
	values (@ArticleId,@TagId)
end;
 
---- Executing the proceedure to add values to ArticleTag_Table
exec ArticleTagdetails  '456','1';
exec ArticleTagdetails '789','2';
exec ArticleTagdetails '233','3';


create procedure Articledetails
  @ArticleId INT,
  @Title  NVARCHAR(100),
  @Content TEXT,
  @PublishedDate DATETIME,
  @LastModifiedDate DATETIME,
  @AuthorId INT,
  @CategoryId INT
as
begin
	insert into Article_Table(ArticleId,Title, Content,PublishedDate, LastModifiedDate, AuthorId, CategoryId) 
	values (@ArticleId,@Title, @Content,@PublishedDate, @LastModifiedDate, @AuthorId, @CategoryId)
end;
 
--- Executing the  proceedure to add value to Article_Table
exec Articledetails 123, 'Introduction to Programming', 'In this article, we explore the basics of programming languages.', '2024-01-31 14:20:30', '2024-01-31 14:20:30', 13, 11
exec Articledetails 789, 'Top Travel Destinations in 2024', 'Discover the most exciting travel destinations for this year.', '2024-02-15 09:45:30', '2024-02-15 09:45:30', 10, 22
exec Articledetails 456, 'Maintaining a Healthy Lifestyle', 'Tips and advice for maintaining a healthy and balanced lifestyle.', '2024-03-02 18:20:15', '2024-03-02 18:20:15', 14, 32
exec Articledetails 233,  'Delicious Culinary Delights', 'Discover mouthwatering recipes and culinary adventures from around the world.', '2024-06-05 14:27:40', '2024-06-05 14:27:40', 12, 11


