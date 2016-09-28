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
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2009.10.22 ���s�j���� �_�E���[�h�G���[��ʂ̕ύX 
	//--------------------------------------------------------------------------
	// ADD 2016.04.11 BEVAS�j���{ CF408T�v�����^LAN�ڑ�������_�E�����[�h�@�\�̒ǉ� 
	//--------------------------------------------------------------------------
	public class is2Manual : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Button btn�_�E�����[�h;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label lab�}�j���A���_�E�����[�h;
		protected System.Web.UI.WebControls.Button btn�}�j���A���_�E�����[�h;
		protected System.Web.UI.WebControls.Label lab�����;
		protected System.Web.UI.WebControls.Label lab���p�Җ�;
		protected System.Web.UI.WebControls.Button btn�ȈՃ}�j���A���_�E�����[�h;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Button btnis2��ı��ߎ菇;
		protected System.Web.UI.WebControls.Button butSATO�����;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Button btn�Z�b�g�A�b�v�}�j���A���_�E�����[�h;
		protected System.Web.UI.WebControls.Image imgManual_back;
		protected System.Web.UI.WebControls.Image is2Manual_aspx_back;
		protected System.Web.UI.HtmlControls.HtmlInputHidden info01;
		protected System.Web.UI.HtmlControls.HtmlInputHidden info02;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Button btnCF408TLAN�ڑ�;
		protected System.Web.UI.WebControls.Button btn�߂�;
	
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
// MOD 2009.10.22 ���s�j���� �_�E���[�h�G���[��ʂ̕ύX START
//				Session["message"] = "";
				Session["message"] = "�P�T���ȏ�ڑ����Ȃ������ׁA�ؒf����܂����B<BR>"
								   + "�ēx���O�C�����s���Ă��������B";
// MOD 2009.10.22 ���s�j���� �_�E���[�h�G���[��ʂ̕ύX END
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
			this.btn�}�j���A���_�E�����[�h.Click += new System.EventHandler(this.btn�}�j���A���_�E�����[�h_Click);
			this.btn�ȈՃ}�j���A���_�E�����[�h.Click += new System.EventHandler(this.btn�ȈՃ}�j���A���_�E�����[�h_Click);
			this.btn�Z�b�g�A�b�v�}�j���A���_�E�����[�h.Click += new System.EventHandler(this.btn�Z�b�g�A�b�v�}�j���A���_�E�����[�h_Click);
			this.btnis2��ı��ߎ菇.Click += new System.EventHandler(this.btnis2��ı��ߎ菇_Click);
			this.butSATO�����.Click += new System.EventHandler(this.butSATO�����_Click);
			this.btnCF408TLAN�ڑ�.Click += new System.EventHandler(this.btnCF408TLAN�ڑ�_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn�߂�_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("is2Main.htm");
		}

		private void btn�}�j���A���_�E�����[�h_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual.pdf");
			Response.End();
		}
		private void btn�Z�b�g�A�b�v�}�j���A���_�E�����[�h_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2Setuptebiki.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2Setuptebiki.pdf");
			Response.End();
		}
		private void btn�ȈՃ}�j���A���_�E�����[�h_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is2manual_kani.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is2manual_kani.pdf");
			Response.End();
		}

		private void btnis2��ı��ߎ菇_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=is-2saisetup.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\is-2saisetup.pdf");
			Response.End();
		}

		private void butSATO�����_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=satosetup.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\satosetup.pdf");
			Response.End();
		}

// ADD 2016.04.11 BEVAS�j���{ CF408T�v�����^LAN�ڑ�������_�E�����[�h�@�\�̒ǉ� START
		private void btnCF408TLAN�ڑ�_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=CF408TLANmanual.pdf");
			Response.WriteFile("D:\\is2\\webapp\\manual\\CF408TLANmanual.pdf");
			Response.End();
		}
// ADD 2016.04.11 BEVAS�j���{ CF408T�v�����^LAN�ڑ�������_�E�����[�h�@�\�̒ǉ� END
	}
}
