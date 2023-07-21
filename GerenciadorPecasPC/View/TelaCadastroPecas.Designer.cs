namespace GerenciadorPecasPC.View
{
    partial class TelaCadastroPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPecas = new System.Windows.Forms.TextBox();
            this.textBoxMarcas = new System.Windows.Forms.TextBox();
            this.textBoxCapacidades = new System.Windows.Forms.TextBox();
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marcas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidades:";
            // 
            // textBoxPecas
            // 
            this.textBoxPecas.Location = new System.Drawing.Point(66, 147);
            this.textBoxPecas.Name = "textBoxPecas";
            this.textBoxPecas.Size = new System.Drawing.Size(374, 23);
            this.textBoxPecas.TabIndex = 4;
            // 
            // textBoxMarcas
            // 
            this.textBoxMarcas.Location = new System.Drawing.Point(65, 217);
            this.textBoxMarcas.Name = "textBoxMarcas";
            this.textBoxMarcas.Size = new System.Drawing.Size(375, 23);
            this.textBoxMarcas.TabIndex = 5;
            // 
            // textBoxCapacidades
            // 
            this.textBoxCapacidades.Location = new System.Drawing.Point(65, 287);
            this.textBoxCapacidades.Name = "textBoxCapacidades";
            this.textBoxCapacidades.Size = new System.Drawing.Size(375, 23);
            this.textBoxCapacidades.TabIndex = 6;
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarPecas.Font = new System.Drawing.Font("LEMON MILK Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPecas.Location = new System.Drawing.Point(156, 348);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(191, 57);
            this.btnCadastrarPecas.TabIndex = 7;
            this.btnCadastrarPecas.Text = "Cadastrar";
            this.btnCadastrarPecas.UseVisualStyleBackColor = false;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // TelaCadastroPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.textBoxCapacidades);
            this.Controls.Add(this.textBoxMarcas);
            this.Controls.Add(this.textBoxPecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroPecas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxPecas;
        private TextBox textBoxMarcas;
        private TextBox textBoxCapacidades;
        private Button btnCadastrarPecas;
    }
}