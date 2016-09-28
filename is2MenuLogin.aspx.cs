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
	/// is2MenuLogin の概要の説明です。
	/// </summary>
	public class is2MenuLogin : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink hlマニュアル;
		protected System.Web.UI.WebControls.HyperLink hlダウンロード;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// ページを初期化するユーザー コードをここに挿入します。
			if (Session["member"] == null || Session["member"].ToString().Equals("") &&
				Session["user"]   == null || Session["user"].ToString().Equals(""))
			{
				Response.Redirect("is2Menu.aspx");
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
