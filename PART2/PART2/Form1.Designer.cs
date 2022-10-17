namespace PART2
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
            this.TextBox_Operand = new System.Windows.Forms.TextBox();
            this.linkLabel1_button = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBox_double = new System.Windows.Forms.TextBox();
            this.TextBox_byte = new System.Windows.Forms.TextBox();
            this.label1_answer = new System.Windows.Forms.Label();
            this.label1_location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Operand
            // 
            this.TextBox_Operand.Location = new System.Drawing.Point(327, 157);
            this.TextBox_Operand.Name = "TextBox_Operand";
            this.TextBox_Operand.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Operand.TabIndex = 0;
            this.TextBox_Operand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1_button
            // 
            this.linkLabel1_button.AutoSize = true;
            this.linkLabel1_button.Location = new System.Drawing.Point(352, 91);
            this.linkLabel1_button.Name = "linkLabel1_button";
            this.linkLabel1_button.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1_button.TabIndex = 1;
            this.linkLabel1_button.TabStop = true;
            this.linkLabel1_button.Text = "linkLabel1";
            this.linkLabel1_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextBox_double
            // 
            this.TextBox_double.Location = new System.Drawing.Point(504, 157);
            this.TextBox_double.Name = "TextBox_double";
            this.TextBox_double.Size = new System.Drawing.Size(100, 20);
            this.TextBox_double.TabIndex = 3;
            this.TextBox_double.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBox_byte
            // 
            this.TextBox_byte.Location = new System.Drawing.Point(156, 157);
            this.TextBox_byte.Name = "TextBox_byte";
            this.TextBox_byte.Size = new System.Drawing.Size(100, 20);
            this.TextBox_byte.TabIndex = 4;
            this.TextBox_byte.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1_answer
            // 
            this.label1_answer.AutoSize = true;
            this.label1_answer.Location = new System.Drawing.Point(363, 206);
            this.label1_answer.Name = "label1_answer";
            this.label1_answer.Size = new System.Drawing.Size(35, 13);
            this.label1_answer.TabIndex = 3;
            this.label1_answer.Text = "label1";
            this.label1_answer.Click += new System.EventHandler(this.label1_answer_Click);
            // 
            // label1_location
            // 
            this.label1_location.AutoSize = true;
            this.label1_location.Location = new System.Drawing.Point(363, 21);
            this.label1_location.Name = "label1_location";
            this.label1_location.Size = new System.Drawing.Size(35, 13);
            this.label1_location.TabIndex = 5;
            this.label1_location.Text = "label1";
            this.label1_location.Click += new System.EventHandler(this.label1_location_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_location);
            this.Controls.Add(this.label1_answer);
            this.Controls.Add(this.TextBox_byte);
            this.Controls.Add(this.TextBox_double);
            this.Controls.Add(this.linkLabel1_button);
            this.Controls.Add(this.TextBox_Operand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Operand;
        private System.Windows.Forms.LinkLabel linkLabel1_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TextBox_double;
        private System.Windows.Forms.TextBox TextBox_byte;
        private System.Windows.Forms.Label label1_answer;
        private System.Windows.Forms.Label label1_location;
    }
}

