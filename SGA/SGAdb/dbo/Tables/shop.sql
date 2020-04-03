CREATE TABLE [dbo].[shop] (
    [shop_id]        INT            IDENTITY (1, 1) NOT NULL,
    [shop_name]      NVARCHAR (50)  NOT NULL,
    [shop_owner]     NVARCHAR (50)  NOT NULL,
    [shop_longitude] NVARCHAR (50)  NOT NULL,
    [shop_latitude]  NVARCHAR (50)  NOT NULL,
    [shop_image]     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_shop] PRIMARY KEY CLUSTERED ([shop_id] ASC)
);

