using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {        
        delegate void delegado(int valor);
        Random rd = new Random();
        public Form1()
        {
            
            InitializeComponent();
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            Thread H1 = new Thread(new ThreadStart(Pro1)); 
            Thread H2 = new Thread(new ThreadStart(Pro2)); 
            Thread H3 = new Thread(new ThreadStart(Pro3));
            H1.Start();
            H2.Start();
            H3.Start();            
        }
        public void Pro1()
        {
            for (int i = 1; i <= 100; i++)
            {
                delegado md = new delegado(move);
                this.Invoke(md, new object[] { i });
                int num = rd.Next(1, 500);
                Thread.Sleep(num);
            }
        }
        public void move(int valor)
        {
            label1.Text = valor.ToString() + ("%");
            progressBar1.Value = valor;
        }
        public void Pro2()
        {
            for (int i = 1; i <= 100; i++)
            {
                delegado md = new delegado(move2);
                this.Invoke(md, new object[] { i });
                int num = rd.Next(1, 500);
                Thread.Sleep(num);
            }
        }
        public void move2(int valor)
        {
            label4.Text = valor.ToString()+("%");
            progressBar2.Value = valor;
        }
        public void Pro3()
        {
            for (int i = 1; i <= 100; i++)
            {
                delegado md = new delegado(move3);
                this.Invoke(md, new object[] { i });
                int num = rd.Next(1, 500);
                Thread.Sleep(num);
            }
        }
        public void move3(int valor)
        {
            label6.Text = valor.ToString() + ("%");
            progressBar3.Value = valor;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar bar1 = new ProgressBar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            ProgressBar bar2 = new ProgressBar();
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
            ProgressBar bar3 = new ProgressBar();
        }
    }
}
