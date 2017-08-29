CREATE TABLE [GMK].[tb_reclamo] (
    [codReclamo]         INT           NOT NULL,
    [descripcionReclamo] NVARCHAR (50) NULL,
    [fechaReclamo]       DATE          NULL,
    [codLocal]           INT           NULL,
    CONSTRAINT [PK_tb_reclamo] PRIMARY KEY CLUSTERED ([codReclamo] ASC)
);

