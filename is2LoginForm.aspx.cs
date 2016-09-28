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
	// �C������
	//--------------------------------------------------------------------------
	// ADD 2008.05.19 ���s�j���� ����׎�݂̂�Vista�Ή� 
	//--------------------------------------------------------------------------
	// MOD 2008.12.25 ���s�j���� �p�X���[�h�`�F�b�N�̋��� 
	//--------------------------------------------------------------------------

	public class LoginForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lab����R�[�h;
		protected System.Web.UI.WebControls.TextBox tex�p�X���[�h;
		protected System.Web.UI.WebControls.Label lab�p�X���[�h;
		protected System.Web.UI.WebControls.TextBox tex���p�҃R�[�h;
		protected System.Web.UI.WebControls.Label lab���p�҃R�[�h;
		protected System.Web.UI.WebControls.Button btn���O�C��;
		protected System.Web.UI.WebControls.TextBox tex����R�[�h;
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.HyperLink hl�߂�;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Image Image1;
        protected System.Web.UI.HtmlControls.HtmlForm Form;
	
		// �v�����T�[�r�X�ϐ�
		protected static is2init.Service1  sv_is2init  = null;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// �y�[�W�����������郆�[�U�[ �R�[�h�������ɑ}�����܂��B
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
			this.btn���O�C��.Click += new System.EventHandler(this.btn���O�C��_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn���O�C��_Click(object sender, System.EventArgs e)
		{
			sv_is2init = new is2init.Service1();
			string[] s���[�U = new string[3];
			string[] sKey = new string[3];
			sKey[0] = tex����R�[�h.Text;
			sKey[1] = tex���p�҃R�[�h.Text;
			sKey[2] = tex�p�X���[�h.Text;
			string[] sRet = sv_is2init.login(s���[�U, sKey);
// MOD 2008.12.25 ���s�j���� �p�X���[�h�`�F�b�N�̋��� START
//			if (sRet[0].Equals("����I��"))
			if (sRet[0].Length == 4)
// MOD 2008.12.25 ���s�j���� �p�X���[�h�`�F�b�N�̋��� END
			{
				Session["member"] = sRet[2];
				Session["user"] = sRet[4];
// ADD 2008.05.19 ���s�j���� ����׎�݂̂�Vista�Ή� START
				Session["membercd"] = sKey[0];
// ADD 2008.05.19 ���s�j���� ����׎�݂̂�Vista�Ή� END
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
