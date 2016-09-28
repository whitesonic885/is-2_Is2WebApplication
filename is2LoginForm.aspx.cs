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
	/// [LoginForm]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.05.19 東都）高木 特定荷主のみのVista対応 
	//--------------------------------------------------------------------------
	// MOD 2008.12.25 東都）高木 パスワードチェックの強化 
	//--------------------------------------------------------------------------

	public class LoginForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lab会員コード;
		protected System.Web.UI.WebControls.TextBox texパスワード;
		protected System.Web.UI.WebControls.Label labパスワード;
		protected System.Web.UI.WebControls.TextBox tex利用者コード;
		protected System.Web.UI.WebControls.Label lab利用者コード;
		protected System.Web.UI.WebControls.Button btnログイン;
		protected System.Web.UI.WebControls.TextBox tex会員コード;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.HyperLink hl戻る;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Image Image1;
        protected System.Web.UI.HtmlControls.HtmlForm Form;
	
		// Ｗｅｂサービス変数
		protected static is2init.Service1  sv_is2init  = null;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// ページを初期化するユーザー コードをここに挿入します。
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
			this.btnログイン.Click += new System.EventHandler(this.btnログイン_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnログイン_Click(object sender, System.EventArgs e)
		{
			sv_is2init = new is2init.Service1();
			string[] sユーザ = new string[3];
			string[] sKey = new string[3];
			sKey[0] = tex会員コード.Text;
			sKey[1] = tex利用者コード.Text;
			sKey[2] = texパスワード.Text;
			string[] sRet = sv_is2init.login(sユーザ, sKey);
// MOD 2008.12.25 東都）高木 パスワードチェックの強化 START
//			if (sRet[0].Equals("正常終了"))
			if (sRet[0].Length == 4)
// MOD 2008.12.25 東都）高木 パスワードチェックの強化 END
			{
				Session["member"] = sRet[2];
				Session["user"] = sRet[4];
// ADD 2008.05.19 東都）高木 特定荷主のみのVista対応 START
				Session["membercd"] = sKey[0];
// ADD 2008.05.19 東都）高木 特定荷主のみのVista対応 END
//				Response.Redirect("is2PackageDownload.aspx");
				Response.Redirect("is2MainLogin.htm");
			}
			else
			{
				Session["message"] = sRet[0];
				Response.Redirect("is2MainError.htm");
			}
		}
	}
}
