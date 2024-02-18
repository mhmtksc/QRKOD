using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
namespace QRKOD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            if (string.IsNullOrWhiteSpace(metin))
            {
                MessageBox.Show("Lütfen bir metin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                QRCodeGenerator ZZZ = new QRCodeGenerator();// sınıf tanımladım.
                QRCodeData aaa = ZZZ.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q); //tanımladığım sınıfı burada kullandım.
                QRCode qrCode = new QRCode(aaa);
                int boyut = 3;
                Bitmap qrCodeImage = qrCode.GetGraphic(boyut);
                pictureBox1.Image = qrCodeImage;
            }





           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                button1.PerformClick(); 
            }
        }
    }

    }



