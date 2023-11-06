namespace Unidad_3_9
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
            label1 = new Label();
            i = new Label();
            cua = new Label();
            cub = new Label();
            zeta = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Z=x²+x³";
            // 
            // i
            // 
            i.AutoSize = true;
            i.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            i.Location = new Point(65, 73);
            i.Name = "i";
            i.Size = new Size(19, 21);
            i.TabIndex = 1;
            i.Text = "X";
            // 
            // cua
            // 
            cua.AutoSize = true;
            cua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cua.Location = new Point(173, 73);
            cua.Name = "cua";
            cua.Size = new Size(23, 21);
            cua.TabIndex = 2;
            cua.Text = "x²";
            // 
            // cub
            // 
            cub.AutoSize = true;
            cub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cub.Location = new Point(299, 73);
            cub.Name = "cub";
            cub.Size = new Size(23, 21);
            cub.TabIndex = 3;
            cub.Text = "x³";
            // 
            // zeta
            // 
            zeta.AutoSize = true;
            zeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zeta.Location = new Point(413, 73);
            zeta.Name = "zeta";
            zeta.Size = new Size(19, 21);
            zeta.TabIndex = 4;
            zeta.Text = "Z";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(41, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(71, 124);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(146, 101);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(71, 124);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(273, 101);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(71, 124);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(387, 101);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(71, 124);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(184, 263);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 9;
            button1.Text = "Calcular valores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 327);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(zeta);
            Controls.Add(cub);
            Controls.Add(cua);
            Controls.Add(i);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label i;
        private Label cua;
        private Label cub;
        private Label zeta;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}