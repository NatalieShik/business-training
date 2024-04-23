namespace BusinessTraining
{
    internal class Configuration // TODO: подумать над сериализацией
    {
        public int PasswordHashCode { get; set; }

        public bool FirstLaunch { get; set; }
    }
}
