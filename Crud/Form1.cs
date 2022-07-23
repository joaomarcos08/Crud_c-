using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form1 : Form
    {
        string caminho;
        string genero;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=snbbllab02-12\joao;Initial Catalog=crud;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            id.Enabled = false;
            nome.Enabled = false;
            masculino.Enabled = false;
            feminino.Enabled = false;
            aniversario.Enabled = false;
            email.Enabled = false;
            endereco.Enabled = false;


            salvar.Enabled = false;
            editar.Enabled = false;
            del.Enabled = false;
            gridData();
        }

        private void validar()
        {
            if(id.Text != "" && nome.Text != "" && aniversario.Text != "" && email.Text !="" && endereco.Text != "" && pictureBox1.ImageLocation != "" )
            {
                editar.Enabled = true;
                del.Enabled = true;
            } else
            {
                editar.Enabled = false;
                del.Enabled = false;
            }
        }

        private void validar1()
        {
            if (nome.Text != "" && aniversario.Text != "" && email.Text != "" && endereco.Text != "" && pictureBox1.ImageLocation != "")
            {
                salvar.Enabled = true;
            }
        }
        private void gridData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            int i = 0;

            c.Open();

            SqlCommand cmd = new SqlCommand("select id, nome, genero, aniversario, email, endereco from Estudante ", c);
            SqlDataReader fill = cmd.ExecuteReader();

            while (fill.Read())
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value = fill[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = fill[1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = fill[2].ToString();
                dataGridView1.Rows[i].Cells[3].Value = fill[3].ToString();
                dataGridView1.Rows[i].Cells[4].Value = fill[4].ToString();
                dataGridView1.Rows[i].Cells[5].Value = fill[5].ToString();
                i++;

            }


            c.Close();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog1.FileName;
                pictureBox1.ImageLocation = caminho;


                nome.Enabled = true;
                masculino.Enabled = true;
                feminino.Enabled = true;
                aniversario.Enabled = true;
                email.Enabled = true;
                endereco.Enabled = true;
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            
            byte[] images = null;

            FileStream stream = new FileStream(caminho, FileMode.Open, FileAccess.Read);

            BinaryReader ImagemConvertido = new BinaryReader(stream);

            images = ImagemConvertido.ReadBytes((int)stream.Length);

            c.Open();

            if (masculino.Checked)
            {
                genero = "masculino";
            }else if (feminino.Checked)
            {
                genero = "feminino";
            }

            SqlCommand inserir = new SqlCommand("insert into Estudante(nome,genero,aniversario,email,endereco,foto) values('" + nome.Text + "','" + genero + "','" + aniversario.Text + "','"+email.Text+"','"+endereco.Text+"',@i)", c);
            inserir.Parameters.Add("@i", images);
            int r = inserir.ExecuteNonQuery();
            if (r == 1)
            {
                MessageBox.Show("Aluno Cadastrado");
                c.Close();
                gridData();
                c.Open();

            }
            else
            {
                MessageBox.Show("Erro no Cadastro");
            }
            c.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string iid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            c.Open();
            SqlCommand cmd = new SqlCommand("select * from Estudante where id = '" + iid + "'", c);
            SqlDataReader fill = cmd.ExecuteReader();

            if (fill.Read())
            {                
                id.Text = fill[0].ToString();
                nome.Text = fill[1].ToString();
                string genero = fill[2].ToString();
                aniversario.Text = fill[3].ToString();
                email.Text = fill[4].ToString();
                endereco.Text = fill[5].ToString();

                byte[] images = ((byte[])fill[6]);
                MemoryStream mstreem = new MemoryStream(images);
                pictureBox1.Image = Image.FromStream(mstreem);



                if (genero == "masculino")
                {
                    masculino.Checked = true;
                } else if (genero == "feminino")
                {
                    feminino.Checked = true;
                }
            }

            c.Close();
            validar();
            nome.Enabled = true;
            masculino.Enabled = true;
            feminino.Enabled = true;
            aniversario.Enabled = true;
            email.Enabled = true;
            endereco.Enabled = true;
        }

        private void del_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cmd = new SqlCommand("delete from Estudante where id = '" + id.Text + "'", c);
            int result = cmd.ExecuteNonQuery();
             if (result == 1)
            {
                MessageBox.Show("cadastro deletado com sucesso");
                c.Close();
                gridData();
                c.Open();
                Limpar();
            }
            else if (result == 0)
            {
                MessageBox.Show("Erro ao deletar cadastro");
            }
            c.Close();
        }

        private void Limpar()
        {
            id.Clear();
            nome.Clear();
            masculino.Checked = false;
            feminino.Checked = false;
            aniversario.Clear();
            email.Clear();
            endereco.Clear();
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            validar();
            id.Enabled = false;
            nome.Enabled = false;
            masculino.Enabled = false;
            feminino.Enabled = false;
            aniversario.Enabled = false;
            email.Enabled = false;
            endereco.Enabled = false;


            salvar.Enabled = false;
            editar.Enabled = false;
            del.Enabled = false;

            pictureBox1.Image = null;

        }

        private void editar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Deseja realizar as alterações no cadastro?", "confirmar", MessageBoxButtons.YesNo);
            //DialogResult resulta;
            //if (resulta == DialogResult.Yes)
            //{

            //}

            if (masculino.Checked)
            {
                genero = "masculino";
            }
            else if (feminino.Checked)
            {
                genero = "feminino";
            }

            string message = "Deseja realizar as alterações no cadastro";
            string caption = "confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resulta;

            resulta = MessageBox.Show(message, caption, buttons);
            if (resulta == System.Windows.Forms.DialogResult.Yes)
            {
            c.Open();
            SqlCommand cmd = new SqlCommand("update Estudante set nome = '"+nome.Text+"', '"+genero+"','"+aniversario.Text+"','"+endereco.Text+"' where id = '" + id.Text + "'",c);
            int result = cmd.ExecuteNonQuery();
            c.Close();
            }
        }

        private void email_Validated(object sender, EventArgs e)
        {
            int posicao, posicao2;
            posicao = email.Text.IndexOf("@");
            posicao2 = email.Text.IndexOf(".com");
            if (posicao == -1 || posicao2 == -1)
            {
                MessageBox.Show("Email Invalida");
                email.BackColor = Color.Red;
            }
            else
            {
                email.BackColor = Color.Green;
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

        private void aniversario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            validar1();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }

        private void endereco_TextChanged(object sender, EventArgs e)
        {
            validar1();
        }
    }
}
