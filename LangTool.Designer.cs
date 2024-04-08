namespace ONE1_richTextCtrl
{
    partial class LangTool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbHE = new System.Windows.Forms.RadioButton();
            this.rdbEN = new System.Windows.Forms.RadioButton();
            this.rdbOff = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbHE
            // 
            this.rdbHE.AutoSize = true;
            this.rdbHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbHE.Location = new System.Drawing.Point(4, 4);
            this.rdbHE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbHE.Name = "rdbHE";
            this.rdbHE.Size = new System.Drawing.Size(48, 21);
            this.rdbHE.TabIndex = 0;
            this.rdbHE.TabStop = true;
            this.rdbHE.Text = "HE";
            this.rdbHE.UseVisualStyleBackColor = true;
            this.rdbHE.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbEN
            // 
            this.rdbEN.AutoSize = true;
            this.rdbEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbEN.Location = new System.Drawing.Point(65, 4);
            this.rdbEN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEN.Name = "rdbEN";
            this.rdbEN.Size = new System.Drawing.Size(48, 21);
            this.rdbEN.TabIndex = 1;
            this.rdbEN.TabStop = true;
            this.rdbEN.Text = "EN";
            this.rdbEN.UseVisualStyleBackColor = true;
            this.rdbEN.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbOff
            // 
            this.rdbOff.AutoSize = true;
            this.rdbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbOff.Location = new System.Drawing.Point(127, 4);
            this.rdbOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbOff.Name = "rdbOff";
            this.rdbOff.Size = new System.Drawing.Size(56, 21);
            this.rdbOff.TabIndex = 2;
            this.rdbOff.TabStop = true;
            this.rdbOff.Text = "OFF";
            this.rdbOff.UseVisualStyleBackColor = true;
            this.rdbOff.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // LangTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.rdbOff);
            this.Controls.Add(this.rdbEN);
            this.Controls.Add(this.rdbHE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LangTool";
            this.Size = new System.Drawing.Size(192, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbHE;
        private System.Windows.Forms.RadioButton rdbEN;
        private System.Windows.Forms.RadioButton rdbOff;
    }
}
