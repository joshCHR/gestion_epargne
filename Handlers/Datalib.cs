namespace ADTMPDapk.Handlers
{
    public class Datalib
    {
        Params prms = new Params();
        public Datalib()
        {
            prms.Server = Properties.Settings.Default.Server;
            prms.Database = Properties.Settings.Default.Database;
            prms.Username = Properties.Settings.Default.Username;
            prms.PassKey = Properties.Settings.Default.Password;
        }
        public object GetInstance()
        {
            return prms;
        }
    }
}
