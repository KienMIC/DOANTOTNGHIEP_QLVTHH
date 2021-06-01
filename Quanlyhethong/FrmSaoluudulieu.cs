using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class FrmSaoluudulieu : Form
    {
        public FrmSaoluudulieu()
        {
            InitializeComponent();
        }
        public string database = "QLVTHH";
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string files = "";
        private void btnChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Chọn đường dẫn lưu file sao lưu";
            fbd.ShowNewFolderButton = true;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                files = fbd.SelectedPath;
                txtFolder.Text = files;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFolder.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng chọn đường dẫn lưu file sao lưu");
                }
                else
                {
                    bgWorker.RunWorkerAsync();
                    string sql = "BACKUP DATABASE [" + database + "] TO DISK='" + files + "\\" + "db_QLVTHH" + "-" + DateTime.Now.ToString("dd.MM.yyyy--HH-mm-ss") + ".bak'";
                    SQLClass.clsCRUD cls = new SQLClass.clsCRUD();
                    if (cls.Them_sua_xoa(sql))
                    {
                        MessageBox.Show("Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sao lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 1; i <= 100; i++)
            {
                Thread.Sleep(0);
                bgWorker.WorkerReportsProgress = true;
                bgWorker.ReportProgress(i);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbBR.Value = e.ProgressPercentage;

        }


        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "File sao lưu CSDL|*.bak";
            dlg.Title = "Khôi phục CSDL";
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dlg.RestoreDirectory = true;
                try
                {
                    bgWorker.RunWorkerAsync();
                    string filerestore = dlg.FileName;
                    SQLClass.clsCRUD cls = new SQLClass.clsCRUD();

                    string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + filerestore + "'WITH REPLACE;";
                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");

                    if(cls.Them_sua_xoa(sqlStmt2) && cls.Them_sua_xoa(sqlStmt3) && cls.Them_sua_xoa(sqlStmt4))
                    {
                        MessageBox.Show("Khôi phục CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục CSDL thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void FrmSaoluudulieu_Load(object sender, EventArgs e)
        {
        }
    }
}