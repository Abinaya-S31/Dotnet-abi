-- Use your project database
USE DN4_SQLProject;
GO

-- Drop the procedure if it already exists
IF OBJECT_ID('GetEmployeesByDept', 'P') IS NOT NULL
    DROP PROCEDURE GetEmployeesByDept;
GO

-- Create the stored procedure
CREATE PROCEDURE GetEmployeesByDept
    @DeptName NVARCHAR(50)
AS
BEGIN
    SELECT Id, Name, Department, Salary
    FROM Employees
    WHERE Department = @DeptName;
END;
GO

-- ✅ Example: Execute the procedure
EXEC GetEmployeesByDept @DeptName = 'IT';
