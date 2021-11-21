using SQL___Inlämning_1;
using SQL___Inlämning_1.SQL;
using SQL___Inlämning_1.SQLClient;

Select Selection = new Select();
Selection.Logins();
SQLClient.GenerateConnection();
SqlCommands commands = new SqlCommands();

var dbName = "Test1";

commands.CreateDB(SQLClient.C, dbName, "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA\\");
commands.CreateTable(SQLClient.C, dbName);



SQLClient.C.Close();