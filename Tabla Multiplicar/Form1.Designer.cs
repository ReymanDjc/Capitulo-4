namespace Tabla_Multiplicar
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
            this.NumeroTablaTextBox = new System.Windows.Forms.TextBox();
            this.CarcularBotton = new System.Windows.Forms.Button();
            this.TablaListBox = new System.Windows.Forms.ListBox();
            this.TablaMutiplicarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroTablaTextBox
            // 
            this.NumeroTablaTextBox.Location = new System.Drawing.Point(117, 9);
            this.NumeroTablaTextBox.Name = "NumeroTablaTextBox";
            this.NumeroTablaTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroTablaTextBox.TabIndex = 8;
            // 
            // CarcularBotton
            // 
            this.CarcularBotton.Location = new System.Drawing.Point(77, 153);
            this.CarcularBotton.Name = "CarcularBotton";
            this.CarcularBotton.Size = new System.Drawing.Size(75, 23);
            this.CarcularBotton.TabIndex = 7;
            this.CarcularBotton.Text = "Carcular ";
            this.CarcularBotton.UseVisualStyleBackColor = true;
            this.CarcularBotton.Click += new System.EventHandler(this.CarcularBotton_Click);
            // 
            // TablaListBox
            // 
            this.TablaListBox.FormattingEnabled = true;
            this.TablaListBox.Location = new System.Drawing.Point(58, 35);
            this.TablaListBox.Name = "TablaListBox";
            this.TablaListBox.Size = new System.Drawing.Size(120, 95);
            this.TablaListBox.TabIndex = 6;
            // 
            // TablaMutiplicarLabel
            // 
            this.TablaMutiplicarLabel.AutoSize = true;
            this.TablaMutiplicarLabel.Location = new System.Drawing.Point(12, 9);
            this.TablaMutiplicarLabel.Name = "TablaMutiplicarLabel";
            this.TablaMutiplicarLabel.Size = new System.Drawing.Size(99, 13);
            this.TablaMutiplicarLabel.TabIndex = 5;
            this.TablaMutiplicarLabel.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 180);
            this.Controls.Add(this.NumeroTablaTextBox);
            this.Controls.Add(this.CarcularBotton);
            this.Controls.Add(this.TablaListBox);
            this.Controls.Add(this.TablaMutiplicarLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroTablaTextBox;
        private System.Windows.Forms.Button CarcularBotton;
        private System.Windows.Forms.ListBox TablaListBox;
        private System.Windows.Forms.Label TablaMutiplicarLabel;
    }
}

