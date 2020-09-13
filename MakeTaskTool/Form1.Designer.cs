namespace MakeTaskTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "タスク名";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 35);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label2";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxTaskName.Location = new System.Drawing.Point(88, 24);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(346, 27);
            this.textBoxTaskName.TabIndex = 2;
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(226, 66);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(101, 31);
            this.buttonMake.TabIndex = 3;
            this.buttonMake.Text = "作成";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(333, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 31);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelErrMsg
            // 
            this.labelErrMsg.AutoSize = true;
            this.labelErrMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrMsg.Location = new System.Drawing.Point(85, 54);
            this.labelErrMsg.Name = "labelErrMsg";
            this.labelErrMsg.Size = new System.Drawing.Size(0, 16);
            this.labelErrMsg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonMake;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(446, 109);
            this.Controls.Add(this.labelErrMsg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "タスク作成";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelErrMsg;
    }
}

