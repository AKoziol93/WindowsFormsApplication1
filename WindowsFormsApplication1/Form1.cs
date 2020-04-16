using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttWyslij_Click(object sender, EventArgs e)
        {
            
            if (chbInteria1.Checked == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("poczta.interia.pl");
                mail.From = new MailAddress(txtOd.Text, txtOd.Text);
                mail.To.Add("programowanie1@o2.pl");
                mail.Subject = txtTemat.Text;
                mail.IsBodyHtml = true;
                mail.Body = "Model: " + comProducent.Text + Environment.NewLine + "Model: " + txtModel.Text + Environment.NewLine + "cena od " + txtCenaOd.Text + Environment.NewLine + "cena do " + txtCenaDo.Text + Environment.NewLine + Environment.NewLine + "wiadomosc od klijenta :" + Environment.NewLine + TxtWiadomosc.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtOd.Text, txtHaslo.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            if (chbInteria2.Checked == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("poczta.interia.eu");
                mail.From = new MailAddress(txtOd.Text, txtOd.Text);
                mail.To.Add("programowanie1@o2.pl");
                mail.Subject = txtTemat.Text;
                mail.IsBodyHtml = true;
                mail.Body = "Model: " + comProducent.Text + Environment.NewLine + "Model: " + txtModel.Text + Environment.NewLine + "cena od " + txtCenaOd.Text + Environment.NewLine + "cena do " + txtCenaDo.Text + Environment.NewLine + Environment.NewLine + "wiadomosc od klijenta :" + Environment.NewLine + TxtWiadomosc.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtOd.Text, txtHaslo.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            if (chbO2.Checked == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("poczta.o2.pl");
                mail.From = new MailAddress(txtOd.Text, txtOd.Text);
                mail.To.Add("programowanie1@o2.pl");
                mail.Subject = txtTemat.Text;
                mail.IsBodyHtml = true;
                mail.Body = "Model: " + comProducent.Text + Environment.NewLine + "Model: " + txtModel.Text + Environment.NewLine + "cena od " + txtCenaOd.Text + Environment.NewLine + "cena do " + txtCenaDo.Text + Environment.NewLine + Environment.NewLine + "wiadomosc od klijenta :" + Environment.NewLine + TxtWiadomosc.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtOd.Text, txtHaslo.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            if (chbOnet.Checked == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.poczta.onet.pl");
                mail.From = new MailAddress(txtOd.Text, txtOd.Text);
                mail.To.Add("programowanie1@o2.pl");
                mail.Subject = txtTemat.Text;
                mail.IsBodyHtml = true;
                mail.Body = "Model: " + comProducent.Text + Environment.NewLine + "Model: " + txtModel.Text + Environment.NewLine + "cena od " + txtCenaOd.Text + Environment.NewLine + "cena do " + txtCenaDo.Text + Environment.NewLine + Environment.NewLine + "wiadomosc od klijenta :" + Environment.NewLine + TxtWiadomosc.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtOd.Text, txtHaslo.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            if (chbWp.Checked == true)
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.wp.pl");
                mail.From = new MailAddress(txtOd.Text, txtOd.Text);
                mail.To.Add("programowanie1@o2.pl");
                mail.Subject = txtTemat.Text;
                mail.IsBodyHtml = true;
                mail.Body = "Model: " + comProducent.Text + Environment.NewLine + "Model: " + txtModel.Text + Environment.NewLine + "cena od " + txtCenaOd.Text + Environment.NewLine + "cena do " + txtCenaDo.Text + Environment.NewLine + Environment.NewLine + "wiadomosc od klijenta :" + Environment.NewLine + TxtWiadomosc.Text;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(txtOd.Text, txtHaslo.Text);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            
        }



        private void chbO2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbO2.Checked == true)
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = false;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = false;
                chbOnet.Checked = false;
                chbOnet.Enabled = false;
                chbWp.Checked = false;
                chbWp.Enabled = false;
            }
            else
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = true;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = true;
                chbOnet.Checked = false;
                chbOnet.Enabled = true;
                chbWp.Checked = false;
                chbWp.Enabled = true;
            }
        }

        private void chbWp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbWp.Checked == true)
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = false;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = false;
                chbOnet.Checked = false;
                chbOnet.Enabled = false;
                chbO2.Checked = false;
                chbO2.Enabled = false;
            }
            else
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = true;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = true;
                chbOnet.Checked = false;
                chbOnet.Enabled = true;
                chbO2.Checked = false;
                chbO2.Enabled = true;
            }
        }

        private void chbOnet_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOnet.Checked == true)
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = false;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = false;
                chbO2.Checked = false;
                chbO2.Enabled = false;
                chbWp.Checked = false;
                chbWp.Enabled = false;
            }
            else
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = true;
                chbInteria1.Checked = false;
                chbInteria1.Enabled = true;
                chbO2.Checked = false;
                chbO2.Enabled = true;
                chbWp.Checked = false;
                chbWp.Enabled = true;
            }
        }

        private void chbInteria1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbInteria1.Checked == true)
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = false;
                chbO2.Checked = false;
                chbO2.Enabled = false;
                chbOnet.Checked = false;
                chbOnet.Enabled = false;
                chbWp.Checked = false;
                chbWp.Enabled = false;
            }
            else
            {
                chbInteria2.Checked = false;
                chbInteria2.Enabled = true;
                chbO2.Checked = false;
                chbO2.Enabled = true;
                chbOnet.Checked = false;
                chbOnet.Enabled = true;
                chbWp.Checked = false;
                chbWp.Enabled = true;
            }
        }

        private void chbInteria2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbInteria2.Checked == true)
            {
                chbInteria1.Checked = false;
                chbInteria1.Enabled = false;
                chbO2.Checked = false;
                chbO2.Enabled = false;
                chbOnet.Checked = false;
                chbOnet.Enabled = false;
                chbWp.Checked = false;
                chbWp.Enabled = false;
            }
            else
            {
                chbInteria1.Checked = false;
                chbInteria1.Enabled = true;
                chbO2.Checked = false;
                chbO2.Enabled = true;
                chbOnet.Checked = false;
                chbOnet.Enabled = true;
                chbWp.Checked = false;
                chbWp.Enabled = true;
            }
        }

        private void buttDane_Click(object sender, EventArgs e)
        {
            MessageBox.Show("data : " + lblDay.Text + "." + lblMonth.Text + "." + lblYear.Text + Environment.NewLine + "sposób platnosci : " + comPlatnosc.Text, "okienko", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void vscrDay_Scroll(object sender, ScrollEventArgs e)
        {
            double liczba;
            liczba = vscrDay.Value;
            lblDay.Text = Convert.ToString(liczba);
        }

        private void vsrMonth_Scroll(object sender, ScrollEventArgs e)
        {
            double liczba;
            liczba = vscrMonth.Value;
            lblMonth.Text = Convert.ToString(liczba);
        }

        private void vscrYear_Scroll(object sender, ScrollEventArgs e)
        {
            double liczba;
            liczba = vscrYear.Value;
            lblYear.Text = Convert.ToString(liczba);
        }

        private void buttclear_Click(object sender, EventArgs e)
        {
            txtCenaDo.Clear();
            txtCenaOd.Clear();
            txtHaslo.Clear();
            txtModel.Clear();
            txtOd.Clear();
            txtTemat.Clear();
            TxtWiadomosc.Clear();
            lblDay.Text = "Dzień";
            lblMonth.Text = "Miesiac";
            lblYear.Text = "Rok";
            chbInteria1.Checked = false;
            chbInteria2.Checked = false;
            chbO2.Checked = false;
            chbOnet.Checked = false;
            chbWp.Checked = false;
        }

        private void buttEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
