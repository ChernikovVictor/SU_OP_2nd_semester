using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private IVector[] arr; // Array of IVector (static)
        public IVector[] Arr { get { return arr; } }
        private int size;       // size of arr[]
        delegate void Del(IVector[] arr, int size);
        Del delegateForMenu = null; 
        //
        // Пункты меню для делегата
        //
        // 1 пункт меню: Самые маленькие вектора
        public static void Action1(IVector[] arr, int size)
        {
            // searching min
            IVector minVector = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i].CompareTo(minVector) < 0)
                    minVector = arr[i];
            }
            // create form for answer
            FormMenuItem1 f = new FormMenuItem1();
            f.Answer = "Выполняется 1 пункт меню \nСамые маленькие векторы:\n";
            for (int i = 0; i < size; i++)
            {
                if (arr[i].CompareTo(minVector) == 0)
                    f.Answer += arr[i].ToString() + "\n";
            }
            f.ShowDialog();
            f.Dispose();
        }

        // 2 пункт меню: Самые большие вектора
        public static void Action2(IVector[] arr, int size)
        {
            // searching max
            IVector maxVector = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i].CompareTo(maxVector) > 0)
                    maxVector = arr[i];
            }
            // create form for answer
            FormMenuItem1 f = new FormMenuItem1();
            f.Answer = "Выполняется 2 пункт меню\nСамые большие векторы:\n";
            for (int i = 0; i < size; i++)
            {
                if (arr[i].CompareTo(maxVector) == 0)
                    f.Answer += arr[i].ToString() + "\n";
            }
            f.ShowDialog();
            f.Dispose();
        }

        // 3 пункт меню: Сортировка по возрастанию модулей
        public static void Action3(IVector[] arr, int size)
        {
            FormMenuItem1 f = new FormMenuItem1();
            f.Answer = "Выполняется 3 пункт меню\nВекторы сортированы по возрастанию модулей:\n";
            Array.Sort(arr, 0, size, new LinkedListVector.SortByNorm());
            for (int i = 0; i < size; i++)
            {
                f.Answer += arr[i].ToString() + "\n";
            }
            f.ShowDialog();
            f.Dispose();
        }

        // 4 пункт меню: Сортировка по кол-ву координат
        public static void Action4(IVector[] arr, int size)
        {
            FormMenuItem1 f = new FormMenuItem1();
            f.Answer = "Выполняется 4 пункт меню\nВекторы сортированы по кол-ву координат:\n";
            Array.Sort(arr, 0, size);
            for (int i = 0; i < size; i++)
            {
                f.Answer += arr[i].ToString() + "\n";
            }
            f.ShowDialog();
            f.Dispose();
        }

        // 5 пункт меню: Клонирование вектора
        public static void Action5(IVector[] arr, int size)
        {
            FormChooseVector f1 = new FormChooseVector();
            f1.SetLabelVectors = "Выполняется пункт меню 5\nВыберете вектор для клонирования:\n";
            f1.Count = size; // count need to choose correct index
            for (int i = 0; i < size; i++)
                f1.SetLabelVectors += arr[i].ToString() + "\n";
            f1.ShowDialog();
            int j = f1.Index; // index of vector that should be clonned
            f1.Dispose();
            FormMenuItem1 f2 = new FormMenuItem1();
            IVector clone = (IVector)arr[j].Clone(); // clone vector arr[j]
            for (int i = 0; i < clone.Length; i++)
                clone[i] = 5;
            f2.Answer = "Заменили в клоне все элементы на значение: 5 \n" +
                              clone.ToString() + "\n" +
                              "Исходный вектор не изменился: \n" +
                              arr[j].ToString();
            f2.ShowDialog();
            f2.Dispose();
        }
        //
        // конец пунктов меню для делегата
        //

        public MainForm()
        {
            InitializeComponent();
            arr = new IVector[10];
            size = 0;
        }

        private void buttonAddVector_Click(object sender, EventArgs e)
        {
            FormAddVector f = new FormAddVector();
            if (f.ShowDialog() == DialogResult.OK)
            {
                arr[size] = f.Array; // get IVector from property of form "f"
                size++;
                labelVectors.Text += "\n" + arr[size - 1].ToString();
            }
        }

        private void buttonAddMenuItem1_Click(object sender, EventArgs e)
        {
            labelDelegate.Text += " 1";
            delegateForMenu += Action1;
        }

        private void buttonAddMenuItem2_Click(object sender, EventArgs e)
        {
            labelDelegate.Text += " 2";
            delegateForMenu += Action2;
        }

        private void buttonAddMenuItem3_Click(object sender, EventArgs e)
        {
            labelDelegate.Text += " 3";
            delegateForMenu += Action3;
        }

        private void buttonAddMenuItem4_Click(object sender, EventArgs e)
        {
            labelDelegate.Text += " 4";
            delegateForMenu += Action4;
        }

        private void buttonAddMenuItem5_Click(object sender, EventArgs e)
        {
            labelDelegate.Text += " 5";
            delegateForMenu += Action5;
        }

        // start delegate
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                MessageBox.Show("Добавьте векторы");
                return;
            }
            if (delegateForMenu == null)
            {
                MessageBox.Show("Введите последовательность для делегата");
                return;
            }            
            delegateForMenu(arr, size);
            MessageBox.Show("Программа успешно завершена!");
            Close();
        }
    }
}
