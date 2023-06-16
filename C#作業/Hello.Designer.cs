namespace C_作業
{
    partial class Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.txtStar = new System.Windows.Forms.TextBox();
            this.txtSax = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.labStar = new System.Windows.Forms.Label();
            this.labSax = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(251, 213);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(95, 22);
            this.txtStar.TabIndex = 29;
            // 
            // txtSax
            // 
            this.txtSax.Location = new System.Drawing.Point(251, 167);
            this.txtSax.Name = "txtSax";
            this.txtSax.Size = new System.Drawing.Size(95, 22);
            this.txtSax.TabIndex = 28;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(251, 108);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(95, 22);
            this.txtEnglishName.TabIndex = 27;
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.Location = new System.Drawing.Point(128, 216);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(55, 19);
            this.labStar.TabIndex = 26;
            this.labStar.Text = "星座:";
            // 
            // labSax
            // 
            this.labSax.AutoSize = true;
            this.labSax.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSax.Location = new System.Drawing.Point(128, 163);
            this.labSax.Name = "labSax";
            this.labSax.Size = new System.Drawing.Size(55, 19);
            this.labSax.TabIndex = 25;
            this.labSax.Text = "性別:";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglishName.Location = new System.Drawing.Point(102, 111);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(130, 19);
            this.labEnglishName.TabIndex = 24;
            this.labEnglishName.Text = "English Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(251, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 22);
            this.txtName.TabIndex = 23;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(128, 65);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(55, 19);
            this.labName.TabIndex = 22;
            this.labName.Text = "姓名:";
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(249, 268);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(94, 72);
            this.btnHi.TabIndex = 21;
            this.btnHi.Text = "Say Hi !";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(132, 268);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(94, 72);
            this.btnHello.TabIndex = 20;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtSax);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labSax);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.TextBox txtSax;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.Label labSax;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnHello;
    }
}