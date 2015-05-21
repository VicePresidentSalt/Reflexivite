using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Reflexivite
{
    public partial class UserControl_Methodes : UserControl
    {
        private dynamic obj = null;
        private MethodInfo info = null;

        public UserControl_Methodes()
        {
            InitializeComponent();
            btn_Appliquer.Enabled = false;
        }

        public void ShowMethods<T>(Type Type, T ClassT)
        {
            obj = ClassT;
            listBox_Methodes.DataSource = Type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            btn_Appliquer.Enabled = true;
        }

        public void ChangeButtonState()
        {
            btn_Appliquer.Enabled = true;
        }

        private void btn_Appliquer_Click(object sender, EventArgs e)
        {
            info = (MethodInfo)listBox_Methodes.SelectedItem;
            if (info.GetParameters().Length == 0)
            {
                var returnMethod = info.Invoke(obj, null);
                if (returnMethod == null)
                    MessageBox.Show("Opération réussie");
                else
                    MessageBox.Show(returnMethod.ToString());
            }
            else
            {
                Form_Parametres form = new Form_Parametres(info.GetParameters());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var returnMethod = info.Invoke(obj, null);
                    if (returnMethod == null)
                        MessageBox.Show("Opération réussie");
                    else
                        MessageBox.Show(returnMethod.ToString());
                }

            }
        }
    }
}
