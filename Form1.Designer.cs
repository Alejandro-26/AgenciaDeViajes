namespace Agencia
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
            comboBox1 = new ComboBox();
            T3 = new TextBox();
            T2 = new TextBox();
            T1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            T5 = new TextBox();
            T4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MintCream;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(T3);
            groupBox1.Controls.Add(T2);
            groupBox1.Controls.Add(T1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(162, 123);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(454, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRO USUARIO";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.ForeColor = SystemColors.ActiveCaption;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Agente de ventas", "Cliente", "Proveedor" });
            comboBox1.Location = new Point(243, 218);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 32);
            comboBox1.TabIndex = 12;
            // 
            // T3
            // 
            T3.BackColor = SystemColors.ActiveCaption;
            T3.ForeColor = SystemColors.ActiveCaption;
            T3.Location = new Point(243, 162);
            T3.Margin = new Padding(3, 4, 3, 4);
            T3.Name = "T3";
            T3.Size = new Size(179, 29);
            T3.TabIndex = 11;
            // 
            // T2
            // 
            T2.BackColor = SystemColors.ActiveCaption;
            T2.ForeColor = SystemColors.ActiveCaption;
            T2.Location = new Point(243, 108);
            T2.Margin = new Padding(3, 4, 3, 4);
            T2.Name = "T2";
            T2.Size = new Size(179, 29);
            T2.TabIndex = 10;
            // 
            // T1
            // 
            T1.BackColor = SystemColors.ActiveCaption;
            T1.ForeColor = SystemColors.ActiveCaption;
            T1.Location = new Point(243, 55);
            T1.Margin = new Padding(3, 4, 3, 4);
            T1.Name = "T1";
            T1.Size = new Size(179, 29);
            T1.TabIndex = 9;
            T1.TextChanged += T1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 221);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 8;
            label4.Text = "ROL_USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(221, 24);
            label3.TabIndex = 7;
            label3.Text = "CONTRASEÑA_USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 111);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE_USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 55);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 5;
            label1.Text = "ID_USUARIO";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Honeydew;
            groupBox2.Controls.Add(T5);
            groupBox2.Controls.Add(T4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(679, 123);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(451, 375);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "INICIAR SESION";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // T5
            // 
            T5.BackColor = SystemColors.GradientActiveCaption;
            T5.ForeColor = SystemColors.Window;
            T5.Location = new Point(117, 193);
            T5.Margin = new Padding(3, 4, 3, 4);
            T5.Name = "T5";
            T5.Size = new Size(225, 29);
            T5.TabIndex = 13;
            // 
            // T4
            // 
            T4.BackColor = SystemColors.GradientActiveCaption;
            T4.ForeColor = SystemColors.Window;
            T4.Location = new Point(117, 101);
            T4.Margin = new Padding(3, 4, 3, 4);
            T4.Name = "T4";
            T4.Size = new Size(225, 29);
            T4.TabIndex = 12;
            T4.TextChanged += T4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 147);
            label6.Name = "label6";
            label6.Size = new Size(132, 24);
            label6.TabIndex = 7;
            label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 59);
            label5.Name = "label5";
            label5.Size = new Size(178, 24);
            label5.TabIndex = 6;
            label5.Text = "NOMBRE_USUARIO";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(147, 284);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(173, 59);
            button1.TabIndex = 0;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(162, 439);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(139, 59);
            button2.TabIndex = 2;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(324, 439);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(135, 59);
            button3.TabIndex = 3;
            button3.Text = "CAMBIO CONTRASEÑA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(497, 439);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(104, 59);
            button4.TabIndex = 4;
            button4.Text = "NUEVO";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(469, 35);
            label7.Name = "label7";
            label7.Size = new Size(205, 27);
            label7.TabIndex = 8;
            label7.Text = "REGISTRO Y LOGIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1279, 600);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "marzo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private TextBox T4;
        private TextBox T3;
        private TextBox T2;
        private TextBox T1;
        private TextBox T5;
        private ComboBox comboBox1;
    }
}