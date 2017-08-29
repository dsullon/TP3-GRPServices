
-- DROP PROCEDURE [dbo].[USPS_OpcionXPerfil]
CREATE PROCEDURE [dbo].[USPS_OpcionXPerfil]
	@idapp			int,
	@idperfil		int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT	OP.OpcionId,
			O.Nombre as Opcion,
			OP.AplicacionId,
			A.Descripcion as Aplicacion,
			OP.PerfilId,
			P.Nombre as Perfil,
			OP.Escritura
	FROM OpcionPerfil OP
		INNER JOIN Aplicacion A ON OP.AplicacionId = A.Id
		INNER JOIN Perfil P ON OP.PerfilId = P.Id
		INNER JOIN Opcion O ON OP.OpcionId= O.Id
	WHERE ((@idapp = -1) OR (OP.AplicacionId = @idapp))
	AND ((@idperfil = -1) OR (OP.PerfilId = @idperfil))
	order by O.orden
	
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


