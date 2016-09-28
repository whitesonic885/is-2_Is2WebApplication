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
	/// ErrorForm の概要の説明です。
	/// </summary>
	public class ErrorForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnログイン画面へ;
		protected System.Web.UI.WebControls.Label labメッセージ;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ページを初期化するユーザー コードをここに挿入します。
			if (Session["message"] != null && !Session["message"].ToString().Equals(""))
// MOD 2005.08.19 東都）高木 メッセージの変更 START
//				labメッセージ.Text = Session["message"].ToString();
				labメッセージ.Text = Session["message"].ToString().Replace("\n", "<BR>\n");
// MOD 2005.08.19 東都）高木 メッセージの変更 END
// MOD 2005.09.02 東都）伊賀 メッセージの変更 START
			else
				labメッセージ.Text = "ログインするにはCookieの受け入れが必要です。<BR>ブラウザの設定を変更してください。";
// MOD 2005.09.02 東都）伊賀 メッセージの変更 END
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
			this.btnログイン画面へ.Click += new System.EventHandler(this.btnログイン画面へ_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnログイン画面へ_Click(object sender, System.EventArgs e)
		{
				Response.Redirect("is2LoginForm.aspx");		
		}

	}
}
