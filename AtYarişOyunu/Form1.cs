using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarişOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, üçüncüatsolauzaklık;

      

        Random rastgele = new Random();

     

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            üçüncüatsolauzaklık = pictureBox3.Left;

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            int birinciatıngenişliği = pictureBox1.Width;
            int ikinciatıngenişliği = pictureBox2.Width;
            int üçüncüatıngenişliği = pictureBox3.Width;

            int bitişcizgisi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

            if (pictureBox1.Left>pictureBox2.Left+5&&pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text = "1 numaralı AT önde";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 numaralı AT önde";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "3  numaralı AT önde";
            }

            if (birinciatıngenişliği+pictureBox1.Left>= bitişcizgisi)
            {
                pictureBox4.ImageLocation = "C:\\Users\\baxan\\Desktop\\1.at.png";
                timer1.Enabled = false;
                label6.Text = "1 numaralı AT tarışı kazandı...";
                MessageBox.Show("1 numaralı AT tarışı kazandı...");
                


            }
            if (ikinciatıngenişliği + pictureBox2.Left >= bitişcizgisi)
            {
                pictureBox4.ImageLocation = "C:\\Users\\baxan\\Desktop\\2.at.png";
                timer1.Enabled = false;
                label6.Text = "2 numaralı AT tarışı kazandı...";
                MessageBox.Show("2 numaralı AT tarışı kazandı...");
                




            }
            if (üçüncüatıngenişliği + pictureBox3.Left >= bitişcizgisi)
            {
                pictureBox4.ImageLocation = "C:\\Users\\baxan\\Desktop\\3.at.png";
                timer1.Enabled = false;
                label6.Text = "3 numaralı AT tarışı kazandı...";
                MessageBox.Show("3 numaralı AT tarışı kazandı...");
               


            }


        }
    }
}
