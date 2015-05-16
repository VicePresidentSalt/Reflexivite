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
    public partial class UserControl_Methodes : UserControl
    {
        public UserControl_Methodes()
        {
            InitializeComponent();
            btn_Appliquer.Enabled = false;
        }

        public void ShowMethods<T>(Type Type , T classT)
        {  
            listBox_Methodes.DataSource = Type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            btn_Appliquer.Enabled = true;
        }
    }
}
