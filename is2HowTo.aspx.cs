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
	/// is2HowTo �̊T�v�̐����ł��B
	/// </summary>
	public class is2HowTo : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image1;
	
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
