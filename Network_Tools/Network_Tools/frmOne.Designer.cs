namespace Network_Tools
{
    partial class frmOne
    {
         
         
         
        private System.ComponentModel.IContainer components = null;

         
         
         
         
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

         
         
         
         
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOne));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txtArgument = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
             
             
             
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(12, 143);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(526, 198);
            this.txtResult.TabIndex = 0;
             
             
             
            this.cboCommand.FormattingEnabled = true;
            this.cboCommand.Location = new System.Drawing.Point(220, 119);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Size = new System.Drawing.Size(121, 21);
            this.cboCommand.TabIndex = 3;
            this.cboCommand.SelectedIndexChanged += new System.EventHandler(this.cboCommand_SelectedIndexChanged);
             
             
             
            this.styleManager1.ManagerColorTint = System.Drawing.Color.MediumOrchid;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
             
             
             
            this.txtArgument.Location = new System.Drawing.Point(16, 119);
            this.txtArgument.Name = "txtArgument";
            this.txtArgument.Size = new System.Drawing.Size(198, 20);
            this.txtArgument.TabIndex = 4;
             
             
             
            this.pictureBox1.Image = global::Network_Tools.Properties.Resources.preferences_system_network;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
             
             
             
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Network Administrator Tools";
             
             
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(547, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtArgument);
            this.Controls.Add(this.cboCommand);
            this.Controls.Add(this.txtResult);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASA - Network Administrator Tools";
            this.Load += new System.EventHandler(this.frmOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cboCommand;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.TextBox txtArgument;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

