CREATE TABLE [dbo].[Promotion] (
    [promotion_id]      INT            NOT NULL,
    [promotion_name]    NVARCHAR (MAX) NULL,
    [promotion_details] NVARCHAR (MAX) NULL,
    [brand_id]          INT            NULL,
    [shop_id]           INT            NULL,
    [startdate]         DATETIME       NULL,
    [endtdate]          DATETIME       NULL,
    CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED ([promotion_id] ASC),
    CONSTRAINT [FK_Brand_Promotion] FOREIGN KEY ([brand_id]) REFERENCES [dbo].[Brand] ([brand_id]),
    CONSTRAINT [FK_Shop_Promotion] FOREIGN KEY ([shop_id]) REFERENCES [dbo].[shop] ([shop_id])
);

