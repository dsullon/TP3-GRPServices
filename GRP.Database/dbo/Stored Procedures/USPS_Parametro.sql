
-- DROP PROCEDURE [dbo].[USPS_Parametro]
CREATE PROCEDURE [dbo].[USPS_Parametro]
	@codigo			int,
	@idAgrupador	int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	IF (@codigo <> 0)
	BEGIN
		SELECT	p.Codigo, 
				p.Nombre,
				p.Valor,
				p.CodigoGrupo,
				p.Grupo,
				p.Descripcion,
				p.ValueText1,
				p.ValueText2,
				p.ValueText3
		FROM Parametro P
		WHERE p.Id = @CODIGO;
	END
	ELSE
	BEGIN
		SELECT	p.Codigo, 
				p.Nombre,
				p.Valor,
				p.CodigoGrupo,
				p.Grupo,
				p.Descripcion,
				p.ValueText1,
				p.ValueText2,
				p.ValueText3
		FROM Parametro P
		WHERE P.CodigoGrupo = @idAgrupador;
		
	END
	
	Set @coderr = 0
	Set @msgerr = 'OK'

END TRY
BEGIN CATCH
	DECLARE @mensajeError as varchar(4000)
	DECLARE @codSeveridad as int
	DECLARE @codStatus as int

	Select @mensajeError = ERROR_MESSAGE(),
		   @codSeveridad = ERROR_SEVERITY(),
		   @codStatus = ERROR_STATE()
	
	set @coderr = 1
	set @msgerr = @mensajeError

	-- RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


