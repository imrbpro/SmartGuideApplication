CREATE TABLE [dbo].[Brand] (
    [brand_id]    INT            NOT NULL,
    [brand_name]  NVARCHAR (50)  NULL,
    [shop_no]     NVARCHAR (MAX) NULL,
    [brand_owner] NVARCHAR (50)  NULL,
    [brand_logo]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED ([brand_id] ASC)
);

