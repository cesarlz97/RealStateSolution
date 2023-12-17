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
    public partial class ClientDetailForm : Form
    {
        private Client _client { get; set; }

        public ClientDetailForm()
        {
            InitializeComponent();
        }

        public ClientDetailForm(Client client)
        {
            InitializeComponent();
            this._client = client;
        }

        private void ClientDetailForm_Load(object sender, EventArgs e)
        {
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.Image = new Bitmap(Resources.cara_1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {

        }
    }
}
