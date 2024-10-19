using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Para conexión a base de datos

namespace LibraryReservationSystem
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int year = int.Parse(txtYear.Text);
            string genre = txtGenre.Text;
            int copies = int.Parse(txtCopies.Text);

            // Validaciones
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Por favor, ingrese todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conectar a la base de datos y agregar libro
            using (SqlConnection conn = new SqlConnection("Server=your_server_name;Database=LibraryDB;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (ISBN, Title, Author, Publisher, YearOfPublication, Genre, NumberOfCopies) VALUES (@ISBN, @Title, @Author, @Publisher, @Year, @Genre, @Copies)", conn);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Copies", copies);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Libro agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
