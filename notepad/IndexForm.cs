using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }
        string text_path = @"C:\Users\dsj003\Desktop\记事本";
        private void IndexForm_Load(object sender, EventArgs e)
        {
            initial();
        }

        /// <summary>
        /// 初始化面板，清除所有组件后根据文件夹中的记事本个数添加所有记事本
        /// </summary>
        private void initial()
        {
            note_pad_panal.Controls.Clear();
            DirectoryInfo text_dir = Directory.CreateDirectory(text_path);
            FileInfo[] files = text_dir.GetFiles();
            int x = 10;
            int y = 10;
            int x_interval = 85;
            int y_interval = 33;
            for (int i = 0; i < files.Length; i++)
            {
                Button text = new Button();
                text.Size = new Size(75, 23);
                text.Text = files[i].Name;
                text.Location = new Point(x, y);
                x += x_interval;
                if (i % 5 == 0 && i != 0)
                {
                    x = 10;
                    y += y_interval;
                }
                text.Click += new EventHandler(text_edit);

                note_pad_panal.Controls.Add(text);
            }
        }

        private void notpad_strip_Click(object sender, EventArgs e)
        {
            
        }
        // 正在编辑的文本
        string current_edit_text;
        /// <summary>
        /// 编辑文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_edit(object sender, EventArgs e)
        {
            current_edit_text = (sender.ToString().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1]).Trim();
            string file_path = text_path + "\\" + (sender.ToString().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)[1]).Trim();
            using(StreamReader sr = new StreamReader(file_path, Encoding.UTF8))
            {
                while (true)
                {
                    char[] buf = new char[1024 * 5];
                    int result = sr.Read(buf, 0, buf.Length);
                    if(result == 0)
                    {
                        break;
                    }
                    text_edit_box.AppendText(new string(buf));
                }
            }
            text_panel.Visible = true;
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_text_Click(object sender, EventArgs e)
        {
            current_edit_text = "";
            text_panel.Visible = true;
            text_edit_box.Focus();
        }

        // 返回按钮
        private void back_btn_Click(object sender, EventArgs e)
        {
            text_edit_box.Clear();
            text_panel.Visible = false;
        }

        // 保存按钮
        private void save_text_Click(object sender, EventArgs e)
        {
            DirectoryInfo text_dir = Directory.CreateDirectory(text_path);
            FileInfo [] files = text_dir.GetFiles();
            List<string> file_names = new List<string>();
            foreach (var file in files)
            {
                file_names.Add(file.Name);
            }
            if(current_edit_text == "")
            {
                // 添加新记事本
                save_panel.Visible = true;
            }
            else
            {
                // 保存原有记事本
                SaveFile(current_edit_text);
            }
        }

        // 生成记事本按钮
        private void create_note_Click(object sender, EventArgs e)
        {
            string file_name = save_name.Text;
            // 判断记事本是否存在
            if (file_name.Contains(file_name))
            {
                // 记事本已存在
                DialogResult message_result = MessageBox.Show("是否覆盖原记事本？", "保存", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message_result == DialogResult.Yes)
                {
                    // 替换原记事本
                    SaveFile(file_name);
                }
            }
            else
            {
                // 记事本不存在存在
                SaveFile(file_name);
            }
            save_panel.Visible = false;
            text_panel.Visible = false;
            initial();
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="file_name">文件名称</param>
        private void SaveFile(string file_name)
        {
            string file_name_path = text_path + "\\" + file_name;
            using(StreamWriter sw = new StreamWriter(file_name_path))
            {
                sw.Write(text_edit_box.Text);
            }
        }
    }
}
