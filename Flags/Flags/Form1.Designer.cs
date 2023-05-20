namespace Flags
{
    partial class Form1
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
            this.picBoxDisplay = new System.Windows.Forms.PictureBox();
            this.FranceRadioButton = new System.Windows.Forms.RadioButton();
            this.USARadioButton = new System.Windows.Forms.RadioButton();
            this.ColombiaRadioButton = new System.Windows.Forms.RadioButton();
            this.PhilippinesRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlagViewerLabel = new System.Windows.Forms.Label();
            this.ProgrammerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProgrammerCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryNameCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxDisplay
            // 
            this.picBoxDisplay.Location = new System.Drawing.Point(237, 100);
            this.picBoxDisplay.Name = "picBoxDisplay";
            this.picBoxDisplay.Size = new System.Drawing.Size(264, 186);
            this.picBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDisplay.TabIndex = 0;
            this.picBoxDisplay.TabStop = false;
            this.picBoxDisplay.Click += new System.EventHandler(this.picBoxDisplay_Click);
            // 
            // FranceRadioButton
            // 
            this.FranceRadioButton.AutoSize = true;
            this.FranceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranceRadioButton.Location = new System.Drawing.Point(30, 105);
            this.FranceRadioButton.Name = "FranceRadioButton";
            this.FranceRadioButton.Size = new System.Drawing.Size(87, 26);
            this.FranceRadioButton.TabIndex = 3;
            this.FranceRadioButton.Text = "France";
            this.FranceRadioButton.UseVisualStyleBackColor = true;
            this.FranceRadioButton.CheckedChanged += new System.EventHandler(this.FranceRadioButton_CheckedChanged);
            // 
            // USARadioButton
            // 
            this.USARadioButton.AutoSize = true;
            this.USARadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USARadioButton.Location = new System.Drawing.Point(30, 79);
            this.USARadioButton.Name = "USARadioButton";
            this.USARadioButton.Size = new System.Drawing.Size(68, 26);
            this.USARadioButton.TabIndex = 4;
            this.USARadioButton.Text = "USA";
            this.USARadioButton.UseVisualStyleBackColor = true;
            this.USARadioButton.CheckedChanged += new System.EventHandler(this.USARadioButton_CheckedChanged);
            // 
            // ColombiaRadioButton
            // 
            this.ColombiaRadioButton.AutoSize = true;
            this.ColombiaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColombiaRadioButton.Location = new System.Drawing.Point(30, 53);
            this.ColombiaRadioButton.Name = "ColombiaRadioButton";
            this.ColombiaRadioButton.Size = new System.Drawing.Size(106, 26);
            this.ColombiaRadioButton.TabIndex = 5;
            this.ColombiaRadioButton.Text = "Colombia";
            this.ColombiaRadioButton.UseVisualStyleBackColor = true;
            this.ColombiaRadioButton.CheckedChanged += new System.EventHandler(this.ColombiaRadioButton_CheckedChanged);
            // 
            // PhilippinesRadioButton
            // 
            this.PhilippinesRadioButton.AutoSize = true;
            this.PhilippinesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhilippinesRadioButton.Location = new System.Drawing.Point(30, 27);
            this.PhilippinesRadioButton.Name = "PhilippinesRadioButton";
            this.PhilippinesRadioButton.Size = new System.Drawing.Size(118, 26);
            this.PhilippinesRadioButton.TabIndex = 6;
            this.PhilippinesRadioButton.Text = "Philippines";
            this.PhilippinesRadioButton.UseVisualStyleBackColor = true;
            this.PhilippinesRadioButton.CheckedChanged += new System.EventHandler(this.PhilippinesRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColombiaRadioButton);
            this.groupBox1.Controls.Add(this.FranceRadioButton);
            this.groupBox1.Controls.Add(this.PhilippinesRadioButton);
            this.groupBox1.Controls.Add(this.USARadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // FlagViewerLabel
            // 
            this.FlagViewerLabel.AutoSize = true;
            this.FlagViewerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagViewerLabel.Location = new System.Drawing.Point(289, 55);
            this.FlagViewerLabel.Name = "FlagViewerLabel";
            this.FlagViewerLabel.Size = new System.Drawing.Size(153, 29);
            this.FlagViewerLabel.TabIndex = 8;
            this.FlagViewerLabel.Text = "Flag Viewer";
            this.FlagViewerLabel.Visible = false;
            // 
            // ProgrammerLabel
            // 
            this.ProgrammerLabel.AutoSize = true;
            this.ProgrammerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerLabel.Location = new System.Drawing.Point(121, 342);
            this.ProgrammerLabel.Name = "ProgrammerLabel";
            this.ProgrammerLabel.Size = new System.Drawing.Size(0, 32);
            this.ProgrammerLabel.TabIndex = 8;
            this.ProgrammerLabel.Visible = false;
            this.ProgrammerLabel.Click += new System.EventHandler(this.ProgrammerLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgrammerCheckBox);
            this.groupBox2.Controls.Add(this.CountryNameCheckBox);
            this.groupBox2.Controls.Add(this.TitleCheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ProgrammerCheckBox
            // 
            this.ProgrammerCheckBox.AutoSize = true;
            this.ProgrammerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrammerCheckBox.Location = new System.Drawing.Point(28, 79);
            this.ProgrammerCheckBox.Name = "ProgrammerCheckBox";
            this.ProgrammerCheckBox.Size = new System.Drawing.Size(130, 26);
            this.ProgrammerCheckBox.TabIndex = 10;
            this.ProgrammerCheckBox.Text = "Programmer";
            this.ProgrammerCheckBox.UseVisualStyleBackColor = true;
            this.ProgrammerCheckBox.CheckedChanged += new System.EventHandler(this.ProgrammerCheckBox_CheckedChanged);
            // 
            // CountryNameCheckBox
            // 
            this.CountryNameCheckBox.AutoSize = true;
            this.CountryNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameCheckBox.Location = new System.Drawing.Point(28, 53);
            this.CountryNameCheckBox.Name = "CountryNameCheckBox";
            this.CountryNameCheckBox.Size = new System.Drawing.Size(147, 26);
            this.CountryNameCheckBox.TabIndex = 10;
            this.CountryNameCheckBox.Text = "Country Name";
            this.CountryNameCheckBox.UseVisualStyleBackColor = true;
            this.CountryNameCheckBox.CheckedChanged += new System.EventHandler(this.CountryNameCheckBox_CheckedChanged);
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCheckBox.Location = new System.Drawing.Point(28, 27);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(67, 26);
            this.TitleCheckBox.TabIndex = 10;
            this.TitleCheckBox.Text = "Title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            this.TitleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // CountryNameLabel
            // 
            this.CountryNameLabel.AutoSize = true;
            this.CountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryNameLabel.Location = new System.Drawing.Point(300, 289);
            this.CountryNameLabel.Name = "CountryNameLabel";
            this.CountryNameLabel.Size = new System.Drawing.Size(0, 32);
            this.CountryNameLabel.TabIndex = 8;
            this.CountryNameLabel.Visible = false;
            this.CountryNameLabel.Click += new System.EventHandler(this.CountryNameLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(774, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CountryNameLabel);
            this.Controls.Add(this.ProgrammerLabel);
            this.Controls.Add(this.FlagViewerLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Flag Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxDisplay;
        private System.Windows.Forms.RadioButton FranceRadioButton;
        private System.Windows.Forms.RadioButton USARadioButton;
        private System.Windows.Forms.RadioButton ColombiaRadioButton;
        private System.Windows.Forms.RadioButton PhilippinesRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FlagViewerLabel;
        private System.Windows.Forms.Label ProgrammerLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ProgrammerCheckBox;
        private System.Windows.Forms.CheckBox CountryNameCheckBox;
        private System.Windows.Forms.CheckBox TitleCheckBox;
        private System.Windows.Forms.Label CountryNameLabel;
    }
}

