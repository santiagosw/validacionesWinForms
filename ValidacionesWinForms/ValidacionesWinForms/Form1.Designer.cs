namespace ValidacionesWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnValidarPatente = new System.Windows.Forms.Button();
            this.btnSepararCUIT = new System.Windows.Forms.Button();
            this.lblResultadoPatente = new System.Windows.Forms.Label();
            this.lblCUITFormateado = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(100, 30);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(135, 20);
            this.txtPatente.TabIndex = 0;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(100, 70);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(135, 20);
            this.txtCUIT.TabIndex = 1;
            // 
            // btnValidarPatente
            // 
            this.btnValidarPatente.Location = new System.Drawing.Point(100, 110);
            this.btnValidarPatente.Name = "btnValidarPatente";
            this.btnValidarPatente.Size = new System.Drawing.Size(135, 23);
            this.btnValidarPatente.TabIndex = 4;
            this.btnValidarPatente.Text = "Validar Patente";
            this.btnValidarPatente.Click += new System.EventHandler(this.btnValidarPatente_Click);
            // 
            // btnSepararCUIT
            // 
            this.btnSepararCUIT.Location = new System.Drawing.Point(100, 150);
            this.btnSepararCUIT.Name = "btnSepararCUIT";
            this.btnSepararCUIT.Size = new System.Drawing.Size(135, 23);
            this.btnSepararCUIT.TabIndex = 3;
            this.btnSepararCUIT.Text = "Separar CUIT";
            this.btnSepararCUIT.Click += new System.EventHandler(this.btnSepararCUIT_Click);
            // 
            // lblResultadoPatente
            // 
            this.lblResultadoPatente.AutoSize = true;
            this.lblResultadoPatente.Location = new System.Drawing.Point(100, 190);
            this.lblResultadoPatente.Name = "lblResultadoPatente";
            this.lblResultadoPatente.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoPatente.TabIndex = 2;
            // 
            // lblCUITFormateado
            // 
            this.lblCUITFormateado.AutoSize = true;
            this.lblCUITFormateado.Location = new System.Drawing.Point(100, 220);
            this.lblCUITFormateado.Name = "lblCUITFormateado";
            this.lblCUITFormateado.Size = new System.Drawing.Size(0, 13);
            this.lblCUITFormateado.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(100, 250);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(0, 13);
            this.lblDNI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "lblPatente";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 57);
            this.label2.Name = "lblCUIT";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CUIT:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCUITFormateado);
            this.Controls.Add(this.lblResultadoPatente);
            this.Controls.Add(this.btnSepararCUIT);
            this.Controls.Add(this.btnValidarPatente);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.txtPatente);
            this.Name = "MainForm";
            this.Text = "Validaciones WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnValidarPatente;
        private System.Windows.Forms.Button btnSepararCUIT;
        private System.Windows.Forms.Label lblResultadoPatente;
        private System.Windows.Forms.Label lblCUITFormateado;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
