
namespace TempConversion
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
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_fah = new System.Windows.Forms.TextBox();
            this.txt_kelv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cel = new System.Windows.Forms.Button();
            this.btn_fah = new System.Windows.Forms.Button();
            this.btn_kelv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(189, 32);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(100, 20);
            this.txt_cel.TabIndex = 0;
            this.txt_cel.TextChanged += new System.EventHandler(this.txt_cel_TextChanged);
            // 
            // txt_fah
            // 
            this.txt_fah.Location = new System.Drawing.Point(189, 85);
            this.txt_fah.Name = "txt_fah";
            this.txt_fah.Size = new System.Drawing.Size(100, 20);
            this.txt_fah.TabIndex = 1;
            this.txt_fah.TextChanged += new System.EventHandler(this.txt_fah_TextChanged);
            // 
            // txt_kelv
            // 
            this.txt_kelv.Location = new System.Drawing.Point(189, 138);
            this.txt_kelv.Name = "txt_kelv";
            this.txt_kelv.Size = new System.Drawing.Size(100, 20);
            this.txt_kelv.TabIndex = 2;
            this.txt_kelv.TextChanged += new System.EventHandler(this.txt_kelv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fahrenheight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelvin";
            // 
            // btn_cel
            // 
            this.btn_cel.Location = new System.Drawing.Point(341, 32);
            this.btn_cel.Name = "btn_cel";
            this.btn_cel.Size = new System.Drawing.Size(75, 23);
            this.btn_cel.TabIndex = 6;
            this.btn_cel.Text = "Convert!";
            this.btn_cel.UseVisualStyleBackColor = true;
            this.btn_cel.Click += new System.EventHandler(this.btn_cel_Click);
            // 
            // btn_fah
            // 
            this.btn_fah.Location = new System.Drawing.Point(341, 85);
            this.btn_fah.Name = "btn_fah";
            this.btn_fah.Size = new System.Drawing.Size(75, 23);
            this.btn_fah.TabIndex = 7;
            this.btn_fah.Text = "Convert!";
            this.btn_fah.UseVisualStyleBackColor = true;
            this.btn_fah.Click += new System.EventHandler(this.btn_fah_Click);
            // 
            // btn_kelv
            // 
            this.btn_kelv.Location = new System.Drawing.Point(341, 138);
            this.btn_kelv.Name = "btn_kelv";
            this.btn_kelv.Size = new System.Drawing.Size(75, 23);
            this.btn_kelv.TabIndex = 8;
            this.btn_kelv.Text = "Convert!";
            this.btn_kelv.UseVisualStyleBackColor = true;
            this.btn_kelv.Click += new System.EventHandler(this.btn_kelv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 226);
            this.Controls.Add(this.btn_kelv);
            this.Controls.Add(this.btn_fah);
            this.Controls.Add(this.btn_cel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kelv);
            this.Controls.Add(this.txt_fah);
            this.Controls.Add(this.txt_cel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_fah;
        private System.Windows.Forms.TextBox txt_kelv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cel;
        private System.Windows.Forms.Button btn_fah;
        private System.Windows.Forms.Button btn_kelv;
    }
}

