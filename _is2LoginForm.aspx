<%@ Page language="c#" Codebehind="is2LoginForm.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.LoginForm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ－２　ログイン画面</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="PageLayout" background="file:///D:\IS2\webapp\is2WebApplication\Web References\e1_08.gif">
		<form id="Form" method="post" target="_top" runat="server">
			<FONT face="MS UI Gothic">
				<asp:label id="Label5" style="Z-INDEX: 111; LEFT: 200px; POSITION: absolute; TOP: 16px" runat="server"
					ForeColor="Black" Font-Bold="True" Font-Names="ＭＳ ゴシック" Width="280px" Height="11px" Font-Size="18pt">　is-2会員専用ページ</asp:label>
				<asp:image id="Image1" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
					Width="700px" Height="40px" ImageUrl="Web References\b7_03_d.gif"></asp:image>
				<br>
				<br>
				<br>
				<asp:label id="Label2" style="Z-INDEX: 116; LEFT: 112px; POSITION: relative" runat="server"
					ForeColor="MediumPurple" Font-Names="ＭＳ ゴシック" Width="488px" Height="24px" Font-Size="Large">ようこそ　ｉＳＴＡＲ-２会員専用ページへ！
				</asp:label>
				<br>
				<br>
				<br>
				<asp:label id="Label3" style="Z-INDEX: 117; LEFT: 104px; POSITION: relative" runat="server"
					Font-Names="ＭＳ ゴシック" Width="464px" Height="80px">　恐れ入りますが、まずはお客様の認証をさせていただきます。下記、入力項目に別途、ｉＳＴＡＲ-２スターターキットに同送させていただきましたお客様の会員コード、利用者コード、パスワードを入力し『ログイン』ボタンをクリックしてください。
				</asp:label>
				<br>
				<br>
				<br>
				<asp:label id="Label4" style="Z-INDEX: 118; LEFT: 112px; POSITION: relative" runat="server"
					Font-Names="ＭＳ ゴシック" Width="416px" Height="24px">パスワード入力の際はアルファベットの大文字・小文字を正しく入力していただきますよう、ご注意ください。
				</asp:label>
				<br>
				<br>
				<br>
				<asp:image id="Image4" style="Z-INDEX: 113; LEFT: 186px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
				<asp:label id="lab会員コード" style="Z-INDEX: 101; LEFT: 200px; POSITION: relative; TOP: 7px" runat="server"
					ForeColor="MediumPurple" Font-Bold="True" Font-Names="ＭＳ ゴシック" Font-Size="12pt" Width="105px"
					Height="24">会員コード　</asp:label>
				<asp:textbox id="tex会員コード" style="Z-INDEX: 102; LEFT: 220px; POSITION: relative; TOP: 7px" tabIndex="1"
					runat="server" Width="128px" Height="26px" MaxLength="10"></asp:textbox>
				<br>
				<br>
				<asp:image id="Image5" style="Z-INDEX: 114; LEFT: 186px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
				<asp:label id="lab利用者コード" style="Z-INDEX: 103; LEFT: 200px; POSITION: relative; TOP: 7px" runat="server"
					ForeColor="MediumPurple" Font-size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" Width="105px"
					Height="24px">利用者コード</asp:label>
				<asp:textbox id="tex利用者コード" style="Z-INDEX: 105; LEFT: 220px; POSITION: relative; TOP: 7px" tabIndex="2"
					runat="server" Width="128px" Height="26px" MaxLength="10"></asp:textbox>
				<br>
				<br>
				<asp:image id="Image6" style="Z-INDEX: 115; LEFT: 186px; POSITION: relative; TOP: 0px" runat="server"
					Width="8px" Height="10px" ImageUrl="Web References/h7_02.gif"></asp:image>
				<asp:label id="labパスワード" style="Z-INDEX: 106; LEFT: 200px; POSITION: relative; TOP: 7px" runat="server"
					ForeColor="MediumPurple" Font-Bold="True" Font-Names="ＭＳ ゴシック" Font-Size="12pt" Width="105px"
					Height="24px">パスワード　</asp:label>
				<asp:textbox id="texパスワード" style="Z-INDEX: 107; LEFT: 220px; POSITION: relative; TOP: 7px" tabIndex="3"
					runat="server" Width="128px" Height="26px" TextMode="Password" MaxLength="10"></asp:textbox>
				<br>
				<br>
				<br>
				<asp:button id="btnログイン" style="Z-INDEX: 108; LEFT: 340px; POSITION: relative" tabIndex="4"
					runat="server" ForeColor="Blue" Font-Bold="True" Font-Names="Impact" Width="56px" Height="32px"
					BackColor="PaleGreen" Text="ログイン"></asp:button>
				<br>
				<br>
				<br>
				<asp:hyperlink id="hl戻る" style="Z-INDEX: 119; LEFT: 350px; POSITION: relative" runat="server" Font-Bold="True"
					Font-Names="ＭＳ ゴシック" Width="48px" Height="24px" Font-Size="12pt" NavigateUrl="is2LoginForm.aspx">戻る</asp:hyperlink>
			</FONT>
		</form>
	</body>
</HTML>
