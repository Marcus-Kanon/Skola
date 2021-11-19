using SQL___Inlämning_1;
using SQL___Inlämning_1.SQL;
using SQL___Inlämning_1.SQLClient;

Select Selection = new Select();
Selection.Start();

SQLClient.GenerateConnection();

SqlCommands commands = new SqlCommands();

commands.CreateDB(SQLClient.C, "TestDBDB", "");
