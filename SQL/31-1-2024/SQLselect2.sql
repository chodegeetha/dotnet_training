use WordVoyager
create procedure selectarticle
@ArticleId INT,
@Content TEXT,
@Title  nvarchar(100)
as 
begin
select Content,Title from Article_Table where ArticleId=@ArticleId;
end
exec selectarticle @ArticleId=233