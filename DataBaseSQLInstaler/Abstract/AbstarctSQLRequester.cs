using DataBaseSQLInstaller.VIewModel.Responses;
using DomainInstaller.ResponseObserverInteface.Repository;
using DomainInstaller.SQLinterface;
using DomainInstaller.SQLinterface.DataInterface;
using Npgsql;
using СommonService;

namespace DataBaseSQLInstaller.Abstract
{
    public abstract class AbstarctSQLRequester : ISQLRequester
    {
        private ISQLUser user;
        private string hostConnection;
        private string portConnection;
        public string HostConnection { get => hostConnection; set { hostConnection = value; } }
        public string PortConnection { get => portConnection; set { portConnection = value; } }
        public ISQLUser User { get => user; set { user = value; } }
        public AbstarctSQLRequester(ISQLUser user, string hostConnection,string portConnection)
        {
            this.user = user;
            this.hostConnection = hostConnection;
            this.portConnection = portConnection;

        }
        public IResponseState StartRequest(string command)
        {
            try
            {
                NpgsqlConnection npgsqlConnection = new NpgsqlConnection($"Host={hostConnection};Port={portConnection};Username={user.UserName};Password={user.Password};");
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(command, npgsqlConnection);
                npgsqlConnection.Open();
                npgsqlCommand.ExecuteScalar();
                npgsqlConnection.Close();
                return new SQLResponse()
                {
                    ResponseCode = StateResponseCode.SUCCESS,
                    StringReposne = "Команда выполненна"
                };
            }
            catch (Exception ex)
            {

                return new SQLResponse()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            }
        }

    }
}
