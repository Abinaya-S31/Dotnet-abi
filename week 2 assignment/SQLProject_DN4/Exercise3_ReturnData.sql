-- Step 1: Use your database
USE DN4_SQLProject;
GO

-- Step 2: Drop the procedure if it already exists
IF OBJECT_ID('GetHighEarners', 'P') IS NOT NULL
    DROP PROCEDURE GetHighEarners;
GO

-- Step 3: Create the procedure
CREATE PROCEDURE GetHighEarners
    @MinSalary INT
AS
BEGIN
    SELECT Id, Name, Department, Salary
    FROM Employees
    WHERE Salary > @MinSalary;
END;
GO

-- Step 4: Execute the procedure with sample input
EXEC GetHighEarners @MinSalary = 50000;
