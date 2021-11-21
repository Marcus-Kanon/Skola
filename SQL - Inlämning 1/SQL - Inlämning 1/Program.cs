using SQL___Inlämning_1;
using SQL___Inlämning_1.SQL;
using SQL___Inlämning_1.SQLClient;

Select Selection = new Select();
Selection.Logins();
SqlConnectorClient.GenerateConnection();
SqlCommands commands = new SqlCommands();

var dbName = "Test1";

commands.CreateDB(SqlConnectorClient.C, dbName, "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\");
commands.CreateTable(SqlConnectorClient.C, dbName);



SqlConnectorClient.C.Close();