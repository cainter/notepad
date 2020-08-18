namespace notepad
{
    partial class IndexForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notpad_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_strip = new System.Windows.Forms.ToolStripMenuItem();
            this.note_pad_panal = new System.Windows.Forms.Panel();
            this.text_panel = new System.Windows.Forms.Panel();
            this.save_text = new System.Windows.Forms.Button();
            this.text_edit_box = new System.Windows.Forms.TextBox();
            this.add_text = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.del_text_box = new System.Windows.Forms.Button();
            this.save_panel = new System.Windows.Forms.Panel();
            this.save_name = new System.Windows.Forms.TextBox();
            this.create_note = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.note_pad_panal.SuspendLayout();
            this.text_panel.SuspendLayout();
            this.save_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notpad_strip,
            this.picture_strip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notpad_strip
            // 
            this.notpad_strip.Name = "notpad_strip";
            this.notpad_strip.Size = new System.Drawing.Size(56, 21);
            this.notpad_strip.Text = "记事本";
            this.notpad_strip.Click += new System.EventHandler(this.notpad_strip_Click);
            // 
            // picture_strip
            // 
            this.picture_strip.Name = "picture_strip";
            this.picture_strip.Size = new System.Drawing.Size(80, 21);
            this.picture_strip.Text = "图片浏览器";
            // 
            // note_pad_panal
            // 
            this.note_pad_panal.Controls.Add(this.text_panel);
            this.note_pad_panal.Controls.Add(this.del_text_box);
            this.note_pad_panal.Controls.Add(this.add_text);
            this.note_pad_panal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note_pad_panal.Location = new System.Drawing.Point(0, 25);
            this.note_pad_panal.Name = "note_pad_panal";
            this.note_pad_panal.Size = new System.Drawing.Size(509, 353);
            this.note_pad_panal.TabIndex = 1;
            // 
            // text_panel
            // 
            this.text_panel.Controls.Add(this.save_panel);
            this.text_panel.Controls.Add(this.back_btn);
            this.text_panel.Controls.Add(this.save_text);
            this.text_panel.Controls.Add(this.text_edit_box);
            this.text_panel.Location = new System.Drawing.Point(3, 3);
            this.text_panel.Name = "text_panel";
            this.text_panel.Size = new System.Drawing.Size(503, 309);
            this.text_panel.TabIndex = 2;
            this.text_panel.Visible = false;
            // 
            // save_text
            // 
            this.save_text.Location = new System.Drawing.Point(247, 284);
            this.save_text.Name = "save_text";
            this.save_text.Size = new System.Drawing.Size(75, 23);
            this.save_text.TabIndex = 1;
            this.save_text.Text = "保存";
            this.save_text.UseVisualStyleBackColor = true;
            this.save_text.Click += new System.EventHandler(this.save_text_Click);
            // 
            // text_edit_box
            // 
            this.text_edit_box.Location = new System.Drawing.Point(3, 3);
            this.text_edit_box.Multiline = true;
            this.text_edit_box.Name = "text_edit_box";
            this.text_edit_box.Size = new System.Drawing.Size(497, 274);
            this.text_edit_box.TabIndex = 0;
            // 
            // add_text
            // 
            this.add_text.Location = new System.Drawing.Point(12, 318);
            this.add_text.Name = "add_text";
            this.add_text.Size = new System.Drawing.Size(75, 23);
            this.add_text.TabIndex = 0;
            this.add_text.Text = "添加记事本";
            this.add_text.UseVisualStyleBackColor = true;
            this.add_text.Click += new System.EventHandler(this.add_text_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(166, 284);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "返回";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // del_text_box
            // 
            this.del_text_box.Location = new System.Drawing.Point(94, 319);
            this.del_text_box.Name = "del_text_box";
            this.del_text_box.Size = new System.Drawing.Size(75, 23);
            this.del_text_box.TabIndex = 2;
            this.del_text_box.Text = "删除记事本";
            this.del_text_box.UseVisualStyleBackColor = true;
            // 
            // save_panel
            // 
            this.save_panel.Controls.Add(this.create_note);
            this.save_panel.Controls.Add(this.save_name);
            this.save_panel.Location = new System.Drawing.Point(146, 187);
            this.save_panel.Name = "save_panel";
            this.save_panel.Size = new System.Drawing.Size(200, 61);
            this.save_panel.TabIndex = 3;
            this.save_panel.Visible = false;
            // 
            // save_name
            // 
            this.save_name.Location = new System.Drawing.Point(4, 4);
            this.save_name.Name = "save_name";
            this.save_name.Size = new System.Drawing.Size(193, 21);
            this.save_name.TabIndex = 0;
            // 
            // create_note
            // 
            this.create_note.Location = new System.Drawing.Point(57, 31);
            this.create_note.Name = "create_note";
            this.create_note.Size = new System.Drawing.Size(75, 23);
            this.create_note.TabIndex = 1;
            this.create_note.Text = "保存";
            this.create_note.UseVisualStyleBackColor = true;
            this.create_note.Click += new System.EventHandler(this.create_note_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 378);
            this.Controls.Add(this.note_pad_panal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.note_pad_panal.ResumeLayout(false);
            this.text_panel.ResumeLayout(false);
            this.text_panel.PerformLayout();
            this.save_panel.ResumeLayout(false);
            this.save_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notpad_strip;
        private System.Windows.Forms.ToolStripMenuItem picture_strip;
        private System.Windows.Forms.Panel note_pad_panal;
        private System.Windows.Forms.Button add_text;
        private System.Windows.Forms.Panel text_panel;
        private System.Windows.Forms.Button save_text;
        private System.Windows.Forms.TextBox text_edit_box;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button del_text_box;
        private System.Windows.Forms.Panel save_panel;
        private System.Windows.Forms.TextBox save_name;
        private System.Windows.Forms.Button create_note;
    }
}