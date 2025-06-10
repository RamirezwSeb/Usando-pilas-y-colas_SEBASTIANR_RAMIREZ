namespace Usando_pilas_y_colas_SEBASTIANR_RAMIREZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCargarDatos = new Button();
            lstPila = new ListBox();
            txtCantidad = new TextBox();
            txtEliminarValor = new TextBox();
            btnEliminarValor = new Button();
            lstCola = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Location = new Point(356, 27);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(94, 23);
            btnCargarDatos.TabIndex = 0;
            btnCargarDatos.Text = "Cargar datos";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // lstPila
            // 
            lstPila.FormattingEnabled = true;
            lstPila.ItemHeight = 15;
            lstPila.Location = new Point(23, 71);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(120, 94);
            lstPila.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(218, 6);
            txtCantidad.MaxLength = 2;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            // 
            // txtEliminarValor
            // 
            txtEliminarValor.Location = new Point(147, 256);
            txtEliminarValor.MaxLength = 2;
            txtEliminarValor.Name = "txtEliminarValor";
            txtEliminarValor.Size = new Size(100, 23);
            txtEliminarValor.TabIndex = 3;
            // 
            // btnEliminarValor
            // 
            btnEliminarValor.Location = new Point(349, 252);
            btnEliminarValor.Name = "btnEliminarValor";
            btnEliminarValor.Size = new Size(101, 23);
            btnEliminarValor.TabIndex = 4;
            btnEliminarValor.Text = "Eliminar valor";
            btnEliminarValor.UseVisualStyleBackColor = true;
            btnEliminarValor.Click += btnEliminarValor_Click;
            // 
            // lstCola
            // 
            lstCola.FormattingEnabled = true;
            lstCola.ItemHeight = 15;
            lstCola.Location = new Point(198, 71);
            lstCola.Name = "lstCola";
            lstCola.Size = new Size(120, 94);
            lstCola.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 6);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese la cantidad de números:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 256);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 7;
            label2.Text = "Valor a eliminar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 301);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCola);
            Controls.Add(btnEliminarValor);
            Controls.Add(txtEliminarValor);
            Controls.Add(txtCantidad);
            Controls.Add(lstPila);
            Controls.Add(btnCargarDatos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarDatos;
        private ListBox lstPila;
        private TextBox txtCantidad;
        private TextBox txtEliminarValor;
        private Button btnEliminarValor;
        private ListBox lstCola;
        private Label label1;
        private Label label2;
    }
}
