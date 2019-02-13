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
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            webBrowser1.Navigate(text);
        }



    }
}
