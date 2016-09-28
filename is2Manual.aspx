<%@ Page language="c#" Codebehind="is2Manual.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2Manual" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳ-２ マニュアルページ</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" MS_POSITIONING="PageLayout">
		<INPUT type="hidden" name="info01" id="info01" runat="server"> <INPUT type="hidden" name="info02" id="info02" runat="server">
		<table cellSpacing="0" cellPadding="0" width="540" border="0">
			<!--DWLayoutTable-->
			<tr align="left">
				<td vAlign="top" colSpan="2" height="35"><IMG height="35" src="is2-title-02.gif" width="450"></td>
			</tr>
			<tr>
				<td width="445" height="35">
				&nbsp;
				<td width="95">&nbsp;</td>
			</tr>
			<tr>
				<td vAlign="top" height="40">
					<p><font color="#6600cc"><asp:label id="lab会員名" style="Z-INDEX: 105; LEFT: 40px; POSITION: relative" Height="24px" Width="350px"
								ForeColor="#6600CC" runat="server"></asp:label><br>
							<asp:label id="lab利用者名" style="Z-INDEX: 106; LEFT: 40px; POSITION: relative" Height="24px"
								Width="350px" ForeColor="#6600CC" runat="server"></asp:label></font></p>
				</td>
			</tr>
		</table>
		<form id="Form" method="post" target="_self" runat="server">
			<table cellSpacing="0" cellPadding="0" width="540" border="0">
				<tr>
					<td style="WIDTH: 36px" vAlign="top" width="36" height="40"><asp:image id="Image1" style="Z-INDEX: 110; LEFT: 16px; POSITION: relative; TOP: 16px" Height="10px"
							Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
					<td style="WIDTH: 290px" vAlign="top" width="290" height="40"><asp:label id="labマニュアルダウンロード" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px"
							Width="276px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">iSTAR-2操作ﾏﾆｭｱﾙﾀﾞｳﾝﾛｰﾄﾞ
						</asp:label></td>
					<td vAlign="top" width="220" height="40"><asp:button id="btnマニュアルダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							Height="32px" Width="203px" ForeColor="#C000C0" runat="server" Text="iSTAR-2操作ﾏﾆｭｱﾙﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></td>
				</tr>
				<tr>
					<td colSpan="3">&nbsp;</td>
				</tr>
				<tr>
					<td style="WIDTH: 36px" vAlign="top" width="36" height="40"><asp:image id="Image2" style="Z-INDEX: 110; LEFT: 16px; POSITION: relative; TOP: 16px" Height="10px"
							Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
					<td style="WIDTH: 290px" vAlign="top" width="290" height="40"><asp:label id="Label1" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px" Width="276px"
							ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" DESIGNTIMEDRAGDROP="37">iSTAR-2簡易版ﾏﾆｭｱﾙﾀﾞｳﾝﾛｰﾄﾞ
						</asp:label></td>
					<td vAlign="top" width="220" height="40"><asp:button id="btn簡易マニュアルダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							Height="32px" Width="204px" ForeColor="#C000C0" runat="server" Text="iSTAR-2簡易版ﾏﾆｭｱﾙﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></td>
				</tr>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 21px" vAlign="top" width="36" height="21"><FONT face="MS UI Gothic"></FONT></TD>
					<TD style="WIDTH: 290px; HEIGHT: 21px" vAlign="top" width="290" height="21"></TD>
					<TD style="HEIGHT: 21px" vAlign="top" width="220" height="21"></TD>
				</TR>
				<tr>
					<td style="WIDTH: 36px" vAlign="top" width="36" height="40"><asp:image id="Image4" style="Z-INDEX: 110; LEFT: 16px; POSITION: relative; TOP: 16px" Height="10px"
							Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
					<td style="WIDTH: 290px" vAlign="top" width="290" height="40"><asp:label id="Label5" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px" Width="276px"
							ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" DESIGNTIMEDRAGDROP="37">iSTAR-2ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ
						</asp:label></td>
					<td vAlign="top" width="220" height="40"><asp:button id="btnセットアップマニュアルダウンロード" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
							Height="32px" Width="204px" ForeColor="#C000C0" runat="server" Text="iSTAR-2ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></td>
				</tr>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 15px" vAlign="top" width="36" height="15"></TD>
					<TD style="HEIGHT: 15px" vAlign="top" width="220" height="15"><FONT face="MS UI Gothic"></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 39px" vAlign="top" width="36" height="39">
						<P align="center"><FONT face="MS UI Gothic"><asp:image id="Image3" style="Z-INDEX: 110; LEFT: 6px; POSITION: relative; TOP: 19px" Height="10px"
									Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></FONT></P>
					</TD>
					<TD style="WIDTH: 290px; HEIGHT: 39px" vAlign="top" width="290" height="39"><FONT face="MS UI Gothic"><asp:label id="Label2" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px" Width="276px"
								ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" DESIGNTIMEDRAGDROP="37">iSTAR-2再ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ
						</asp:label></FONT></TD>
					<TD style="HEIGHT: 39px" vAlign="top" width="220" height="39"><FONT face="MS UI Gothic"><asp:button id="btnis2ｾｯﾄｱｯﾌﾟ手順" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
								Height="32px" Width="204px" ForeColor="#C000C0" runat="server" Text="iSTAR-2再ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 19px" vAlign="top" width="36" height="19"></TD>
					<TD style="WIDTH: 290px; HEIGHT: 19px" vAlign="top" width="290" height="19"><FONT face="MS UI Gothic"></FONT></TD>
					<TD style="HEIGHT: 19px" vAlign="top" width="220" height="19"><FONT face="MS UI Gothic"></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 40px" vAlign="top" width="36" height="40">
						<P align="center"><asp:image id="Image5" style="Z-INDEX: 110; LEFT: 7px; POSITION: relative; TOP: 16px" Height="10px"
								Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></P>
					</TD>
					<TD style="WIDTH: 290px; HEIGHT: 40px" vAlign="top" width="290" height="40"><FONT face="MS UI Gothic"><asp:label id="Label3" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px" Width="286px"
								ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" DESIGNTIMEDRAGDROP="37">SATOﾌﾟﾘﾝﾀ再ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ
</asp:label></FONT></TD>
					<TD style="HEIGHT: 40px" vAlign="top" width="220" height="40"><FONT face="MS UI Gothic"><asp:button id="butSATOﾌﾟﾘﾝﾀ" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
								Height="32px" Width="203px" ForeColor="#C000C0" runat="server" Text="SATO再ｾｯﾄｱｯﾌﾟ手引きﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 19px" vAlign="top" width="36" height="19"></TD>
					<TD style="WIDTH: 290px; HEIGHT: 19px" vAlign="top" width="290" height="19"><FONT face="MS UI Gothic"></FONT></TD>
					<TD style="HEIGHT: 19px" vAlign="top" width="220" height="19"><FONT face="MS UI Gothic"></FONT></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 36px; HEIGHT: 40px" vAlign="top" width="36" height="40">
						<P align="center"><asp:image id="Image6" style="Z-INDEX: 110; LEFT: 7px; POSITION: relative; TOP: 16px" Height="10px"
								Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></P>
					</TD>
					<TD style="WIDTH: 290px; HEIGHT: 40px" vAlign="top" width="290" height="40"><FONT face="MS UI Gothic"><asp:label id="Label4" style="Z-INDEX: 101; POSITION: relative; TOP: 15px" Height="24px" Width="286px"
								ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック" DESIGNTIMEDRAGDROP="37">CF408TﾌﾟﾘﾝﾀLAN接続手引きﾀﾞｳﾝﾛｰﾄﾞ
</asp:label></FONT></TD>
					<TD style="HEIGHT: 40px" vAlign="top" width="220" height="40"><FONT face="MS UI Gothic"><asp:button id="btnCF408TLAN接続" style="Z-INDEX: 100; POSITION: relative; TOP: 8px" tabIndex="4"
								Height="32px" Width="234px" ForeColor="#C000C0" runat="server" Text="CF408TﾌﾟﾘﾝﾀLAN接続手引きﾀﾞｳﾝﾛｰﾄﾞ"></asp:button></FONT></TD>
				</TR>
				<tr>
					<td style="HEIGHT: 18px" colSpan="3">&nbsp;</td>
				</tr>
				<tr>
					<td colSpan="3">&nbsp;</td>
				</tr>
				<tr>
					<td style="WIDTH: 36px">&nbsp;</td>
					<td style="WIDTH: 290px">
						<a href="is2MainLogin.htm" target="_top">
							<asp:image id="is2Manual_aspx_back" style="Z-INDEX: 108; LEFT: 150px; POSITION: relative" Height="32px"
								Width="56px" runat="server" ImageUrl="./is2Manual.aspx.back.jpg"></asp:image></a>
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
