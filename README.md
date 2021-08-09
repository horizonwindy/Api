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
10. 
