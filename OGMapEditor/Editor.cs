﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OGMapEditor
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }
        public IntPtr GetDrawSurface()
        {
            return pictureBox1.Handle;
        }
    }
}
