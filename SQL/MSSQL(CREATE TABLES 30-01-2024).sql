Create Database WordVoyager;
use WordVoyager;

Create Table User_Table
(
  UserId INT primary key,
  Username  NVARCHAR(100),
  Email NVARCHAR(100),
  PasswordHash NVARCHAR(100),
  RegistrationDate DATETIME
  );
  sp_help 'Category_Table' ;
   /*  TO SEE THE INFO ABOUT COLUMNS (SKELETON) IN THE TABLE */

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
  Create Table Tag_Table (
    TagId INT PRIMARY KEY,
    Name NVARCHAR(100)
  );  

  Create Table ArticleTag (
    PRIMARY KEY (ArticleId, TagId),
    ArticleId INT FOREIGN KEY  REFERENCES Article_Table(ArticleId),
    TagId INT FOREIGN KEY  REFERENCES Tag_Table(TagId)
  );

  
  Create Table Attachment_Table (
    AttachmentId INT PRIMARY KEY,
    FileName NVARCHAR(100),
    FileType NVARCHAR(100),
    FilePath NVARCHAR(100),
    UploadDate DATETIME,
    ArticleId INT FOREIGN KEY  REFERENCES Article_Table(ArticleId)
  );
  select * From INFORMATION_SCHEMA.columns where Table_name='Category_Table'
  /*  TO SEE THE INFO ABOUT COLUMNS (SKELETON) IN THE TABLE */
  select * From INFORMATION_SCHEMA.TABLES;
   /*  TO SEE THE EXISTING TABLES IN THE DATABASE (OR) CONTROL F1 KEY */

   select * From  Category_Table;
  
   select * From Comment_Table;
    select * From Article_Table;
	 select * From ArticleTag;
	  select * From Attachment_Table;



 
 


  
