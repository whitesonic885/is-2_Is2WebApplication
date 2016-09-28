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
	/// [is2PackageDownload]
	/// </summary>
	//--------------------------------------------------------------------------
	// �C������
	//--------------------------------------------------------------------------
	// MOD 2008.12.09 ���s�j���� Window7 �Ή� 
	//--------------------------------------------------------------------------
	// MOD 2009.10.22 ���s�j���� �_�E���[�h�G���[��ʂ̕ύX 
	//--------------------------------------------------------------------------
	// MOD 2010.11.25 ���s�j���� SATO�h���C�o�̕ύX 
	//--------------------------------------------------------------------------
	// MOD 2013.04.11 TDI�j�j�V SATO�h���C�o�̒ǉ�(CF408T) 
	//--------------------------------------------------------------------------
	// MOD 2015.01.27 BEVAS) �O�c�@.NET Framework1.1 ServicePach1�_�E�����[�h�ǉ�
	//--------------------------------------------------------------------------

	public class is2PackageDownload : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Image Image4;
		protected System.Web.UI.WebControls.Label lab�����;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.Label lab�t���[�����[�N�_�E�����[�h;
		protected System.Web.UI.WebControls.Button btn�t���[�����[�N�_�E�����[�h;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Label lab�v�����^�ݒ�_�E�����[�h;
		protected System.Web.UI.WebControls.Button btn�߂�;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�Q;
		protected System.Web.UI.WebControls.Image Image3;
		protected System.Web.UI.WebControls.Label labVista;
		protected System.Web.UI.WebControls.Label lab�p�b�P�[�W�_�E�����[�h;
		protected System.Web.UI.WebControls.Button btn�p�b�P�[�W�_�E�����[�h;
		protected System.Web.UI.WebControls.Image Image5;
		protected System.Web.UI.WebControls.Label lab�p�b�P�[�W�v���L�V�Ή�����;
		protected System.Web.UI.WebControls.Button btn�p�b�P�[�W�v���L�V�Ή�����;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.Image imgBack;
		protected System.Web.UI.WebControls.LinkButton lnkBtnSATO��;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�R;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h;
		protected System.Web.UI.WebControls.Label lab�v�����^�ݒ�_�E�����[�h�O;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�P;
		protected System.Web.UI.WebControls.Image Image7;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�O;
		protected System.Web.UI.WebControls.Label lab�v�����^�ݒ�_�E�����[�h�Q;
		protected System.Web.UI.WebControls.Image Image6;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�S;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�T;
		protected System.Web.UI.WebControls.Button btn�v�����^�ݒ�_�E�����[�h�U;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Image Image8;
		protected System.Web.UI.WebControls.Image Image10;
		protected System.Web.UI.WebControls.Image Image9;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Button btn�_�E�����[�hdotClean;
		protected System.Web.UI.WebControls.Image Image11;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Button btnDotNet11SP1�_�E�����[�h;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label lab���p�Җ�;
	
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
//				Session["message"] = "���O�C������ɂ�Cookie�̎󂯓��ꂪ�K�v�ł��B<BR>�u���E�U�̐ݒ��ύX���Ă��������B";
				Session["message"] = "�P�T���ȏ�ڑ����Ȃ������ׁA�ؒf����܂����B<BR>"
								   + "�ēx���O�C�����s���Ă��������B";
// MOD 2009.10.22 ���s�j���� �_�E���[�h�G���[��ʂ̕ύX END
				Server.Transfer("is2ErrorForm.aspx");
			}
// MOD 2008.12.09 ���s�j���� Window7 �Ή� START
////20070122 START TTD)Y.IGA Vista�Ή� 
//			if (Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") == -1)
//			{
//				this.btn�p�b�P�[�W�_�E�����[�h.Enabled = true;
//			}
//			else
//			{
//// MOD 2008.05.19 ���s�j���� Vista�Z�b�g�A�b�v�v���O�����Ή� START
////				this.btn�p�b�P�[�W�_�E�����[�h.Enabled = false;
////				this.labVista.Text = "�����_�ŁAiS-2�́A���g�p���̂n�r�ɑΉ����Ă���܂���B";
//// MOD 2008.06.03 ���s�j���� Vista�Ή��̌ڋq�����̉��� START
////				if(Session["membercd"] != null && !Session["membercd"].ToString().Equals(""))
////				{
////					if(Session["membercd"].ToString().Equals("honbu")
////						|| Session["membercd"].ToString().Equals("9050879680")	// �O�����K�i�L�j�a
////					){
////						this.btn�p�b�P�[�W�_�E�����[�h.Enabled = true;
////					}else{
////						this.btn�p�b�P�[�W�_�E�����[�h.Enabled = false;
////						this.labVista.Text = "�����_�ŁAiS-2�́A���g�p���̂n�r�ɑΉ����Ă���܂���B";
////					}
////				}else{
////					this.btn�p�b�P�[�W�_�E�����[�h.Enabled = false;
////					this.labVista.Text = "�����_�ŁAiS-2�́A���g�p���̂n�r�ɑΉ����Ă���܂���B";
////				}
//// MOD 2008.05.19 ���s�j���� Vista�Z�b�g�A�b�v�v���O�����Ή� END
//				this.btn�p�b�P�[�W�_�E�����[�h.Enabled = true;
//				this.labVista.Text = "�����_�ŁAiS-2�́A���g�p���̂n�r�ɑΉ����Ă���܂���B";
//// MOD 2008.06.03 ���s�j���� Vista�Ή��̌ڋq�����̉��� END
//			}
////20070122 END   TTD)Y.IGA Vista�Ή� 
// MOD 2008.12.09 ���s�j���� Window7 �Ή� END
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
			this.btn�p�b�P�[�W�_�E�����[�h.Click += new System.EventHandler(this.btn�p�b�P�[�W�_�E�����[�h_Click);
			this.btn�t���[�����[�N�_�E�����[�h.Click += new System.EventHandler(this.btn�t���[�����[�N�_�E�����[�h_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�S.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�S_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�T.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�T_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�O.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�O_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�P.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�P_Click);
			this.lnkBtnSATO��.Click += new System.EventHandler(this.lnkBtnSATO��_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�Q.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�Q_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�R.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�R_Click);
			this.btn�v�����^�ݒ�_�E�����[�h.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h_Click);
			this.btn�v�����^�ݒ�_�E�����[�h�U.Click += new System.EventHandler(this.btn�v�����^�ݒ�_�E�����[�h�U_Click);
			this.btn�p�b�P�[�W�v���L�V�Ή�����.Click += new System.EventHandler(this.btn�p�b�P�[�W�v���L�V�Ή�����_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btn�p�b�P�[�W�_�E�����[�h_Click(object sender, System.EventArgs e)
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
// MOD 2008.12.09 ���s�j���� Window7 �Ή� START
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0){
			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.") >= 0){
// MOD 2008.12.09 ���s�j���� Window7 �Ή� END
				Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
			}else{
				Response.AddHeader("content-disposition","attachment; filename=is2Setup.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2Setup.msi");
			}
// MOD 2008.05.19 ���s�j���� Vista�Z�b�g�A�b�v�v���O�����Ή� END
			Response.End();
		}

		private void btn�v�����^�ݒ�_�E�����[�h_Click(object sender, System.EventArgs e)
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

// MOD 2006.09.25 FJCS�j�R�� �v�����^�h���C�o�Q�ǉ� START
		private void btn�v�����^�ݒ�_�E�����[�h�Q_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat.exe");
			Response.End();
		}
// MOD 2006.09.25 FJCS�j�R�� �v�����^�h���C�o�ǉ� END

// MOD 2011.05.18 ���s�j���� �v�����^�h���C�o�R�ǉ� START
		private void btn�v�����^�ݒ�_�E�����[�h�R_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat_64.exe");
			Response.End();
		}
// MOD 2011.05.18 ���s�j���� �v�����^�h���C�o�R�ǉ� END

		private void btn�t���[�����[�N�_�E�����[�h_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=dotnetfx.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\dotnetfx.exe");
			Response.End();
		}

		// MOD 2011.12.08 FJCS�j�쑺 �v�����^�h���C�o�O,�P�ǉ� START
		private void btn�v�����^�ݒ�_�E�����[�h�O_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcs408t.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcs408t.exe");
			Response.End();
		}

		private void btn�v�����^�ݒ�_�E�����[�h�P_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcs408t_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcs408t_64.exe");
			Response.End();
		}
		// MOD 2011.12.08 FJCS�j�쑺 �v�����^�h���C�o�ǉ� END

// MOD 2013.04.11 TDI�j�j�V SATO�h���C�o�̒ǉ�(CF408T)  START
		private void btn�v�����^�ݒ�_�E�����[�h�S_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcf408t.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcf408t.exe");
			Response.End();
		}

		private void btn�v�����^�ݒ�_�E�����[�h�T_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsatcf408t_64.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsatcf408t_64.exe");
			Response.End();
		}
// MOD 2013.04.11 TDI�j�j�V SATO�h���C�o�̒ǉ�(CF408T)  END

// MOD 2009.08.20 ���s�j���� �v���L�V�Ή� START
		private void btn�p�b�P�[�W�v���L�V�Ή�����_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
//			if(Request.ServerVariables.Get("HTTP_USER_AGENT").IndexOf("Windows NT 6.0") >= 0)
//			{
//				Response.AddHeader("content-disposition","attachment; filename=is2SetupVista.msi");
//				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupVista.msi");
//			}
//			else
			{
				Response.AddHeader("content-disposition","attachment; filename=is2SetupProxy.msi");
				Response.WriteFile("D:\\is2\\webapp\\Package\\is2SetupProxy.msi");
			}
			Response.End();
		}
// MOD 2009.08.20 ���s�j���� �v���L�V�Ή� END

		private void btn�߂�_Click(object sender, System.EventArgs e)
		{
//			this.Response.Redirect("is2Main.htm");
		}
// MOD 2010.11.25 ���s�j���� SATO�h���C�o�̕ύX START
		private void lnkBtnSATO��_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=printsat_T070901.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\printsat_T070901.exe");
			Response.End();
		}
// MOD 2010.11.25 ���s�j���� SATO�h���C�o�̕ύX END

// MOD 2013.10.23 TDI�j�j�V ����TEC�h���C�o�̒ǉ�(B-EV4D)  START
		private void btn�v�����^�ݒ�_�E�����[�h�U_Click(object sender, System.EventArgs e)
		{
			Response.ContentType = "application/";
			Response.AddHeader("content-disposition","attachment; filename=TEC-Fukuyama_732_M-2.exe");
			Response.WriteFile("D:\\is2\\webapp\\manual\\TEC-Fukuyama_732_M-2.exe");
			Response.End();
		}


// MOD 2013.10.23 TDI�j�j�V ����TEC�h���C�o�̒ǉ�(B-EV4D)  END

	}
}
