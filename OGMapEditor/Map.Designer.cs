namespace OGMapEditor
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLayers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParallax = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewLayer = new System.Windows.Forms.Button();
            this.buttonSaveScript = new System.Windows.Forms.Button();
            this.buttonDeleteLayer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLayers
            // 
            this.listBoxLayers.FormattingEnabled = true;
            this.listBoxLayers.Location = new System.Drawing.Point(6, 19);
            this.listBoxLayers.Name = "listBoxLayers";
            this.listBoxLayers.Size = new System.Drawing.Size(188, 316);
            this.listBoxLayers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveScript);
            this.groupBox1.Controls.Add(this.buttonDeleteLayer);
            this.groupBox1.Controls.Add(this.buttonNewLayer);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBoxParallax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxLayers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 589);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parallax";
            // 
            // textBoxParallax
            // 
            this.textBoxParallax.Location = new System.Drawing.Point(203, 35);
            this.textBoxParallax.Name = "textBoxParallax";
            this.textBoxParallax.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallax.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(200, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 430);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scripts";
            // 
            // buttonNewLayer
            // 
            this.buttonNewLayer.Location = new System.Drawing.Point(6, 341);
            this.buttonNewLayer.Name = "buttonNewLayer";
            this.buttonNewLayer.Size = new System.Drawing.Size(75, 23);
            this.buttonNewLayer.TabIndex = 4;
            this.buttonNewLayer.Text = "New";
            this.buttonNewLayer.UseVisualStyleBackColor = true;
            this.buttonNewLayer.Click += new System.EventHandler(this.buttonNewLayer_Click);
            // 
            // buttonSaveScript
            // 
            this.buttonSaveScript.Location = new System.Drawing.Point(386, 510);
            this.buttonSaveScript.Name = "buttonSaveScript";
            this.buttonSaveScript.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveScript.TabIndex = 4;
            this.buttonSaveScript.Text = "Save";
            this.buttonSaveScript.UseVisualStyleBackColor = true;
            this.buttonSaveScript.Click += new System.EventHandler(this.buttonSaveScript_Click);
            // 
            // buttonDeleteLayer
            // 
            this.buttonDeleteLayer.Location = new System.Drawing.Point(119, 341);
            this.buttonDeleteLayer.Name = "buttonDeleteLayer";
            this.buttonDeleteLayer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteLayer.TabIndex = 4;
            this.buttonDeleteLayer.Text = "Delete";
            this.buttonDeleteLayer.UseVisualStyleBackColor = true;
            this.buttonDeleteLayer.Click += new System.EventHandler(this.buttonDeleteLayer_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 613);
            this.Controls.Add(this.groupBox1);
            this.Name = "Map";
            this.Text = "Map";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveScript;
        private System.Windows.Forms.Button buttonDeleteLayer;
        private System.Windows.Forms.Button buttonNewLayer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxParallax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}