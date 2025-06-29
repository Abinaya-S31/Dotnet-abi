-- Step 1: Use your project database
USE DN4_SQLProject;
GO

-- Step 2: Drop function if it exists
IF OBJECT_ID('dbo.GetTaxBySalary', 'FN') IS NOT NULL
    DROP FUNCTION dbo.GetTaxBySalary;
GO

-- Step 3: Create the scalar function
CREATE FUNCTION dbo.GetTaxBySalary (@Salary FLOAT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Tax FLOAT;
    SET @Tax = @Salary * 0.10;
    RETURN @Tax;
END;
GO

-- Step 4: Use the function in a SELECT query
SELECT Name, Department, Salary, 
       dbo.GetTaxBySalary(Salary) AS Tax
FROM Employees;
