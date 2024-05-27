namespace Formulario_Auto
{
    partial class Formulario_auto
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
            cmb_colores = new ComboBox();
            txt_marca = new TextBox();
            txt_combustible = new TextBox();
            lsb_mis_autos = new ListBox();
            lbl_marca = new Label();
            lbl_combustible = new Label();
            lbl_color = new Label();
            lbl_lista_autos = new Label();
            btn_enviar = new Button();
            btn_limpiar = new Button();
            SuspendLayout();
            // 
            // cmb_colores
            // 
            cmb_colores.BackColor = SystemColors.InactiveCaption;
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Items.AddRange(new object[] { "rojo", "azul", "blanco", "verde" });
            cmb_colores.Location = new Point(41, 196);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(164, 23);
            cmb_colores.TabIndex = 0;
            cmb_colores.SelectedIndexChanged += cbb_colores_SelectedIndexChanged;
            // 
            // txt_marca
            // 
            txt_marca.BackColor = SystemColors.InactiveCaption;
            txt_marca.Location = new Point(41, 53);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(173, 23);
            txt_marca.TabIndex = 1;
            // 
            // txt_combustible
            // 
            txt_combustible.BackColor = SystemColors.InactiveCaption;
            txt_combustible.Location = new Point(41, 117);
            txt_combustible.Name = "txt_combustible";
            txt_combustible.Size = new Size(173, 23);
            txt_combustible.TabIndex = 2;
            // 
            // lsb_mis_autos
            // 
            lsb_mis_autos.ItemHeight = 15;
            lsb_mis_autos.Location = new Point(375, 53);
            lsb_mis_autos.Name = "lsb_mis_autos";
            lsb_mis_autos.Size = new Size(261, 199);
            lsb_mis_autos.TabIndex = 10;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(44, 29);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 4;
            lbl_marca.Text = "Marca";
            // 
            // lbl_combustible
            // 
            lbl_combustible.AutoSize = true;
            lbl_combustible.Location = new Point(45, 95);
            lbl_combustible.Name = "lbl_combustible";
            lbl_combustible.Size = new Size(75, 15);
            lbl_combustible.TabIndex = 5;
            lbl_combustible.Text = "Combustible";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(46, 171);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 6;
            lbl_color.Text = "Color";
            lbl_color.Click += label3_Click;
            // 
            // lbl_lista_autos
            // 
            lbl_lista_autos.AutoSize = true;
            lbl_lista_autos.Location = new Point(375, 18);
            lbl_lista_autos.Name = "lbl_lista_autos";
            lbl_lista_autos.Size = new Size(58, 15);
            lbl_lista_autos.TabIndex = 7;
            lbl_lista_autos.Text = "Mis autos";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(46, 284);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 8;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(377, 295);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 9;
            btn_limpiar.Text = "limpiar lista";
            btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Formulario_auto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_lista_autos);
            Controls.Add(lbl_color);
            Controls.Add(lbl_combustible);
            Controls.Add(lbl_marca);
            Controls.Add(lsb_mis_autos);
            Controls.Add(txt_combustible);
            Controls.Add(txt_marca);
            Controls.Add(cmb_colores);
            Name = "Formulario_auto";
            Text = "Form1";
            Load += Formulario_auto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_colores;
        private TextBox txt_marca;
        private TextBox txt_combustible;
        private ListBox lsb_mis_autos;
        private Label lbl_marca;
        private Label lbl_combustible;
        private Label lbl_color;
        private Label lbl_lista_autos;
        private Button btn_enviar;
        private Button btn_limpiar;
    }
}
