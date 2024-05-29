using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    internal class RoomController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public RoomController() { }

        public void InsertRoom(Room roomobj)
        {
            try
            {
                if (string.IsNullOrEmpty(roomobj.RoomID) || string.IsNullOrEmpty(roomobj.RoomType) || string.IsNullOrEmpty(roomobj.PatientName) || string.IsNullOrEmpty(roomobj.BuildingFloorNo) || string.IsNullOrEmpty(roomobj.AwardNo) || string.IsNullOrEmpty(roomobj.BedNo) || string.IsNullOrEmpty(roomobj.Status) || string.IsNullOrEmpty(roomobj.RoomCharge))


                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO room (room_ID, roomtype, patientname, buildingfloorno, awardno, bedno, status, patientcheckin, roomcharege, patientcheckout) " +
                        "VALUES (@Room_ID, @Roomtype, @PatientName, @BuildingFloorNo, @AwardNo, @BedNo, @Status, @PatientCheckIn, @RoomCharege, @PatientCheckOut)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", roomobj.RoomID);
                        cmd.Parameters.AddWithValue("@Roomtype,", roomobj.RoomType);
                        cmd.Parameters.AddWithValue("@PatientName", roomobj.PatientName);
                        cmd.Parameters.AddWithValue("@BuildingFloorNo", roomobj.BuildingFloorNo);
                        cmd.Parameters.AddWithValue("@AwardNo", roomobj.AwardNo);
                        cmd.Parameters.AddWithValue("@BedNo", roomobj.BedNo);
                        cmd.Parameters.AddWithValue("@Status", roomobj.Status);
                        cmd.Parameters.AddWithValue("@PatientCheckIn", roomobj.PatientCheckIn);
                        cmd.Parameters.AddWithValue("@RoomCharge", roomobj.RoomCharge);
                        //cmd.Parameters.AddWithValue("PatientCheckOut", roomobj.PatientCheckOut);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully");

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }


            }

        }

        //datagridview view code for patient

        public void ViewRoom(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM room";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void SearchRoom(DataGridView dataGridView, string RoomID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM room WHERE room_ID = @RoomID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);

                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // update code for staff

        public void UpdateRoom(Room roomupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(roomupdate.RoomID) || string.IsNullOrEmpty(roomupdate.RoomType) || string.IsNullOrEmpty(roomupdate.PatientName) || string.IsNullOrEmpty(roomupdate.BuildingFloorNo) || string.IsNullOrEmpty(roomupdate.AwardNo) || string.IsNullOrEmpty(roomupdate.BedNo) || string.IsNullOrEmpty(roomupdate.Status) || string.IsNullOrEmpty(roomupdate.RoomCharge))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE room SET roomtype =  @RoomType, patientname = @PatientName," +
                        " building_floor_no = @BuildingFloorNo, awardno = @AwardNo, bedno = @BedNo, status =@Status, patient_checkin =@PatientCheckIn, roomcharge =@RoomCharge, patient_checkout =@PatientCheckOut WHERE room_ID = @RoomID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Room_ID", roomupdate.RoomID);
                        cmd.Parameters.AddWithValue("@Roomtype,", roomupdate.RoomType);
                        cmd.Parameters.AddWithValue("@PatientName", roomupdate.PatientName);
                        cmd.Parameters.AddWithValue("@BuildingFloorNo", roomupdate.BuildingFloorNo);
                        cmd.Parameters.AddWithValue("@AwardNo", roomupdate.AwardNo);
                        cmd.Parameters.AddWithValue("@BedNo", roomupdate.BedNo);
                        cmd.Parameters.AddWithValue("@Status", roomupdate.Status);
                        cmd.Parameters.AddWithValue("@PatientCheckIn", roomupdate.PatientCheckIn);
                        cmd.Parameters.AddWithValue("@RoomCharge", roomupdate.RoomCharge);
                        cmd.Parameters.AddWithValue("PatientCheckOut", roomupdate.PatientCheckOut);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. theater member not found.");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        // delete code for patient

        public void DeleteRoom(string roomIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(roomIDToDelete))
                {
                    MessageBox.Show("Enter the Room ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM room WHERE room_ID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given room ID");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

       // want to type retrieve code for room
    }
}
