namespace Parfonov_LR3_RE_21mp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_P_IN = new System.Windows.Forms.TextBox();
            this.textBox_Key_IN = new System.Windows.Forms.TextBox();
            this.textBox_C_IN = new System.Windows.Forms.TextBox();
            this.textBox_P_OUT = new System.Windows.Forms.TextBox();
            this.textBox_Key_OUT = new System.Windows.Forms.TextBox();
            this.textBox_C_OUT = new System.Windows.Forms.TextBox();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.toolTip_HEX = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_IN = new System.Windows.Forms.GroupBox();
            this.groupBox_OUT = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "P=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "C=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "=Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "=P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "=C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 8;
            // 
            // textBox_P_IN
            // 
            this.textBox_P_IN.Location = new System.Drawing.Point(111, 77);
            this.textBox_P_IN.Name = "textBox_P_IN";
            this.textBox_P_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_P_IN.TabIndex = 9;
            // 
            // textBox_Key_IN
            // 
            this.textBox_Key_IN.Location = new System.Drawing.Point(111, 106);
            this.textBox_Key_IN.Name = "textBox_Key_IN";
            this.textBox_Key_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key_IN.TabIndex = 10;
            // 
            // textBox_C_IN
            // 
            this.textBox_C_IN.Location = new System.Drawing.Point(111, 138);
            this.textBox_C_IN.Name = "textBox_C_IN";
            this.textBox_C_IN.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_IN.TabIndex = 11;
            // 
            // textBox_P_OUT
            // 
            this.textBox_P_OUT.Location = new System.Drawing.Point(395, 76);
            this.textBox_P_OUT.Name = "textBox_P_OUT";
            this.textBox_P_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_P_OUT.TabIndex = 14;
            // 
            // textBox_Key_OUT
            // 
            this.textBox_Key_OUT.Location = new System.Drawing.Point(392, 107);
            this.textBox_Key_OUT.Name = "textBox_Key_OUT";
            this.textBox_Key_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key_OUT.TabIndex = 13;
            // 
            // textBox_C_OUT
            // 
            this.textBox_C_OUT.Location = new System.Drawing.Point(395, 138);
            this.textBox_C_OUT.Name = "textBox_C_OUT";
            this.textBox_C_OUT.Size = new System.Drawing.Size(100, 22);
            this.textBox_C_OUT.TabIndex = 12;
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(279, 76);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(75, 23);
            this.button_XOR.TabIndex = 15;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(279, 133);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(83, 23);
            this.button_clean.TabIndex = 16;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // groupBox_IN
            // 
            this.groupBox_IN.Location = new System.Drawing.Point(41, 25);
            this.groupBox_IN.Name = "groupBox_IN";
            this.groupBox_IN.Size = new System.Drawing.Size(205, 146);
            this.groupBox_IN.TabIndex = 17;
            this.groupBox_IN.TabStop = false;
            this.groupBox_IN.Text = "Зашифрування";
            // 
            // groupBox_OUT
            // 
            this.groupBox_OUT.Location = new System.Drawing.Point(368, 25);
            this.groupBox_OUT.Name = "groupBox_OUT";
            this.groupBox_OUT.Size = new System.Drawing.Size(228, 154);
            this.groupBox_OUT.TabIndex = 18;
            this.groupBox_OUT.TabStop = false;
            this.groupBox_OUT.Text = "Розшифрування";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 221);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_XOR);
            this.Controls.Add(this.textBox_P_OUT);
            this.Controls.Add(this.textBox_Key_OUT);
            this.Controls.Add(this.textBox_C_OUT);
            this.Controls.Add(this.textBox_C_IN);
            this.Controls.Add(this.textBox_Key_IN);
            this.Controls.Add(this.textBox_P_IN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_IN);
            this.Controls.Add(this.groupBox_OUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_P_IN;
        private System.Windows.Forms.TextBox textBox_Key_IN;
        private System.Windows.Forms.TextBox textBox_C_IN;
        private System.Windows.Forms.TextBox textBox_P_OUT;
        private System.Windows.Forms.TextBox textBox_Key_OUT;
        private System.Windows.Forms.TextBox textBox_C_OUT;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.ToolTip toolTip_HEX;
        private System.Windows.Forms.GroupBox groupBox_IN;
        private System.Windows.Forms.GroupBox groupBox_OUT;
    }
}

