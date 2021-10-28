
namespace Calculadora.WinForm
{
    partial class CalculadoraForm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(10, 480);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(122, 76);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(138, 480);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 76);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(266, 480);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 76);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(266, 398);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(124, 76);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(138, 398);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(122, 76);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(10, 398);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(122, 76);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(266, 316);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(124, 76);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(138, 316);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(122, 76);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(10, 316);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(122, 76);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(138, 562);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(122, 76);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPunto.Location = new System.Drawing.Point(266, 562);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(124, 76);
            this.btnPunto.TabIndex = 10;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIgual.Location = new System.Drawing.Point(396, 562);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(124, 76);
            this.btnIgual.TabIndex = 11;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuma.Location = new System.Drawing.Point(396, 480);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(124, 76);
            this.btnSuma.TabIndex = 12;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResta.Location = new System.Drawing.Point(396, 398);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(124, 76);
            this.btnResta.TabIndex = 13;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMulti.Location = new System.Drawing.Point(396, 316);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(124, 76);
            this.btnMulti.TabIndex = 14;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.clickOperador);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResultado.Location = new System.Drawing.Point(12, 30);
            this.txtResultado.MaxLength = 11;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(510, 106);
            this.txtResultado.TabIndex = 15;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(396, 234);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 76);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.AutoSize = true;
            this.txtPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(12, 139);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(0, 28);
            this.txtPreview.TabIndex = 17;
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 667);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "CalculadoraForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caluladora FV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label txtPreview;
    }
}

