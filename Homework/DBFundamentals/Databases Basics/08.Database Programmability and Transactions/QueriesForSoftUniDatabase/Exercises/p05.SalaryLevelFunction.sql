CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18, 4))
RETURNS CHAR(7)
BEGIN
	DECLARE @salaryLevel CHAR(7);
	IF(@salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low';
	END
	ELSE IF(@salary >= 30000 AND @salary <= 50000)
	BEGIN
		SET @salaryLevel = 'Average';
	END
	ELSE
		SET @salaryLevel = 'High';

    RETURN @salaryLevel;
END
