namespace FacturacionCine
{
    partial class frmPopupSala
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopupSala));
            this.Cine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbonombre = new System.Windows.Forms.ComboBox();
            this.txtnumerobutacas = new System.Windows.Forms.NumericUpDown();
            this.txtfila = new System.Windows.Forms.NumericUpDown();
            this.txtcolumna = new System.Windows.Forms.NumericUpDown();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumerobutacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cine
            // 
            resources.ApplyResources(this.Cine, "Cine");
            this.Cine.Name = "Cine";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbonombre
            // 
            this.cbonombre.FormattingEnabled = true;
            resources.ApplyResources(this.cbonombre, "cbonombre");
            this.cbonombre.Name = "cbonombre";
            // 
            // txtnumerobutacas
            // 
            resources.ApplyResources(this.txtnumerobutacas, "txtnumerobutacas");
            this.txtnumerobutacas.Name = "txtnumerobutacas";
            // 
            // txtfila
            // 
            resources.ApplyResources(this.txtfila, "txtfila");
            this.txtfila.Name = "txtfila";
            // 
            // txtcolumna
            // 
            resources.ApplyResources(this.txtcolumna, "txtcolumna");
            this.txtcolumna.Name = "txtcolumna";
            // 
            // txtnombre
            // 
            resources.ApplyResources(this.txtnombre, "txtnombre");
            this.txtnombre.Name = "txtnombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorDatos
            // 
            this.errorDatos.ContainerControl = this;
            // 
            // frmPopupSala
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcolumna);
            this.Controls.Add(this.txtfila);
            this.Controls.Add(this.txtnumerobutacas);
            this.Controls.Add(this.cbonombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cine);
            this.Name = "frmPopupSala";
            this.Load += new System.EventHandler(this.frmPopupSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumerobutacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcolumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbonombre;
        private System.Windows.Forms.NumericUpDown txtnumerobutacas;
        private System.Windows.Forms.NumericUpDown txtfila;
        private System.Windows.Forms.NumericUpDown txtcolumna;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorDatos;
    }
}