namespace SkorkEngine.Service {
    public class UpdateService {

        private string version;

        public UpdateService() {s
            this.version = "";
        }

        public bool CheckUpdates() {
            long dbVersion = 0;

            return (long.Parse(version.Replace(".", string.Empty)) < dbVersion) ? true : false;         
        }
    }
}
