using System.DirectoryServices;

namespace Showroom.Infrastucture
{
    public static class CommonMethods
    {
        public static string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://RootDSE");
            return $"LDAP://{de.Properties["defaultNamingContext"][0].ToString()}";
        }
    }
}
