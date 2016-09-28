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
	/// ErrorForm �̊T�v�̐����ł��B
	/// </summary>
	public class ErrorForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btn���O�C����ʂ�;
		protected System.Web.UI.WebControls.Label lab���b�Z�[�W;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// �y�[�W�����������郆�[�U�[ �R�[�h�������ɑ}�����܂��B
			if (Session["message"] != null && !Session["message"].ToString().Equals(""))
// MOD 2005.08.19 ���s�j���� ���b�Z�[�W�̕ύX START
//				lab���b�Z�[�W.Text = Session["message"].ToString();
				lab���b�Z�[�W.Text = Session["message"].ToString().Replace("\n", "<BR>\n");
// MOD 2005.08.19 ���s�j���� ���b�Z�[�W�̕ύX END
// MOD 2005.09.02 ���s�j�ɉ� ���b�Z�[�W�̕ύX START
			else
				lab���b�Z�[�W.Text = "���O�C������ɂ�Cookie�̎󂯓��ꂪ�K�v�ł��B<BR>�u���E�U�̐ݒ��ύX���Ă��������B";
// MOD 2005.09.02 ���s�j�ɉ� ���b�Z�[�W�̕ύX END
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
			this.btn���O�C����ʂ�.Click += new System.EventHandler(this.btn���O�C����ʂ�_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn���O�C����ʂ�_Click(object sender, System.EventArgs e)
		{
				Response.Redirect("is2LoginForm.aspx");		
		}

	}
}
