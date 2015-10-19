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

namespace SEPatRanking
{
    public partial class CalculatingForm : Form
    {
        public CalculatingForm()
        {
            InitializeComponent();
        }

        internal void Run()
        { //created so I can ShowDialog in a thread, as ThreadStart requires void return
            this.ShowDialog();
        }
    }
}
