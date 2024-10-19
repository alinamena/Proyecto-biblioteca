using System;
using System.Windows.Forms;

namespace LibraryReservationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de usuarios
            var usersForm = new UsersForm();
            usersForm.Show();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de reservas
            var reservationsForm = new ReservationsForm();
            reservationsForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            // Abre el formulario de gestión de libros
            var booksForm = new BooksForm();
            booksForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
