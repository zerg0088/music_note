namespace tempWindow
{
    partial class note
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
            this.button_plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Gulim", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_plus.Location = new System.Drawing.Point(31, 36);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(52, 51);
            this.button_plus.TabIndex = 0;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            // 
            // note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_plus);
            this.Name = "note";
            this.Size = new System.Drawing.Size(829, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_plus;
    }
}
