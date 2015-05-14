using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflexivite
{
    public partial class FormReflex : Form
    {
        public FormReflex()
        {
            InitializeComponent();
        }

        private void FormReflex_Load(object sender, EventArgs e)
        {
            ConstructorInfo[] p = typeof(ClassAnimal).GetConstructors(
            BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in p)
            {
                cb_Classes.Items.Add(item.Name);
            }
        }

    }
}
