CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [subject] NVARCHAR(50) NOT NULL, 
    [content] NVARCHAR(MAX) NOT NULL, 
    [PostDateTime] DATETIME NOT NULL
)
