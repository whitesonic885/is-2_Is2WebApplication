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
	/// is2PackageDownload �̊T�v�̐����ł��B
	/// </summary>
	public class is2PackageDownload2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.HyperLink hl�p�b�P�[�W�_�E�����[�h;
		protected System.Web.UI.WebControls.HyperLink hl�߂�;
		protected System.Web.UI.WebControls.Label lab�����;
		protected System.Web.UI.WebControls.Label lab���p�Җ�;
		protected System.Web.UI.WebControls.Button btn�_�E�����[�h;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.HyperLink hl������ݒ��޳�۰��;
		protected System.Web.UI.WebControls.Button btn�_�E�����[�h3;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image7;
		protected System.Web.UI.WebControls.HyperLink Hyperlink4;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button btn�_�E�����[�h4;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label Label4;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �y�[�W�����������郆�[�U�[ �R�[�h�������ɑ}�����܂��B
			if (Session["member"] != null && !Session["member"].ToString().Equals("") &&
				Session["user"]   != null && !Session["user"].ToString().Equals(""))
			{
				lab�����.Text = Session["member"].ToString();
				lab���p�Җ�.Text = Session["user"].ToString() + " �l";
			}
			else
			{
				Session["message"] = "";
				Server.Transfer("is2ErrorForm.aspx");
			}
		}

		#region Web �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h 
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: ���̌Ăяo���́AASP.NET Web �t�H�[�� �f�U�C�i�ŕK�v�ł��B
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �f�U�C�i �T�|�[�g�ɕK�v�ȃ��\�b�h�ł��B���̃��\�b�h�̓��e��
		/// �R�[�h �G�f�B�^�ŕύX���Ȃ��ł��������B
		/// </summary>
		private void InitializeComponent()
		{    
			this.btn�_�E�����[�h.Click += new System.EventHandler(this.btn�_�E�����[�h_Click);
			this.btn�_�E�����[�h4.Click += new System.EventHandler(this.btn�_�E�����[�h4_Click);
			this.btn�_�E�����[�h3.Click += new System.EventHandler(this.btn�_�E�����[�h3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn�_�E�����[�h_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
// MOD 2008.05.19 ���s�j���� Vista�Z�b�g�A�b�v�v���O�����Ή� START
//			Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
////			Response.WriteFile("D:\\Package\\is2Setup.msi");
//			Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
// MOD 2008.06.03 ���s�j���� Vista�Ή��̌ڋq�����̉��� START
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0
//				&& Session["membercd"] != null && !Session["membercd"].ToString().Equals("")
//			){
//				if(Session["membercd"].ToString().Equals("honbu")
//					|| Session["membercd"].ToString().Equals("9050879680")	// �O�����K�i�L�j�a
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
// MOD 2008.06.03 ���s�j���� Vista�Ή��̌ڋq�����̉��� END
			}else{
				Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
			}
// MOD 2008.05.19 ���s�j���� Vista�Z�b�g�A�b�v�v���O�����Ή� END
			Response.End();
		}

		private void btn�_�E�����[�h2_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual.pdf");
			Response.End();
		}

		private void btn�_�E�����[�h3_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";

// MOD 2005.05.31 ���s�j���� �v�����^�h���C�o���̕ύX START
//			Response.AddHeader("content-disposition","attachment; filename=is2zlp2844.zip");
//			Response.WriteFile("D:\\is2\\webapp\\manual\\is2zlp2844.zip");
			Response.AddHeader("content-disposition","attachment; filename=printdev.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printdev.exe");
// MOD 2005.05.31 ���s�j���� �v�����^�h���C�o���̕ύX END

			Response.End();
		}

		private void btn�_�E�����[�h4_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=dotnetfx.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\dotnetfx.exe");
			Response.End();
		}
	}
}
