<%@ Page language="c#" Codebehind="is2MenuLogin.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2MenuLogin" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２　ユーザ専用メニューページ</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="PageLayout" background="file:///D:\IS2\webapp\is2WebApplication\Web References\e1_08.gif">
		<form id="Form1" method="post" runat="server" target="page">
			<asp:HyperLink id="hlマニュアル" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 104px; TEXT-ALIGN: center"
				runat="server" Width="170px" Font-Size="12pt" Height="30px" NavigateUrl="is2Manual.aspx" Target="page" BorderStyle="Outset">マニュアル</asp:HyperLink>
			<asp:HyperLink id="hlダウンロード" style="Z-INDEX: 105; LEFT: 16px; POSITION: absolute; TOP: 40px; TEXT-ALIGN: center"
				runat="server" Width="170px" Font-Size="12pt" Height="30px" NavigateUrl="is2PackageDownload.aspx" Target="page"
				BorderStyle="Outset">ダウンロード</asp:HyperLink>
		</form>
	</body>
</HTML>
