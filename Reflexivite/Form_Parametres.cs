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
        public object[] objets { get; private set; }
        private ParameterInfo[] parameters;

        public Form_Parametres()
        {
            InitializeComponent();
        }

        public Form_Parametres(ParameterInfo[] p)
		{
			InitializeComponent();

			objets = new object[p.Length];
			parameters = p;

			foreach (var pi in parameters)
				flp_Parametres.Controls.Add(GetFlowLayoutPanel(pi));
		}

        private void btn_Confirmer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < parameters.Length; ++i)
            {
                Control[] ctrl = Controls.Find(parameters[i].Name, true);
                errorProvider1.SetError(ctrl[0].Parent, string.Empty);
               

                if (ctrl[0] is CheckBox)
                    objets[i] = ((CheckBox)ctrl[0]).Checked;
                else if (ctrl[0] is DateTimePicker)
                    objets[i] = ((DateTimePicker)ctrl[0]).Value.Date;
                else if (ctrl[0] is TextBox)
                    objets[i] = ConvertTo((TextBox)ctrl[0], parameters[i]);

                if (!string.IsNullOrEmpty(errorProvider1.GetError(ctrl[0].Parent))) return;
            }

            DialogResult = DialogResult.OK;
        }
        
        private object ConvertTo(TextBox ctrl, ParameterInfo pi)
		{
			string valeur = ctrl.Text;

			switch (pi.ParameterType.Name)
			{
				case "Int32":
					int nbInt;
					if (int.TryParse(valeur, out nbInt))
						return nbInt;
					else
						errorProvider1.SetError(ctrl.Parent, "La valeur doit être un entier.");
					break;
				case "Float":
					float nbFloat;
					if (float.TryParse(valeur, out nbFloat))
						return nbFloat;
					else
						errorProvider1.SetError(ctrl.Parent, "La valeur doit être un float.");
					break;
				case "Double":
					double nbDouble;
					if (double.TryParse(valeur, out nbDouble))
						return nbDouble;
					else
						errorProvider1.SetError(ctrl.Parent, "La valeur doit être un double.");
					break;
			}
            return valeur;
        }
         


        private FlowLayoutPanel GetFlowLayoutPanel(ParameterInfo pi)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.AutoSize = true;
            flp.Controls.Add(GetLabel(pi));

            switch (pi.ParameterType.Name)
            {
                case "DateTime":
                    flp.Controls.Add(GetDateTimePicker(pi));
                    break;
                case "Boolean":
                    flp.Controls.Add(GetCheckBox(pi));
                    break;
                default:
                    flp.Controls.Add(GetTextBox(pi));
                    break;
            }

            return flp;
        }


        private Label GetLabel(ParameterInfo pi)
        {
            Label lbl = new Label();
            lbl.Text = pi.Name + ":";
            lbl.AutoSize = true;
            lbl.Padding = new Padding(0, 5, 0, 0);
            return lbl;
        }


        private TextBox GetTextBox(ParameterInfo pi)
        {
            TextBox txtBox = new TextBox();
            return txtBox;
        }


        private DateTimePicker GetDateTimePicker(ParameterInfo pi)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Name = pi.Name;
            return dateTimePicker;
        }


        private CheckBox GetCheckBox(ParameterInfo pi)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = pi.Name;
            return checkBox;
        }

    }
}
