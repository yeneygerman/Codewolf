/* Write a query to print the
company_code, founder name, total number of lead managers, total number of senior managers, total number of managers, and total number of employees.
Order your output by ascending company_code.*/

SELECT
c.company_code,
c.founder,
COUNT(DISTINCT e.lead_manager_code) AS 'Lead Managers',
COUNT(DISTINCT e.senior_manager_code) AS 'Senior Managers',
COUNT(DISTINCT e.manager_code) AS 'Managers',
COUNT(DISTINCT e.employee_code) AS 'Employees'

FROM Employee e

INNER JOIN Company c
ON e.company_code = c.company_code

GROUP BY c.company_code, c.founder
ORDER BY c.company_code