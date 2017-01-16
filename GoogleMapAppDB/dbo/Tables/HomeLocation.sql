CREATE TABLE [dbo].[HomeLocation] (
    [ID]          INT           NOT NULL,
    [TipeRumah]   INT           NULL,
    [AlamatRumah] VARCHAR (MAX) NULL,
    [Latitude]    FLOAT (53)    NULL,
    [Longitude]   FLOAT (53)    NULL,
    CONSTRAINT [PK_HomeLocation] PRIMARY KEY CLUSTERED ([ID] ASC)
);

