using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryReservationSystem
{
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtUserID.Text);
            string isbn = txtISBN.Text;
            DateTime reservationDate = DateTime.Now;
            DateTime returnDate = reservationDate.AddDays(14); // 14 días para el retorno

            using (SqlConnection conn = new SqlConnection("Server=your_server_name;Database=LibraryDB;Trusted_Connection=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservations (UserID, ISBN, ReservationDate, ReturnDate) VALUES (@UserID, @ISBN, @ReservationDate, @ReturnDate)", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Reserva realizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
