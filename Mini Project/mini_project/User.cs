using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace mini_project
{
    class User
    {

        public static SqlConnection con;
        public static SqlCommand cmd;



        static SqlConnection getConnection()
        {
            con = new SqlConnection("Server=ICS-LT-D244D6GB;initial catalog=prj;Integrated Security=true");
            con.Open();
            return con;
        }
        public static void UserMenu()
        {

            Console.WriteLine("\n======== User ============");
            Console.WriteLine("Choose an operation");
            Console.WriteLine("1.Check Trains Available");
            Console.WriteLine("2.Book Ticket");
            Console.WriteLine("3.Cancel Ticket");
            Console.WriteLine("4.Show All Trains");
            Console.WriteLine("5.Show All Bookings");
            Console.WriteLine("6.Exit");
            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CheckTrain();
                    break;
                case 2:
                    BookTicket();
                    break;
                case 3:
                    CancelTicket();
                        break;
                case 4:
                    ShowAllTrains();
                    break;
                case 5:
                    ShowAllBookings();
                    break;
                case 6:
                    Console.WriteLine("You selected option Exit");
                    return;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
             
            }
        }
        public static void CheckTrain()
        {
            SqlConnection con = getConnection();
            Console.WriteLine("Enter booking date (YYYY-MM-DD): ");
            DateTime bookingDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter source station: ");
            string source = Console.ReadLine();
            Console.WriteLine("Enter destination station: ");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter number of tickets: ");
            int numberOfTickets = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("CheckTrain", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@booking_date", bookingDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@destination", destination);
            cmd.Parameters.AddWithValue("@number_of_tickets", numberOfTickets);
            
          
            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string TrainStatus = Convert.ToString(param.Value);
            Console.WriteLine($"{TrainStatus} ");
        }
        public static void BookTicket()
        {

            SqlConnection con = getConnection();


           SqlCommand cmd = new SqlCommand("BookTicket", con);
           cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter Train Number:");
            int train_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of tickets: ");
            int numberOfTickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class in Train (Sleeper/1A/2A/3A):");
            string Train_Class = Console.ReadLine();

            Console.WriteLine("Enter User Name:");
            string user_name = Console.ReadLine();
            Console.WriteLine("Enter User Age");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter User Gender");
            string Gender = Console.ReadLine();
            
            cmd.Parameters.AddWithValue("@train_num", train_num);
            cmd.Parameters.AddWithValue("@name",user_name);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@number_of_tickets", numberOfTickets);
            cmd.Parameters.AddWithValue("@Class", Train_Class);


            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string bookingStatus = Convert.ToString(param.Value);
            Console.WriteLine($"Booking Status :{bookingStatus} ");

        }


        public static void CancelTicket()
        {

            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand("Cancel_Tickets", con);
            cmd.CommandType = CommandType.StoredProcedure;

            Console.WriteLine("Enter the booking ID: ");
            int bookingid = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.Add(new SqlParameter("@booking_id", bookingid));

            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string bookingStatus = Convert.ToString(param.Value);
            Console.WriteLine($"Booking Status :{bookingStatus} ");

        }



        public static void ShowAllTrains()
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand("ShowTrains", con);
            cmd.CommandType = CommandType.StoredProcedure;
            Console.WriteLine("The available trains are : ");
            Console.WriteLine("Train Number|\tTrain Name|\t\tSource|\tDestination|\tAvailable Berths|\tPrice");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["TrainNumber"]}|\t\t{reader["TrainName"]}|\t{reader["Source"]}|\t{reader["Destination"]}|\t\t{reader["AvailableBerths"]}|\t\t{reader["Price"]}|\t");
            }
        }
        public static void ShowAllBookings()
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand("ShowBookings", con);
            cmd.CommandType = CommandType.StoredProcedure;
            Console.WriteLine("The available bookings are : ");
            Console.WriteLine("Booking_ID|\tTrainNumber|\t Booking_Date|\tSource|\tDestination|\tnumberoftickets");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Booking_ID"]}|\t\t{reader["TrainNumber"]}|\t{reader["Booking_Date"]}|\t{reader["Source"]}|\t{reader["Destination"]}|\t\t{reader["number_of_tickets"]}|\t");
            }
        }
    }
}
    

