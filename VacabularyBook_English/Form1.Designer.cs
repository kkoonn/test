namespace 英単語
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.open_button = new System.Windows.Forms.Button();
            this.Japanese_description = new System.Windows.Forms.RichTextBox();
            this.English_word = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cauntion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.Location = new System.Drawing.Point(12, 190);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(581, 23);
            this.open_button.TabIndex = 0;
            this.open_button.Text = "OPEN";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // Japanese_description
            // 
            this.Japanese_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Japanese_description.Location = new System.Drawing.Point(12, 219);
            this.Japanese_description.Name = "Japanese_description";
            this.Japanese_description.Size = new System.Drawing.Size(581, 177);
            this.Japanese_description.TabIndex = 1;
            this.Japanese_description.Text = "";
            // 
            // English_word
            // 
            this.English_word.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.English_word.AutoSize = true;
            this.English_word.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.English_word.Location = new System.Drawing.Point(113, 67);
            this.English_word.Name = "English_word";
            this.English_word.Size = new System.Drawing.Size(377, 54);
            this.English_word.TabIndex = 2;
            this.English_word.Text = "NEXTを押してね";
            this.English_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_button
            // 
            this.next_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.next_button.Location = new System.Drawing.Point(12, 161);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(581, 23);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "NEXT";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cauntion
            // 
            this.cauntion.AutoSize = true;
            this.cauntion.Location = new System.Drawing.Point(12, 13);
            this.cauntion.Name = "cauntion";
            this.cauntion.Size = new System.Drawing.Size(0, 12);
            this.cauntion.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(605, 407);
            this.Controls.Add(this.cauntion);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.English_word);
            this.Controls.Add(this.Japanese_description);
            this.Controls.Add(this.open_button);
            this.Name = "Form1";
            this.Text = "英単語";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.RichTextBox Japanese_description;
        private System.Windows.Forms.Label English_word;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label cauntion;

    }
}

