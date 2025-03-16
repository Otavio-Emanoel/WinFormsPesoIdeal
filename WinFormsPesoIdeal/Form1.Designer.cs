namespace WinFormsPesoIdeal
{
    partial class FormMenu
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
            groupBox = new Panel();
            panel1 = new Panel();
            fecharBtn = new Button();
            salvarBtn = new Button();
            excluirBtn = new Button();
            calcularBtn = new Button();
            feminino = new RadioButton();
            label7 = new Label();
            masculino = new RadioButton();
            label6 = new Label();
            dataAtual = new DateTimePicker();
            label5 = new Label();
            txtDataNascimento = new DateTimePicker();
            label4 = new Label();
            txtAltura = new TextBox();
            label3 = new Label();
            txtPeso = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            panel2 = new Panel();
            nanoFoto = new PictureBox();
            label8 = new Label();
            panelInfo = new Panel();
            pesoIdealLbl = new Label();
            lblIdade = new Label();
            groupBox.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nanoFoto).BeginInit();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.DarkGray;
            groupBox.Controls.Add(panel1);
            groupBox.Controls.Add(feminino);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(masculino);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(dataAtual);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(txtDataNascimento);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(txtAltura);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(txtPeso);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txtNome);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(259, 537);
            groupBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(fecharBtn);
            panel1.Controls.Add(salvarBtn);
            panel1.Controls.Add(excluirBtn);
            panel1.Controls.Add(calcularBtn);
            panel1.Location = new Point(3, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 201);
            panel1.TabIndex = 14;
            // 
            // fecharBtn
            // 
            fecharBtn.BackColor = Color.DarkRed;
            fecharBtn.BackgroundImageLayout = ImageLayout.None;
            fecharBtn.FlatAppearance.BorderColor = Color.DarkRed;
            fecharBtn.FlatStyle = FlatStyle.Flat;
            fecharBtn.Font = new Font("Segoe UI", 12F);
            fecharBtn.ForeColor = SystemColors.ControlLight;
            fecharBtn.Location = new Point(160, 74);
            fecharBtn.Name = "fecharBtn";
            fecharBtn.Size = new Size(80, 40);
            fecharBtn.TabIndex = 3;
            fecharBtn.Text = "Fechar";
            fecharBtn.UseVisualStyleBackColor = false;
            fecharBtn.Click += fecharBtn_Click;
            // 
            // salvarBtn
            // 
            salvarBtn.BackColor = Color.FromArgb(128, 255, 255);
            salvarBtn.BackgroundImageLayout = ImageLayout.None;
            salvarBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            salvarBtn.FlatStyle = FlatStyle.Flat;
            salvarBtn.Font = new Font("Segoe UI", 12F);
            salvarBtn.Location = new Point(160, 19);
            salvarBtn.Name = "salvarBtn";
            salvarBtn.Size = new Size(80, 40);
            salvarBtn.TabIndex = 2;
            salvarBtn.Text = "Salvar";
            salvarBtn.UseVisualStyleBackColor = false;
            salvarBtn.Click += salvarBtn_Click;
            // 
            // excluirBtn
            // 
            excluirBtn.BackColor = Color.Red;
            excluirBtn.BackgroundImageLayout = ImageLayout.None;
            excluirBtn.FlatAppearance.BorderColor = Color.Red;
            excluirBtn.FlatStyle = FlatStyle.Flat;
            excluirBtn.Font = new Font("Segoe UI", 12F);
            excluirBtn.ForeColor = SystemColors.ControlLight;
            excluirBtn.Location = new Point(11, 74);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(80, 40);
            excluirBtn.TabIndex = 1;
            excluirBtn.Text = "Excluir";
            excluirBtn.UseVisualStyleBackColor = false;
            excluirBtn.Click += excluirBtn_Click;
            // 
            // calcularBtn
            // 
            calcularBtn.BackColor = Color.YellowGreen;
            calcularBtn.BackgroundImageLayout = ImageLayout.None;
            calcularBtn.FlatAppearance.BorderColor = Color.YellowGreen;
            calcularBtn.FlatStyle = FlatStyle.Flat;
            calcularBtn.Font = new Font("Segoe UI", 12F);
            calcularBtn.Location = new Point(11, 19);
            calcularBtn.Name = "calcularBtn";
            calcularBtn.Size = new Size(80, 40);
            calcularBtn.TabIndex = 0;
            calcularBtn.Text = "Calcular";
            calcularBtn.UseVisualStyleBackColor = false;
            calcularBtn.Click += calcularBtn_Click;
            // 
            // feminino
            // 
            feminino.AccessibleName = "genero";
            feminino.AutoSize = true;
            feminino.Font = new Font("Segoe UI", 12F);
            feminino.Location = new Point(62, 292);
            feminino.Name = "feminino";
            feminino.Size = new Size(93, 25);
            feminino.TabIndex = 13;
            feminino.TabStop = true;
            feminino.Text = "Feminino";
            feminino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14F);
            label7.Location = new Point(9, 236);
            label7.Name = "label7";
            label7.Size = new Size(79, 22);
            label7.TabIndex = 12;
            label7.Text = "Gênero:";
            // 
            // masculino
            // 
            masculino.AccessibleName = "genero";
            masculino.AutoSize = true;
            masculino.Font = new Font("Segoe UI", 12F);
            masculino.Location = new Point(62, 261);
            masculino.Name = "masculino";
            masculino.Size = new Size(99, 25);
            masculino.TabIndex = 11;
            masculino.TabStop = true;
            masculino.Text = "Masculino";
            masculino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(9, 121);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 10;
            label6.Text = "Data Atual:";
            // 
            // dataAtual
            // 
            dataAtual.Font = new Font("Segoe UI", 12F);
            dataAtual.Format = DateTimePickerFormat.Short;
            dataAtual.Location = new Point(120, 116);
            dataAtual.Name = "dataAtual";
            dataAtual.Size = new Size(123, 29);
            dataAtual.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14F);
            label5.Location = new Point(9, 86);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 8;
            label5.Text = "Nasimento:";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Font = new Font("Segoe UI", 12F);
            txtDataNascimento.Format = DateTimePickerFormat.Short;
            txtDataNascimento.Location = new Point(120, 81);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(123, 29);
            txtDataNascimento.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F);
            label4.Location = new Point(9, 193);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 6;
            label4.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 12F);
            txtAltura.Location = new Point(75, 191);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(168, 29);
            txtAltura.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(9, 158);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 4;
            label3.Text = "Peso:";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(75, 156);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(168, 29);
            txtPeso.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F);
            label2.Location = new Point(9, 39);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 10);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 1;
            label1.Text = "Formulário";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(81, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(162, 29);
            txtNome.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(nanoFoto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panelInfo);
            panel2.Location = new Point(282, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 537);
            panel2.TabIndex = 1;
            // 
            // nanoFoto
            // 
            nanoFoto.Image = Properties.Resources.NANO_LOGO;
            nanoFoto.ImageLocation = "";
            nanoFoto.Location = new Point(3, 190);
            nanoFoto.Name = "nanoFoto";
            nanoFoto.Size = new Size(584, 344);
            nanoFoto.SizeMode = PictureBoxSizeMode.Zoom;
            nanoFoto.TabIndex = 16;
            nanoFoto.TabStop = false;
            nanoFoto.Click += nanoFoto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(214, 10);
            label8.Name = "label8";
            label8.Size = new Size(199, 24);
            label8.TabIndex = 15;
            label8.Text = "Resultados Salvos";
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(pesoIdealLbl);
            panelInfo.Controls.Add(lblIdade);
            panelInfo.Location = new Point(3, 39);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(584, 32);
            panelInfo.TabIndex = 0;
            // 
            // pesoIdealLbl
            // 
            pesoIdealLbl.AutoSize = true;
            pesoIdealLbl.Font = new Font("Segoe UI", 12F);
            pesoIdealLbl.Location = new Point(267, 6);
            pesoIdealLbl.Name = "pesoIdealLbl";
            pesoIdealLbl.Size = new Size(82, 21);
            pesoIdealLbl.TabIndex = 1;
            pesoIdealLbl.Text = "Peso Ideal:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 12F);
            lblIdade.Location = new Point(12, 6);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(51, 21);
            lblIdade.TabIndex = 0;
            lblIdade.Text = "Idade:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(884, 561);
            Controls.Add(panel2);
            Controls.Add(groupBox);
            MinimumSize = new Size(900, 600);
            Name = "FormMenu";
            Text = "CUIDE DA SUA SAÚDE";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nanoFoto).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel groupBox;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label4;
        private TextBox txtAltura;
        private Label label3;
        private TextBox txtPeso;
        private DateTimePicker txtDataNascimento;
        private Label label6;
        private DateTimePicker dataAtual;
        private Label label5;
        private RadioButton feminino;
        private Label label7;
        private RadioButton masculino;
        private Panel panel1;
        private Button calcularBtn;
        private Button salvarBtn;
        private Button excluirBtn;
        private Button fecharBtn;
        private Panel panel2;
        private Label label8;
        private Panel panelInfo;
        private Label pesoIdealLbl;
        private Label lblIdade;
        private PictureBox nanoFoto;
    }
}
