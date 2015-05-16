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
            var theList = Assembly.GetExecutingAssembly().GetTypes().ToList().Where(t => t.IsClass && t.Namespace == "Reflexivite").ToList();
            foreach (var item in theList)
            {
                cb_Classes.Items.Add(item.Name);
            }
        }

        private void cb_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(cb_Classes.SelectedItem.ToString()))
                 userControl_Constructeurs1.ShowConstructeurs(GetType(cb_Classes.SelectedItem.ToString()));
           userControl_Constructeurs1.ChangeButtonState();
        }

        private Type GetType(string classe)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                                .SelectMany(a => a.GetTypes())
                                .Where(t => t.Name == classe && t.IsClass && t.Namespace == "Reflexivite")
                                .FirstOrDefault();
        }
    }
}