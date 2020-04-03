CREATE TABLE [dbo].[Product] (
    [product_id]    INT            NOT NULL,
    [shop_id]       INT            NULL,
    [brand_id]      INT            NULL,
    [product_name]  NVARCHAR (50)  NULL,
    [product_color] NVARCHAR (50)  NULL,
    [product_image] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([product_id] ASC),
    CONSTRAINT [FK_Brand_Product] FOREIGN KEY ([brand_id]) REFERENCES [dbo].[Brand] ([brand_id]),
    CONSTRAINT [FK_shop_product] FOREIGN KEY ([shop_id]) REFERENCES [dbo].[shop] ([shop_id])
);

