namespace MetroFrameworkProject
{
    partial class FrmExclude
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbStadium = new MetroFramework.Controls.MetroComboBox();
            this.cmdDelete = new MetroFramework.Controls.MetroButton();
            this.txtStadium = new MetroFramework.Controls.MetroTextBox();
            this.txtState = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(80, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select Stadium";
            // 
            // cmbStadium
            // 
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.ItemHeight = 23;
            this.cmbStadium.Location = new System.Drawing.Point(227, 106);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(166, 29);
            this.cmbStadium.TabIndex = 1;
            this.cmbStadium.SelectedIndexChanged += new System.EventHandler(this.cmbStadium_SelectedIndexChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(168, 269);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(102, 36);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtStadium
            // 
            this.txtStadium.Enabled = false;
            this.txtStadium.Location = new System.Drawing.Point(227, 164);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(166, 23);
            this.txtStadium.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(227, 210);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(166, 23);
            this.txtState.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 164);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Stadium";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(83, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "State";
            // 
            // FrmExclude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmExclude";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.FrmExclude_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbStadium;
        private MetroFramework.Controls.MetroButton cmdDelete;
        private MetroFramework.Controls.MetroTextBox txtStadium;
        private MetroFramework.Controls.MetroTextBox txtState;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}