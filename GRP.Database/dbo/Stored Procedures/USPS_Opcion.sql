
-- DROP PROCEDURE [dbo].[USPS_Opcion]
CREATE PROCEDURE [dbo].[USPS_Opcion]
	@idOpcion		int,
	@idapp			int,
	@estado			int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT	O.Id,
			O.AplicacionId,
			A.Descripcion as Aplicacion,
			O.Nombre,
			O.PadreId,
			O.Nivel,
			O.NivelPadre,
			O.Imagen,
			O.Controler,
			O.Accion,
			O.Orden,
			O.Observacion,
			O.Estado
	FROM Opcion O
		INNER JOIN Aplicacion A ON o.AplicacionId = A.Id
	WHERE ((@idOpcion = -1) OR (O.Id = @idOpcion)) 
	AND ((@idapp = -1) OR (O.AplicacionId = @idapp))
	AND ((@estado = -1) OR (O.Accion = @estado))
	
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

	--RAISERROR(@mensajeError, @codSeveridad, @codStatus)
END CATCH


