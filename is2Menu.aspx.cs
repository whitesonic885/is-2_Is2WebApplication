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
	/// is2Menu の概要の説明です。
	/// </summary>
	public class is2Menu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink hl会員専用;
		protected System.Web.UI.WebControls.HyperLink hl営業所検索;
		protected System.Web.UI.WebControls.HyperLink hlマニュアル;
		protected System.Web.UI.WebControls.HyperLink hlダウンロード;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.HtmlControls.HtmlForm Form2;
		protected System.Web.UI.WebControls.Panel TopMenu;
		protected System.Web.UI.WebControls.Panel DownloadMenu;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.HyperLink hlIS2;
		protected System.Web.UI.WebControls.HyperLink hlプライバシ;
	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
