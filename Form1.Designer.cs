namespace tempWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.loading_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabsUp = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tabInst = new System.Windows.Forms.TabPage();
            this.tabNote = new System.Windows.Forms.TabPage();
            this.tabSign = new System.Windows.Forms.TabPage();
            this.tabOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.button_menu = new System.Windows.Forms.Button();
            this.button_inst = new System.Windows.Forms.Button();
            this.button_note = new System.Windows.Forms.Button();
            this.button_sign = new System.Windows.Forms.Button();
            this.loading_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabsUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(887, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "내보내기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(798, 112);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(83, 38);
            this.button_convert.TabIndex = 5;
            this.button_convert.Text = "가사 변환";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Visible = false;
            this.button_convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(934, 31);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(36, 38);
            this.button_play.TabIndex = 6;
            this.button_play.Text = "▶";
            this.button_play.UseVisualStyleBackColor = true;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(892, 31);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(36, 38);
            this.button_stop.TabIndex = 7;
            this.button_stop.Text = "■";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // loading_panel
            // 
            this.loading_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loading_panel.Controls.Add(this.label3);
            this.loading_panel.Controls.Add(this.pictureBox5);
            this.loading_panel.Location = new System.Drawing.Point(385, 190);
            this.loading_panel.Name = "loading_panel";
            this.loading_panel.Size = new System.Drawing.Size(200, 210);
            this.loading_panel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Converting....";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::tempWindow.Properties.Resources._56cf09e;
            this.pictureBox5.Location = new System.Drawing.Point(41, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(118, 124);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // tabsUp
            // 
            this.tabsUp.Controls.Add(this.tabMenu);
            this.tabsUp.Controls.Add(this.tabInst);
            this.tabsUp.Controls.Add(this.tabNote);
            this.tabsUp.Controls.Add(this.tabSign);
            this.tabsUp.Location = new System.Drawing.Point(0, 0);
            this.tabsUp.Name = "tabsUp";
            this.tabsUp.SelectedIndex = 0;
            this.tabsUp.Size = new System.Drawing.Size(984, 24);
            this.tabsUp.TabIndex = 12;
            // 
            // tabMenu
            // 
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(976, 0);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Tag = "0";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // tabInst
            // 
            this.tabInst.Location = new System.Drawing.Point(4, 25);
            this.tabInst.Name = "tabInst";
            this.tabInst.Padding = new System.Windows.Forms.Padding(3);
            this.tabInst.Size = new System.Drawing.Size(976, 0);
            this.tabInst.TabIndex = 1;
            this.tabInst.Tag = "1";
            this.tabInst.UseVisualStyleBackColor = true;
            // 
            // tabNote
            // 
            this.tabNote.Location = new System.Drawing.Point(4, 25);
            this.tabNote.Name = "tabNote";
            this.tabNote.Size = new System.Drawing.Size(976, 0);
            this.tabNote.TabIndex = 2;
            this.tabNote.Tag = "2";
            this.tabNote.UseVisualStyleBackColor = true;
            // 
            // tabSign
            // 
            this.tabSign.Location = new System.Drawing.Point(4, 25);
            this.tabSign.Name = "tabSign";
            this.tabSign.Size = new System.Drawing.Size(976, 0);
            this.tabSign.TabIndex = 3;
            this.tabSign.Tag = "3";
            this.tabSign.UseVisualStyleBackColor = true;
            // 
            // tabOpenTimer
            // 
            this.tabOpenTimer.Interval = 12;
            this.tabOpenTimer.Tick += new System.EventHandler(this.tabOpenTimer_Tick);
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(0, 0);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(70, 28);
            this.button_menu.TabIndex = 13;
            this.button_menu.Text = "매뉴";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_inst
            // 
            this.button_inst.Location = new System.Drawing.Point(69, 0);
            this.button_inst.Name = "button_inst";
            this.button_inst.Size = new System.Drawing.Size(70, 28);
            this.button_inst.TabIndex = 14;
            this.button_inst.Text = "악기";
            this.button_inst.UseVisualStyleBackColor = true;
            this.button_inst.Click += new System.EventHandler(this.button_inst_Click);
            // 
            // button_note
            // 
            this.button_note.Location = new System.Drawing.Point(137, 0);
            this.button_note.Name = "button_note";
            this.button_note.Size = new System.Drawing.Size(70, 28);
            this.button_note.TabIndex = 15;
            this.button_note.Text = "음표";
            this.button_note.UseVisualStyleBackColor = true;
            this.button_note.Click += new System.EventHandler(this.button_note_Click);
            // 
            // button_sign
            // 
            this.button_sign.Location = new System.Drawing.Point(206, 0);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(70, 28);
            this.button_sign.TabIndex = 16;
            this.button_sign.Text = "기호";
            this.button_sign.UseVisualStyleBackColor = true;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 600);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.button_note);
            this.Controls.Add(this.button_inst);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.tabsUp);
            this.Controls.Add(this.loading_panel);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guide Program";
            this.loading_panel.ResumeLayout(false);
            this.loading_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabsUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Panel loading_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabControl tabsUp;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabInst;
        private System.Windows.Forms.TabPage tabNote;
        private System.Windows.Forms.TabPage tabSign;
        private System.Windows.Forms.Timer tabOpenTimer;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_inst;
        private System.Windows.Forms.Button button_note;
        private System.Windows.Forms.Button button_sign;
    }
}

