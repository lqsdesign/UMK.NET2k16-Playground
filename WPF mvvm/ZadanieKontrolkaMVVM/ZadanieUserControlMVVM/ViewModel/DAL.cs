
namespace DataAccessLayer
{
    using ZadanieUserControlMVVM.Properties;
    using ZadanieUserControlMVVM.Model;

    class DAL
    {
        public static void SaveModel(FilePathModel model)
        {
            Settings.Default.Location = model.FilePathString;
            Settings.Default.Save();
        }

        public static FilePathModel LoadModel(FilePathModel model)
        {
            model.FilePathString = Settings.Default.Location;
            return model;
        }

        public static FilePathModel LoadModel()
        {
            return new FilePathModel()
            {
                FilePathString = Settings.Default.Location
            };
        }
    }
}

