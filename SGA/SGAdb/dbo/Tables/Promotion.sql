CREATE TABLE [dbo].[Promotion] (
    [promotion_id]      INT            NOT NULL,
    [promotion_name]    NVARCHAR (50)  NOT NULL,
    [promotion_details] NVARCHAR (MAX) NULL,
    [brand_id]          INT            NOT NULL,
    [shop_id]           INT            NOT NULL,
    [startdate]         DATETIME       NOT NULL,
    [endtdate]          DATETIME       NOT NULL,
    [Promo_code]        NVARCHAR (50)  NOT NULL,
    [isShop]            BIT            NOT NULL,
    [isBrand]           BIT            NOT NULL,
    CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED ([promotion_id] ASC),
    CONSTRAINT [FK_Brand_Promotion] FOREIGN KEY ([brand_id]) REFERENCES [dbo].[Brand] ([brand_id]),
    CONSTRAINT [FK_Shop_Promotion] FOREIGN KEY ([shop_id]) REFERENCES [dbo].[shop] ([shop_id])
);



