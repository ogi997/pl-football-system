using PLFootballSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms.CityForm
{
   
    public partial class AddNewCityForm : Form
    {
        ControllerCity cc = new ControllerCity();
        public AddNewCityForm()
        {
            InitializeComponent();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string cityName = tbCityName.Text;
            cc.InsertCity(cityName);
        }
    }
}
