namespace WordInForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseWord = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnOpenWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseWord
            // 
            this.btnChooseWord.Location = new System.Drawing.Point(492, 65);
            this.btnChooseWord.Name = "btnChooseWord";
            this.btnChooseWord.Size = new System.Drawing.Size(154, 37);
            this.btnChooseWord.TabIndex = 0;
            this.btnChooseWord.Text = "选择Word文件";
            this.btnChooseWord.UseVisualStyleBackColor = true;
            this.btnChooseWord.Click += new System.EventHandler(this.btnChooseWord_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(77, 65);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(350, 25);
            this.textBoxPath.TabIndex = 1;
            // 
            // btnOpenWord
            // 
            this.btnOpenWord.Location = new System.Drawing.Point(492, 135);
            this.btnOpenWord.Name = "btnOpenWord";
            this.btnOpenWord.Size = new System.Drawing.Size(154, 33);
            this.btnOpenWord.TabIndex = 2;
            this.btnOpenWord.Text = "打开word文件";
            this.btnOpenWord.UseVisualStyleBackColor = true;
            this.btnOpenWord.Click += new System.EventHandler(this.btnOpenWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 329);
            this.Controls.Add(this.btnOpenWord);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.btnChooseWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseWord;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnOpenWord;
    }
}

