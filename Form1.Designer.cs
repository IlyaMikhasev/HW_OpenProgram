namespace HW_OpenProgram
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
            this.b_note = new System.Windows.Forms.Button();
            this.b_calculator = new System.Windows.Forms.Button();
            this.b_paint = new System.Windows.Forms.Button();
            this.b_startProcces = new System.Windows.Forms.Button();
            this.tb_nameProc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_note
            // 
            this.b_note.Location = new System.Drawing.Point(316, 12);
            this.b_note.Name = "b_note";
            this.b_note.Size = new System.Drawing.Size(89, 23);
            this.b_note.TabIndex = 0;
            this.b_note.Text = "Блокнот";
            this.b_note.UseVisualStyleBackColor = true;
            this.b_note.Click += new System.EventHandler(this.b_note_Click);
            // 
            // b_calculator
            // 
            this.b_calculator.Location = new System.Drawing.Point(316, 41);
            this.b_calculator.Name = "b_calculator";
            this.b_calculator.Size = new System.Drawing.Size(89, 23);
            this.b_calculator.TabIndex = 1;
            this.b_calculator.Text = "калькулятор";
            this.b_calculator.UseVisualStyleBackColor = true;
            this.b_calculator.Click += new System.EventHandler(this.b_calculator_Click);
            // 
            // b_paint
            // 
            this.b_paint.Location = new System.Drawing.Point(316, 70);
            this.b_paint.Name = "b_paint";
            this.b_paint.Size = new System.Drawing.Size(89, 23);
            this.b_paint.TabIndex = 2;
            this.b_paint.Text = "Paint";
            this.b_paint.UseVisualStyleBackColor = true;
            this.b_paint.Click += new System.EventHandler(this.b_paint_Click);
            // 
            // b_startProcces
            // 
            this.b_startProcces.Location = new System.Drawing.Point(316, 150);
            this.b_startProcces.Name = "b_startProcces";
            this.b_startProcces.Size = new System.Drawing.Size(89, 23);
            this.b_startProcces.TabIndex = 3;
            this.b_startProcces.Text = "Запуск";
            this.b_startProcces.UseVisualStyleBackColor = true;
            this.b_startProcces.Click += new System.EventHandler(this.b_startProcces_Click);
            // 
            // tb_nameProc
            // 
            this.tb_nameProc.Location = new System.Drawing.Point(25, 150);
            this.tb_nameProc.Name = "tb_nameProc";
            this.tb_nameProc.Size = new System.Drawing.Size(267, 20);
            this.tb_nameProc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите название приложения для запуска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nameProc);
            this.Controls.Add(this.b_startProcces);
            this.Controls.Add(this.b_paint);
            this.Controls.Add(this.b_calculator);
            this.Controls.Add(this.b_note);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_note;
        private System.Windows.Forms.Button b_calculator;
        private System.Windows.Forms.Button b_paint;
        private System.Windows.Forms.Button b_startProcces;
        private System.Windows.Forms.TextBox tb_nameProc;
        private System.Windows.Forms.Label label1;
    }
}

