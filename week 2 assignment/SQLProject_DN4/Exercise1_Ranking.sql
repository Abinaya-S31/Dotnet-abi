USE DN4_SQLProject;
GO

-- Just view the results using ranking functions
SELECT Name, Department, Salary,
    ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum,
    RANK() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RankNum,
    DENSE_RANK() OVER(PARTITION BY Department ORDER BY Salary DESC) AS DenseRank
FROM Employees;
