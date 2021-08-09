# Api
 1. Program1.Program.cs
 2. Program2.Program.cs
 3. Program3.Program.cs
 4. Program4.Program.cs
 5. SELECT * FROM  [dbo].[LKPROVINCE] WHERE [PROVINCE_NAME] Like N'กรุง%' ORDER BY [UpdateDate] DESC
 6. DELETE FROM [dbo].[LKPROVICE] WHERE [PROVINCE_ID] > 10
 7. SELECT LEFT([PROVINCE_NAME],1) AS SubName FROM [dbo].[LKPROVINCE]  WHERE [PROVINCE_NAME] IS NOT NULL
 8. UPDATE  [dbo].[LKPROVINCE] SET [UpdateDate] = GETDATE() WHERE [PROVINCE_NAME] = N'กรุงเทพมหานคร'
 9. INSERT INTO [dbo].[LKPROVINCE] ([PROVINCE_ID],[PROVINCE_NAME],[CreateBy] ,[CreateDate]) VALUES(10,N'กรุงเทพมหานคร',N'system',GETDATE())
10. SELECT C.[MS_CUS_ID],C.[MS_CUS_ID],P.[PROVINCE_NAME]  FROM [dbo].[MS_CUSTOMER] AS C INNER JOIN  [dbo].[LKPROVINCE] AS P ON C.[PROVINCE_ID] = P.[PROVINCE_ID]
11. SELECT Emp_Name,
	   Dept_Name,
	   Salary
FROM (

SELECT E.Emp_Name,
	   D.Dept_Name,
	   E.Salary,
	   ROW_NUMBER() OVER (
		  PARTITION BY E.Dept_ID
      ORDER BY E.Salary DESC
	   ) row_num
FROM [EMP] AS E
INNER JOIN [DEP] AS D
ON E.Dept_ID = D.Dept_ID AND D.[Location] <> 'LA'
) AS R.row_num = 1
12.SELECT Emp_Name,
	   Dept_Name,
	   Salary
FROM (

SELECT E.Emp_Name,
	   D.Dept_Name,
	   E.Salary,
	   ROW_NUMBER() OVER (
		  PARTITION BY E.Dept_ID
      ORDER BY E.Salary DESC
	   ) row_num
FROM [EMP] AS E
INNER JOIN [DEP] AS D
ON E.Dept_ID = D.Dept_ID AND D.[Location] <> 'LA'
) AS R.row_num = 2
