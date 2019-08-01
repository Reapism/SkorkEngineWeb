namespace SkorkEngine.service {
    public class UpdateService {

        private string version;

        public UpdateService() {
            this.version = "";
        }

        public bool CheckUpdates() {
            long dbVersion = 0;

            return (long.Parse(version.Replace(".", string.Empty)) < dbVersion) ? true : false;         
        }
    }
}
