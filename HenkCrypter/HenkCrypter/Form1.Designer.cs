namespace HenkCrypter
{
    partial class Builder
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
            this.path = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(80, 12);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(187, 13);
            this.path.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.search.BackgroundImage = global::HenkCrypter.Properties.Resources.search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(273, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(20, 15);
            this.search.TabIndex = 29;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Application:";
            // 
            // build
            // 
            this.build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.build.Cursor = System.Windows.Forms.Cursors.Hand;
            this.build.FlatAppearance.BorderSize = 0;
            this.build.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.build.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build.ForeColor = System.Drawing.Color.White;
            this.build.Location = new System.Drawing.Point(12, 53);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(281, 30);
            this.build.TabIndex = 31;
            this.build.Text = "build";
            this.build.UseVisualStyleBackColor = false;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Key:";
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key.ForeColor = System.Drawing.Color.White;
            this.Key.Location = new System.Drawing.Point(80, 34);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(213, 13);
            this.Key.TabIndex = 33;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(305, 90);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.build);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Builder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HenkCrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Key;
    }
}

