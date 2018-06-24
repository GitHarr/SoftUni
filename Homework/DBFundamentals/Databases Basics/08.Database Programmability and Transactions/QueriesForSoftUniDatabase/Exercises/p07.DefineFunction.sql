CREATE FUNCTION ufn_IsWordComprised
(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX)) 
RETURNS BIT
BEGIN
	DECLARE @index INT = 1;
	DECLARE @currentChar CHAR(1);
	DECLARE @isComprised INT = 1;

	WHILE(@index <= LEN(@word))
	BEGIN
		SET @currentChar = SUBSTRING(@word, @index, 1);
		SET @isComprised = CHARINDEX(@currentChar, @setOfLetters);

		IF(@isComprised = 0)
		BEGIN
			RETURN 0;
		END

		SET @index += 1;
	END

	RETURN 1;

END