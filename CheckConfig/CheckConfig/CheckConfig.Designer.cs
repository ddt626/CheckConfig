namespace CheckConfig
{
	partial class CheckConfig
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
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.pickFloder = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbConfig = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessagelistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pathTxt
            // 
            this.pathTxt.Location = new System.Drawing.Point(82, 49);
            this.pathTxt.Margin = new System.Windows.Forms.Padding(2);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(155, 22);
            this.pathTxt.TabIndex = 0;
            // 
            // pickFloder
            // 
            this.pickFloder.Location = new System.Drawing.Point(240, 49);
            this.pickFloder.Margin = new System.Windows.Forms.Padding(2);
            this.pickFloder.Name = "pickFloder";
            this.pickFloder.Size = new System.Drawing.Size(30, 22);
            this.pickFloder.TabIndex = 1;
            this.pickFloder.Text = "...";
            this.pickFloder.UseVisualStyleBackColor = true;
            this.pickFloder.Click += new System.EventHandler(this.pickFloder_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(96, 90);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(107, 55);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cbConfig
            // 
            this.cbConfig.FormattingEnabled = true;
            this.cbConfig.Location = new System.Drawing.Point(82, 15);
            this.cbConfig.Name = "cbConfig";
            this.cbConfig.Size = new System.Drawing.Size(121, 20);
            this.cbConfig.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "設定檔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "資料夾路徑";
            // 
            // MessagelistBox
            // 
            this.MessagelistBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessagelistBox.FormattingEnabled = true;
            this.MessagelistBox.ItemHeight = 12;
            this.MessagelistBox.Location = new System.Drawing.Point(0, 169);
            this.MessagelistBox.Name = "MessagelistBox";
            this.MessagelistBox.Size = new System.Drawing.Size(315, 88);
            this.MessagelistBox.TabIndex = 6;
            // 
            // CheckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 257);
            this.Controls.Add(this.MessagelistBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConfig);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.pickFloder);
            this.Controls.Add(this.pathTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckConfig";
            this.Text = "CheckConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox pathTxt;
		private System.Windows.Forms.Button pickFloder;
		private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cbConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox MessagelistBox;
	}
}

