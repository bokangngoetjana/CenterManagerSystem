using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace CenterManagerSystem.Data.Migrations
{
    public partial class AddManagerAccount : Migration
    {
        const string MANAGER_USER_GUID = "efe7db5a-c525-41f8-b95b-5ad5e7cf3ed4";
        const string MANAGER_ROLE_GUID = "343ce7f3-0489-457c-9e98-6f08f319437c";


        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var passwordHash = hasher.HashPassword(null, "Password100!");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp,FirstName)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{MANAGER_USER_GUID}'");
            sb.AppendLine(",'bokang@projectzeal.com'");
            sb.AppendLine(",'BOKANG@PROJECTZEAL.COM'");
            sb.AppendLine(",'bokang@projectzeal.com'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(",'BOKANG@PROJECTZEAL.COM'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(",'Bokang'");
            sb.AppendLine(")");


            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{MANAGER_ROLE_GUID}','Manager','MANAGER')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{MANAGER_USER_GUID}','{MANAGER_ROLE_GUID}')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{MANAGER_USER_GUID}' AND RoleId = '{MANAGER_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{MANAGER_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{MANAGER_ROLE_GUID}'");
        }
    }
}
