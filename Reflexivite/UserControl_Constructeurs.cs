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

        private void UserControl_Constructeurs_Load(object sender, EventArgs e)
        {
            
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
                userControl_Methodes1.ShowMethods(type, info.Invoke(info.GetParameters()));
                MessageBox.Show("Objet construit");
            }
            else
            {
            }
        }

        private void listBox_Constructeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public ConstructorInfo getConstructorInfos()
        {
            ConstructorInfo info = (ConstructorInfo)listBox_Constructeurs.SelectedItem;
            return info;
        }
    }
}
