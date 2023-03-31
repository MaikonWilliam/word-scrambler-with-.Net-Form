using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_canal_Click(object sender, EventArgs e)
        {  
            List<char> list = new List<char>();
            Random rnd = new Random();

            lb_texto.Text = null;
           
            var lt = tb_text.Text.OrderBy(x=> rnd.Next());
            foreach(char c in lt)
            {
                lb_texto.Text += c.ToString().ToLower();
            }
            
        }

       
    }
}
