namespace CleanArchitecture.Application.Common.Security.Permissions;

public static partial class Permission
{
    public static class Person
    {
        public const string Create = "create:person";
        public const string Delete = "delete:person";
        public const string Get = "get:person";
    }
}