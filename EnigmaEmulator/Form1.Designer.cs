namespace EnigmaEmulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblReflector = new System.Windows.Forms.Label();
            this.cmbReflector = new System.Windows.Forms.ComboBox();
            this.lblWheelOrder = new System.Windows.Forms.Label();
            this.cmbR3 = new System.Windows.Forms.ComboBox();
            this.cmbR2 = new System.Windows.Forms.ComboBox();
            this.cmbR1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.lblRotor3 = new System.Windows.Forms.Label();
            this.lblRotor2 = new System.Windows.Forms.Label();
            this.lblRotor1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRotor3Up = new System.Windows.Forms.Button();
            this.btnRotor3Down = new System.Windows.Forms.Button();
            this.btnRotor2Up = new System.Windows.Forms.Button();
            this.btnRotor2Down = new System.Windows.Forms.Button();
            this.btnRotor1Up = new System.Windows.Forms.Button();
            this.btnRotor1Down = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReflector
            // 
            this.lblReflector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReflector.AutoSize = true;
            this.lblReflector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReflector.Location = new System.Drawing.Point(294, 310);
            this.lblReflector.Name = "lblReflector";
            this.lblReflector.Size = new System.Drawing.Size(134, 20);
            this.lblReflector.TabIndex = 0;
            this.lblReflector.Text = "Reflector Wheel:";
            // 
            // cmbReflector
            // 
            this.cmbReflector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReflector.DropDownWidth = 120;
            this.cmbReflector.FormattingEnabled = true;
            this.cmbReflector.Items.AddRange(new object[] {
            "--- B ---",
            "--- C ---"});
            this.cmbReflector.Location = new System.Drawing.Point(454, 306);
            this.cmbReflector.Name = "cmbReflector";
            this.cmbReflector.Size = new System.Drawing.Size(121, 24);
            this.cmbReflector.TabIndex = 1;
            this.cmbReflector.SelectionChangeCommitted += new System.EventHandler(this.cmbReflector_SelectionChangeCommitted);
            // 
            // lblWheelOrder
            // 
            this.lblWheelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWheelOrder.AutoSize = true;
            this.lblWheelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheelOrder.Location = new System.Drawing.Point(58, 18);
            this.lblWheelOrder.Name = "lblWheelOrder";
            this.lblWheelOrder.Size = new System.Drawing.Size(109, 20);
            this.lblWheelOrder.TabIndex = 2;
            this.lblWheelOrder.Text = "Wheel Order:";
            // 
            // cmbR3
            // 
            this.cmbR3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbR3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbR3.FormattingEnabled = true;
            this.cmbR3.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbR3.Location = new System.Drawing.Point(193, 18);
            this.cmbR3.Name = "cmbR3";
            this.cmbR3.Size = new System.Drawing.Size(65, 24);
            this.cmbR3.TabIndex = 3;
            this.cmbR3.SelectionChangeCommitted += new System.EventHandler(this.cmbR3_SelectionChangeCommitted);
            // 
            // cmbR2
            // 
            this.cmbR2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbR2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbR2.FormattingEnabled = true;
            this.cmbR2.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbR2.Location = new System.Drawing.Point(261, 18);
            this.cmbR2.Name = "cmbR2";
            this.cmbR2.Size = new System.Drawing.Size(65, 24);
            this.cmbR2.TabIndex = 4;
            this.cmbR2.SelectionChangeCommitted += new System.EventHandler(this.cmbR2_SelectionChangeCommitted);
            // 
            // cmbR1
            // 
            this.cmbR1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbR1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbR1.FormattingEnabled = true;
            this.cmbR1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbR1.Location = new System.Drawing.Point(332, 18);
            this.cmbR1.Name = "cmbR1";
            this.cmbR1.Size = new System.Drawing.Size(65, 24);
            this.cmbR1.TabIndex = 5;
            this.cmbR1.SelectionChangeCommitted += new System.EventHandler(this.cmbR1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ring Settings:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(75, 589);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(71, 25);
            this.label28.TabIndex = 13;
            this.label28.Text = "INPUT";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(80, 617);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(699, 22);
            this.txtInput.TabIndex = 14;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(80, 688);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(699, 22);
            this.txtOutput.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(75, 660);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 25);
            this.label29.TabIndex = 15;
            this.label29.Text = "OUTPUT";
            // 
            // lblRotor3
            // 
            this.lblRotor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotor3.Location = new System.Drawing.Point(193, 58);
            this.lblRotor3.Name = "lblRotor3";
            this.lblRotor3.Size = new System.Drawing.Size(63, 23);
            this.lblRotor3.TabIndex = 17;
            this.lblRotor3.Text = "A";
            this.lblRotor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotor2
            // 
            this.lblRotor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotor2.Location = new System.Drawing.Point(262, 58);
            this.lblRotor2.Name = "lblRotor2";
            this.lblRotor2.Size = new System.Drawing.Size(63, 23);
            this.lblRotor2.TabIndex = 18;
            this.lblRotor2.Text = "A";
            this.lblRotor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRotor1
            // 
            this.lblRotor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRotor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotor1.Location = new System.Drawing.Point(332, 58);
            this.lblRotor1.Name = "lblRotor1";
            this.lblRotor1.Size = new System.Drawing.Size(63, 23);
            this.lblRotor1.TabIndex = 19;
            this.lblRotor1.Text = "A";
            this.lblRotor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRotor3Up);
            this.groupBox2.Controls.Add(this.btnRotor3Down);
            this.groupBox2.Controls.Add(this.btnRotor2Up);
            this.groupBox2.Controls.Add(this.btnRotor2Down);
            this.groupBox2.Controls.Add(this.btnRotor1Up);
            this.groupBox2.Controls.Add(this.btnRotor1Down);
            this.groupBox2.Controls.Add(this.lblRotor1);
            this.groupBox2.Controls.Add(this.lblRotor2);
            this.groupBox2.Controls.Add(this.lblRotor3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbR1);
            this.groupBox2.Controls.Add(this.cmbR2);
            this.groupBox2.Controls.Add(this.cmbR3);
            this.groupBox2.Controls.Add(this.lblWheelOrder);
            this.groupBox2.Location = new System.Drawing.Point(203, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 148);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotors";
            // 
            // btnRotor3Up
            // 
            this.btnRotor3Up.Image = global::EnigmaEmulator.Properties.Resources.Up;
            this.btnRotor3Up.Location = new System.Drawing.Point(193, 90);
            this.btnRotor3Up.Name = "btnRotor3Up";
            this.btnRotor3Up.Size = new System.Drawing.Size(32, 40);
            this.btnRotor3Up.TabIndex = 53;
            this.btnRotor3Up.UseVisualStyleBackColor = true;
            this.btnRotor3Up.Click += new System.EventHandler(this.btnRotor3Up_Click);
            // 
            // btnRotor3Down
            // 
            this.btnRotor3Down.Image = global::EnigmaEmulator.Properties.Resources.Down;
            this.btnRotor3Down.Location = new System.Drawing.Point(226, 90);
            this.btnRotor3Down.Name = "btnRotor3Down";
            this.btnRotor3Down.Size = new System.Drawing.Size(32, 40);
            this.btnRotor3Down.TabIndex = 52;
            this.btnRotor3Down.UseVisualStyleBackColor = true;
            this.btnRotor3Down.Click += new System.EventHandler(this.btnRotor3Down_Click);
            // 
            // btnRotor2Up
            // 
            this.btnRotor2Up.Image = global::EnigmaEmulator.Properties.Resources.Up;
            this.btnRotor2Up.Location = new System.Drawing.Point(263, 90);
            this.btnRotor2Up.Name = "btnRotor2Up";
            this.btnRotor2Up.Size = new System.Drawing.Size(32, 40);
            this.btnRotor2Up.TabIndex = 23;
            this.btnRotor2Up.UseVisualStyleBackColor = true;
            this.btnRotor2Up.Click += new System.EventHandler(this.btnRotor2Up_Click);
            // 
            // btnRotor2Down
            // 
            this.btnRotor2Down.Image = global::EnigmaEmulator.Properties.Resources.Down;
            this.btnRotor2Down.Location = new System.Drawing.Point(296, 90);
            this.btnRotor2Down.Name = "btnRotor2Down";
            this.btnRotor2Down.Size = new System.Drawing.Size(32, 40);
            this.btnRotor2Down.TabIndex = 22;
            this.btnRotor2Down.UseVisualStyleBackColor = true;
            this.btnRotor2Down.Click += new System.EventHandler(this.btnRotor2Down_Click);
            // 
            // btnRotor1Up
            // 
            this.btnRotor1Up.Image = global::EnigmaEmulator.Properties.Resources.Up;
            this.btnRotor1Up.Location = new System.Drawing.Point(332, 90);
            this.btnRotor1Up.Name = "btnRotor1Up";
            this.btnRotor1Up.Size = new System.Drawing.Size(32, 40);
            this.btnRotor1Up.TabIndex = 21;
            this.btnRotor1Up.UseVisualStyleBackColor = true;
            this.btnRotor1Up.Click += new System.EventHandler(this.btnRotor1Up_Click);
            // 
            // btnRotor1Down
            // 
            this.btnRotor1Down.Image = global::EnigmaEmulator.Properties.Resources.Down;
            this.btnRotor1Down.Location = new System.Drawing.Point(365, 90);
            this.btnRotor1Down.Name = "btnRotor1Down";
            this.btnRotor1Down.Size = new System.Drawing.Size(32, 40);
            this.btnRotor1Down.TabIndex = 20;
            this.btnRotor1Down.UseVisualStyleBackColor = true;
            this.btnRotor1Down.Click += new System.EventHandler(this.btnRotor1Down_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Image = global::EnigmaEmulator.Properties.Resources.logo;
            this.lblLogo.Location = new System.Drawing.Point(143, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(580, 225);
            this.lblLogo.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 768);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cmbReflector);
            this.Controls.Add(this.lblReflector);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENIGMA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReflector;
        private System.Windows.Forms.ComboBox cmbReflector;
        private System.Windows.Forms.Label lblWheelOrder;
        private System.Windows.Forms.ComboBox cmbR3;
        private System.Windows.Forms.ComboBox cmbR2;
        private System.Windows.Forms.ComboBox cmbR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblRotor3;
        private System.Windows.Forms.Label lblRotor2;
        private System.Windows.Forms.Label lblRotor1;
        private System.Windows.Forms.Button btnRotor1Down;
        private System.Windows.Forms.Button btnRotor1Up;
        private System.Windows.Forms.Button btnRotor2Up;
        private System.Windows.Forms.Button btnRotor2Down;
        private System.Windows.Forms.Button btnRotor3Up;
        private System.Windows.Forms.Button btnRotor3Down;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLogo;
    }
}

