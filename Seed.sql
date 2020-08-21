SET IDENTITY_INSERT [dbo].[Categories] ON
GO

INSERT INTO [dbo].[Categories] 
(
[Id], 
[Name]
)
VALUES 
(0,
'Base Category'
);
GO

SET IDENTITY_INSERT [dbo].[Categories] OFF
GO


INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Product 1', 'img url', 1, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Product 2', 'img url', 1, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Product 3', 'img url', 1, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Product 4', 'img url', 1, 0);
GO