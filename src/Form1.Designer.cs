namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "F";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "J";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "K";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(490, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "L";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(182, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(255, 104);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 482);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

    }
}

