namespace Eazy.Tours.Core
{
    public class Constants
    {
        public static class Roles
        {
            public const string Administrator = "Administrator";
            public const string ExcursionOwner = "ExcursionOwner";
        }

        public static class Policies
        {
            public const string RequireAdmin = "RequireAdmin";
            public const string RequireExcursionOwner = "RequireExcursionOwner";
        }
    }
}
