using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeTaskTool
{
    public partial class Form1 : Form
    {
        const string ERR_NO_INPUT = "タスク名を入力してください。";
        const string ERR_EXIST_DIR = "同じタスクが存在しています。";
        const string PATH_TEMPLATE = "\\template";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // タスク名の日付部分を作成
            string date = DateTime.Now.ToString("yyyyMMdd_");
            this.labelDate.Text = date;

            // テキストボックスにフォーカスする
            this.textBoxTaskName.Focus();
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            // --- 事前処理 ---
            // 入力チェック
            if(String.IsNullOrEmpty(this.textBoxTaskName.Text))
            {
                this.labelErrMsg.Text = ERR_NO_INPUT;
                return;
            }

            // --- フォルダの作成 ---
            // フォルダパス作成
            string dirName = this.labelDate.Text + this.textBoxTaskName.Text;
            string taskPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + dirName;
            
            // フォルダ存在チェック
            if (System.IO.Directory.Exists(taskPath))
            {
                this.labelErrMsg.Text = ERR_EXIST_DIR;
                return;
            }

            // フォルダ作成
            System.IO.Directory.CreateDirectory(taskPath);

            // --- テンプレートファイルのコピー ---
            // テンプレートフォルダのパスを作成
            string templatePath = System.Windows.Forms.Application.StartupPath + PATH_TEMPLATE;
            if (System.IO.Directory.Exists(templatePath))
            {
                // ファイルのリストを取得
                string[] files = System.IO.Directory.GetFiles(templatePath);

                // ファイルのコピー
                foreach(string filePath in files)
                {
                    System.IO.File.Copy(filePath, taskPath + "\\" + System.IO.Path.GetFileName(filePath));
                }
            }

            // --- 事後処理 ---
            // フォルダを開く
            System.Diagnostics.Process.Start(taskPath);

            // 終了
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // 終了
            this.Close();
        }
    }
}
