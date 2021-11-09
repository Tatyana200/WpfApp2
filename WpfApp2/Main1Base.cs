namespace WpfApp2
{
    internal class Main1Base
    {
        public void AddGroup(Group group)
        {
            String SqlcCod = $"INSERT INTO [dbo].[group] ([NameGroup],[NumberGroup ],[CuratorGroup])" +
                $"VALUES ({group.NameGroup},{group.NumberGroup},{group.CuratorGroup})";
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
    }
}