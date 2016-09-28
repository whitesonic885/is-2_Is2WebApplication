<%@ Page language="c#" Codebehind="is2Menu.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2Menu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２　メニューページ</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="file:///D:\IS2\webapp\is2WebApplication\Web References\e1_08.gif">
		<FORM id="Form" method="post" target="Main" runat="server">
			<asp:hyperlink id="hlプライバシ" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 232px; TEXT-ALIGN: center"
				runat="server" Width="170px" Height="30px" NavigateUrl="is2Top.htm" Target="_top" BorderStyle="Outset"
				Font-Size="12pt">プライバシーマーク</asp:hyperlink>
			<asp:hyperlink id="hl営業所検索" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 168px; TEXT-ALIGN: center"
				runat="server" Width="170px" Height="30px" NavigateUrl="is2Top.htm" Target="_top" BorderStyle="Outset"
				Font-Size="12pt">営業所検索</asp:hyperlink>
			<asp:hyperlink id="hl会員専用" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 104px; TEXT-ALIGN: center"
				runat="server" Width="170px" Height="30px" NavigateUrl="is2LoginForm.aspx" Target="Main" BorderStyle="Outset"
				Font-Size="12pt">会員専用</asp:hyperlink>
			<asp:hyperlink id="hlIS2" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 40px; TEXT-ALIGN: center"
				runat="server" Height="30px" Width="170px" NavigateUrl="is2HowTo.aspx" Target="Main" BorderStyle="Outset"
				Font-Size="12pt">ｉＳ-２とは</asp:hyperlink>
		</FORM>
	</body>
</HTML>
