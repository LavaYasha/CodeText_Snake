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
            this.DebugText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uLR
            // 
            this.uLR.AutoSize = true;
            this.uLR.Location = new System.Drawing.Point(12, 12);
            this.uLR.Name = "uLR";
            this.uLR.Size = new System.Drawing.Size(142, 17);
            this.uLR.TabIndex = 0;
            this.uLR.TabStop = true;
            this.uLR.Text = "Левый верхний вправо";
            this.uLR.UseVisualStyleBackColor = true;
            // 
            // uRL
            // 
            this.uRL.AutoSize = true;
            this.uRL.Location = new System.Drawing.Point(12, 35);
            this.uRL.Name = "uRL";
            this.uRL.Size = new System.Drawing.Size(142, 17);
            this.uRL.TabIndex = 1;
            this.uRL.TabStop = true;
            this.uRL.Text = "Правый верхний влево";
            this.uRL.UseVisualStyleBackColor = true;
            // 
            // bRL
            // 
            this.bRL.AutoSize = true;
            this.bRL.Location = new System.Drawing.Point(12, 58);
            this.bRL.Name = "bRL";
            this.bRL.Size = new System.Drawing.Size(139, 17);
            this.bRL.TabIndex = 3;
            this.bRL.TabStop = true;
            this.bRL.Text = "Правый нижний влево";
            this.bRL.UseVisualStyleBackColor = true;
            // 
            // bLR
            // 
            this.bLR.AutoSize = true;
            this.bLR.Location = new System.Drawing.Point(12, 81);
            this.bLR.Name = "bLR";
            this.bLR.Size = new System.Drawing.Size(139, 17);
            this.bLR.TabIndex = 2;
            this.bLR.TabStop = true;
            this.bLR.Text = "Левый нижний вправо";
            this.bLR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текст";
            // 
            // ThisText
            // 
            this.ThisText.Location = new System.Drawing.Point(12, 199);
            this.ThisText.Name = "ThisText";
            this.ThisText.Size = new System.Drawing.Size(425, 158);
            this.ThisText.TabIndex = 5;
            this.ThisText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закодировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bRU
            // 
            this.bRU.AutoSize = true;
            this.bRU.Location = new System.Drawing.Point(160, 58);
            this.bRU.Name = "bRU";
            this.bRU.Size = new System.Drawing.Size(138, 17);
            this.bRU.TabIndex = 10;
            this.bRU.TabStop = true;
            this.bRU.Text = "Правый нижний вверх";
            this.bRU.UseVisualStyleBackColor = true;
            // 
            // bLU
            // 
            this.bLU.AutoSize = true;
            this.bLU.Location = new System.Drawing.Point(160, 81);
            this.bLU.Name = "bLU";
            this.bLU.Size = new System.Drawing.Size(132, 17);
            this.bLU.TabIndex = 9;
            this.bLU.TabStop = true;
            this.bLU.Text = "Левый нижний вверх";
            this.bLU.UseVisualStyleBackColor = true;
            // 
            // uRD
            // 
            this.uRD.AutoSize = true;
            this.uRD.Location = new System.Drawing.Point(160, 35);
            this.uRD.Name = "uRD";
            this.uRD.Size = new System.Drawing.Size(136, 17);
            this.uRD.TabIndex = 8;
            this.uRD.TabStop = true;
            this.uRD.Text = "Правый верхний вниз";
            this.uRD.UseVisualStyleBackColor = true;
            // 
            // uLD
            // 
            this.uLD.AutoSize = true;
            this.uLD.Location = new System.Drawing.Point(160, 12);
            this.uLD.Name = "uLD";
            this.uLD.Size = new System.Drawing.Size(130, 17);
            this.uLD.TabIndex = 7;
            this.uLD.TabStop = true;
            this.uLD.Text = "Левый верхний вниз";
            this.uLD.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Декодировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DebugText
            // 
            this.DebugText.Location = new System.Drawing.Point(11, 363);
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(425, 116);
            this.DebugText.TabIndex = 12;
            this.DebugText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 491);
            this.Controls.Add(this.DebugText);
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
        private System.Windows.Forms.RichTextBox DebugText;
    }
}

