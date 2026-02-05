namespace AuthService2024010.Domain.Constants;

public static class RoleConstants
{
    public const string USER_ROLE = "USER_ROLE";
    public const string ADMIN_ROLE = "ADMIN_ROLE";

    public static readonly string[] AllowRoles = [USER_ROLE, ADMIN_ROLE ];

}