Create database WordVoyager
use WordVoyager
Create Table User_Table
(
  UserId INT primary key,
  Username  NVARCHAR(100),
  Email NVARCHAR(100),
  PasswordHash NVARCHAR(100),
  RegistrationDate DATETIME
  );
  sp_help 'ArticleTag' ;

  /*usertable*/

  Create Table Article_Table
  (
  ArticleId INT primary key,
  Title  NVARCHAR(100),
  Content TEXT,
  PublishedDate DATETIME,
  LastModifiedDate DATETIME,
  AuthorId INT Foreign key References User_Table(UserId),
  CategoryId INT Foreign key References Category_Table(CategoryId),
  );
  Create Table Category_Table
  (
   CategoryId INT primary key,
   Name NVARCHAR(100),
   Description TEXT,
   );

   Create Table Comment_Table (
    CommentId INT PRIMARY KEY,
    Content TEXT,
    CommentDate DATETIME,
    ArticleId  INT Foreign key  REFERENCES Article_Table(ArticleId),
    UserId INT Foreign key REFERENCES User_Table(UserId)
  );

  Create Table ArticleTag (
    PRIMARY KEY (ArticleId, TagId),
    ArticleId INT FOREIGN KEY  REFERENCES Article_Table(ArticleId),
    TagId INT FOREIGN KEY  REFERENCES Tag_Table(TagId)
  );

  Create Table Tag_Table (
    TagId INT PRIMARY KEY,
    Name NVARCHAR(100)
  );  
  Create Table Attachment_Table (
    AttachmentId INT PRIMARY KEY,
    FileName NVARCHAR(100),
    FileType NVARCHAR(100),
    FilePath NVARCHAR(100),
    UploadDate DATETIME,
    ArticleId INT FOREIGN KEY  REFERENCES Article_Table(ArticleId)
  );