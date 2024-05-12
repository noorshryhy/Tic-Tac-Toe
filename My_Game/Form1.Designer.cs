
namespace My_Game
{
    partial class Main_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_frm));
            this.go_btn = new System.Windows.Forms.Button();
            this.EX_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.Color.Green;
            this.go_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.go_btn.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_btn.ForeColor = System.Drawing.Color.Black;
            this.go_btn.Location = new System.Drawing.Point(162, 447);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(292, 88);
            this.go_btn.TabIndex = 0;
            this.go_btn.Text = "Let\'s Go ";
            this.go_btn.UseVisualStyleBackColor = false;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // EX_btn
            // 
            this.EX_btn.BackColor = System.Drawing.Color.Maroon;
            this.EX_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EX_btn.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EX_btn.Location = new System.Drawing.Point(244, 601);
            this.EX_btn.Name = "EX_btn";
            this.EX_btn.Size = new System.Drawing.Size(114, 41);
            this.EX_btn.TabIndex = 1;
            this.EX_btn.Text = "Exit";
            this.EX_btn.UseVisualStyleBackColor = false;
            this.EX_btn.Click += new System.EventHandler(this.EX_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 290);
            this.label1.TabIndex = 2;
            this.label1.Text = "   X / O\r\n   Game\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EX_btn);
            this.Controls.Add(this.go_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EX_btn;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Label label1;
    }
}

