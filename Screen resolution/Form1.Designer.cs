namespace Screen_resolution
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.lblHeight);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 714);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(504, 541);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(212, 55);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeight.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(296, 398);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(629, 58);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Screen Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidth.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(296, 340);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(629, 58);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Screen Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplay.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(296, 247);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(629, 58);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "0000 x 000";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(315, 102);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(589, 58);
            this.header.TabIndex = 0;
            this.header.Text = "Your Screen Resolution is";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 714);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen resolution";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblHeight;
    }
}

