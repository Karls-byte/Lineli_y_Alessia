
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.cmdresultado = new System.Windows.Forms.Button();
            this.cdxoperacion = new System.Windows.Forms.ComboBox();
            this.lbloperaciones = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.Location = new System.Drawing.Point(101, 104);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(77, 13);
            this.lblV1.TabIndex = 0;
            this.lblV1.Text = "Ingrese valor 1";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.Location = new System.Drawing.Point(411, 104);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(77, 13);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Ingrese valor 2";
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(494, 97);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(159, 20);
            this.txtV2.TabIndex = 2;
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(184, 97);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(159, 20);
            this.txtV1.TabIndex = 3;
            this.txtV1.TextChanged += new System.EventHandler(this.txtV1_TextChanged);
            // 
            // cmdresultado
            // 
            this.cmdresultado.Location = new System.Drawing.Point(306, 311);
            this.cmdresultado.Name = "cmdresultado";
            this.cmdresultado.Size = new System.Drawing.Size(169, 45);
            this.cmdresultado.TabIndex = 4;
            this.cmdresultado.Text = "Resultado";
            this.cmdresultado.UseVisualStyleBackColor = true;
            this.cmdresultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // cdxoperacion
            // 
            this.cdxoperacion.FormattingEnabled = true;
            this.cdxoperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta ",
            "Multiplicacion",
            "Division"});
            this.cdxoperacion.Location = new System.Drawing.Point(389, 135);
            this.cdxoperacion.Name = "cdxoperacion";
            this.cdxoperacion.Size = new System.Drawing.Size(160, 21);
            this.cdxoperacion.TabIndex = 7;
            this.cdxoperacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbloperaciones
            // 
            this.lbloperaciones.AutoSize = true;
            this.lbloperaciones.Location = new System.Drawing.Point(303, 143);
            this.lbloperaciones.Name = "lbloperaciones";
            this.lbloperaciones.Size = new System.Drawing.Size(67, 13);
            this.lbloperaciones.TabIndex = 8;
            this.lbloperaciones.Text = "Operaciones";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(377, 268);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(13, 13);
            this.lblresult.TabIndex = 9;
            this.lblresult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbloperaciones);
            this.Controls.Add(this.cdxoperacion);
            this.Controls.Add(this.cmdresultado);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblV1);
            this.Name = "Form1";
            this.Text = "Proyecto 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Button cmdresultado;
        private System.Windows.Forms.ComboBox cdxoperacion;
        private System.Windows.Forms.Label lbloperaciones;
        private System.Windows.Forms.Label lblresult;
    }
}

