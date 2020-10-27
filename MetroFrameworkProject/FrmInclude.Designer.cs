namespace MetroFrameworkProject
{
    partial class FrmInclude
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
            this.cmdInclude = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStadium = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtState = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cmdInclude
            // 
            this.cmdInclude.Location = new System.Drawing.Point(63, 189);
            this.cmdInclude.Name = "cmdInclude";
            this.cmdInclude.Size = new System.Drawing.Size(320, 30);
            this.cmdInclude.TabIndex = 0;
            this.cmdInclude.Text = "Include";
            this.cmdInclude.Click += new System.EventHandler(this.cmdInclude_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Stadium:";
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(185, 92);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(198, 23);
            this.txtStadium.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "State:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(185, 133);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(198, 23);
            this.txtState.TabIndex = 4;
            // 
            // FrmInclude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 370);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmdInclude);
            this.Name = "FrmInclude";
            this.Text = "Include";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdInclude;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStadium;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtState;
    }
}