using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngrok_Desktop
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }
        const string NORMAL_BUTTON_TEXT = "Add Authtoken";
        const string CHANGE_BUTTON_TEXT = "Change Authtoken";
        string FileSave;//biến chứa đường dẫn lưu files
        WebClient Wc = new WebClient();//Khai báo biến webclient để thực hiện tải về

        public void init()
        {
            string url = "";
            WebClient Wc = new WebClient();//Khai báo biến webclient để thực hiện tải về
            Uri FileUrl = new Uri(url.Trim());//Uri để tạo đầu vào cho Wc tải về, Trim để xóa kí tự rỗng ở 2 đầu
            Wc.DownloadFileAsync(FileUrl, "txtSaveFile.Text");
        }

        private void Save_File()//chọn đường dẫn lưu file
        {
            SaveFileDialog saveDial = new SaveFileDialog();//Hộp thoại tạo file lưu trữ
            saveDial.Title = "Lưu file";//tên hộp thoại
            saveDial.Filter = "Tất cả|*.*";//Định dạnh file lưu
            if (saveDial.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)//Nếu không ấn hủy thì sẽ lấy đường dẫn lưu file
                FileSave = saveDial.FileName;//Lấy đường dẫn để lưu file
            //txtSaveFile.Text = FileSave;//Xuất đường dẫn ra textbox
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            getAuthtoken();
        }
        private void getAuthtoken()
        {
            bool isEmpty = String.IsNullOrEmpty(txtAuthtoken.Text);
            string btnText = isEmpty ? NORMAL_BUTTON_TEXT : CHANGE_BUTTON_TEXT;
            btnAuthtoken.Text = btnText;

            txtPath1.Text = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            txtPath2.Text = (System.AppDomain.CurrentDomain.BaseDirectory);
            txtPath3.Text = (System.Environment.CurrentDirectory);
            txtPath4.Text = (System.IO.Directory.GetCurrentDirectory());
            txtPath5.Text =(Environment.CurrentDirectory);
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
