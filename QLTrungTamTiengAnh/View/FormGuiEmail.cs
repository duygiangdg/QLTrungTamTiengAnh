using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormGuiEmail : Office2007Form
    {
        private List<string> receivers;
        public FormGuiEmail()
        {
            InitializeComponent();
            receivers = new List<string>();
        }

        public void putExtra(List<string> receivers)
        {
            this.receivers = receivers;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("espeedenglishcenter@gmail.com", "espeed@123");

                MailMessage message = new MailMessage();
                message.From = new MailAddress("espeedenglishcenter@gmail.com");
                foreach (string receiver in receivers)
                {
                    message.To.Add(receiver);
                }
                message.Subject = txtChuDe.Text;
                message.Body = txtNoiDung.Text;

                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGuiEmail_Load(object sender, EventArgs e)
        {
            foreach (string receiver in receivers)
            {
                txtNguoiNhan.Text += receiver + "; ";
            }
        }
    }
}
