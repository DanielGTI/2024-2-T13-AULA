namespace Aula4
{
    partial class frm_Carros
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
            btnCarro1 = new Button();
            btnCarro2 = new Button();
            lbl_Escolha = new Label();
            pic_Carro = new PictureBox();
            btnVotar = new Button();
            lbl_Corolla = new Label();
            label2 = new Label();
            lbl_Votos_Corolla = new Label();
            lbl_Votos_Cybertruck = new Label();
            btnZerar = new Button();
            btn_Ferrari = new Button();
            lbl_Votos_Ferrari = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Carro).BeginInit();
            SuspendLayout();
            // 
            // btnCarro1
            // 
            btnCarro1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCarro1.Location = new Point(68, 56);
            btnCarro1.Name = "btnCarro1";
            btnCarro1.Size = new Size(327, 35);
            btnCarro1.TabIndex = 0;
            btnCarro1.Text = "Toyota Corolla";
            btnCarro1.UseVisualStyleBackColor = true;
            btnCarro1.Click += btnCarro1_Click;
            // 
            // btnCarro2
            // 
            btnCarro2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCarro2.Location = new Point(68, 97);
            btnCarro2.Name = "btnCarro2";
            btnCarro2.Size = new Size(327, 35);
            btnCarro2.TabIndex = 1;
            btnCarro2.Text = "Tesla Cybertruck";
            btnCarro2.UseVisualStyleBackColor = true;
            btnCarro2.Click += btnCarro2_Click;
            // 
            // lbl_Escolha
            // 
            lbl_Escolha.AutoSize = true;
            lbl_Escolha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Escolha.Location = new Point(68, 18);
            lbl_Escolha.Name = "lbl_Escolha";
            lbl_Escolha.Size = new Size(144, 21);
            lbl_Escolha.TabIndex = 2;
            lbl_Escolha.Text = "Escolha um carro:";
            // 
            // pic_Carro
            // 
            pic_Carro.Image = Properties.Resources.cars;
            pic_Carro.Location = new Point(68, 196);
            pic_Carro.Name = "pic_Carro";
            pic_Carro.Size = new Size(327, 233);
            pic_Carro.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Carro.TabIndex = 3;
            pic_Carro.TabStop = false;
            // 
            // btnVotar
            // 
            btnVotar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnVotar.Location = new Point(68, 435);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(327, 35);
            btnVotar.TabIndex = 4;
            btnVotar.Text = "ESCOLHA DO MOTORISTA";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // lbl_Corolla
            // 
            lbl_Corolla.AutoSize = true;
            lbl_Corolla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Corolla.Location = new Point(99, 485);
            lbl_Corolla.Name = "lbl_Corolla";
            lbl_Corolla.Size = new Size(73, 21);
            lbl_Corolla.TabIndex = 5;
            lbl_Corolla.Text = "Corolla: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 515);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 6;
            label2.Text = "CyberTruck: ";
            // 
            // lbl_Votos_Corolla
            // 
            lbl_Votos_Corolla.AutoSize = true;
            lbl_Votos_Corolla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Votos_Corolla.Location = new Point(178, 485);
            lbl_Votos_Corolla.Name = "lbl_Votos_Corolla";
            lbl_Votos_Corolla.Size = new Size(19, 21);
            lbl_Votos_Corolla.TabIndex = 7;
            lbl_Votos_Corolla.Text = "0";
            // 
            // lbl_Votos_Cybertruck
            // 
            lbl_Votos_Cybertruck.AutoSize = true;
            lbl_Votos_Cybertruck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Votos_Cybertruck.Location = new Point(178, 515);
            lbl_Votos_Cybertruck.Name = "lbl_Votos_Cybertruck";
            lbl_Votos_Cybertruck.Size = new Size(19, 21);
            lbl_Votos_Cybertruck.TabIndex = 8;
            lbl_Votos_Cybertruck.Text = "0";
            // 
            // btnZerar
            // 
            btnZerar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnZerar.Location = new Point(319, 485);
            btnZerar.Name = "btnZerar";
            btnZerar.Size = new Size(76, 35);
            btnZerar.TabIndex = 9;
            btnZerar.Text = "Zerar";
            btnZerar.UseVisualStyleBackColor = true;
            btnZerar.Click += btnZerar_Click;
            // 
            // btn_Ferrari
            // 
            btn_Ferrari.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Ferrari.Location = new Point(68, 138);
            btn_Ferrari.Name = "btn_Ferrari";
            btn_Ferrari.Size = new Size(327, 35);
            btn_Ferrari.TabIndex = 10;
            btn_Ferrari.Text = "Ferrari";
            btn_Ferrari.UseVisualStyleBackColor = true;
            btn_Ferrari.Click += btn_Ferrari_Click;
            // 
            // lbl_Votos_Ferrari
            // 
            lbl_Votos_Ferrari.AutoSize = true;
            lbl_Votos_Ferrari.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Votos_Ferrari.Location = new Point(178, 549);
            lbl_Votos_Ferrari.Name = "lbl_Votos_Ferrari";
            lbl_Votos_Ferrari.Size = new Size(19, 21);
            lbl_Votos_Ferrari.TabIndex = 12;
            lbl_Votos_Ferrari.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 549);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 11;
            label3.Text = "Ferrari:";
            // 
            // frm_Carros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 593);
            Controls.Add(lbl_Votos_Ferrari);
            Controls.Add(label3);
            Controls.Add(btn_Ferrari);
            Controls.Add(btnZerar);
            Controls.Add(lbl_Votos_Cybertruck);
            Controls.Add(lbl_Votos_Corolla);
            Controls.Add(label2);
            Controls.Add(lbl_Corolla);
            Controls.Add(btnVotar);
            Controls.Add(pic_Carro);
            Controls.Add(lbl_Escolha);
            Controls.Add(btnCarro2);
            Controls.Add(btnCarro1);
            Name = "frm_Carros";
            Text = "Carros";
            ((System.ComponentModel.ISupportInitialize)pic_Carro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarro1;
        private Button btnCarro2;
        private Label lbl_Escolha;
        private PictureBox pic_Carro;
        private Button btnVotar;
        private Label lbl_Corolla;
        private Label label2;
        private Label lbl_Votos_Corolla;
        private Label lbl_Votos_Cybertruck;
        private Button btnZerar;
        private Button btn_Ferrari;
        private Label lbl_Votos_Ferrari;
        private Label label3;
    }
}
