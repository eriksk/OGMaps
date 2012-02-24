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
    public partial class Form1 : Form
    {
        public Game1 game;
        public Editor editor;
        public Map map;

        public Form1()
        {
            InitializeComponent();
            editor = new Editor();
            editor.MdiParent = this;
            editor.StartPosition = FormStartPosition.Manual;
            editor.Location = new Point(550, 100);
            editor.Show();

            map = new Map();
            map.MdiParent = this;
            map.StartPosition = FormStartPosition.Manual;
            map.Location = new Point(20, 100);
            map.Show();

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.Exit();
        }
                
        public IntPtr GetDrawSurface()
        {
            return editor.GetDrawSurface();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
