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
	/// [is2Manual]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2009.10.22 東都）高木 ダウンードエラー画面の変更 
	//--------------------------------------------------------------------------
	// ADD 2016.04.11 BEVAS）松本 CF408TプリンタLAN接続手引きダウンロード機能の追加 
	//--------------------------------------------------------------------------
	public class is2Manual : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Button btnダウンロード;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label labマニュアルダウンロード;
		protected System.Web.UI.WebControls.Button btnマニュアルダウンロード;
		protected System.Web.UI.WebControls.Label lab会員名;
		protected System.Web.UI.WebControls.Label lab利用者名;
		protected System.Web.UI.WebControls.Button btn簡易マニュアルダウンロード;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Button btnis2ｾｯﾄｱｯﾌﾟ手順;
		protected System.Web.UI.WebControls.Button butSATOﾌﾟﾘﾝﾀ;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Button btnセットアップマニュアルダウンロード;
		protected System.Web.UI.WebControls.Image imgManual_back;
		protected System.Web.UI.WebControls.Image is2Manual_aspx_back;
		protected System.Web.UI.HtmlControls.HtmlInputHidden info01;
		protected System.Web.UI.HtmlControls.HtmlInputHidden info02;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Button btnCF408TLAN接続;
		protected System.Web.UI.WebControls.Button btn戻る;
	
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
//				Session["message"] = "";
				Session["message"] = "１５分以上接続がなかった為、切断されました。<BR>"
								   + "再度ログインを行ってください。";
// MOD 2009.10.22 東都）高木 ダウンードエラー画面の変更 END
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
			this.btnマニュアルダウンロード.Click += new System.EventHandler(this.btnマニュアルダウンロード_Click);
			this.btn簡易マニュアルダウンロード.Click += new System.EventHandler(this.btn簡易マニュアルダウンロード_Click);
			this.btnセットアップマニュアルダウンロード.Click += new System.EventHandler(this.btnセットアップマニュアルダウンロード_Click);
			this.btnis2ｾｯﾄｱｯﾌﾟ手順.Click += new System.EventHandler(this.btnis2ｾｯﾄｱｯﾌﾟ手順_Click);
			this.butSATOﾌﾟﾘﾝﾀ.Click += new System.EventHandler(this.butSATOﾌﾟﾘﾝﾀ_Click);
			this.btnCF408TLAN接続.Click += new System.EventHandler(this.btnCF408TLAN接続_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn戻る_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("is2Main.htm");
		}

		private void btnマニュアルダウンロード_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual.pdf");
			Response.End();
		}
		private void btnセットアップマニュアルダウンロード_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2Setuptebiki.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2Setuptebiki.pdf");
			Response.End();
		}
		private void btn簡易マニュアルダウンロード_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual_kani.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual_kani.pdf");
			Response.End();
		}

		private void btnis2ｾｯﾄｱｯﾌﾟ手順_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is-2saisetup.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is-2saisetup.pdf");
			Response.End();
		}

		private void butSATOﾌﾟﾘﾝﾀ_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=satosetup.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\satosetup.pdf");
			Response.End();
		}

// ADD 2016.04.11 BEVAS）松本 CF408TプリンタLAN接続手引きダウンロード機能の追加 START
		private void btnCF408TLAN接続_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=CF408TLANmanual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\CF408TLANmanual.pdf");
			Response.End();
		}
// ADD 2016.04.11 BEVAS）松本 CF408TプリンタLAN接続手引きダウンロード機能の追加 END
	}
}
