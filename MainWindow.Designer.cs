namespace ParallaxTextureCompositor
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBoxSteep = new PictureBox();
            pictureBoxHigh = new PictureBox();
            pictureBoxMid = new PictureBox();
            pictureBoxLow = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBoxAO = new PictureBox();
            pictureBoxDisplacement = new PictureBox();
            checkBoxLow = new CheckBox();
            checkBoxMid = new CheckBox();
            checkBoxHigh = new CheckBox();
            checkBoxSteep = new CheckBox();
            buttonCombineDisplacement = new Button();
            button1 = new Button();
            label6 = new Label();
            buttonCopyDisplacement = new Button();
            buttonCopyAO = new Button();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSteep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHigh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplacement).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1361, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(122, 26);
            openToolStripMenuItem.Text = "New";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(221, 221, 221);
            label1.Location = new Point(11, 40);
            label1.Name = "label1";
            label1.Size = new Size(596, 48);
            label1.TabIndex = 1;
            label1.Text = "Parallax Texture Compositor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(221, 221, 221);
            label2.Location = new Point(349, 97);
            label2.Name = "label2";
            label2.Size = new Size(177, 33);
            label2.TabIndex = 3;
            label2.Text = "Mid Texture";
            // 
            // pictureBoxSteep
            // 
            pictureBoxSteep.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxSteep.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxSteep.Location = new Point(1023, 133);
            pictureBoxSteep.Name = "pictureBoxSteep";
            pictureBoxSteep.Size = new Size(329, 331);
            pictureBoxSteep.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSteep.TabIndex = 3;
            pictureBoxSteep.TabStop = false;
            pictureBoxSteep.Click += pictureBoxSteep_Click;
            // 
            // pictureBoxHigh
            // 
            pictureBoxHigh.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxHigh.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHigh.Location = new Point(686, 133);
            pictureBoxHigh.Name = "pictureBoxHigh";
            pictureBoxHigh.Size = new Size(331, 331);
            pictureBoxHigh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHigh.TabIndex = 2;
            pictureBoxHigh.TabStop = false;
            pictureBoxHigh.Click += pictureBoxHigh_Click;
            // 
            // pictureBoxMid
            // 
            pictureBoxMid.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxMid.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMid.Location = new Point(349, 133);
            pictureBoxMid.Name = "pictureBoxMid";
            pictureBoxMid.Size = new Size(331, 331);
            pictureBoxMid.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMid.TabIndex = 1;
            pictureBoxMid.TabStop = false;
            pictureBoxMid.Click += pictureBoxMid_Click;
            // 
            // pictureBoxLow
            // 
            pictureBoxLow.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxLow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLow.Location = new Point(12, 133);
            pictureBoxLow.Name = "pictureBoxLow";
            pictureBoxLow.Size = new Size(331, 331);
            pictureBoxLow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLow.TabIndex = 0;
            pictureBoxLow.TabStop = false;
            pictureBoxLow.Click += pictureBoxLow_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(221, 221, 221);
            label5.Location = new Point(686, 97);
            label5.Name = "label5";
            label5.Size = new Size(191, 33);
            label5.TabIndex = 6;
            label5.Text = "High Texture";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(221, 221, 221);
            label4.Location = new Point(1023, 97);
            label4.Name = "label4";
            label4.Size = new Size(205, 33);
            label4.TabIndex = 5;
            label4.Text = "Steep Texture";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(221, 221, 221);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(184, 33);
            label3.TabIndex = 4;
            label3.Text = "Low Texture";
            // 
            // pictureBoxAO
            // 
            pictureBoxAO.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxAO.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAO.Location = new Point(686, 470);
            pictureBoxAO.Name = "pictureBoxAO";
            pictureBoxAO.Size = new Size(331, 331);
            pictureBoxAO.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAO.TabIndex = 3;
            pictureBoxAO.TabStop = false;
            pictureBoxAO.Click += pictureBoxAO_Click;
            // 
            // pictureBoxDisplacement
            // 
            pictureBoxDisplacement.BackColor = Color.FromArgb(45, 45, 45);
            pictureBoxDisplacement.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDisplacement.Location = new Point(349, 470);
            pictureBoxDisplacement.Name = "pictureBoxDisplacement";
            pictureBoxDisplacement.Size = new Size(331, 331);
            pictureBoxDisplacement.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDisplacement.TabIndex = 2;
            pictureBoxDisplacement.TabStop = false;
            pictureBoxDisplacement.Click += pictureBoxDisplacement_Click;
            // 
            // checkBoxLow
            // 
            checkBoxLow.AutoSize = true;
            checkBoxLow.ForeColor = Color.FromArgb(209, 209, 209);
            checkBoxLow.Location = new Point(691, 59);
            checkBoxLow.Name = "checkBoxLow";
            checkBoxLow.Size = new Size(107, 24);
            checkBoxLow.TabIndex = 7;
            checkBoxLow.Text = "Enable Low";
            checkBoxLow.UseVisualStyleBackColor = true;
            checkBoxLow.CheckedChanged += checkBoxLow_CheckedChanged;
            // 
            // checkBoxMid
            // 
            checkBoxMid.AutoSize = true;
            checkBoxMid.ForeColor = Color.FromArgb(209, 209, 209);
            checkBoxMid.Location = new Point(829, 59);
            checkBoxMid.Name = "checkBoxMid";
            checkBoxMid.Size = new Size(106, 24);
            checkBoxMid.TabIndex = 8;
            checkBoxMid.Text = "Enable Mid";
            checkBoxMid.UseVisualStyleBackColor = true;
            checkBoxMid.CheckedChanged += checkBoxMid_CheckedChanged;
            // 
            // checkBoxHigh
            // 
            checkBoxHigh.AutoSize = true;
            checkBoxHigh.ForeColor = Color.FromArgb(209, 209, 209);
            checkBoxHigh.Location = new Point(966, 59);
            checkBoxHigh.Name = "checkBoxHigh";
            checkBoxHigh.Size = new Size(112, 24);
            checkBoxHigh.TabIndex = 9;
            checkBoxHigh.Text = "Enable High";
            checkBoxHigh.UseVisualStyleBackColor = true;
            checkBoxHigh.CheckedChanged += checkBoxHigh_CheckedChanged;
            // 
            // checkBoxSteep
            // 
            checkBoxSteep.AutoSize = true;
            checkBoxSteep.ForeColor = Color.FromArgb(209, 209, 209);
            checkBoxSteep.Location = new Point(1109, 59);
            checkBoxSteep.Name = "checkBoxSteep";
            checkBoxSteep.Size = new Size(118, 24);
            checkBoxSteep.TabIndex = 10;
            checkBoxSteep.Text = "Enable Steep";
            checkBoxSteep.UseVisualStyleBackColor = true;
            checkBoxSteep.CheckedChanged += checkBoxSteep_CheckedChanged;
            // 
            // buttonCombineDisplacement
            // 
            buttonCombineDisplacement.BackColor = Color.FromArgb(45, 45, 45);
            buttonCombineDisplacement.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            buttonCombineDisplacement.FlatAppearance.BorderSize = 0;
            buttonCombineDisplacement.FlatStyle = FlatStyle.Flat;
            buttonCombineDisplacement.ForeColor = Color.LightGray;
            buttonCombineDisplacement.Location = new Point(12, 517);
            buttonCombineDisplacement.Name = "buttonCombineDisplacement";
            buttonCombineDisplacement.Size = new Size(331, 41);
            buttonCombineDisplacement.TabIndex = 11;
            buttonCombineDisplacement.Text = "Combine To Displacement";
            buttonCombineDisplacement.UseVisualStyleBackColor = false;
            buttonCombineDisplacement.Click += buttonCombineDisplacement_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 45, 45);
            button1.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(12, 564);
            button1.Name = "button1";
            button1.Size = new Size(331, 41);
            button1.TabIndex = 12;
            button1.Text = "Combine To Occlusion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(221, 221, 221);
            label6.Location = new Point(12, 474);
            label6.Name = "label6";
            label6.Size = new Size(218, 33);
            label6.TabIndex = 13;
            label6.Text = "Generate Maps";
            // 
            // buttonCopyDisplacement
            // 
            buttonCopyDisplacement.BackColor = Color.FromArgb(45, 45, 45);
            buttonCopyDisplacement.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            buttonCopyDisplacement.FlatAppearance.BorderSize = 0;
            buttonCopyDisplacement.FlatStyle = FlatStyle.Flat;
            buttonCopyDisplacement.ForeColor = Color.LightGray;
            buttonCopyDisplacement.Location = new Point(349, 807);
            buttonCopyDisplacement.Name = "buttonCopyDisplacement";
            buttonCopyDisplacement.Size = new Size(331, 41);
            buttonCopyDisplacement.TabIndex = 14;
            buttonCopyDisplacement.Text = "Copy to Clipboard";
            buttonCopyDisplacement.UseVisualStyleBackColor = false;
            buttonCopyDisplacement.Click += buttonCopyDisplacement_Click;
            // 
            // buttonCopyAO
            // 
            buttonCopyAO.BackColor = Color.FromArgb(45, 45, 45);
            buttonCopyAO.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
            buttonCopyAO.FlatAppearance.BorderSize = 0;
            buttonCopyAO.FlatStyle = FlatStyle.Flat;
            buttonCopyAO.ForeColor = Color.LightGray;
            buttonCopyAO.Location = new Point(686, 807);
            buttonCopyAO.Name = "buttonCopyAO";
            buttonCopyAO.Size = new Size(331, 41);
            buttonCopyAO.TabIndex = 15;
            buttonCopyAO.Text = "Copy to Clipboard";
            buttonCopyAO.UseVisualStyleBackColor = false;
            buttonCopyAO.Click += buttonCopyAO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1361, 878);
            Controls.Add(buttonCopyAO);
            Controls.Add(buttonCopyDisplacement);
            Controls.Add(label6);
            Controls.Add(pictureBoxAO);
            Controls.Add(label4);
            Controls.Add(pictureBoxDisplacement);
            Controls.Add(label5);
            Controls.Add(pictureBoxSteep);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBoxHigh);
            Controls.Add(buttonCombineDisplacement);
            Controls.Add(pictureBoxMid);
            Controls.Add(checkBoxSteep);
            Controls.Add(pictureBoxLow);
            Controls.Add(checkBoxHigh);
            Controls.Add(checkBoxMid);
            Controls.Add(checkBoxLow);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Parallax Texture Compositor";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSteep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHigh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplacement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBoxSteep;
        private PictureBox pictureBoxHigh;
        private PictureBox pictureBoxMid;
        private PictureBox pictureBoxLow;
        private PictureBox pictureBoxAO;
        private PictureBox pictureBoxDisplacement;
        private CheckBox checkBoxLow;
        private CheckBox checkBoxMid;
        private CheckBox checkBoxHigh;
        private CheckBox checkBoxSteep;
        private Button buttonCombineDisplacement;
        private Button button1;
        private Label label6;
        private Button buttonCopyDisplacement;
        private Button buttonCopyAO;
    }
}