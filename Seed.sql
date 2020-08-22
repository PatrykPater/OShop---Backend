--- BASE CATEGORY ---

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

--- PRODUCTS SEED ---

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Spinach', 'http://www.publicdomainpictures.net/pictures/170000/velka/spinach-leaves-1461774375kTU.jpg', 2.5, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Freshly Baked Bread', 'https://static.pexels.com/photos/2434/bread-food-healthy-breakfast.jpg', 3, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Avacado', 'https://www.newhollandchips.com/wp-content/uploads/2020/06/rs7776_thinkstockphotos-856586464_1-low.jpg', 1.75, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Tomato', 'https://static.pexels.com/photos/8390/food-wood-tomatoes.jpg', 2.5, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Lettuce', 'https://upload.wikimedia.org/wikipedia/commons/7/7f/Lettuce_Mini_Heads_%287331119710%29.jpg', 2.5, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Cauliflower', 'https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Cauliflowers_-_20051021.jpg/1280px-Cauliflowers_-_20051021.jpg', 1.75, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Banana', 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Bananas.jpg/1024px-Bananas.jpg', 1.25, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Orange', 'https://upload.wikimedia.org/wikipedia/commons/c/c4/Orange-Fruit-Pieces.jpg', 1.7, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Apple', 'https://upload.wikimedia.org/wikipedia/commons/1/15/Red_Apple.jpg', 2, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Grape', 'https://upload.wikimedia.org/wikipedia/commons/3/36/Kyoho-grape.jpg', 2, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Peach', 'https://upload.wikimedia.org/wikipedia/commons/9/9e/Autumn_Red_peaches.jpg', 2, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Cinnamon Sticks', 'https://upload.wikimedia.org/wikipedia/commons/8/8c/Cinnamon-other.jpg', 0.5, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Saffron', 'https://upload.wikimedia.org/wikipedia/commons/4/48/Saffron_Crop.JPG', 0.75, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Ground Turmeric', 'http://maxpixel.freegreatpicture.com/static/photo/1x/Seasoning-Powder-Curry-Spice-Ingredient-Turmeric-2344157.jpg', 0.75, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Coriander Seeds', 'http://maxpixel.freegreatpicture.com/static/photo/1x/Ingredient-Herb-Seasoning-Seeds-Food-Coriander-390015.jpg', 0.75, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Lavash Bread', 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Fabrication_du_lavash_%C3%A0_Noravank_%286%29.jpg/1280px-Fabrication_du_lavash_%C3%A0_Noravank_%286%29.jpg', 1, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Bagel Bread', 'https://upload.wikimedia.org/wikipedia/commons/1/1d/Bagel-Plain-Alt.jpg', 1.25, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Strawberry', 'https://upload.wikimedia.org/wikipedia/commons/e/e1/Strawberries.jpg', 1.95, 0);
GO

INSERT INTO [dbo].[Products] ([Name], [ImageUrl], [Price], [CategoryId])
VALUES ('Baguette Bread', 'https://static.pexels.com/photos/416607/pexels-photo-416607.jpeg', 1.25, 0);
GO

--- CATEGORIES SEED ---

INSERT INTO [dbo].[Categories] ([Name])
VALUES ('Bread');
GO

INSERT INTO [dbo].[Categories] ([Name])
VALUES ('Dairy');
GO

INSERT INTO [dbo].[Categories] ([Name])
VALUES ('Fruits');
GO

INSERT INTO [dbo].[Categories] ([Name])
VALUES ('Seasonings and Spices');
GO

INSERT INTO [dbo].[Categories] ([Name])
VALUES ('Vegetables');
GO