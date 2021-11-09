using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    class Main1
    {
        string strConnection = @"Data Sourse=DESKTOP-MUGUFKI\SQLEXPRESS;Initial Catalog=groupall;integrated Security=True";
        public void AddGroup(Group group)
        {
            String SqlcCod = $"INSERT INTO [dbo].[group] ([NameGroup],[NumberGroup ],[CuratorGroup])" +
                $"VALUES '({group.NameGroup}','{group.NumberGroup}','{group.CuratorGroup}')";
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnection))
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(SqlCmd, connection);
                    cmd.ExecuteNonQuery();



                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            internal void AddGroup(GroupBox group) => throw new NotImplementedException();


        }




        public List<Group> ReadGroup ()
        {
          string SqlCmd  = "Select * from [dbo].[group]";
            List<Group> groups = new List<Group>();
            {

                try
                {
                    using (SqlConnection connection = new SqlConnection(strConnection))
                    {

                        connection.Open();
                        SqlCommand cmd = new SqlCommand(SqlCmd, connection);
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                groups.Add(new Group()
                                {

                                    NameGroup = sqlDataReader.GetString(1),
                                    NumberGroup = sqlDataReader.GetString(2),
                                    CuratorGroup = sqlDataReader.GetString(3)
                                });
                            }
                        }



                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                return groups;
            }

    }




        class Group
        {
            public int idGroup { get; set; }
            public string NameGroup { get; set; }
            public string NumberGroup { get; set; }
            public string CuratorGroup { get; set; }

        }
    }
}
