namespace SinemaBufeSatis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_bilet = new TextBox();
            label4 = new Label();
            txt_cay = new TextBox();
            label3 = new Label();
            txt_su = new TextBox();
            label2 = new Label();
            txt_misir = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            lbl_kasa = new Label();
            button1 = new Button();
            lbl_toplam = new Label();
            label9 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(txt_bilet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_cay);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_su);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_misir);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            // 
            // txt_bilet
            // 
            txt_bilet.Location = new Point(99, 210);
            txt_bilet.Name = "txt_bilet";
            txt_bilet.Size = new Size(125, 30);
            txt_bilet.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 213);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 4;
            label4.Text = "Bilet:";
            // 
            // txt_cay
            // 
            txt_cay.Location = new Point(99, 150);
            txt_cay.Name = "txt_cay";
            txt_cay.Size = new Size(125, 30);
            txt_cay.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 4;
            label3.Text = "Çay:";
            // 
            // txt_su
            // 
            txt_su.Location = new Point(99, 94);
            txt_su.Name = "txt_su";
            txt_su.Size = new Size(125, 30);
            txt_su.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 23);
            label2.TabIndex = 2;
            label2.Text = "Su:";
            // 
            // txt_misir
            // 
            txt_misir.Location = new Point(99, 39);
            txt_misir.Name = "txt_misir";
            txt_misir.Size = new Size(125, 30);
            txt_misir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 0;
            label1.Text = "Mısır:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Yellow;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(316, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyatlar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 184);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 7;
            label8.Text = "Bilet: 8TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 136);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 6;
            label7.Text = "Çay: 2TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 87);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 7;
            label6.Text = "Su: 1TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 39);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 6;
            label5.Text = "Mısır: 4TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(lbl_kasa);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(lbl_toplam);
            groupBox3.Location = new Point(606, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 280);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // lbl_kasa
            // 
            lbl_kasa.AutoSize = true;
            lbl_kasa.Location = new Point(60, 231);
            lbl_kasa.Name = "lbl_kasa";
            lbl_kasa.Size = new Size(118, 23);
            lbl_kasa.TabIndex = 8;
            lbl_kasa.Text = "Kasa: 00 TL";
            // 
            // button1
            // 
            button1.Location = new Point(60, 136);
            button1.Name = "button1";
            button1.Size = new Size(130, 34);
            button1.TabIndex = 7;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_toplam
            // 
            lbl_toplam.AutoSize = true;
            lbl_toplam.Location = new Point(60, 94);
            lbl_toplam.Name = "lbl_toplam";
            lbl_toplam.Size = new Size(136, 23);
            lbl_toplam.TabIndex = 6;
            lbl_toplam.Text = "Toplam: 00 TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(200, 62);
            label9.Name = "label9";
            label9.Size = new Size(472, 61);
            label9.TabIndex = 9;
            label9.Text = "Sinema & Büfe Satış Paneli";
            // 
            // button2
            // 
            button2.Location = new Point(60, 181);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 9;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 518);
            Controls.Add(label9);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Büfe Sinema";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_bilet;
        private Label label4;
        private TextBox txt_cay;
        private Label label3;
        private TextBox txt_su;
        private Label label2;
        private TextBox txt_misir;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button button1;
        private Label lbl_toplam;
        private Label label9;
        private Label lbl_kasa;
        private Button button2;
    }
}