using PLFootballSystem.Controller;
using PLFootballSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms
{
    public partial class SettingsForm : Form
    {
        ControllerTheme ct = new ControllerTheme();
        public SettingsForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            List<ThemeModel> themeModels = ct.FindAll();
            foreach(var t in themeModels)
            {
                cbTheme.Items.Add(t.Description);
            }
        }
    }
}
