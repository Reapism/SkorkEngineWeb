namespace SkorkEngine.service {
    public class UpdateService {

        private string version;

        public UpdateService() {
            this.version = "";
        }

        public bool CheckUpdates() {

            long dbVersion = 0;
            if (long.Parse(version.Replace(".",string.Empty)) < dbVersion) {
                // update is available!
            }


            return true;
        }
    }
}
