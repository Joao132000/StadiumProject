namespace MetroFrameworkProject
{
    partial class FrmAlter
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtState = new MetroFramework.Controls.MetroTextBox();
            this.txtStadium = new MetroFramework.Controls.MetroTextBox();
            this.cmdUpdate = new MetroFramework.Controls.MetroButton();
            this.cmbStadium = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(92, 197);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "State";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(92, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Stadium";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(236, 197);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(166, 23);
            this.txtState.TabIndex = 12;
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(236, 151);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(166, 23);
            this.txtStadium.TabIndex = 11;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(177, 256);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(102, 36);
            this.cmdUpdate.TabIndex = 10;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmbStadium
            // 
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.ItemHeight = 23;
            this.cmbStadium.Location = new System.Drawing.Point(236, 93);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(166, 29);
            this.cmbStadium.TabIndex = 9;
            this.cmbStadium.SelectedIndexChanged += new System.EventHandler(this.cmbStadium_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(89, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Select Stadium";
            // 
            // FrmAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAlter";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.FrmAlter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtState;
        private MetroFramework.Controls.MetroTextBox txtStadium;
        private MetroFramework.Controls.MetroButton cmdUpdate;
        private MetroFramework.Controls.MetroComboBox cmbStadium;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}