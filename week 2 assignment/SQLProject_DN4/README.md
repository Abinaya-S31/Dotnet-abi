Exercise1_Ranking.sql

   Objective: Implement advanced windowing techniques using SQL ranking functions.

   Description: Applies ROW_NUMBER(), RANK(), and DENSE_RANK() to rank employees within each department based on descending salary.

   Technical Focus: Demonstrates partitioning (PARTITION BY) and sorting (ORDER BY) within window functions for grouped ranking scenarios.

Exercise2_StoredProcedure.sql

   Objective: Develop a parameterized stored procedure for department-specific data retrieval.

   Description: Creates a stored procedure GetEmployeesByDept that takes a department name as input and returns a filtered list of employees belonging to that department.

   Technical Focus: Emphasizes procedural abstraction, input parameter handling, and dynamic filtering via WHERE clauses.

Exercise3_ReturnData.sql

   Objective: Build a stored procedure to retrieve conditional datasets based on runtime inputs.

   Description: Defines GetHighEarners, a stored procedure that accepts a minimum salary threshold and returns employees whose salaries exceed this value.

   Technical Focus: Showcases numeric parameterization, conditional logic using WHERE, and runtime filtering of result sets.

ScalarFunction.sql

   Objective: Design and utilize a scalar-valued user-defined function for on-the-fly computations.

   Description: Implements GetTaxBySalary, a function that accepts a salary as input and returns 10% of it as tax. Integrated directly in SELECT queries.

   Technical Focus: Highlights reusable computation logic through scalar functions, parameterized return values, and seamless query integration.

