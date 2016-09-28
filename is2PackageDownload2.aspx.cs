using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace is2WebApplication
{
	/// <summary>
	/// is2PackageDownload の概要の説明です。
	/// </summary>
	public class is2PackageDownload2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink hlパッケージダウンロード;
		protected System.Web.UI.WebControls.HyperLink hl戻る;
		protected System.Web.UI.WebControls.Label lab会員名;
		protected System.Web.UI.WebControls.Label lab利用者名;
		protected System.Web.UI.WebControls.Button btnダウンロード;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.HyperLink hlﾌﾟﾘﾝﾀ設定ﾀﾞｳﾝﾛｰﾄﾞ;
		protected System.Web.UI.WebControls.Button btnダウンロード3;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image7;
		protected System.Web.UI.WebControls.HyperLink Hyperlink4;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button btnダウンロード4;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label Label4;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ページを初期化するユーザー コードをここに挿入します。
			if (Session["member"] != null && !Session["member"].ToString().Equals("") &&
				Session["user"]   != null && !Session["user"].ToString().Equals(""))
			{
				lab会員名.Text = Session["member"].ToString();
				lab利用者名.Text = Session["user"].ToString() + " 様";
			}
			else
			{
				Session["message"] = "";
				Server.Transfer("is2ErrorForm.aspx");
			}
		}

		#region Web フォーム デザイナで生成されたコード 
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: この呼び出しは、ASP.NET Web フォーム デザイナで必要です。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnダウンロード.Click += new System.EventHandler(this.btnダウンロード_Click);
			this.btnダウンロード4.Click += new System.EventHandler(this.btnダウンロード4_Click);
			this.btnダウンロード3.Click += new System.EventHandler(this.btnダウンロード3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnダウンロード_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
// MOD 2008.05.19 東都）高木 Vistaセットアッププログラム対応 START
//			Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
////			Response.WriteFile("D:\\Package\\is2Setup.msi");
//			Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
// MOD 2008.06.03 東都）高木 Vista対応の顧客制限の解除 START
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0
//				&& Session["membercd"] != null && !Session["membercd"].ToString().Equals("")
//			){
//				if(Session["membercd"].ToString().Equals("honbu")
//					|| Session["membercd"].ToString().Equals("9050879680")	// 三原美幸（有）殿
//				){
//					Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
//					Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
//				}else{
//					Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
//					Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
//				}
			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0)
			{
				Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
// MOD 2008.06.03 東都）高木 Vista対応の顧客制限の解除 END
			}else{
				Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
			}
// MOD 2008.05.19 東都）高木 Vistaセットアッププログラム対応 END
			Response.End();
		}

		private void btnダウンロード2_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual.pdf");
			Response.End();
		}

		private void btnダウンロード3_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";

// MOD 2005.05.31 東都）高木 プリンタドライバ名の変更 START
//			Response.AddHeader("content-disposition","attachment; filename=is2zlp2844.zip");
//			Response.WriteFile("D:\\is2\\webapp\\manual\\is2zlp2844.zip");
			Response.AddHeader("content-disposition","attachment; filename=printdev.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printdev.exe");
// MOD 2005.05.31 東都）高木 プリンタドライバ名の変更 END

			Response.End();
		}

		private void btnダウンロード4_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=dotnetfx.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\dotnetfx.exe");
			Response.End();
		}
	}
}
