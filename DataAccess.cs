using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnTest
{
    public class DataAccess
    {
        public List<User> GetUsers(string userId)
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                try
                {
                    var userOutput = connection.Query<User>("dbo.Users_getUsersId @UserId", new { UserId = userId }).ToList();
                    
                    return userOutput;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                    System.Windows.Forms.MessageBox.Show("The ID can only be a number!");
                    return null;
                    
                }
            }
        }
        public List<Device> GetDevices(string deviceId)
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                try
                {
                    var deviceOutput = connection.Query<Device>("dbo.Devices_getDevicesId @DeviceId", new { DeviceId = deviceId }).ToList();
                    return deviceOutput;
                }
                catch (Exception f)
                {
                    Console.WriteLine("Exception caught: {0}", f);
                    return null;
                }
            }
        }     
        
        public void AddUser(string name, string role, string location)
        {
            using(IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                List<User> users = new List<User>();

                users.Add(new User { Name = name, Location = location, Role = role });

                connection.Execute("dbo.Users_addUser @Name, @Role, @Location", users);
            }
        }

        public void DeleteUser()
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                List<User> users = new List<User>();
                int UserId = Form1.ID.UserId;
                users.Add(new User { UserId = UserId });

                connection.Execute("dbo.Users_deleteUser @UserId", users);
            }
        }

        public void AddDevice(string name, string manufacturer, string type, string os, string osv, string cpu, string ram)
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                List<Device> devices = new List<Device>();

                devices.Add(new Device { Name = name, Manufacturer = manufacturer, Type = type, OS = os, OSv = osv, CPU = cpu, RAM = ram});

                connection.Execute("dbo.Devices_addDevice @Name, @Manufacturer, @Type, @OS, @OSv, @CPU, @RAM", devices);
            }
        }

        public void UpdateUser(string name, string role, string location)
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                List<User> users = new List<User>();
                int userID = Form1.ID.UserId;
                users.Add(new User { Name = name, Location = location, Role = role, UserId = userID});

                connection.Execute("dbo.Users_updateUser @Name, @Role, @Location, @UserId", users);

            }
        }

        public void UpdateDevice(string name, string manufacturer, string type, string os, string osv, string cpu, string ram)
        {
            using (IDbConnection connection = new SqlConnection(ConnHelper.ConnVal("TutorialDB")))
            {
                List<Device> devices = new List<Device>();
                int deviceID = Form1.ID.UserId;
                devices.Add(new Device { Name = name, Manufacturer = manufacturer, Type = type, OS = os, OSv = osv, CPU = cpu, RAM = ram, DeviceId = deviceID });

                connection.Execute("dbo.Devices_updateDevice @Name, @Manufacturer, @Type, @OS, @OSv, @CPU, @RAM, @DeviceId", devices);
            }
        }
    }
}
