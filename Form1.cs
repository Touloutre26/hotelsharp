namespace hotelcsharpL3
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;
        public Form1()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }using System.Text.RegularExpressions;


namespace hotelcsharpL3
{
    public partial class BooknPan : Form
    {
        public BooknPan()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomBox.Text) ||
                string.IsNullOrEmpty(prenomBox.Text) ||
                string.IsNullOrEmpty(telBox.Text) ||
                string.IsNullOrEmpty(emailBox.Text) ||
                string.IsNullOrEmpty(adresseBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // V�rification du num�ro de t�l�phone
            if (!Regex.IsMatch(telBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Mauvais format de num�ro de t�l�phone", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // V�rification de l'adresse email
            if (!Regex.IsMatch(emailBox.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                MessageBox.Show("Adresse E-mail Invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // V�rification des dates de s�jour
            if (debutBox.Value >= finBox.Value)
            {
                MessageBox.Show("Erreur : Veuillez v�rifier les dates de s�jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
