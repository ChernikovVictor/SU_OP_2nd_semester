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
    public partial class FormAddVector : Form
    {
        //
        //  form for adding new IVector to others
        //
        public FormAddVector()
        {
            InitializeComponent();
        }

        private IVector array; // array from formAddVector
        public IVector Array
        {
            get { return array; }
        }
        
        // Save vector from form to "array"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string[] mas = textBoxArray.Text.Split();
                if (radioButtonVector.Checked)
                    array = new ArrayVector(mas.Length);
                else
                    array = new LinkedListVector(mas.Length);
                for (int i = 0; i < array.Length; i++)
                    array[i] = Double.Parse(mas[i]);
            }
            catch (Exception)
            {
                MessageBox.Show("Массив задан некорректно");
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}
