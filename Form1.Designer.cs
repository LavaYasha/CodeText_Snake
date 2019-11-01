namespace Max
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
            this.uLR = new System.Windows.Forms.RadioButton();
            this.uRL = new System.Windows.Forms.RadioButton();
            this.bRL = new System.Windows.Forms.RadioButton();
            this.bLR = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ThisText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bRU = new System.Windows.Forms.RadioButton();
            this.bLU = new System.Windows.Forms.RadioButton();
            this.uRD = new System.Windows.Forms.RadioButton();
            this.uLD = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uLR
            // 
            this.uLR.AutoSize = true;
            this.uLR.Location = new System.Drawing.Point(16, 15);
            this.uLR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uLR.Name = "uLR";
            this.uLR.Size = new System.Drawing.Size(179, 21);
            this.uLR.TabIndex = 0;
            this.uLR.TabStop = true;
            this.uLR.Text = "Левый верхний вправо";
            this.uLR.UseVisualStyleBackColor = true;
            this.uLR.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // uRL
            // 
            this.uRL.AutoSize = true;
            this.uRL.Location = new System.Drawing.Point(16, 43);
            this.uRL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uRL.Name = "uRL";
            this.uRL.Size = new System.Drawing.Size(179, 21);
            this.uRL.TabIndex = 1;
            this.uRL.TabStop = true;
            this.uRL.Text = "Правый верхний влево";
            this.uRL.UseVisualStyleBackColor = true;
            this.uRL.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // bRL
            // 
            this.bRL.AutoSize = true;
            this.bRL.Location = new System.Drawing.Point(16, 71);
            this.bRL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRL.Name = "bRL";
            this.bRL.Size = new System.Drawing.Size(175, 21);
            this.bRL.TabIndex = 3;
            this.bRL.TabStop = true;
            this.bRL.Text = "Правый нижний влево";
            this.bRL.UseVisualStyleBackColor = true;
            this.bRL.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // bLR
            // 
            this.bLR.AutoSize = true;
            this.bLR.Location = new System.Drawing.Point(16, 100);
            this.bLR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLR.Name = "bLR";
            this.bLR.Size = new System.Drawing.Size(175, 21);
            this.bLR.TabIndex = 2;
            this.bLR.TabStop = true;
            this.bLR.Text = "Левый нижний вправо";
            this.bLR.UseVisualStyleBackColor = true;
            this.bLR.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // ThisText
            // 
            this.ThisText.Location = new System.Drawing.Point(16, 245);
            this.ThisText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThisText.Name = "ThisText";
            this.ThisText.Size = new System.Drawing.Size(565, 344);
            this.ThisText.TabIndex = 5;
            this.ThisText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bRU
            // 
            this.bRU.AutoSize = true;
            this.bRU.Location = new System.Drawing.Point(213, 71);
            this.bRU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRU.Name = "bRU";
            this.bRU.Size = new System.Drawing.Size(173, 21);
            this.bRU.TabIndex = 10;
            this.bRU.TabStop = true;
            this.bRU.Text = "Правый нижний вверх";
            this.bRU.UseVisualStyleBackColor = true;
            // 
            // bLU
            // 
            this.bLU.AutoSize = true;
            this.bLU.Location = new System.Drawing.Point(213, 100);
            this.bLU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLU.Name = "bLU";
            this.bLU.Size = new System.Drawing.Size(165, 21);
            this.bLU.TabIndex = 9;
            this.bLU.TabStop = true;
            this.bLU.Text = "Левый нижний вверх";
            this.bLU.UseVisualStyleBackColor = true;
            // 
            // uRD
            // 
            this.uRD.AutoSize = true;
            this.uRD.Location = new System.Drawing.Point(213, 43);
            this.uRD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uRD.Name = "uRD";
            this.uRD.Size = new System.Drawing.Size(171, 21);
            this.uRD.TabIndex = 8;
            this.uRD.TabStop = true;
            this.uRD.Text = "Правый верхний вниз";
            this.uRD.UseVisualStyleBackColor = true;
            // 
            // uLD
            // 
            this.uLD.AutoSize = true;
            this.uLD.Location = new System.Drawing.Point(213, 15);
            this.uLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uLD.Name = "uLD";
            this.uLD.Size = new System.Drawing.Size(163, 21);
            this.uLD.TabIndex = 7;
            this.uLD.TabStop = true;
            this.uLD.Text = "Левый верхний вниз";
            this.uLD.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(152, 209);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bRU);
            this.Controls.Add(this.bLU);
            this.Controls.Add(this.uRD);
            this.Controls.Add(this.uLD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThisText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRL);
            this.Controls.Add(this.bLR);
            this.Controls.Add(this.uRL);
            this.Controls.Add(this.uLR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton uLR;
        private System.Windows.Forms.RadioButton uRL;
        private System.Windows.Forms.RadioButton bRL;
        private System.Windows.Forms.RadioButton bLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ThisText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton bRU;
        private System.Windows.Forms.RadioButton bLU;
        private System.Windows.Forms.RadioButton uRD;
        private System.Windows.Forms.RadioButton uLD;
        private System.Windows.Forms.Button button2;
    }
}

