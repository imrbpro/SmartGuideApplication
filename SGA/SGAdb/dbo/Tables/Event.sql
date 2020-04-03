CREATE TABLE [dbo].[Event] (
    [event_id]       INT            NOT NULL,
    [shop_id]        INT            NULL,
    [brand_id]       INT            NULL,
    [event_name]     NVARCHAR (MAX) NULL,
    [event_details]  NVARCHAR (MAX) NULL,
    [event_datetime] DATETIME       NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([event_id] ASC),
    CONSTRAINT [FK_Brand_Event] FOREIGN KEY ([brand_id]) REFERENCES [dbo].[Brand] ([brand_id]),
    CONSTRAINT [FK_Shop_Event] FOREIGN KEY ([shop_id]) REFERENCES [dbo].[shop] ([shop_id])
);

