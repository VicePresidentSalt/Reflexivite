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

namespace Reflexivite
{
    public partial class UserControl_Constructeurs : UserControl
    {
        private ConstructorInfo info = null;
        private Type type = null;

        public UserControl_Constructeurs()
        {
            InitializeComponent();
            btn_Construire.Enabled = false;
        }
        public void ShowConstructeurs(Type Type)
        {
            listBox_Constructeurs.DataSource = Type.GetConstructors();
            type = Type ;
        }
        public void ChangeButtonState()
        {
            btn_Construire.Enabled = true;
        }

        private void btn_Construire_Click(object sender, EventArgs e)
        {
            info = getConstructorInfos();
            if (info.GetParameters().Length == 0)
            {
                userControl_Methodes.ShowMethods(type, info.Invoke(info.GetParameters()));
                userControl_Methodes.ChangeButtonState();
                MessageBox.Show("L'objet est construit");
            }
            else
            {
                userControl_Methodes.ChangeButtonState();
                Form_Parametres form = new Form_Parametres(info.GetParameters());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    userControl_Methodes.ShowMethods(type, info.Invoke(form.controle));
                    MessageBox.Show("L'objet est construit");
                }

            }
        }
        private ConstructorInfo getConstructorInfos()
        {
            ConstructorInfo info = (ConstructorInfo)listBox_Constructeurs.SelectedItem;
            return info;
        }
    }
}
