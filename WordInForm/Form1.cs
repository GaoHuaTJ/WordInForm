using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string DefaultPath = "";
        private void btnChooseWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog wordOpenfileDiag = new OpenFileDialog();
            if (DefaultPath != "")//用来记录上次打开的文件地址
            {
                wordOpenfileDiag.FileName = DefaultPath;
            }
            if (wordOpenfileDiag.ShowDialog() == DialogResult.OK)
            {
                DefaultPath = wordOpenfileDiag.FileName;
                textBoxPath.Text = wordOpenfileDiag.FileName;//显示选择的word文件地址
                textBoxPath.Enabled = false;
            }
        }

        private void btnOpenWord_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(this.textBoxPath.Text);//将文件地址传给form2
            Form2.ShowDialog();
        }
    }
}
