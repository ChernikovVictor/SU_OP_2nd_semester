using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMenuItem1 : Form
    {
        //
        //  form for showing result of each delegate process
        //
        public FormMenuItem1()
        {
            InitializeComponent();
        }

        public string Answer 
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
