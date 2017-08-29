CREATE TABLE [GMK].[tb_local] (
    [codLocal]           INT           IDENTITY (1, 1) NOT NULL,
    [nombreLocal]        NVARCHAR (50) NULL,
    [fechaAperturaLocal] DATE          NULL,
    [responsableLocal]   NVARCHAR (50) NULL,
    [distritoLocal]      NVARCHAR (50) NULL,
    [direccionLocal]     NVARCHAR (50) NULL,
    [latitudLocal]       NVARCHAR (50) NULL,
    [longitudLocal]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_tb_local] PRIMARY KEY CLUSTERED ([codLocal] ASC)
);

