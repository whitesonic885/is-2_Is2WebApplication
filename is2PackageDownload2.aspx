<%@ Page language="c#" Codebehind="is2PackageDownload2.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2PackageDownload2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２　ダウンロードページ</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgcolor="#003399" MS_POSITIONING="PageLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="MS UI Gothic">
				<asp:image id="Image1" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
					Width="700px" Height="40px" ImageUrl="Web References\b7_03_d.gif"></asp:image><asp:label id="Label4" style="Z-INDEX: 126; LEFT: 224px; POSITION: absolute; TOP: 16px" runat="server"
					Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="Black" Width="313px" Height="11px" Font-Size="18pt">iS-2ダウンロードページ
				</asp:label><br>
				<br>
				<asp:label id="lab会員名" style="Z-INDEX: 105; LEFT: 40px; POSITION: relative" runat="server"
					ForeColor="Blue" Width="350px" Height="24px"></asp:label><br>
				<asp:label id="lab利用者名" style="Z-INDEX: 106; LEFT: 40px; POSITION: relative" runat="server"
					ForeColor="Blue" Width="350px" Height="24px"></asp:label><br>
				<br>
				<asp:label id="Label3" style="Z-INDEX: 117; LEFT: 88px; POSITION: relative" runat="server"
					Font-Names="ＭＳ ゴシック" Width="480px" Height="22px">ｉＳ-２のダウンロードにあたって</asp:label><br>
				<br>
				<asp:label id="Label2" style="Z-INDEX: 118; LEFT: 128px; POSITION: relative" runat="server"
					Font-Names="ＭＳ ゴシック" Width="440px" Height="68px">ｉＳ-２は.NETで開発しております。ｉＳ-２のインストール前に.NET Frameworkのインストールが必要です。(既にインストール済の場合は必要ありません）</asp:label><br>
				<br>
				<asp:image id="Image4" style="Z-INDEX: 110; LEFT: 128px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image><asp:hyperlink id="hlパッケージダウンロード" style="Z-INDEX: 101; LEFT: 144px; POSITION: relative; TOP: 7px"
					runat="server" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#C000C0" Width="265px" Height="24px" Font-Size="12pt">iS-2パッケージダウンロード　</asp:hyperlink>
				<asp:button id="btnダウンロード" style="Z-INDEX: 108; LEFT: 160px; POSITION: relative; TOP: 7px" tabIndex="4"
					runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text="iS-2パッケージダウンロード"></asp:button>
				<br>
				<br>
				<br>
				<asp:image id="Image7" style="Z-INDEX: 121; LEFT: 128px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
				<asp:hyperlink id="Hyperlink4" style="Z-INDEX: 122; LEFT: 144px; POSITION: relative; TOP: 7px"
					runat="server" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#C000C0" Width="265px" Height="24px"
					Font-Size="12pt">.NET Frameworkダウンロード</asp:hyperlink>
				<asp:button id="btnダウンロード4" style="Z-INDEX: 123; LEFT: 160px; POSITION: relative; TOP: 7px"
					tabIndex="4" runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text=".NET Frameworkダウンロード"></asp:button>
				<br>
				<br>
				<asp:label id="Label1" style="Z-INDEX: 125; LEFT: 192px; POSITION: relative" runat="server"
					Font-Names="ＭＳ ゴシック" Width="440px" Height="20px">.NET FrameworkはMicrosoft社の製品です</asp:label>
				<br>
				<br>
				<asp:image id="Image6" style="Z-INDEX: 115; LEFT: 128px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
				<asp:hyperlink id="hlﾌﾟﾘﾝﾀ設定ﾀﾞｳﾝﾛｰﾄﾞ" style="Z-INDEX: 114; LEFT: 144px; POSITION: relative; TOP: 7px"
					runat="server" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#C000C0" Width="265px" Height="24px"
					Font-Size="12pt">iS-2 ﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ</asp:hyperlink>
				<asp:button id="btnダウンロード3" style="Z-INDEX: 116; LEFT: 160px; POSITION: relative; TOP: 7px"
					tabIndex="4" runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text="iS-2ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞﾀﾞウンロード"></asp:button>
				<br>
				<br>
				<br>
				<asp:hyperlink id="hl戻る" style="Z-INDEX: 104; LEFT: 304px; POSITION: relative" runat="server" Height="24px"
					Width="48px" NavigateUrl="is2Main.htm" Font-Names="ＭＳ ゴシック" Font-Bold="True" Target="_top"
					Font-Size="12pt">戻る</asp:hyperlink></FONT></form>
	</body>
</HTML>
