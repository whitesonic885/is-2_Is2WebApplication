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
	/// [is2PackageDownload]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2008.12.09 東都）高木 Window7 対応 
	//--------------------------------------------------------------------------
	// MOD 2009.10.22 東都）高木 ダウンードエラー画面の変更 
	//--------------------------------------------------------------------------
	// MOD 2010.11.25 東都）高木 SATOドライバの変更 
	//--------------------------------------------------------------------------
	// MOD 2013.04.11 TDI）綱澤 SATOドライバの追加(CF408T) 
	//--------------------------------------------------------------------------
	// MOD 2015.01.27 BEVAS) 前田　.NET Framework1.1 ServicePach1ダウンロード追加
	//--------------------------------------------------------------------------

	public class is2PackageDownload : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Label lab会員名;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label labフレームワークダウンロード;
		protected System.Web.UI.WebControls.Button btnフレームワークダウンロード;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label labプリンタ設定ダウンロード;
		protected System.Web.UI.WebControls.Button btn戻る;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード２;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Label labVista;
		protected System.Web.UI.WebControls.Label labパッケージダウンロード;
		protected System.Web.UI.WebControls.Button btnパッケージダウンロード;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Label labパッケージプロキシ対応β版;
		protected System.Web.UI.WebControls.Button btnパッケージプロキシ対応β版;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.Image imgBack;
		protected System.Web.UI.WebControls.LinkButton lnkBtnSATO旧;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード３;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード;
		protected System.Web.UI.WebControls.Label labプリンタ設定ダウンロード０;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード１;
		protected System.Web.UI.WebControls.Image Image7;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード０;
		protected System.Web.UI.WebControls.Label labプリンタ設定ダウンロード２;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード４;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード５;
		protected System.Web.UI.WebControls.Button btnプリンタ設定ダウンロード６;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image8;
		protected System.Web.UI.WebControls.Image Image10;
		protected System.Web.UI.WebControls.Image Image9;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Button btnダウンロードdotClean;
		protected System.Web.UI.WebControls.Image Image11;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Button btnDotNet11SP1ダウンロード;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label lab利用者名;
	
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
// MOD 2009.10.22 東都）高木 ダウンードエラー画面の変更 START
//				Session["message"] = "ログインするにはCookieの受け入れが必要です。<BR>ブラウザの設定を変更してください。";
				Session["message"] = "１５分以上接続がなかった為、切断されました。<BR>"
								   + "再度ログインを行ってください。";
// MOD 2009.10.22 東都）高木 ダウンードエラー画面の変更 END
				Server.Transfer("is2ErrorForm.aspx");
			}
// MOD 2008.12.09 東都）高木 Window7 対応 START
////20070122 START TTD)Y.IGA Vista対応 
//			if (Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") == -1)
//			{
//				this.btnパッケージダウンロード.Enabled = true;
//			}
//			else
//			{
//// MOD 2008.05.19 東都）高木 Vistaセットアッププログラム対応 START
////				this.btnパッケージダウンロード.Enabled = false;
////				this.labVista.Text = "現時点で、iS-2は、ご使用中のＯＳに対応しておりません。";
//// MOD 2008.06.03 東都）高木 Vista対応の顧客制限の解除 START
////				if(Session["membercd"] != null && !Session["membercd"].ToString().Equals(""))
////				{
////					if(Session["membercd"].ToString().Equals("honbu")
////						|| Session["membercd"].ToString().Equals("9050879680")	// 三原美幸（有）殿
////					){
////						this.btnパッケージダウンロード.Enabled = true;
////					}else{
////						this.btnパッケージダウンロード.Enabled = false;
////						this.labVista.Text = "現時点で、iS-2は、ご使用中のＯＳに対応しておりません。";
////					}
////				}else{
////					this.btnパッケージダウンロード.Enabled = false;
////					this.labVista.Text = "現時点で、iS-2は、ご使用中のＯＳに対応しておりません。";
////				}
//// MOD 2008.05.19 東都）高木 Vistaセットアッププログラム対応 END
//				this.btnパッケージダウンロード.Enabled = true;
//				this.labVista.Text = "現時点で、iS-2は、ご使用中のＯＳに対応しておりません。";
//// MOD 2008.06.03 東都）高木 Vista対応の顧客制限の解除 END
//			}
////20070122 END   TTD)Y.IGA Vista対応 
// MOD 2008.12.09 東都）高木 Window7 対応 END
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
			this.btnパッケージダウンロード.Click += new System.EventHandler(this.btnパッケージダウンロード_Click);
			this.btnフレームワークダウンロード.Click += new System.EventHandler(this.btnフレームワークダウンロード_Click);
			this.btnプリンタ設定ダウンロード４.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード４_Click);
			this.btnプリンタ設定ダウンロード５.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード５_Click);
			this.btnプリンタ設定ダウンロード０.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード０_Click);
			this.btnプリンタ設定ダウンロード１.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード１_Click);
			this.lnkBtnSATO旧.Click += new System.EventHandler(this.lnkBtnSATO旧_Click);
			this.btnプリンタ設定ダウンロード２.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード２_Click);
			this.btnプリンタ設定ダウンロード３.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード３_Click);
			this.btnプリンタ設定ダウンロード.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード_Click);
			this.btnプリンタ設定ダウンロード６.Click += new System.EventHandler(this.btnプリンタ設定ダウンロード６_Click);
			this.btnパッケージプロキシ対応β版.Click += new System.EventHandler(this.btnパッケージプロキシ対応β版_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnパッケージダウンロード_Click(object sender, System.EventArgs e)
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
// MOD 2008.12.09 東都）高木 Window7 対応 START
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0){
			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.") >= 0){
// MOD 2008.12.09 東都）高木 Window7 対応 END
				Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
			}else{
				Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
			}
// MOD 2008.05.19 東都）高木 Vistaセットアッププログラム対応 END
			Response.End();
		}

		private void btnプリンタ設定ダウンロード_Click(object sender, System.EventArgs e)
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

// MOD 2006.09.25 FJCS）山内 プリンタドライバ２追加 START
		private void btnプリンタ設定ダウンロード２_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat.exe");
			Response.End();
		}
// MOD 2006.09.25 FJCS）山内 プリンタドライバ追加 END

// MOD 2011.05.18 東都）高木 プリンタドライバ３追加 START
		private void btnプリンタ設定ダウンロード３_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat_64.exe");
			Response.End();
		}
// MOD 2011.05.18 東都）高木 プリンタドライバ３追加 END

		private void btnフレームワークダウンロード_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=dotnetfx.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\dotnetfx.exe");
			Response.End();
		}

		// MOD 2011.12.08 FJCS）野村 プリンタドライバ０,１追加 START
		private void btnプリンタ設定ダウンロード０_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcs408t.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcs408t.exe");
			Response.End();
		}

		private void btnプリンタ設定ダウンロード１_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcs408t_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcs408t_64.exe");
			Response.End();
		}
		// MOD 2011.12.08 FJCS）野村 プリンタドライバ追加 END

// MOD 2013.04.11 TDI）綱澤 SATOドライバの追加(CF408T)  START
		private void btnプリンタ設定ダウンロード４_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcf408t.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcf408t.exe");
			Response.End();
		}

		private void btnプリンタ設定ダウンロード５_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcf408t_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcf408t_64.exe");
			Response.End();
		}
// MOD 2013.04.11 TDI）綱澤 SATOドライバの追加(CF408T)  END

// MOD 2009.08.20 東都）高木 プロキシ対応 START
		private void btnパッケージプロキシ対応β版_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0)
//			{
//				Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
//				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
//			}
//			else
			{
				Response.AddHeader("content-disposition","attachment; filename=is2SetupProxy.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupProxy.msi");
			}
			Response.End();
		}
// MOD 2009.08.20 東都）高木 プロキシ対応 END

		private void btn戻る_Click(object sender, System.EventArgs e)
		{
//			this.Response.Redirect("is2Main.htm");
		}
// MOD 2010.11.25 東都）高木 SATOドライバの変更 START
		private void lnkBtnSATO旧_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat_T070901.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat_T070901.exe");
			Response.End();
		}
// MOD 2010.11.25 東都）高木 SATOドライバの変更 END

// MOD 2013.10.23 TDI）綱澤 東芝TECドライバの追加(B-EV4D)  START
		private void btnプリンタ設定ダウンロード６_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=TEC-Fukuyama_732_M-2.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\TEC-Fukuyama_732_M-2.exe");
			Response.End();
		}


// MOD 2013.10.23 TDI）綱澤 東芝TECドライバの追加(B-EV4D)  END

	}
}
