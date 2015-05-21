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
    public partial class Form_Parametres : Form
    {
        public dynamic[] controle = null;
        private ParameterInfo[] paramInfos;

        public Form_Parametres()
        {
            InitializeComponent();
        }

        public Form_Parametres(ParameterInfo[] pi)
		{
			InitializeComponent();

			controle = new dynamic[pi.Length];
            paramInfos = pi;

            foreach (var piInfos in paramInfos)
            flp_Parametres.Controls.Add(GetFLP(piInfos));
		}

        private FlowLayoutPanel GetFLP(ParameterInfo paramInfos)
        {
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Controls.Add(GetParameter("Label", paramInfos));

            switch (paramInfos.ParameterType.Name)
            {
                case "DateTime":
                    flowPanel.Controls.Add(GetParameter("DateTimePicker", paramInfos));
                    break;
                default:
                    flowPanel.Controls.Add(GetParameter("TextBox", paramInfos));
                    break;
            }

            return flowPanel;
        }

        private void btn_Confirmer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < paramInfos.Length; ++i)
            {
                Control[] ctrl = Controls.Find(paramInfos[i].Name, true);
                string typeCtrl = ctrl[0].GetType().Name;

                switch (typeCtrl)
                {
                    case "DateTimePicker":
                        controle[i] = ((DateTimePicker)ctrl[0]).Value.Date;
                        break;

                    case "TextBox":
                        if (paramInfos[i].ParameterType.FullName == "System.Int32")
                            try
                            {
                                controle[i] = Convert.ToInt32(ctrl[0].Text);
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Votre entrée n'est pas un entier");
                            }
                        else
                            controle[i] = ctrl[0].Text;
                        break;
                }
                DialogResult = DialogResult.OK;
            }
            
        }


        private dynamic GetParameter(string typeCtrl, ParameterInfo paramInfos)
        {
            dynamic typeReturn = null;

            switch (typeCtrl)
            {
                case "Label":
                    Label label = new Label();
                    label.Text = paramInfos.Name;
                    typeReturn = label;
                    break;
                case "DateTimePicker":
                    DateTimePicker dateTime = new DateTimePicker();
                    dateTime.Name = paramInfos.Name;
                    typeReturn = dateTime;
                    break;
                case "CheckBox":
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = paramInfos.Name;
                    typeReturn = checkBox;
                    break;
                case "TextBox":
                    TextBox txt = new TextBox();
                    txt.Name = paramInfos.Name;
                    typeReturn = txt;
                    break;
            }
            return typeReturn;
        }
    }
}
