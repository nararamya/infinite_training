using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace mini_project
{
    class Admin
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("Server=ICS-LT-D244D6GB;initial catalog=prj;Integrated Security=true");
            con.Open();
            return con;
        }
        public static void Adminlogin()
        {
            string Admin_Username = "admin";
            string Admin_Password = "train";

            Console.WriteLine("Enter Admin Username: ");
            string entered_Username = Console.ReadLine();

            Console.WriteLine("Enter Admin Password: ");
            string entered_Password = Console.ReadLine();


            if (entered_Username == Admin_Username && entered_Password == Admin_Password)
            {
                Console.WriteLine("Login successful!");
                AdminMenu();
            }
            else
            {
                Console.WriteLine("Invalid UserName and Password");
            }
        }

           public static void AdminMenu()
            {
                while (true)
                {
                   
                    Console.WriteLine("\n============= Admin ===============");
                    Console.WriteLine("Choose an operation");
                    Console.WriteLine("1. Add Train");
                    Console.WriteLine("2. Delete Train");
                    Console.WriteLine("3. Modify Train");
                    Console.WriteLine("4. Exit");
                    int options = int.Parse(Console.ReadLine());
                    switch (options)
                    {
                        case 1:AddTrain();  break;
                        case 2:DeleteTrain(); break;
                        case 3: ModifyTrain();  break;
                        case 4:
                            Console.WriteLine("Logged Out!");
                            return;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;

                    }
                }
            }
        
        static void AddTrain()
        {
            con = getConnection();

            Console.WriteLine("Enter train number:");
            int TrainNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            string TrainName = Console.ReadLine();
            Console.Write("Enter Source: ");
            string Source = Console.ReadLine();
            Console.Write("Enter Destination: ");
            string Destination = Console.ReadLine();
            Console.WriteLine("Enter Total berths");
            int TotalBerths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available berths:");
            int AvailableBerths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The date (YYYY-MM-DD):");
            DateTime Travel_Date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price:");
            int Price = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("AddTrain",con);
            cmd.CommandType = CommandType.StoredProcedure;

            

            cmd.Parameters.AddWithValue("@TrainNum", TrainNumber);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@Source", Source);
            cmd.Parameters.AddWithValue("@Destination", Destination);
            cmd.Parameters.AddWithValue("@TotalBerths", TotalBerths);
            cmd.Parameters.AddWithValue("@AvailableBerths", AvailableBerths);
            cmd.Parameters.AddWithValue("@travel_date", Travel_Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@price", Price);

            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string TrainStatus = Convert.ToString(param.Value);

          Console.WriteLine(TrainStatus);
           
        }

        static void DeleteTrain()
        {
            con = getConnection();
            Console.Write("Enter Train Number to delete: ");
            int TrainNumber = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("DeleteTrain", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("TrainNum", TrainNumber);

            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string TrainStatus = Convert.ToString(param.Value);
            Console.WriteLine(TrainStatus);

        }

        static void ModifyTrain()
        {
            con = getConnection();

            Console.Write("Enter Train number to modify: ");
            int TrainNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter New Train Name: ");
            string TrainName = Console.ReadLine();
            Console.Write("Enter New Source: ");
            string Source = Console.ReadLine();
            Console.Write("Enter New Destination: ");
            string Destination = Console.ReadLine();
            Console.WriteLine("Enter New Total Berths");
            int TotalBerths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Available berths:");
            int AvailableBerths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New date (YYYY-MM-DD):");
            DateTime Travel_Date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter New price:");
            int Price = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("ModifyTrain", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TrainNum", TrainNumber);
            cmd.Parameters.AddWithValue("@TrainName", TrainName);
            cmd.Parameters.AddWithValue("@Source", Source);
            cmd.Parameters.AddWithValue("@Destination", Destination);
            cmd.Parameters.AddWithValue("@TotalBerths", TotalBerths);
            cmd.Parameters.AddWithValue("@AvailableBerths", AvailableBerths);
            cmd.Parameters.AddWithValue("@travel_date", Travel_Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@price", Price);

            SqlParameter param = new SqlParameter("@Message", SqlDbType.VarChar, 50);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteReader();
            string TrainStatus = Convert.ToString(param.Value);
            Console.WriteLine(TrainStatus);
        }

    }
}


    

