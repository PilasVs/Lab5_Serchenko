using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Serchenko
{
    using Factory;
    using Matrices;
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string m1Text = Convert.ToString(matrix_1.Text);
                Matrix m1 = ScanMatrix(m1Text);

                string m2Text = Convert.ToString(matrix_2.Text);
                Matrix m2 = ScanMatrix(m2Text);

                Matrix m3 = m1 + m2;
                matrix_3.Text = m3.ToString();
                errorText.Text = "";
            }
            catch(Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                string m1Text = Convert.ToString(matrix_1.Text);
                Matrix m1 = ScanMatrix(m1Text);

                string m2Text = Convert.ToString(matrix_2.Text);
                Matrix m2 = ScanMatrix(m2Text);

                Matrix m3 = m1 - m2;
                matrix_3.Text = m3.ToString();
                errorText.Text = "";
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            try
            {
                string m1Text = Convert.ToString(matrix_1.Text);
                Matrix m1 = ScanMatrix(m1Text);

                string m2Text = Convert.ToString(matrix_2.Text);
                Matrix m2 = ScanMatrix(m2Text);

                Matrix m3 = m1 * m2;
                matrix_3.Text = m3.ToString();
                errorText.Text = "";
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void tra_1_Click(object sender, EventArgs e)
        {
            try
            {
                string m1Text = Convert.ToString(matrix_1.Text);
                Matrix m1 = ScanMatrix(m1Text);

                _ = ~m1;
                matrix_1.Text = m1.ToString();
                errorText.Text = "";
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void tra_2_Click(object sender, EventArgs e)
        {
            try
            {
                string m2Text = Convert.ToString(matrix_2.Text);
                Matrix m2 = ScanMatrix(m2Text);

                _ = ~m2;
                matrix_2.Text = m2.ToString();
                errorText.Text = "";
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void det_1_Click(object sender, EventArgs e)
        {
            try
            {
                string m1Text = Convert.ToString(matrix_1.Text);
                Matrix m1 = ScanMatrix(m1Text);

                det_res_1.Text = m1.Det().ToString();
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private void det_2_Click(object sender, EventArgs e)
        {
            try
            {
                string m2Text = Convert.ToString(matrix_2.Text);
                Matrix m2 = ScanMatrix(m2Text);

                det_res_2.Text = m2.Det().ToString();
            }
            catch (Exception exc)
            {
                errorText.Text = exc.Message;
            }
        }

        private Matrix ScanMatrix(string text)
        {
            uint rows = 0, cols = 0;
            foreach (var row in Regex.Split(text, "\r\n|\r|\n"))
            {
                if (row != "")
                {
                    cols = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        cols++;
                    }
                    rows++;
                }
            }
            Matrix m = FactoryMatrix.CreateMatrix(rows, cols);
            rows = 0;
            foreach (var row in Regex.Split(text, "\r\n|\r|\n"))
            {
                if (row != "")
                {
                    cols = 0;
                    foreach (var col in row.Trim().Split(' '))
                    {
                        if (double.TryParse(col, out m[rows][cols++]) == false)
                        {
                            throw new ArgumentException();
                        }
                    }
                    rows++;
                }
            }
            return m;
        }
    }
}
