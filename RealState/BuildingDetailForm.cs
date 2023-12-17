using RealState.Models;
using RealState.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealState
{
    public partial class BuildingDetailForm : Form
    {
        private Property _property { get; set; }

        public BuildingDetailForm()
        {
            InitializeComponent();
        }

        public BuildingDetailForm(Property property)
        {
            InitializeComponent();
            this._property = property;
        }

        private void BuildingDetailForm_Load(object sender, EventArgs e)
        {
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.Image = new Bitmap(Resources.casa_1);
        }

        private void buttonSaveBuilding_Click(object sender, EventArgs e)
        {

        }
    }
}
