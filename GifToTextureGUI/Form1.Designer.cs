namespace GifToTextureGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IMPORT = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WindowBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.interCheck = new System.Windows.Forms.CheckBox();
            this.pictureBoxNearest = new GifToTextureGUI.PictureBoxWithInterpolationMode();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.WindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNearest)).BeginInit();
            this.SuspendLayout();
            // 
            // IMPORT
            // 
            this.IMPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IMPORT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IMPORT.BackColor = System.Drawing.Color.Black;
            this.IMPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IMPORT.Font = new System.Drawing.Font("VCR OSD Mono", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IMPORT.ForeColor = System.Drawing.Color.White;
            this.IMPORT.Location = new System.Drawing.Point(12, 281);
            this.IMPORT.MinimumSize = new System.Drawing.Size(171, 86);
            this.IMPORT.Name = "IMPORT";
            this.IMPORT.Size = new System.Drawing.Size(171, 86);
            this.IMPORT.TabIndex = 6;
            this.IMPORT.Text = "import";
            this.IMPORT.UseVisualStyleBackColor = false;
            this.IMPORT.Click += new System.EventHandler(this.import_Click);
            this.IMPORT.MouseEnter += new System.EventHandler(this.importBtnEnter);
            this.IMPORT.MouseLeave += new System.EventHandler(this.importBtnLeave);
            // 
            // SAVE
            // 
            this.SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SAVE.BackColor = System.Drawing.Color.Black;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.Font = new System.Drawing.Font("VCR OSD Mono", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SAVE.ForeColor = System.Drawing.Color.White;
            this.SAVE.Location = new System.Drawing.Point(216, 281);
            this.SAVE.MinimumSize = new System.Drawing.Size(171, 86);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(171, 86);
            this.SAVE.TabIndex = 7;
            this.SAVE.Text = "save";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            this.SAVE.MouseEnter += new System.EventHandler(this.saveBtnEnter);
            this.SAVE.MouseLeave += new System.EventHandler(this.saveBtnLeave);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDown1.BackColor = System.Drawing.Color.Black;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(155, 460);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 43);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(84, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticks Per Second";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "there are 20 ticks per second";
            // 
            // WindowBar
            // 
            this.WindowBar.BackColor = System.Drawing.Color.White;
            this.WindowBar.Controls.Add(this.minimizeButton);
            this.WindowBar.Controls.Add(this.maximizeButton);
            this.WindowBar.Controls.Add(this.closeButton);
            this.WindowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBar.Location = new System.Drawing.Point(0, 0);
            this.WindowBar.Name = "WindowBar";
            this.WindowBar.Size = new System.Drawing.Size(399, 40);
            this.WindowBar.TabIndex = 12;
            this.WindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.WindowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.WindowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Gray;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(242, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(46, 26);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "\\/";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maximizeButton.Location = new System.Drawing.Point(294, 8);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(46, 26);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.Text = "/\\";
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(346, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(46, 26);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "///";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // interCheck
            // 
            this.interCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.interCheck.AutoSize = true;
            this.interCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.interCheck.Font = new System.Drawing.Font("VCR OSD Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interCheck.ForeColor = System.Drawing.Color.White;
            this.interCheck.Location = new System.Drawing.Point(139, 516);
            this.interCheck.Name = "interCheck";
            this.interCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interCheck.Size = new System.Drawing.Size(126, 17);
            this.interCheck.TabIndex = 13;
            this.interCheck.Text = "Interpolation";
            this.interCheck.UseVisualStyleBackColor = true;
            this.interCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxNearest
            // 
            this.pictureBoxNearest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNearest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxNearest.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pictureBoxNearest.Location = new System.Drawing.Point(12, 60);
            this.pictureBoxNearest.Name = "pictureBoxNearest";
            this.pictureBoxNearest.Size = new System.Drawing.Size(375, 201);
            this.pictureBoxNearest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNearest.TabIndex = 14;
            this.pictureBoxNearest.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(399, 558);
            this.Controls.Add(this.pictureBoxNearest);
            this.Controls.Add(this.interCheck);
            this.Controls.Add(this.WindowBar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.IMPORT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(399, 558);
            this.Name = "Form1";
            this.Text = "GifToTextureGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fullscreenBtn_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.WindowBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNearest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button IMPORT;
        private Button SAVE;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Panel WindowBar;
        private Button closeButton;
        private Button maximizeButton;
        private Button minimizeButton;
        private CheckBox interCheck;
        private PictureBoxWithInterpolationMode pictureBoxNearest;
    }
}