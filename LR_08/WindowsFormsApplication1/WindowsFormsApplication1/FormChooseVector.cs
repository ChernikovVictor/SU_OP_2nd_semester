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
    //
    // Form for getting index (1, 2, ...) of vector that should be clonned
    //
    public partial class FormChooseVector : Form
    {
        public FormChooseVector()
        {
            InitializeComponent();
        }

        private int index;
        public int Index { get { return index; } }
        // array of vectors in labelVectors
        public string SetLabelVectors 
        {
            get { return labelVectors.Text; }
            set { labelVectors.Text = value; }
        }
        private int count; // count of vectors in LabelVectors
        public int Count { set { count = value; } }

        // Событие: выбрали индекс и нажали далее
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                index = Int32.Parse(textBox1.Text);
                index--;
                if (index < 0 || index >= count)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Некорректный индекс");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            Close();
        }

    }
}
