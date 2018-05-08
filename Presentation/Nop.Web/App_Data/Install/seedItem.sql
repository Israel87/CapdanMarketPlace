INSERT [dbo].[EmailTemplates] ([Id], [Name], [Code], [Body], [DateCreated], [IsDeleted], [IsActive]) VALUES (1, N'Welcome to VANHACK Forum Portal', N'Welc', N'<div style="background-color: #fafafa; color: #606060; font-family: Helvetica,Arial,sans-serif; font-size: 10px; line-height: 150%; text-align: left;"><center>
<table border="0" width="100%" cellspacing="0" cellpadding="0">
<thead>
<tr>
<th style="background-color: #ffffff; height: 40px; line-height: 40px; border-bottom: 2px solid #eaeaea; color: #999999; font-size: 13px;">Having problems viewing this email? <a href="#">Try it in text only.</a></th>
</tr>
</thead>
<tbody>
<tr>
<td style="padding: 30px 20px;" align="center"><img style="margin-bottom: 30px;" src="$LogoUrl$" width="32" height="31" />
<div>
<table style="background-color: #ffffff; border: 2px solid #eaeaea; border-radius: 5px;" width="592">
<tbody>
<tr>
<td style="padding: 30px;">
<table>
<tbody style="line-height: 1.35;">
<tr>
<td><span style="color: #555566; font-size: 21px; font-weight: bold;"> Welcome to VANHACK Forum&nbsp;Portal !</span></td>
</tr>
<tr>
<td style="padding: 20px 0; line-height: 1.45;"><span style="color: #555566; font-size: 14px; font-weight: normal;"> Hi {UserName} ,<br /> An account has being created&nbsp;for you on VANHACK Forum portal.<br /> Please find your login details below:<br /> Your Email Address : <strong>{Email}</strong><br /> Your User Name : <strong>{UserName}</strong><br /> </span></td>
</tr>
<tr>
<td style="padding: 20px 0; border-top: 2px solid #eaeaea; font-size: 14px; line-height: 1.45; color: #555566;">Please click on the link below to Setup &nbsp;password for your account on VANHACK Forum Portal;<br /> <a class="btn btn-success" href="{Url}"> Click Here</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</div>
</td>
</tr>
</tbody>
</table>
</center></div>', CAST(N'2016-10-10 15:56:51.080' AS DateTime), 0, 1)
INSERT [dbo].[EmailTemplates] ([Id], [Name], [Code], [Body], [DateCreated], [IsDeleted], [IsActive]) VALUES (3, N'FORGOT PASSWORD', N'F_PASSWORD', N'<div style="background-color: #fafafa; color: #606060; font-family: Helvetica,Arial,sans-serif; font-size: 10px; line-height: 150%; text-align: left;"><center>
<table border="0" width="100%" cellspacing="0" cellpadding="0">
<thead>
<tr>
<th style="background-color: #ffffff; height: 40px; line-height: 40px; border-bottom: 2px solid #eaeaea; color: #999999; font-size: 13px;">Having problems viewing this email? <a href="#">Try it in text only.</a></th>
</tr>
</thead>
<tbody>
<tr>
<td style="padding: 30px 20px;" align="center"><img style="margin-bottom: 30px;" src="$LogoUrl$" width="32" height="31" />
<div>
<table style="background-color: #ffffff; border: 2px solid #eaeaea; border-radius: 5px;" width="592">
<tbody>
<tr>
<td style="padding: 30px;">
<table>
<tbody style="line-height: 1.35;">
<tr>
<td><span style="color: #555566; font-size: 21px; font-weight: bold;">&nbsp;Password Reset</span></td>
</tr>
<tr>
<td style="padding: 20px 0; line-height: 1.45;"><span style="color: #555566; font-size: 14px; font-weight: normal;"> Hi {Name},<br /> We received a request to reset your password on VANHACK Forum Portal<br /> If you didn''t make the request, please disregard this email<br /> Your Username is <strong>{Email}</strong> </span></td>
</tr>
<tr>
<td style="padding: 20px 0; border-top: 2px solid #eaeaea; font-size: 14px; line-height: 1.45; color: #555566;">Please click on the link below to Setup a new password for your account on VANHACK Forum&nbsp;Portal;<br /> <a class="btn btn-success" href="{Url}"> Click Here</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</div>
</td>
</tr>
</tbody>
</table>
</center></div>', CAST(N'2017-03-03 00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[EmailTemplates] ([Id], [Name], [Code], [Body], [DateCreated], [IsDeleted], [IsActive]) VALUES (4, N'Discussion Notification', N'Discussion', N'<div style="background-color: #fafafa; color: #606060; font-family: Helvetica,Arial,sans-serif; font-size: 10px; line-height: 150%; text-align: left;"><center>
<table border="0" width="100%" cellspacing="0" cellpadding="0">
<thead>
<tr>
<th style="background-color: #ffffff; height: 40px; line-height: 40px; border-bottom: 2px solid #eaeaea; color: #999999; font-size: 13px;">Having problems viewing this email? <a href="#">Try it in text only.</a></th>
</tr>
</thead>
<tbody>
<tr>
<td style="padding: 30px 20px;" align="center"><img style="margin-bottom: 30px;" src="$LogoUrl$" width="32" height="31" />
<div>
<table style="background-color: #ffffff; border: 2px solid #eaeaea; border-radius: 5px;" width="592">
<tbody>
<tr>
<td style="padding: 30px;">
<table>
<tbody style="line-height: 1.35;">
<tr>
<td><span style="color: #555566; font-size: 21px; font-weight: bold;"> VANHACK Forum New Discussion Notification !</span></td>
</tr>
<tr>
<td style="padding: 20px 0; line-height: 1.45;"><span style="color: #555566; font-size: 14px; font-weight: normal;"> Hi {UserName} ,<br /> There is new discussion activity for the following on VANHACK Forum portal.<br /> Topic : <strong>{Topic}</strong><br /> Post : <strong>{Post}</strong><br />  Posted By : <strong>{PostedBy}</strong><br /> </span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</div>
</td>
</tr>
</tbody>
</table>
</center></div>', CAST(N'2017-12-27 14:40:45.440' AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[EmailTemplates] OFF
SET IDENTITY_INSERT [dbo].[EmailTokens] ON 

INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (4, N'Welc', N'{Url}', N'http://localhost:62055//Account/ResetPassword?userCode=UPF%2BmVKfM%2BQ%3D&code=vRNnM0dCGX2vEd%2FjD5gvN2R7GR55K1f51I7PY91bCXGH80Z3aLGf2opMYouxDe5hbnvJwnXdZZ0khJAu9cp56RRP7TIBhhfyLRPiP9BZOJfP1b%2Fj%2BQAw4NHoULtbd%2F5GyJ9ET0qebO7eF%2BlY1lH1bQ%3D%3D', CAST(N'2016-10-10 15:56:51.080' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (5, N'Welc', N'{Email}', N'ritaehizogie@yahoo.com', CAST(N'2016-10-10 15:56:51.080' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (6, N'Welc', N'{UserName}', N'ritaehizogie@yahoo.com', CAST(N'2016-10-10 15:56:51.080' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (7, N'F_PASSWORD', N'{Name}', N'fadipe ayobami', CAST(N'2017-03-03 00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (8, N'F_PASSWORD', N'{Email}', N'fadipehayy@yahoo.com', CAST(N'2017-03-03 00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (9, N'F_PASSWORD', N'{Url}', N'http://localhost:62055/Account/ResetPassword?userCode=LIqPtCSK~5Q=&code=BXwbv3Crvtoecbo0hPGvhuWWS1hgj+yfzGE/bVzgmP36sCrXI1x+jeSH6poFzrZBO3SXohxMkkABMvpmsam7FG2FaUKgNXaD8dzXwpDzJhLP2hLLOx1mQ2pfan4iRSC1iEErGmwzn52aDTfjk5cTpQ==', CAST(N'2016-06-30 17:20:32.277' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (10, N'Discussion', N'{UserName}', N'wedwew', CAST(N'2017-12-27 14:40:45.440' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (11, N'Discussion', N'{Topic}', N'sdsdd', CAST(N'2017-12-27 14:40:45.440' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (12, N'Discussion', N'{Post}', N'ddsdd', CAST(N'2017-12-27 14:40:45.440' AS DateTime), 0, 1)
INSERT [dbo].[EmailTokens] ([Id], [EmailCode], [Token], [PreviewText], [DateCreated], [IsDeleted], [IsActive]) VALUES (13, N'Discussion', N'{PostedBy}', N'{PostedBy}', CAST(N'2017-12-27 14:40:45.440' AS DateTime), 0, 1)
SET IDENTITY_INSERT [dbo].[EmailTokens] OFF