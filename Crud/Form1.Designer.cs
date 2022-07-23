namespace Crud
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.aniversario = new System.Windows.Forms.MaskedTextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.masculino = new System.Windows.Forms.CheckBox();
            this.feminino = new System.Windows.Forms.CheckBox();
            this.editar = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.Fullname,
            this.Gender,
            this.Birthday,
            this.Emmail,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(1, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentId
            // 
            this.studentId.HeaderText = "Student ID";
            this.studentId.Name = "studentId";
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // Emmail
            // 
            this.Emmail.HeaderText = "Email";
            this.Emmail.Name = "Emmail";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(490, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(525, 238);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fullname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(724, 82);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 9;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(724, 109);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 10;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(724, 190);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 12;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Validated += new System.EventHandler(this.email_Validated);
            // 
            // aniversario
            // 
            this.aniversario.Location = new System.Drawing.Point(724, 156);
            this.aniversario.Mask = "00/00/0000";
            this.aniversario.Name = "aniversario";
            this.aniversario.Size = new System.Drawing.Size(100, 20);
            this.aniversario.TabIndex = 14;
            this.aniversario.ValidatingType = typeof(System.DateTime);
            this.aniversario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.aniversario_MaskInputRejected);
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(724, 219);
            this.endereco.Multiline = true;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(137, 64);
            this.endereco.TabIndex = 15;
            this.endereco.TextChanged += new System.EventHandler(this.endereco_TextChanged);
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(724, 133);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(74, 17);
            this.masculino.TabIndex = 16;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(804, 133);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(68, 17);
            this.feminino.TabIndex = 17;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(543, 313);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 19;
            this.editar.Text = "Edit";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(624, 313);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 20;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(705, 313);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 21;
            this.cancelar.Text = "Cancel";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(786, 313);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 22;
            this.salvar.Text = "Save";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 369);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.del);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.feminino);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.aniversario);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.MaskedTextBox aniversario;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.CheckBox masculino;
        private System.Windows.Forms.CheckBox feminino;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

