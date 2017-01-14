namespace ElevarNum
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
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.DigitePotenciatextBox = new System.Windows.Forms.TextBox();
            this.DigiteNumerotextBox = new System.Windows.Forms.TextBox();
            this.DigitePotenciaLabel = new System.Windows.Forms.Label();
            this.DigiteNumeroLabel = new System.Windows.Forms.Label();
            this.CalacularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(15, 89);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoLabel.TabIndex = 13;
            this.ResultadoLabel.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(90, 86);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 12;
            // 
            // DigitePotenciatextBox
            // 
            this.DigitePotenciatextBox.Location = new System.Drawing.Point(104, 53);
            this.DigitePotenciatextBox.Name = "DigitePotenciatextBox";
            this.DigitePotenciatextBox.Size = new System.Drawing.Size(100, 20);
            this.DigitePotenciatextBox.TabIndex = 11;
            // 
            // DigiteNumerotextBox
            // 
            this.DigiteNumerotextBox.Location = new System.Drawing.Point(137, 22);
            this.DigiteNumerotextBox.Name = "DigiteNumerotextBox";
            this.DigiteNumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.DigiteNumerotextBox.TabIndex = 10;
            // 
            // DigitePotenciaLabel
            // 
            this.DigitePotenciaLabel.AutoSize = true;
            this.DigitePotenciaLabel.Location = new System.Drawing.Point(15, 56);
            this.DigitePotenciaLabel.Name = "DigitePotenciaLabel";
            this.DigitePotenciaLabel.Size = new System.Drawing.Size(83, 13);
            this.DigitePotenciaLabel.TabIndex = 9;
            this.DigitePotenciaLabel.Text = "Digete Potencia";
            // 
            // DigiteNumeroLabel
            // 
            this.DigiteNumeroLabel.AutoSize = true;
            this.DigiteNumeroLabel.Location = new System.Drawing.Point(15, 25);
            this.DigiteNumeroLabel.Name = "DigiteNumeroLabel";
            this.DigiteNumeroLabel.Size = new System.Drawing.Size(116, 13);
            this.DigiteNumeroLabel.TabIndex = 8;
            this.DigiteNumeroLabel.Text = "Digite Numero a Elevar";
            // 
            // CalacularButton
            // 
            this.CalacularButton.Location = new System.Drawing.Point(104, 126);
            this.CalacularButton.Name = "CalacularButton";
            this.CalacularButton.Size = new System.Drawing.Size(75, 30);
            this.CalacularButton.TabIndex = 7;
            this.CalacularButton.Text = "Calcular";
            this.CalacularButton.UseVisualStyleBackColor = true;
            this.CalacularButton.Click += new System.EventHandler(this.CalacularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 175);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.DigitePotenciatextBox);
            this.Controls.Add(this.DigiteNumerotextBox);
            this.Controls.Add(this.DigitePotenciaLabel);
            this.Controls.Add(this.DigiteNumeroLabel);
            this.Controls.Add(this.CalacularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.TextBox DigitePotenciatextBox;
        private System.Windows.Forms.TextBox DigiteNumerotextBox;
        private System.Windows.Forms.Label DigitePotenciaLabel;
        private System.Windows.Forms.Label DigiteNumeroLabel;
        private System.Windows.Forms.Button CalacularButton;
    }
}

