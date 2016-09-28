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
	/// is2SSLDownload �̊T�v�̐����ł��B
	/// </summary>
	public class is2SSLDownload : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton btn�ؖ����C���X�g�[���菇�_�E�����[�h;
		protected System.Web.UI.WebControls.ImageButton btn���[�g�ؖ����t�@�C���_�E�����[�h;
	
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
			this.btn�ؖ����C���X�g�[���菇�_�E�����[�h.Click += new System.Web.UI.ImageClickEventHandler(this.btn�ؖ����C���X�g�[���菇�_�E�����[�h_Click);
			this.btn���[�g�ؖ����t�@�C���_�E�����[�h.Click += new System.Web.UI.ImageClickEventHandler(this.btn���[�g�ؖ����t�@�C���_�E�����[�h_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn�ؖ����C���X�g�[���菇�_�E�����[�h_Click(object sender, System.Web.UI.ImageClickEventArgs e)
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

		private void btn���[�g�ؖ����t�@�C���_�E�����[�h_Click(object sender, System.Web.UI.ImageClickEventArgs e)
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
