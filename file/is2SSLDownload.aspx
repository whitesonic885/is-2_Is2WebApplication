<%@ Page language="c#" Codebehind="is2SSLDownload.aspx.cs" AutoEventWireup="false" Inherits="is2WebApplication.is2SSLDownload" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ｉＳＴＡＲ－２ ルート証明書ダウンロード</title>
		<META http-equiv="Content-Type" content="text/html; charset=Shift_JIS">
		<META http-equiv="Content-Style-Type" content="text/css">
		<style type="text/css">
		</style>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<BODY link="#000000" bgColor="#ffffff">
		<P align="left"><FONT size="2"><A href="#top"><IMG height="35" src="is2-title-04.gif" width="450" border="0"></A></FONT></P>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" width="596" border="0">
				<TR>
					<TD vAlign="middle" bgColor="#cccccc" colSpan="2" height="24"><FONT size="2"><B>iSTAR-2 
								ルート証明書について</B></FONT></TD>
				</TR>
				<TR>
					<TD vAlign="bottom" align="left" colSpan="2" size="2"><BR>
						iSTAR-2では、SSLサーバ証明書を導入し入力された情報をSSL暗号化通信により保護しております。 
						SSLサーバ証明書発行元であるベリサイン社により2010年10月にルート証明書の仕様が変更されており、旧バージョンのブラウザ等をご利用の場合 
						i-STAR2を継続してご利用頂くにはベリサイン社が発行した新しいルート証明書をインストールして頂く必要があります。
						<BR>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD vAlign="middle" bgColor="#cccccc" colSpan="2" height="24"><FONT size="2"><B>iSTAR-2 
								ルート証明書ダウンロード</B></FONT></TD>
				</TR>
				<TR>
					<TD vAlign="bottom" align="left" colSpan="2" size="2"><BR>
						以下のルート証明書ファイルをダウンロードの上、証明書をインストールして下さい。
						<BR>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD vAlign="bottom" align="left" width="60%" size="2"><FONT color="#6600cc" size="4"><BR>
							<B>証明書インストール手順</B><BR>
							<BR>
						</FONT>
					</TD>
					<TD vAlign="middle" align="left" width="40%" size="2"><A href="VeriSignCA_G5.cer" type="application/octet-stream"></A>&nbsp;
						<asp:ImageButton id="btn証明書インストール手順ダウンロード" runat="server" ImageUrl="button.png"></asp:ImageButton>
					</TD>
				</TR>
				<TR>
					<TD vAlign="bottom" align="left" width="60%" size="2"><FONT color="#6600cc" size="4"><BR>
							<B>ルート証明書ファイル</B><BR>
							<BR>
						</FONT>
					</TD>
					<TD vAlign="middle" align="left" width="40%" size="2"><A href="VeriSignCA_G5.cer" type="application/octet-stream"></A>&nbsp;
						<asp:ImageButton id="btnルート証明書ファイルダウンロード" runat="server" ImageUrl="button.png"></asp:ImageButton>
					</TD>
				</TR>
			</TABLE>
		</form>
	</BODY>
</HTML>
