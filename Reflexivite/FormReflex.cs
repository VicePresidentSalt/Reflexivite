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
            var classes = GetClasses();
        }

        List<Type> GetClasses()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsClass && t.Namespace == "Reflexivite")
                    .ToList();
        }


        private Type GetType(string name)
        {
            return Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(u => u.IsClass && u.Namespace == "Reflexivite" && u.Name == name);
        }

    /*
        private void CbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_Classes.SelectedItem.ToString()))
                UcConstructeurs.Display(GetType(cb_Classes.SelectedItem.ToString()));
        }

    */

    }
}
