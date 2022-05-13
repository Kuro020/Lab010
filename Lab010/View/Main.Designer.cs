
namespace Lab010.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLer = new System.Windows.Forms.Button();
            this.ltbLeitor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(50, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(454, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Leitor de Texto com informações delimitadas";
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(30, 48);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(481, 29);
            this.btnLer.TabIndex = 1;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // ltbLeitor
            // 
            this.ltbLeitor.FormattingEnabled = true;
            this.ltbLeitor.ItemHeight = 15;
            this.ltbLeitor.Location = new System.Drawing.Point(12, 95);
            this.ltbLeitor.Name = "ltbLeitor";
            this.ltbLeitor.Size = new System.Drawing.Size(519, 349);
            this.ltbLeitor.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.ltbLeitor);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Leitor de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.ListBox ltbLeitor;
    }
}