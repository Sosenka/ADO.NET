using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        AWE dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new AWE();
            dbContext.Product.Load();
            productBindingSource.DataSource = dbContext.Product.Local.ToBindingList();
        }
    }
}
