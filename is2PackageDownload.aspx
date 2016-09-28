<%@ Page language="c#" Codebehind="is2PackageDownload.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2PackageDownload" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>iSTAR-2 マニュアルダウンロードページ</title>
		<meta name="vs_snapToGrid" content="False">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body bgColor="#ffffff" MS_POSITIONING="PageLayout">
		<table border="0" cellSpacing="0" cellPadding="0" width="592">
			<!--DWLayoutTable-->
			<tr align="left">
				<td height="35" vAlign="top" colSpan="2"><IMG src="is2-title-02.gif" width="450" height="35"></td>
			</tr>
			<tr>
				<td height="35" width="445">&nbsp;</td>
				<td width="95">&nbsp;</td>
			</tr>
			<tr>
				<td height="40" vAlign="top">
					<p><font color="#6600cc"><asp:label style="Z-INDEX: 105; LEFT: 40px; POSITION: relative" id="lab会員名" Height="24px" Width="320px"
								ForeColor="#6600CC" runat="server"></asp:label><br>
							<asp:label style="Z-INDEX: 106; LEFT: 40px; POSITION: relative" id="lab利用者名" Height="24px"
								Width="320px" ForeColor="#6600CC" runat="server"></asp:label></font></p>
				</td>
			</tr>
			<tr>
				<td height="19">&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
			<tr>
				<td height="110" vAlign="top" colSpan="2">
					<p><font color="#330099" size="5"><strong>iSTAR-2のダウンロードにあたって</strong></font></p>
					<font color="#000000" size="2">iSTAR-2は.NETで開発しております。
						<br>
						iSTAR-2のインストール前に.NET Frameworkのインストールが必要です。
						<br>
						(既にインストール済の場合は必要ありません）
						<br>
						新SATO製（背面に緑の丸いシールが貼っている）は、Microsoft Windows 7 及び Vista で使用可能です。
						<br>
						Microsoft Windows 8 及び 8.1 は、[SATO CF-408T]及び[TEC B-EV4D]のみ使用可能です。</font>
				</td>
			</tr>
		</table>
		<form id="Form" method="post" target="_self" runat="server">
			<table border="2" cellSpacing="0" borderColor="#333333" cellPadding="0">
				<tr>
					<td>
						<table border="0" cellSpacing="0" cellPadding="0">
							<tr>
								<td height="0" width="40">&nbsp;</td>
								<td height="0" width="390" style="WIDTH: 390px">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" id="Image4" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top" style="WIDTH: 390px"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 15px" id="labパッケージダウンロード" Height="24px"
										Width="272px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック"> iSTAR-2パッケージダウンロード </asp:label></td>
								<td height="40" vAlign="top"><asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 8px" id="btnパッケージダウンロード" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></td>
								<td vAlign="top">&nbsp;</td>
							</tr>
							<tr>
								<td>&nbsp;</td>
								<td height="20" vAlign="top" colSpan="3"><FONT size="2" face="MS UI Gothic">※UAC設定変更時は、PC再起動後にインストールを行って下さい。</FONT>
									<asp:label id="labVista" ForeColor="#ffffff" runat="server" Font-Size="9pt"></asp:label></td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" id="Image1" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top" style="WIDTH: 390px"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 15px" id="labフレームワークダウンロード" Height="24px"
										Width="272px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">.NET Frameworkダウンロード </asp:label></td>
								<td height="40" vAlign="top"><asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 8px" id="btnフレームワークダウンロード" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></td>
								<td vAlign="top">&nbsp;</td>
							</tr>
							<tr>
								<td style="HEIGHT: 24px">&nbsp;</td>
								<td height="24" vAlign="top" colSpan="3" style="HEIGHT: 24px">
									<p><font color="#000000" size="2">.NET FrameworkはMicrosoft社の製品です</font></p>
								</td>
							</tr>
							<tr>
								<td height="39" vAlign="top" style="HEIGHT: 39px"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" id="Image11" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="39" vAlign="top" style="WIDTH: 390px; HEIGHT: 39px"><font color="#6600cc">.
										<asp:label id="Label5" runat="server" ForeColor="#6600CC" Width="387px" Height="31px" Font-Names="ＭＳ ゴシック"
											Font-Bold="True" Font-Size="12pt">.NET Framework1.1ServicePack1ダウンロード </asp:label></font></td>
								<TD style="HEIGHT: 39px" vAlign="top" width="120" height="39"><font color="#c000c0"> <a href="http://www.microsoft.com/ja-jp/download/confirmation.aspx?id=33" target="_blank">
											ダウンロード</a></font>
								</TD>
							</tr>
							<tr>
								<td height="10" colSpan="4">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0" cellSpacing="0" cellPadding="0">
							<tr>
								<td height="0" width="40">&nbsp;</td>
								<td height="0" width="360">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 6px" id="Image6" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 5px" id="Label1" Height="12px" Width="352px"
										ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">SATO製ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ [SATO CF-408T] </asp:label><BR>
									<BR>
									<font color="#000000" size="2">&nbsp;＜ CF408T：サーマルブラックプリンター／緑のシール無し ＞</font>
									<BR>
									<font color="#000000" size="2">&nbsp;※Microsoft Windows 7 及び 8 及び 8.1 対応</font>
									<BR>
									<img align="right" src="jpg/SATO_Black_M.png" width="100" height="100"> <img style="WIDTH: 128px; HEIGHT: 94px" align="right" src="jpg/SATO_Black_B.JPG" width="128"
										height="94">
								</td>
								<td height="40" vAlign="top"><FONT size="2">32bit 版</FONT>
									<BR>
									<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード４" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button><br>
									<br>
									<br>
									<font color="#000000" size="4">&nbsp;&nbsp;&nbsp;<STRONG> </STRONG></font>
								</td>
								<td height="40" vAlign="top">
									<P><FONT size="2"><FONT size="2">64bit 版</FONT>
											<BR>
											<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード５" tabIndex="4"
												Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></FONT></P>
								</td>
							<TR>
								<TD style="HEIGHT: 39px" height="39" colSpan="4">&nbsp;</FONT>
									<P><FONT face="MS UI Gothic"></FONT></P>
								</TD>
							<tr>
								<td height="10" colSpan="4">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0" cellSpacing="0" cellPadding="0">
							<tr>
								<td height="0" width="40">&nbsp;</td>
								<td height="0" width="360">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 6px" id="Image7" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 5px" id="labプリンタ設定ダウンロード０" Height="12px"
										Width="352px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">SATO製ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ  [SATO CS-408T] </asp:label><BR>
									<BR>
									<font color="#000000" size="2">&nbsp;＜ CS408T：サーマルブラックプリンター／緑のシール無し ＞</font>
									<BR>
									<font color="#000000" size="2">&nbsp;※Microsoft Windows Vista 及び 7 対応</font>
									<BR>
									<img align="right" src="jpg/SATO_Black_N.png" width="100" height="100"> <img align="right" src="jpg/SATO_Black_A.JPG">
								</td>
								<td height="40" vAlign="top"><FONT size="2">32bit 版</FONT>
									<BR>
									<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード０" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button><br>
									<br>
									<br>
									<font color="#000000" size="4">&nbsp;&nbsp;&nbsp;<b>※緑のシール無し</b></font>
								</td>
								<td height="40" vAlign="top"><FONT size="2">Windows7 64bit 版</FONT>
									<BR>
									<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード１" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></td>
							<tr>
								<td height="10" colSpan="4">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<table border="0" cellSpacing="0" cellPadding="0">
							<tr>
								<td height="0" width="40">&nbsp;</td>
								<td height="0" width="360">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 6px" id="Image2" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 5px" id="labプリンタ設定ダウンロード２" Height="12px"
										Width="352px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">SATO製ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ  [SATO ﾚｽﾌﾟﾘβ] </asp:label><BR>
									<BR>
									<font color="#000000" size="2">&nbsp;＜ L'espritβ：サーマルブラックプリンター／緑のシール有り ＞</font>
									<BR>
									<font color="#000000" size="2">&nbsp;※Microsoft Windows Vista 及び 7 対応</font>
									<BR>
									<font color="#000000" size="2">&nbsp;※旧ドライバは
										<asp:linkbutton id="lnkBtnSATO旧" ForeColor="#000000" runat="server" Font-Size="10pt">こちら</asp:linkbutton></font><img align="right" src="jpg/SATO_Blue_O.png" width="100" height="100">
									<img align="right" src="jpg/SATO_Blue_A.JPG">
								</td>
								<td height="40" vAlign="top"><FONT size="2">32bit 版</FONT>
									<BR>
									<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード２" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button><br>
									<br>
									<br>
									<br>
									<font color="#000000" size="4">&nbsp;&nbsp;&nbsp;<b>※緑のシール有り</b></font>
								</td>
								<td height="40" vAlign="top"><FONT size="2">Windows7 64bit 版</FONT>
									<BR>
									<asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード３" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></td>
							</tr>
							<tr>
								<td height="40" vAlign="top">&nbsp;</td>
								<td height="40" vAlign="top"><img align="right" src="jpg/SATO_Black_O.png" width="100" height="100">
									<img align="right" src="jpg/SATO_Black_A.JPG">
								</td>
								<td height="40" vAlign="top">&nbsp;</td>
								<td height="40" vAlign="top">&nbsp;</td>
							</tr>
							<tr>
								<td height="10" colSpan="4">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td>
						<TABLE border="0" cellSpacing="0" cellPadding="0">
							<tr>
								<td height="0" width="40">&nbsp;</td>
								<td height="0" width="360">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
								<td height="0" width="120">&nbsp;</td>
							</tr>
							<tr>
								<td height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 6px" id="Image3" Height="10px"
										Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></td>
								<td height="40" vAlign="top"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 5px" id="labプリンタ設定ダウンロード" Height="12px"
										Width="352px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">Zebra製ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ  [ZEBRA LP2844] </asp:label><BR>
									<BR>
									<font color="#000000" size="2">&nbsp;＜ LP2844：白色 ＞</font>
									<BR>
									<font color="#000000" size="2">&nbsp;※Microsoft Windows Vista 及び 7(32bit 版)対応</font>
									<BR>
									<img align="right" src="jpg/ZEBRA01.JPG">
								</td>
								<td height="40" vAlign="top"><asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード" tabIndex="4"
										Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></td>
								<td height="40" vAlign="bottom"></td>
							</tr>
							<tr>
								<td height="10" colSpan="4">&nbsp;</td>
							</tr>
						</TABLE>
					</td>
				</tr>
				<tr>
					<td><FONT face="MS UI Gothic">
							<TABLE id="Table1" border="0" cellSpacing="0" cellPadding="0">
								<TR>
									<TD height="0" width="40">&nbsp;</TD>
									<TD height="0" width="360">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
								</TR>
								<TR>
									<TD height="40" vAlign="top"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 6px" id="Image8" Height="10px"
											Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></TD>
									<TD height="40" vAlign="top"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 5px" id="Label2" Height="12px" Width="352px"
											ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">東芝TEC製ﾗﾍﾞﾙﾌﾟﾘﾝﾀﾄﾞﾗｲﾊﾞ [TEC B-EV4D] </asp:label><BR>
										<BR>
										<FONT color="#000000" size="2">&nbsp;＜ B-EV4D-GH17-R：グレー ＞</FONT>
										<BR>
										<font color="#000000" size="2">&nbsp;※Microsoft Windows 7 及び 8 及び 8.1 対応</font>
										<BR>
										<IMG align="right" src="jpg/TEC01.jpg">
									</TD>
									<TD height="40" vAlign="top"><asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 3px" id="btnプリンタ設定ダウンロード６" tabIndex="4"
											Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></TD>
									<TD height="40" vAlign="bottom"></TD>
								</TR>
								<TR>
									<TD height="10" colSpan="4">&nbsp;</TD>
								</TR>
							</TABLE>
						</FONT>
					</td>
				</tr>
				<TR>
					<TD><FONT face="MS UI Gothic">
							<table border="0" cellSpacing="0" cellPadding="0">
								<TR>
									<TD height="0" width="40">&nbsp;</TD>
									<TD height="0" width="360">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
								</TR>
								<TR>
									<TD height="20" vAlign="top" colSpan="4">
										<P><FONT color="#000000" size="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;※</FONT> <FONT color="#000000" size="2">
												プロキシ経由でのご利用で iSTAR-2がうまく動作しない場合には、プロキシ対応β版をお試しください。</FONT>
										</P>
									</TD>
								</TR>
								<TR>
									<TD height="40" vAlign="top" width="40"><asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" id="Image5" Height="10px"
											Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image></TD>
									<TD height="40" vAlign="top" width="271"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 15px" id="labパッケージプロキシ対応β版" Height="24px"
											Width="272px" ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">iSTAR-2ﾊﾟｯｹｰｼﾞ(ﾌﾟﾛｷｼ対応β版)</asp:label></TD>
									<TD height="40" vAlign="top" width="120"><asp:button style="Z-INDEX: 100; POSITION: relative; TOP: 8px" id="btnパッケージプロキシ対応β版" tabIndex="4"
											Height="32px" Width="99px" ForeColor="#C000C0" runat="server" Text="ダウンロード"></asp:button></TD>
									<TD vAlign="top">&nbsp;</TD>
								</TR>
								<TR>
									<TD height="10" colSpan="4">&nbsp;</TD>
								</TR>
							</table>
						</FONT>
					</TD>
				</TR>
				<tr>
					<TD><font face="MS UI Gothic">
							<table border="0" cellSpacing="0" cellPadding="0">
								<TR>
									<TD height="0" width="40">&nbsp;</TD>
									<TD height="0" width="360">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
									<TD height="0" width="120">&nbsp;</TD>
								</TR>
								<TR>
									<TD height="20" vAlign="top" colSpan="4">
										<P><FONT color="#000000" size="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;※</FONT> <FONT color="#000000" size="2">
												外部リンク</FONT>
										</P>
									</TD>
								</TR>
								<TR>
									<TD height="40" vAlign="top" width="40">
										<asp:image style="Z-INDEX: 110; LEFT: 20px; POSITION: relative; TOP: 16px" id="Image9" Height="10px"
											Width="8px" runat="server" ImageUrl="Web References/h7_02.gif"></asp:image>
									</TD>
									<TD height="40" vAlign="top" width="271"><asp:label style="Z-INDEX: 101; POSITION: relative; TOP: 15px" id="Label4" Height="24px" Width="272px"
											ForeColor="#6600CC" runat="server" Font-Size="12pt" Font-Bold="True" Font-Names="ＭＳ ゴシック">.NET Framework Cleanup Tool</asp:label></TD>
									<TD height="40" vAlign="top" width="120">
										<a href="http://blogs.msdn.com/cfs-file.ashx/__key/CommunityServer-Components-PostAttachments/00-08-90-44-93/dotnetfx_5F00_cleanup_5F00_tool.zip"
											target="_blank">ダウンロード</a>
									</TD>
									<TD vAlign="top">&nbsp;</TD>
								</TR>
								<TR>
									<TD colSpan="4">&nbsp;</TD>
								</TR>
								<TR>
									<TD>&nbsp;</TD>
									<TD colSpan="2"><A href="is2Main1.htm" target="_top"><asp:image style="Z-INDEX: 108; LEFT: 250px; POSITION: relative" id="Image10" Height="32px"
												Width="56px" runat="server" ImageUrl="./is2PackageDownload.aspx.back.jpg"></asp:image></A></TD>
									<TD>&nbsp;</TD>
								</TR>
								<TR>
									<TD height="10" colSpan="4">&nbsp;</TD>
								</TR>
							</table>
						</font>
					</TD>
				</tr>
			</table>
		</form>
	</body>
</HTML>
