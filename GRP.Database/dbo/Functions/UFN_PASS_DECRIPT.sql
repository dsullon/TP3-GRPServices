
/**************************************/
/************ Funciones  **************/
/**************************************/

-- DROP FUNCTION UFN_PASS_DECRIPT
CREATE FUNCTION [dbo].[UFN_PASS_DECRIPT](@PASS VARBINARY(8000)) RETURNS VARCHAR(50) 
--
BEGIN
	
	DECLARE @D_PASS AS VARCHAR(50)

	SET @D_PASS = DECRYPTBYPASSPHRASE('Encript0110', @PASS)

	RETURN @D_PASS

END


