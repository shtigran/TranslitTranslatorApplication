namespace ArmenianTranslitTranslator
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.Select = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(104, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(163, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Select the text file ";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.label1.UseWaitCursor = true;
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Font = new System.Drawing.Font("Times Unicode", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(-5, 15);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(4);
      this.label2.Size = new System.Drawing.Size(395, 32);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ա Բ Գ Դ Ե Զ Է Ը --> A B C D E F G H I ";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(33, 96);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(311, 23);
      this.label3.TabIndex = 3;
      this.label3.Text = "To translate into Armenian Translit";
      this.label3.Click += new System.EventHandler(this.label3_Click_1);
      // 
      // Select
      // 
      this.Select.Location = new System.Drawing.Point(37, 138);
      this.Select.Name = "Select";
      this.Select.Size = new System.Drawing.Size(82, 32);
      this.Select.TabIndex = 4;
      this.Select.Text = "Select File";
      this.Select.UseVisualStyleBackColor = true;
      this.Select.Click += new System.EventHandler(this.Select_Click);
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Location = new System.Drawing.Point(226, 138);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(118, 32);
      this.textBox1.TabIndex = 5;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(37, 197);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 33);
      this.button1.TabIndex = 6;
      this.button1.Text = "Translate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox2
      // 
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox2.Location = new System.Drawing.Point(226, 197);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(118, 33);
      this.textBox2.TabIndex = 7;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(25, 250);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox3.Size = new System.Drawing.Size(332, 119);
      this.textBox3.TabIndex = 8;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(380, 417);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.Select);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Armenian Translit Translator";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button Select;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
  }
}

