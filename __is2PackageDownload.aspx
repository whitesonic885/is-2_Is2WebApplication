<%@ Page language="c#" Codebehind="is2PackageDownload.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2PackageDownload" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２　マニュアルダウンロードページ</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgcolor="#003399" MS_POSITIONING="PageLayout">
		<table width="540" border="0" cellpadding="0" cellspacing="0">
			<!--DWLayoutTable-->
			<tr align="left">
				<td height="35" colspan="2" valign="top"><img src="is2-title-02.gif" width="450" height="35"></td>
			</tr>
			<tr>
				<td width="445" height="35">&nbsp;</td>
				<td width="95">&nbsp;</td>
			</tr>
			<tr>
				<td height="40" valign="top"><p><font color="#ffcc00">
							<asp:label id="lab会員名" style="Z-INDEX: 105; LEFT: 40px; POSITION: relative" runat="server"
								ForeColor="#ffcc00" Width="350px" Height="24px"></asp:label>
							<br>
							<asp:label id="lab利用者名" style="Z-INDEX: 106; LEFT: 40px; POSITION: relative" runat="server"
								ForeColor="#ffcc00" Width="350px" Height="24px"></asp:label>
						</font>
					</p>
				</td>
			</tr>
			<tr>
				<td height="19">&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td height="110" valign="top"><p><font color="#ff9900" size="5"><strong>①ｉＳ-２のダウンロードにあたって</strong></font></p>
					<font color="#ffffff" size="2">ｉＳ-２は.NETで開発しております。<br>
						ｉＳ-２のインストール前に.NET Frameworkのインストールが必要です。<br>
						(既にインストール済の場合は必要ありません）</font>
				</td>
				<td>&nbsp;</td>
			</tr>
		</table>
		<form id="Form" method="post" runat="server" target="_top">
			<table width="540" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td height="40" width="40" valign="top">
						<asp:image id="Image4" style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" runat="server"
							Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
					</td>
					<td height="40" width="250" valign="top">
						<asp:label id="labパッケージダウンロード" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" runat="server"
							Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#FFCC00" Width="236px" Height="24px"
							Font-Size="12pt">iS-2パッケージダウンロード
					</asp:label>
					</td>
					<td height="40" width="250" valign="top">
						<asp:button id="btnパッケージダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text="iS-2パッケージダウンロード"></asp:button>
					</td>
                                        <td valign="top">&nbsp;</td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;</td>
				</tr>
				<tr>
					<td height="40" valign="top">
						<asp:image id="Image1" style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" runat="server"
							Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
					</td>
					<td height="40" valign="top">
						<asp:label id="labフレームワークダウンロード" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" runat="server"
							Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#FFCC00" Width="236px" Height="24px"
							Font-Size="12pt">.NET Frameworkダウンロード
					</asp:label>
					</td>
					<td height="40" valign="top">
						<asp:button id="btnフレームワークダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text=".NET Frameworkダウンロード"></asp:button>
					</td>
                                        <td valign="top">&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td height="20" colspan="2" valign="top"><p><font color="#ffffff" size="2">.NET 
								FrameworkはMicrosoft社の製品です</font></p>
					</td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;</td>
				</tr>
				<tr>
					<td height="40" valign="top">
						<asp:image id="Image2" style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" runat="server"
							Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
					</td>
					<td height="40" valign="top">
						<asp:label id="labプリンタ設定ダウンロード" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" runat="server"
							Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#FFCC00" Width="237px" Height="24px"
							Font-Size="12pt">iS-2 ﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ
					</asp:label>
					</td>
					<td height="40" valign="top">
						<asp:button id="btnプリンタ設定ダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							runat="server" ForeColor="#C000C0" Width="184px" Height="32px" Text="iS-2ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞﾀﾞウンロード"></asp:button>
					</td>
                                        <td valign="top">&nbsp;</td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;</td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>
						<asp:button id="btn戻る" style="Z-INDEX: 108; LEFT: 150px; POSITION: relative" tabIndex="4" runat="server"
							ForeColor="Blue" Font-Bold="True" Font-Names="Impact" Width="56px" Height="32px" BackColor="PaleGreen"
							Text="戻る"></asp:button>
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
