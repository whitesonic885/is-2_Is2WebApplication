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
	/// is2SSLDownload の概要の説明です。
	/// </summary>
	public class is2SSLDownload : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton btn証明書インストール手順ダウンロード;
		protected System.Web.UI.WebControls.ImageButton btnルート証明書ファイルダウンロード;
	
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
			this.btn証明書インストール手順ダウンロード.Click += new System.Web.UI.ImageClickEventHandler(this.btn証明書インストール手順ダウンロード_Click);
			this.btnルート証明書ファイルダウンロード.Click += new System.Web.UI.ImageClickEventHandler(this.btnルート証明書ファイルダウンロード_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn証明書インストール手順ダウンロード_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition","attachment; filename=is2SSLInstall.pdf");
			string sPhysicalApplicationPath = Request.PhysicalApplicationPath;
			if(!sPhysicalApplicationPath.EndsWith("\\")){
				sPhysicalApplicationPath += "\\";
			}
			Response.WriteFile(sPhysicalApplicationPath+"file\\is2SSLInstall.pdf");
			Response.End();
		}

		private void btnルート証明書ファイルダウンロード_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.ContentType = "application/x-x509-ca-cert";
			Response.AddHeader("content-disposition","attachment; filename=VeriSignCA_G5.cer");
			string sPhysicalApplicationPath = Request.PhysicalApplicationPath;
			if(!sPhysicalApplicationPath.EndsWith("\\")){
				sPhysicalApplicationPath += "\\";
			}
			Response.WriteFile(sPhysicalApplicationPath+"file\\VeriSignCA_G5.cer");
			Response.End();
		}
	}
}
