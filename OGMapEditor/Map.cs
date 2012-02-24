using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OGMaps;

namespace OGMapEditor
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private Game1 Game
        {
            get { return (MdiParent as Form1).game; }
        }

        private void buttonSaveScript_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteLayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewLayer_Click(object sender, EventArgs e)
        {

        }
    }
}
