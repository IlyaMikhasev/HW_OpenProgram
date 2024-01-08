using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_OpenProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_note_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void b_calculator_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void b_paint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void b_startProcces_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(tb_nameProc.Text);
            }
            catch 
            {
                MessageBox.Show("Неверное название приложения");
            }
        }
    }
}
