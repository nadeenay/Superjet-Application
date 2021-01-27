using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DB_project1
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //find email for all employees
        public DataTable Find_Employee_Email_Admin(string Email)
        {

            string query = "Select * FROM Employee where (Employee_Email='" + Email + "');";
            return dbMan.ExecuteReader(query);
        }

        //password and email is already unique
        public DataTable Find_Employee_Type(string Email, string password)
        {

            string query = "Select Employee_Type FROM Employee where Employee_Password='" + password + "'and Employee_Email='" + Email + "';";
            return dbMan.ExecuteReader(query);
        }
        //To know if there is a trip with this  informatin to reserve or not
        public DataTable Find_Weekly_Trips(string Location1, string Location2, string day, TimeSpan Time)
        {

            string query = "Select WeeklyTrip_ID,Price FROM WeeklyTrips where Starting_Point='" + Location1 + "' and Ending_Point='" + Location2 + "' and WeeklyTrip_Day='" + day + "' and WeeklyTrip_Time='" + Time + "' and Is_Available=1;";
            return dbMan.ExecuteReader(query);
        }

        // for insert Passenger
        public int Insert_Passenger(string Passenger_Name, string PhoneNumber, string Passenger_Email, string Passenger_Gender)
        {

            string query = "INSERT INTO Passenger (Passenger_Name, Passenger_PhoneNumber, Passenger_Email,Passenger_Gender)" +
                            "Values ('" + Passenger_Name + "','" + PhoneNumber + "','" + Passenger_Email + "','" + Passenger_Gender + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //to check if the trip already start to be reserved or not and get the price of this trip
        public DataTable Check(string Location1, string Location2, string day, TimeSpan Time, DateTime date)
        {

            string query = "Select Trip_ID,Price FROM BusTrip,WeeklyTrips where Starting_Point='" + Location1 + "' and Ending_Point='" + Location2 + "' and WeeklyTrip_Day='" + day + "'  and Weekly_Trips_ID=WeeklyTrip_ID and Trip_Date='" + date + "' and WeeklyTrip_Time='" + Time + "' ;";
            return dbMan.ExecuteReader(query);
        }
        //to find number of seats in the bus 

        public DataTable Find_Num_Of_Seats_in_the_Bus(int id)
        {

            string query = "Select Bus_Number_Of_Seats FROM Buses,BusDriver,WeeklyTrips,BusTrip " +
                           "where Bus_ID=D_Bus_ID and WeeklyTrips_DriverID=Driver_ID and Weekly_Trips_ID=WeeklyTrip_ID and Trip_ID=" + id + " ;";//Date should convert to date type!!!
            return dbMan.ExecuteReader(query);
        }
        //to count number of seats in a trip
        public Object Count_Current_seats(int id)
        {

            string query = "Select Sum(Number_Of_Seats) FROM PassengerTrip where PT_Trip_ID=" + id + ";";//date should convert to date type!!!
            return dbMan.ExecuteScalar(query);
        }
        //to insert a bus trip (this happen when the first passenger come for one of the weekly trips)
        public int Insert_Bus_Trip(DateTime Trip_Date, int Weekly_Trips_ID)
        {
            // int WT = Convert.ToInt32(Weekly_Trips_ID);
            string query = "INSERT INTO BusTrip (Trip_Date,Weekly_Trips_ID)" +
                            "Values ('" + Trip_Date + "'," + Weekly_Trips_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        //to know if the promo code valid for this trip or not
        public DataTable Check_Promo_Code_Validation(string PC, int WT)
        {

            string query = "Select Discount FROM PromoCodes,WeeklyTrips,BusTrip WHERE PromoCode=PC_Name and PC_Name='" + PC + "' AND Valid = 1 and WeeklyTrip_ID=Weekly_Trips_ID and Trip_ID=" + WT + " ;";
            return dbMan.ExecuteReader(query);
        }
        // check if there is a passenger with that email 
        public DataTable Get_P_Email(string Email)
        {
            string query = "Select  Passenger_ID FROM Passenger where Passenger_Email='" + Email + "'  ;";
            return dbMan.ExecuteReader(query);
        }
        // catch the type of the employee
        public DataTable Catch_Type(string Email, string Pass)
        {
            string query = "Select Employee_Type FROM Employee WHERE Employee_Email='" + Email + "' AND Employee_Password='" + Pass + "';";
            return dbMan.ExecuteReader(query);
        }
        //find Passenger Id
        public DataTable Get_Passenger_id(string Phone)
        {
            string query = "Select Passenger_ID FROM Passenger WHERE Passenger_PhoneNumber='" + Phone + "' ;";
            return dbMan.ExecuteReader(query);
        }
        //Insert Passenger_Trip(to make relation betwwen passenger and trip)
        public int Insert_Passenger_Trip(int Passenger_id, int Trip_id, int numofseats, int Total_Price)
        {

            string query = "INSERT INTO PassengerTrip (PT_Passenger_ID, PT_Trip_ID, Number_Of_Seats,Total_Money_Paid)" +
                            "Values (" + Passenger_id + "," + Trip_id + "," + numofseats + "," + Total_Price + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        //For  location1 combo box
        public DataTable Get_Location1()
        {
            string query = "Select distinct Starting_Point FROM WeeklyTrips ;";
            return dbMan.ExecuteReader(query);
        }
        //For location2 combo box
        public DataTable Get_Location2()
        {
            string query = "Select distinct Ending_Point FROM WeeklyTrips ;";
            return dbMan.ExecuteReader(query);
        }
        // find number of seats in the weekly trips
        public DataTable Find_Num_Of_Seats_in_the_Bus_Using_IDW(int id)
        {

            string query = "Select Bus_Number_Of_Seats FROM Buses,BusDriver,WeeklyTrips where Bus_ID=D_Bus_ID and WeeklyTrips_DriverID=Driver_ID  and WeeklyTrip_ID=" + id + " ;";
            return dbMan.ExecuteReader(query);
        }
        //Search for weekly trip with ending and start point only
        public DataTable Find_Weekly_Trips_Start_End(string Location1, string Location2)
        {

            string query = "Select WeeklyTrip_Day,WeeklyTrip_Time FROM WeeklyTrips where Starting_Point='" + Location1 + "' and Ending_Point='" + Location2 + "' and Is_Available=1 ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable DriverOfWeeklTrip(string TripID)
        {

            string query = "Select Driver_ID FROM BusDriver,BusTrip,WeeklyTrips  WHERE Trip_ID = " + TripID + " and WeeklyTrip_ID = Weekly_Trips_ID and Driver_ID = WeeklyTrips_DriverID ;";
            return dbMan.ExecuteReader(query);
        }
        public Object CheckTripID(string n)
        {

            string query = "SELECT COUNT(*) " +
                           "FROM BusTrip" +
                           " WHERE Trip_ID = " + n + ";";
            return dbMan.ExecuteScalar(query);
        }
        public Object PassengerinTrip(string PassengerID, string TripID)
        {

            string query = "Select Count(*) FROM PassengerTrip  WHERE PT_Passenger_ID=" + PassengerID + " AND PT_Trip_ID = " + TripID + ";";
            return dbMan.ExecuteScalar(query);
        }

        public int AddComplaint(string Tripid, string passengerid, string complaint, string Driver_ID)
        {
            DateTime now = DateTime.Now;
            string format = "YYYY-MM-DD";
            string query = "INSERT INTO Complaints (C_Trip_ID,C_Passenger_ID,Complaint,Complaint_Date,C_Driver_ID) " +
                            "Values (" + Tripid + "," + passengerid + " ,'" + complaint + "' ,'" + now.Date.ToString("yyyy-MM-dd") + "'," + Driver_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Drivers_with_Complaints(string n, DateTime str, DateTime end)
        {

            string query = "SELECT Driver_ID,Driver_Name,Penalty,Penalty_Date,Driver_Salary,COUNT(*) as No_Complaints FROM BusDriver BD ,Complaints " +
                " WHERE Driver_ID = C_Driver_ID and Complaint_Date >= '" + str.ToString() + "' and Complaint_Date <='" + end.ToString() + "' "
                + " GROUP BY Driver_ID,Driver_Name,Driver_Salary ,Penalty,Penalty_Date" +
                 " HAVING COUNT(*) >" + n + ";";
            return dbMan.ExecuteReader(query);
        }



        public int DecrementSalary(string dec, string numofComplaints)
        {
            DateTime now = DateTime.Now;
            string query =
                "UPDATE BusDriver " +
                " SET Penalty = " + dec + " , Penalty_Date = '" + now.ToString() + "'" +
                " WHERE Driver_ID IN " +
                          " (SELECT Driver_ID FROM BusDriver BD ,Complaints " +
                          " WHERE Driver_ID = C_Driver_ID "
                        + " GROUP BY Driver_ID " +
                          " HAVING COUNT(*) >" + numofComplaints + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public Object CheckEmployeeID(string n)
        {

            string query = "SELECT COUNT(*) " +
                           "FROM Employee " +
                           "WHERE Employee_ID =" + n + ";";
            return dbMan.ExecuteScalar(query);
        }
        public Object CheckWTID(string n)
        {

            string query = "SELECT COUNT(*) " +
                           "FROM WeeklyTrips " +
                           "WHERE WeeklyTrip_ID = " + n + ";";
            return dbMan.ExecuteScalar(query);
        }
        public Object CheckPromoCodeName(string n)
        {

            string query = "SELECT COUNT(*) " +
                           "FROM PromoCodes" +
                           " WHERE PC_Name = '" + n + "';";
            return dbMan.ExecuteScalar(query);
        }
        public int AddPromoCode(string PCname, string discount, int Eid)
        {
            string query = "INSERT INTO PromoCodes (PC_Name,valid,Discount,Employee_ID ) " +
                            "Values ( '" + PCname + "',1," + discount + "," + Eid + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddPromoToWT(string PCname, string WKid)
        {
            string query = "UPDATE WeeklyTrips SET PromoCode = '" + PCname + "' WHERE WeeklyTrip_ID =" + WKid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RemovePromoCode(string PCname)
        {
            string query = "UPDATE  PromoCodes SET Valid = 0 " +
                            "WHERE PC_Name ='" + PCname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetEmployeeIDFromEmail(string email)
        {

            string query = "SELECT Employee_ID FROM Employee " +
                " WHERE Employee_Email = '" + email + "';";
            return dbMan.ExecuteReader(query);
        }



















        public DataTable Get_Employee_byEmail(string email)
        {
            string query = "Select * From Employee Where Employee_Email = '" + email + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAll_Employee()
        {
            string query = "Select * " +
                           "From Employee;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAll_BusDriver()
        {
            string query = "Select * " +
                           "From BusDriver;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAll_BUS()
        {
            string query = "Select * " +
                           "From Buses;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAll_WeeklyTrips()
        {
            string query = "Select * " +
                           "From WeeklyTrips;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAll_Passenger()
        {
            string query = "Select * " +
                           "From Passenger;";
            return dbMan.ExecuteReader(query);
        }

        public int Insert_Driver(string name, DateTime BD, string PhoneNumber, string Address,
            int salary, string nationalID, string gender, string bloodtype,
            string TrifficDepartment, string DrivingLicense, DateTime RedemptionDate, int busid)
        {
            string query = "Insert into BusDriver (Driver_Name, Driver_BirthDate, Driver_PhoneNumber, " +
                           "Driver_Address, Driver_Salary, Driver_National_ID, Driver_HiredDate, Gender, " +
                           "BloodType, Traffic_Department, Driving_License, Redemption_Date, D_Bus_ID) VALUES " +
                           "('" + name + "','" + BD + "','" + PhoneNumber + "','" + Address + "'," + salary +
                           ", '" + nationalID + "', '" + DateTime.Today + "','" + gender + "','" + bloodtype + "','"
                           + TrifficDepartment + "','" + DrivingLicense + "','" + RedemptionDate + "'," + busid + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Search_Driver(string phone)
        {
            string query = "Select * From BusDriver Where Driver_PhoneNumber = '" + phone + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Search_Driver(int ID)
        {
            string query = "Select * From BusDriver Where Driver_ID = '" + ID + "';";
            return dbMan.ExecuteReader(query);
        }

        public int Update_Driver(string name, DateTime BD, string oldPhone, string NewPhoneNumber, string Address,
            int salary, string nationalID, string bloodtype, string TrifficDepartment,
            string DrivingLicense, DateTime RedemptionDate, int busid)
        {
            string query;
            if (busid != -1)
                query = "Update BusDriver set Driver_Name = '" + name + "', Driver_BirthDate = '" + BD + "', " +
                               "Driver_PhoneNumber = '" + NewPhoneNumber + "', Driver_Address = '" + Address + "'," +
                               " Driver_Salary = " + salary + ", Driver_National_ID = '" + nationalID + "'," +
                               "BloodType = '" + bloodtype + "', Traffic_Department = '" + TrifficDepartment + "', " +
                               "Driving_License = '" + DrivingLicense + "', Redemption_Date = '" + RedemptionDate + "',D_Bus_ID = " + busid + " " +
                               "Where Driver_PhoneNumber = '" + oldPhone + "';";
            else
                query = "Update BusDriver set Driver_Name = '" + name + "', Driver_BirthDate = '" + BD + "', " +
                               "Driver_PhoneNumber = '" + NewPhoneNumber + "', Driver_Address = '" + Address + "'," +
                               " Driver_Salary = " + salary + ", Driver_National_ID = '" + nationalID + "'," +
                               "BloodType = '" + bloodtype + "', Traffic_Department = '" + TrifficDepartment + "', " +
                               "Driving_License = '" + DrivingLicense + "', Redemption_Date = '" + RedemptionDate +
                               "' Where Driver_PhoneNumber = '" + oldPhone + "';";

            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete_Driver(string Phone)
        {
            string query = "Delete From BusDriver Where Driver_PhoneNumber = '" + Phone + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insert_Employee(string name, int salary, string Email, string password
            , string type, string NID, DateTime BD, string Address, string Gender)
        {
            string query = " Insert into Employee (Employee_Name, Employee_BirthDate, Employee_Email, " +
                           " Employee_Address, Employee_Salary, Employee_National_ID, Employee_HiredDate, Gender, " +
                           " Employee_Password, Employee_Type) VALUES " +
                           "('" + name + "','" + BD + "','" + Email + "','" + Address + "', " + salary +
                           " , '" + NID + "', '" + DateTime.Today + "','" + Gender + "','" + password + "','"
                           + type + "' );";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Search_Employee(string nid)
        {
            string query = "Select * From Employee Where Employee_National_ID = '" + nid + "';";
            return dbMan.ExecuteReader(query);
        }

        public int Update_Employee(string name, int salary, string email, string pass, string type, string NID
            , DateTime BOD, string address)
        {
            string query = "Update Employee set Employee_Name = '" + name + "', Employee_BirthDate = '" + BOD + "', " +
                           "Employee_Email = '" + email + "',Employee_Password = '" + pass + "', Employee_Address = '" + address + "'," +
                           " Employee_Salary = " + salary + ", Employee_National_ID = '" + NID + "'," +
                           "Employee_Type = '" + type + "' Where Employee_National_ID = '" + NID + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete_Employee(string nid)
        {
            string query = "Delete From Employee Where Employee_National_ID = '" + nid + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insert_Bus(int modelYear, string EngineNo, string Mac, string model,
            DateTime RDate, string traffic, string licence, string type, int NoSeats)
        {
            string query = "Insert Into Buses (Model_Year,Bus_EngineNumber,Bus_Manufacturer," +
                           "Bus_Model,Bus_Redemtion_date,Bus_Traffic_Department,Bus_License," +
                           "Bus_Type,Bus_Number_Of_Seats) VALUES (" + modelYear + ",'" + EngineNo
                           + "','" + Mac + "','" + model + "','" + RDate + "','" + traffic + "','" + licence
                           + "','" + type + "'," + NoSeats + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Search_Bus(string licence)
        {
            string query = "Select * From Buses Where Bus_License = '" + licence + "';";
            return dbMan.ExecuteReader(query);
        }

        public Object Search_Bus_In_Rent(int busid)
        {
            string query = "Select Count(*) From Rent_Contract " +
                           "Where Rented_BusID = " + busid + " and " +
                           "EndDate > '" + DateTime.Today + "' ;";
            return dbMan.ExecuteScalar(query);
        }

        public Object Search_Bus_In_AD(int busid)
        {
            string query = "Select Count(*) From AD_Contract " +
                           "Where AD_Bus_ID = " + busid + " and " +
                           "EndDate > '" + DateTime.Today + "' ;";
            return dbMan.ExecuteScalar(query);
        }

        public Object Search_Bus_In_WeeklyTrip(int busid)
        {
            string query = "Select Count(*) From BusTrip " +
                           "Where Weekly_Trips_ID In " +
                           "(Select WeeklyTrip_ID From WeeklyTrips " +
                           "Where WeeklyTrips_DriverID In " +
                           "(Select Driver_ID From BusDriver " +
                           "Where D_Bus_ID = " + busid + " )) and Trip_Date > '" + DateTime.Today + "';";
            return dbMan.ExecuteScalar(query);
        }

        public DataTable Get_All_Rent_Buses()
        {
            string query = "Select * From Buses Where Bus_Type = Rent ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_All_SuperJet_Buses()
        {
            string query = "Select * From Buses Where Bus_Type = SuperJet ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Non_Driven_Buses()
        {
            string query = "Select * From Buses " +
                           "Where Bus_Type = 'SuperJet' and Bus_ID Not IN " +
                           "(Select D_Bus_ID From BusDriver);";
            return dbMan.ExecuteReader(query);
        }

        public int Update_Bus(int modelYear, string EngineNo, string Mac, string model,
            DateTime RDate, string traffic, string oldlicence, string newlicence, int NoSeats)
        {
            string query = "Update Buses set Model_Year = " + modelYear +
                           " ,Bus_EngineNumber = '" + EngineNo + "', Bus_Manufacturer = '" + Mac +
                           "', Bus_Model = '" + model + "', Bus_Redemtion_date = '" + RDate + "', " +
                           "Bus_Traffic_Department = '" + traffic + "', Bus_License = '" + newlicence +
                           "', Bus_Number_Of_Seats = " + NoSeats + " Where " +
                           "Bus_License = '" + oldlicence + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete_Bus(string licence)
        {
            string query = "Delete From Buses Where Bus_License = '" + licence + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insert_WeeklyTrip_WithDriver(string Start, string end, int driverid, string day
            , TimeSpan time, int price, int avilably)
        {
            string query = "Insert Into WeeklyTrips (Starting_Point,Ending_Point " +
                           ",WeeklyTrips_DriverID, WeeklyTrip_Day, WeeklyTrip_Time, " +
                           "Price, Is_Available) Values ('" + Start + "','" + end + "'," +
                           driverid + ",'" + day + "','" + time + "'," + price + "," + avilably + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Insert_WeeklyTrip_WithoutDriver(string Start, string end, string day
            , TimeSpan time, int price, int avilably)
        {
            string query = "Insert Into WeeklyTrips (Starting_Point,Ending_Point " +
                           ", WeeklyTrip_Day, WeeklyTrip_Time, " +
                           "Price, Is_Available) Values ('" + Start + "','" + end + "'," +
                           "'" + day + "','" + time + "'," + price + "," + avilably + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable Search_Weekly_Trips_Driver(int driverid, string day)
        {
            string query = "Select * From WeeklyTrips " +
                           "Where WeeklyTrips_DriverID = " + driverid + " " +
                           "And WeeklyTrip_Day = '" + day + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Search_WeeklyTrip_Start(string start)
        {
            string query = "Select * From WeeklyTrips Where Starting_Point = '" + start + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Search_WeeklyTrip_End(string end)
        {
            string query = "Select * From WeeklyTrips Where Ending_Point = '" + end + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Search_WeeklyTrip_Start_End(string start, string end)
        {
            string query = "Select * From WeeklyTrips " +
                           "Where Starting_Point = '" + start + "' " +
                           "and Ending_Point = '" + end + "';";
            return dbMan.ExecuteReader(query);
        }



        public int Update_Weeklytrip(string start, string end, int tripid, int driverid, int price,
            string day, TimeSpan time, int avliabal)
        {
            string query;
            if (driverid == -1)
                query = "Update WeeklyTrips set Starting_Point = '" + start + "'," +
                           " Ending_Point = '" + end + "'" +
                           " , WeeklyTrip_Day = '" + day + "', WeeklyTrip_Time = '" + time +
                           "', Price = " + price + " , Is_Available = " + avliabal + " Where " +
                           "WeeklyTrip_ID = " + tripid + " ;";
            else if (driverid == 0)
                query = "Update WeeklyTrips set Starting_Point = '" + start + "'," +
                          " Ending_Point = '" + end + "', WeeklyTrips_DriverID = NULL " +
                          " , WeeklyTrip_Day = '" + day + "', WeeklyTrip_Time = '" + time +
                          "', Price = " + price + " , Is_Available = " + avliabal + " Where " +
                          "WeeklyTrip_ID = " + tripid + " ;";
            else
                query = "Update WeeklyTrips set Starting_Point = '" + start + "'," +
                           " Ending_Point = '" + end + "', WeeklyTrips_DriverID = " + driverid +
                           " , WeeklyTrip_Day = '" + day + "', WeeklyTrip_Time = '" + time +
                           "', Price = " + price + " , Is_Available = " + avliabal + " Where " +
                           "WeeklyTrip_ID = " + tripid + " ;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete_WeeklyTrip(int tripid)// Make the trip unavailable
        {
            string query = "Update WeeklyTrips Set Is_Available = 0, WeeklyTrips_DriverID = NULL Where WeeklyTrip_ID = " + tripid + " ;";
            return dbMan.ExecuteNonQuery(query);
        }
        /*----------------------------------------------------------------------------------------------------------------------*/

        public int Insert_Packages(string name, int days, int price)
        {
            string query;
            query = " insert into Packages Values ('" + name + "'," + days + "," + price + ",1); ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Search_Package(string name)
        {
            string query;
            query = "Select * " +
                    "From Packages " +
                    "where Package_Name = '" + name + "' ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Get_All_Package()
        {
            string query;
            query = "Select * " +
                    "From Packages ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_All_Available_Package()
        {
            string query;
            query = "Select * " +
                    "From Packages " +
                    "Where Is_Available = 1";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Packages_Not_In_AD()
        {
            string query;
            query = "Select * " +
                    "From Packages " +
                    "Where Package_Name Not In " +
                    "(Select Distinct Package_ID " +
                    "From AD_Contract )";
            return dbMan.ExecuteReader(query);
        }

        public int Delete_package(string name)
        {
            string query;
            query = "Update Packages " +
                    "Set Is_Available = 0 " +
                    "Where Package_Name='" + name + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Find_Duration(string name)
        {
            string query;
            query = "Select Duration " +
                    "From Packages " +
                    "Where Package_Name='" + name + "' ;";
            return dbMan.ExecuteReader(query);
        }
        /*--------------------------------------------------------------------------------------------*/
        public int Insert_Ad_Contract(DateTime start, DateTime end, string cname, string nid, string adress, string gender, string pid, string phoneNum, int ad_bus_id)
        {
            string query;
            query = "insert into AD_Contract (StartDate,EndDate,Client_Name,Client_NationalID,Client_Address,Client_Gender,Package_ID,Client_Phone,AD_Bus_ID) " +
                " values('" + start + "','" + end + "','" + cname + "','" + nid + "','" + adress + "','" + gender + "','" + pid + "','" + phoneNum + "'," + ad_bus_id + "); ";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Search_Bus_For_AD_Contract(DateTime start, DateTime end)
        {
            string query1 = "Select Bus_ID From Buses Where Bus_Type = 'SuperJet' and Bus_ID Not In " +
                            "(Select DISTINCT AD_Bus_ID From AD_Contract); ";
            DataTable d = dbMan.ExecuteReader(query1);

            string query2 = "Select Distinct AD_Bus_ID From AD_Contract " +
                            "Where AD_Bus_ID not in " +
                            "(Select Distinct AD_Bus_ID From AD_Contract " +
                            "Where ('" + start + "' >= StartDate and '" + start + "' <= EndDate) " +
                            "or ('" + end + "' >= StartDate and '" + end + "' <= EndDate));";
            if (d == null)
                return dbMan.ExecuteReader(query2);
            else
                return d;
        }
        public DataTable Search_Ad_contract(string Nid)
        {
            string query;
            query = "Select * " +
                    "From AD_Contract " +
                    " Where Client_NationalID='" + Nid + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Search_Ad_Package_Price(string nid)
        {
            string query  = "Select Client_Name,Client_NationalID,Client_Phone,StartDate,EndDate,Package_ID,Price " +
                            "From Packages, AD_Contract " +
                            "Where Package_ID = Package_Name and Client_NationalID = '" + nid + "' ;";
            return dbMan.ExecuteReader(query);
        }

        public int Delete_Ad_contact(string Nid)
        {
            string query;
            query = "delete from AD_Contract " +
                "where Client_NationalID='" + Nid + "'; ";
            return dbMan.ExecuteNonQuery(query);
        }
        /*--------------------------------------------------------------------------------------------*/
        public int Insert_Rent_Contract(DateTime rentd, DateTime endd, int price, string cname, string nid, string address, string gender, int rbus, string phone)
        {
            string query;
            query = " insert into Rent_Contract (RentDate, EndDate, Price, Client_Name, Client_NationalID, Client_Address, Client_Gender, Rented_BusID,Phone_Number) " +
                "values ('" + rentd + "','" + endd + "'," + price + ",'" + cname + "','" + nid + "','" + address + "','" + gender + "','" + rbus + "','" + phone + "') ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Search_Rent_contract(string nid)
        {
            string query;
            query = "select * " +
                "from Rent_Contract " +
                "where Client_NationalID= '" + nid + "'; ";
            return dbMan.ExecuteReader(query);
        }
        public int Delete_Rent_Contract(string nid)
        {
            string query;
            query = "delete from Rent_Contract " +
                "where Client_NationalID= '" + nid + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Search_Available_Rent_Buses(DateTime startD, DateTime Endd)
        {
            string query1 = "(Select * From Buses Where Bus_Type = 'Rent' and Bus_ID Not In " +
                            "(Select DISTINCT Rented_BusID From Rent_Contract)) Union " +
                            "(Select * From Buses Where Bus_ID In " +
                            "(Select Rented_BusID From Rent_Contract " +
                            "Where Rented_BusID not in " +
                            "(Select Distinct Rented_BusID From Rent_Contract " +
                            "Where ('" + startD + "' >= RentDate and '" + startD + "' <= EndDate) " +
                            "or ('" + Endd + "' >= RentDate and '" + Endd + "' <= EndDate))));";
            return dbMan.ExecuteReader(query1);
        }

        /*--------------------------------------------------------------------------------------------*/
        public Object Last_Emplopyee_ID()
        {
            string query = "SELECT IDENT_CURRENT ('Employee')";
            return dbMan.ExecuteScalar(query);
        }
        public Object Last_Bus_ID()
        {
            string query = "SELECT IDENT_CURRENT ('Buses')";
            return dbMan.ExecuteScalar(query);
        }
        public Object Last_Driver_ID()
        {
            string query = "SELECT IDENT_CURRENT ('BusDriver')";
            return dbMan.ExecuteScalar(query);
        }
        public Object Last_WeeklyTrip_ID()
        {
            string query = "SELECT IDENT_CURRENT ('WeeklyTrips')";
            return dbMan.ExecuteScalar(query);
        }
    }
}
