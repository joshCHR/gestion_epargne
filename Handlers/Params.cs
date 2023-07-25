namespace ADTMPDapk.Handlers
{
    public class Params
    {
        private string _server, _database, _username, _passkey;

        public string Database
        {
            get
            {
                return _database;
            }

            set
            {
                _database = value;
            }
        }

        public string PassKey
        {
            get
            {
                return _passkey;
            }

            set
            {
                _passkey = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        public string Server
        {
            get
            {
                return _server;
            }

            set
            {
                _server = value;
            }
        }
        public override string ToString()
        {
            return
                string.Format
                (
                    "Data Source ={0};Initial Catalog={1};User ID={2};Password={3};",
                    _server, _database, _username, _passkey
                );
        }
    }
}
