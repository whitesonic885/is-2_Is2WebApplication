<%@ Page language="c#" Codebehind="is2LoginForm.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.LoginForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２ ユーザ専用ログインページ</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgcolor="#ffffff" MS_POSITIONING="PageLayout">
		<table width="540" border="0" cellpadding="0" cellspacing="0">
			<!--DWLayoutTable-->
			<tr align="left">
				<td height="35" colspan="2" valign="top"><img src="is2-title-01.gif" width="450" height="35"></td>
			</tr>
			<tr>
				<td width="445" height="35">&nbsp;</td>
				<td width="95">&nbsp;</td>
			</tr>
			<tr>
				<td height="133" valign="top"><p><font color="#330099" size="5"><strong>ようこそｉＳＴＡＲ-２ユーザ専用ページへ！</strong></font></p>
					<font color="#000000" size="2">まずお客様の認証をさせていただきます。<br>
						下記入力項目に別途、「ｉＳＴＡＲ-２スターターキット」に同送させていただきました<br>
						お客様の<strong><font color="#6600CC">お客様コード</font></strong>、<strong><font color="#6600CC">ユーザーコード</font></strong>、<strong><font color="#6600CC">パスワード</font></strong>を入力し、<font color="#6600CC"><strong>「ログイン」</strong></font>ボタンを<br>
						クリックしてください。
						<br>
						<br>
						パスワード入力の際はアルファベットの大文字・小文字を正しく入力していた<br>
						だきますよう、ご注意ください。</font>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td height="19">&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td height="198" valign="top">
					<form id="Form" method="post" target="_top" runat="server">
						<asp:image id="Image4" style="Z-INDEX: 113; LEFT: 100px; POSITION: relative; TOP: 0px" runat="server"
							ImageUrl="Web References/h7_02.gif" Height="10px" Width="8px"></asp:image>
						<asp:label id="lab会員コード" style="Z-INDEX: 101; LEFT: 110px; POSITION: relative; TOP: 7px" runat="server"
							Height="24" Width="135px" Font-Size="12pt" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#330099">お客様コード　</asp:label>
						<asp:textbox id="tex会員コード" style="Z-INDEX: 102; LEFT: 110px; POSITION: relative; TOP: 4px" tabIndex="1"
							runat="server" Height="26px" Width="128px" MaxLength="10" BorderColor="#330099" BorderWidth="2"></asp:textbox>
						<br>
						<br>
						<asp:image id="Image5" style="Z-INDEX: 114; LEFT: 100px; POSITION: relative; TOP: 0px" runat="server"
							ImageUrl="Web References/h7_02.gif" Height="10px" Width="8px"></asp:image>
						<asp:label id="lab利用者コード" style="Z-INDEX: 103; LEFT: 110px; POSITION: relative; TOP: 7px" runat="server"
							Height="24px" Width="135px" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#330099" Font-size="12pt">ユーザーコード</asp:label>
						<asp:textbox id="tex利用者コード" style="Z-INDEX: 105; LEFT: 110px; POSITION: relative; TOP: 4px" tabIndex="2"
							runat="server" Height="26px" Width="128px" MaxLength="10" BorderColor="#330099" BorderWidth="2"></asp:textbox>
						<br>
						<br>
						<asp:image id="Image6" style="Z-INDEX: 115; LEFT: 100px; POSITION: relative; TOP: 0px" runat="server"
							ImageUrl="Web References/h7_02.gif" Height="10px" Width="8px"></asp:image>
						<asp:label id="labパスワード" style="Z-INDEX: 106; LEFT: 110px; POSITION: relative; TOP: 7px" runat="server"
							Height="24px" Width="135px" Font-Size="12pt" Font-Names="ＭＳ ゴシック" Font-Bold="True" ForeColor="#330099">パスワード　</asp:label>
						<asp:textbox id="texパスワード" style="Z-INDEX: 107; LEFT: 110px; POSITION: relative; TOP: 4px" tabIndex="3"
							runat="server" Height="26px" Width="176px" MaxLength="20" TextMode="Password" BorderColor="#330099" BorderWidth="2"></asp:textbox>
						<br>
						<br>
						<br>
						<asp:button id="btnログイン" style="Z-INDEX: 108; LEFT: 200px; POSITION: relative" tabIndex="4"
							runat="server" ForeColor="Blue" Font-Bold="True" Font-Names="Impact" Width="56px" Height="32px"
							BackColor="PaleGreen" Text="ログイン"></asp:button>
						<br>
						<!--DWLayoutEmptyCell-->
						&nbsp;</form>
				</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td height="99">&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</table>
	</body>
</HTML>
