using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wedding.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_More_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invitations_InvitationTemplates_TemplateId",
                table: "Invitations");

            migrationBuilder.DropIndex(
                name: "IX_Invitations_TemplateId",
                table: "Invitations");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("7bf8a9cd-0ef8-4655-a09c-cbba1c3329b5"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0a772e60-084e-45c2-b796-3d4e743173d2"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0c16ebb4-3092-453c-80b0-2cc276a24a9a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("231dbb64-8103-4b87-bdd0-cfff34e0d106"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("62dce6af-0cf1-4de8-a7a5-588250506b1a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a88639c5-e7d9-4d8f-ab01-fef69d2ec756"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("aef5f47b-9787-49cf-951b-a58c032bee41"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("becfba1b-ac4f-4159-9d1e-b1accf0fb554"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("efb9c656-d3a8-44b6-81cf-91fe0ac3b97f"));

            migrationBuilder.DeleteData(
                table: "Privacies",
                keyColumn: "Id",
                keyValue: new Guid("7f3852d9-7bc8-444d-91b0-0084129caf9d"));

            migrationBuilder.DeleteData(
                table: "TermOfUses",
                keyColumn: "Id",
                keyValue: new Guid("0b85ce85-1ef0-4d49-ac25-e08d1e90c3a2"));

            migrationBuilder.AddColumn<Guid>(
                name: "CardManagementCardId",
                table: "Weddings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EventPhotos",
                columns: table => new
                {
                    EventPhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPhotos", x => x.EventPhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeddingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventPhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "WeddingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestLists",
                columns: table => new
                {
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuestGift = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestLists", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_GuestLists_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gift = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guests_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guests_GuestLists_GuestId",
                        column: x => x.GuestId,
                        principalTable: "GuestLists",
                        principalColumn: "GuestId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "TranThaiSon493",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fe098ac-d910-46c5-a07b-dcdf88e25225", "AQAAAAIAAYagAAAAEHXwE3NLuWtbRkH32kskWszauWYg3EwfpjZKesIuJwFb96gt6Ci1g+h+9SsFJ22YlQ==", "27bdad53-5f6d-4c28-a859-314382ded6a9" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Email", "FoundedDate", "LogoUrl", "Name", "Phone", "PostalCode", "State", "Website" },
                values: new object[] { new Guid("401e296d-fa3c-48c9-a334-eb4442152144"), "123 Main St", "Hometown", "Country", "ABC Corp is a leading company in XYZ industry.", "contact@abccorp.com", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.abccorp.com/logo.png", "ABC Corp", "123-456-7890", "12345", "State", "http://www.abccorp.com" });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "BodyContent", "CallToAction", "Category", "CreatedBy", "CreatedTime", "FooterContent", "Language", "PersonalizationTags", "PreHeaderText", "RecipientType", "SenderEmail", "SenderName", "Status", "SubjectLine", "TemplateName", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("148ead06-e09f-43cf-898f-c005b99ef973"), "<p>Thank you for registering your Wedding account. Click here to go back the page</p>", "<a href=\"{{Login}}\">Login now</a>", "Verify", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LinkLogin}", "User Account Verified!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Wedding Verify Email", "SendVerifyEmail", null, null },
                    { new Guid("2c74ca32-cf1d-42f1-8ac3-0e695a6ec343"), "Dear [UserFullName],<br><br>You have completed our course program, you can take new courses to increase your knowledge and skills.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Course completed", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Congratulations on completing the course!", "CustomerCompleteCourse", null, null },
                    { new Guid("35cc25e2-a44d-4eaa-b00f-e828caab37f7"), "Dear {FirstName} {LastName},<br><br>\r\n\r\n                    This email confirms that your payout request has been processed successfully.\r\n                    <br>\r\n                    <strong>Payout Details:</strong>\r\n                    <ul>\r\n                    <li>Amount: {PayoutAmount}</li>\r\n                    <li>Transaction Date: {TransactionDate}</li> \r\n                    </ul>\r\n                    <br>\r\n                    You can view your payout history in your customer dashboard. \r\n                    <br> \r\n                    Thank you for being a valued Wedding customer!\r\n                    <br>", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Payout", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}, {PayoutAmount}, {TransactionDate}", "Payout Successful!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Your Wedding Payout is Complete!", "NotifyCustomerPaymentReceived", null, null },
                    { new Guid("3e08ff71-6ad6-4caf-9ad6-d88562dd4d96"), "Dear [UserFullName],<br><br>Your account has been deleted.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Delete Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Delete Account!", "DeleteAccount", null, null },
                    { new Guid("5adf3bab-38cf-4714-9584-28a138b3339b"), "Hi [UserFullName],<br><br>We received a request to reset your password. Click the link below to reset your password.", "https://cursuslms.xyz/sign-in/verify-email?userId=user.Id&token=Uri.EscapeDataString(token)", "Security", null, null, "If you did not request a password reset, please ignore this email.", "English", "[UserFullName], [ResetPasswordLink]", "Reset your password to regain access", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ForgotPasswordEmail", null, null },
                    { new Guid("6ceaf4c3-9061-4c0c-bcf5-80e5c2e852f2"), "Dear [UserFullName],<br><br>Your account will be deleted after 14 days.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Remind Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Remind Delete Account!", "RemindDeleteAccount", null, null },
                    { new Guid("8f9cdc15-4851-43d8-9dbe-a90689e6221f"), "Dear [UserFullName],<br><br>Welcome to Wedding! We are excited to have you join our learning community.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Welcome", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Thank you for signing up!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Welcome to Wedding!", "WelcomeEmail", null, null },
                    { new Guid("9cce07a8-24f1-4435-a913-85642233982c"), "<p>Hello {FirstName},</p><p>Click <a href=\"{ResetLink}\">here</a> to reset your password.</p>", "<a href=\"{{ResetLink}}\">Reset Password</a>", "Security", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {ResetLink}", "Reset your password to regain access.", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ChangePassword", null, null }
                });

            migrationBuilder.InsertData(
                table: "Privacies",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("cca16f42-8f20-4f8a-99af-5d883c8105c3"), "These are the privacy for our service.", true, new DateTime(2024, 9, 22, 9, 57, 55, 56, DateTimeKind.Utc).AddTicks(5578), "Privacy" });

            migrationBuilder.InsertData(
                table: "TermOfUses",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("7af5aae2-d3f0-4451-a369-ab425d4216ba"), "These are the terms of use for our service.", true, new DateTime(2024, 9, 22, 9, 57, 55, 56, DateTimeKind.Utc).AddTicks(5643), "Terms of Use" });

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_CardManagementCardId",
                table: "Weddings",
                column: "CardManagementCardId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPhotos_EventId",
                table: "EventPhotos",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_GuestId",
                table: "Events",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_WeddingId",
                table: "Events",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_GuestLists_EventId",
                table: "GuestLists",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_EventId",
                table: "Guests",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvitationTemplates_Invitations_TemplateId",
                table: "InvitationTemplates",
                column: "TemplateId",
                principalTable: "Invitations",
                principalColumn: "InvitationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_CardManagements_CardManagementCardId",
                table: "Weddings",
                column: "CardManagementCardId",
                principalTable: "CardManagements",
                principalColumn: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventPhotos_Events_EventId",
                table: "EventPhotos",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Guests_GuestId",
                table: "Events",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "GuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvitationTemplates_Invitations_TemplateId",
                table: "InvitationTemplates");

            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_CardManagements_CardManagementCardId",
                table: "Weddings");

            migrationBuilder.DropForeignKey(
                name: "FK_GuestLists_Events_EventId",
                table: "GuestLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Events_EventId",
                table: "Guests");

            migrationBuilder.DropTable(
                name: "EventPhotos");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "GuestLists");

            migrationBuilder.DropIndex(
                name: "IX_Weddings_CardManagementCardId",
                table: "Weddings");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("401e296d-fa3c-48c9-a334-eb4442152144"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("148ead06-e09f-43cf-898f-c005b99ef973"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("2c74ca32-cf1d-42f1-8ac3-0e695a6ec343"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("35cc25e2-a44d-4eaa-b00f-e828caab37f7"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3e08ff71-6ad6-4caf-9ad6-d88562dd4d96"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("5adf3bab-38cf-4714-9584-28a138b3339b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("6ceaf4c3-9061-4c0c-bcf5-80e5c2e852f2"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8f9cdc15-4851-43d8-9dbe-a90689e6221f"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("9cce07a8-24f1-4435-a913-85642233982c"));

            migrationBuilder.DeleteData(
                table: "Privacies",
                keyColumn: "Id",
                keyValue: new Guid("cca16f42-8f20-4f8a-99af-5d883c8105c3"));

            migrationBuilder.DeleteData(
                table: "TermOfUses",
                keyColumn: "Id",
                keyValue: new Guid("7af5aae2-d3f0-4451-a369-ab425d4216ba"));

            migrationBuilder.DropColumn(
                name: "CardManagementCardId",
                table: "Weddings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "TranThaiSon493",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f31e1354-b939-4842-81c6-1b873c9bd94d", "AQAAAAIAAYagAAAAED3wtnDchYi0872N6dNk3nyrpDeGJ2ikKRjFsc4HmOcXOQxMQB0hDhPYx3+vCleEnA==", "b82c398f-35bf-478c-9648-3f00ac1536a1" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Email", "FoundedDate", "LogoUrl", "Name", "Phone", "PostalCode", "State", "Website" },
                values: new object[] { new Guid("7bf8a9cd-0ef8-4655-a09c-cbba1c3329b5"), "123 Main St", "Hometown", "Country", "ABC Corp is a leading company in XYZ industry.", "contact@abccorp.com", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.abccorp.com/logo.png", "ABC Corp", "123-456-7890", "12345", "State", "http://www.abccorp.com" });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "BodyContent", "CallToAction", "Category", "CreatedBy", "CreatedTime", "FooterContent", "Language", "PersonalizationTags", "PreHeaderText", "RecipientType", "SenderEmail", "SenderName", "Status", "SubjectLine", "TemplateName", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0a772e60-084e-45c2-b796-3d4e743173d2"), "Hi [UserFullName],<br><br>We received a request to reset your password. Click the link below to reset your password.", "https://cursuslms.xyz/sign-in/verify-email?userId=user.Id&token=Uri.EscapeDataString(token)", "Security", null, null, "If you did not request a password reset, please ignore this email.", "English", "[UserFullName], [ResetPasswordLink]", "Reset your password to regain access", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ForgotPasswordEmail", null, null },
                    { new Guid("0c16ebb4-3092-453c-80b0-2cc276a24a9a"), "<p>Thank you for registering your Wedding account. Click here to go back the page</p>", "<a href=\"{{Login}}\">Login now</a>", "Verify", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LinkLogin}", "User Account Verified!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Wedding Verify Email", "SendVerifyEmail", null, null },
                    { new Guid("231dbb64-8103-4b87-bdd0-cfff34e0d106"), "Dear [UserFullName],<br><br>You have completed our course program, you can take new courses to increase your knowledge and skills.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Course completed", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Congratulations on completing the course!", "CustomerCompleteCourse", null, null },
                    { new Guid("62dce6af-0cf1-4de8-a7a5-588250506b1a"), "Dear [UserFullName],<br><br>Your account has been deleted.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Delete Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Delete Account!", "DeleteAccount", null, null },
                    { new Guid("a88639c5-e7d9-4d8f-ab01-fef69d2ec756"), "Dear [UserFullName],<br><br>Welcome to Wedding! We are excited to have you join our learning community.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Welcome", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Thank you for signing up!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Welcome to Wedding!", "WelcomeEmail", null, null },
                    { new Guid("aef5f47b-9787-49cf-951b-a58c032bee41"), "<p>Hello {FirstName},</p><p>Click <a href=\"{ResetLink}\">here</a> to reset your password.</p>", "<a href=\"{{ResetLink}}\">Reset Password</a>", "Security", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {ResetLink}", "Reset your password to regain access.", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ChangePassword", null, null },
                    { new Guid("becfba1b-ac4f-4159-9d1e-b1accf0fb554"), "Dear {FirstName} {LastName},<br><br>\r\n\r\n                    This email confirms that your payout request has been processed successfully.\r\n                    <br>\r\n                    <strong>Payout Details:</strong>\r\n                    <ul>\r\n                    <li>Amount: {PayoutAmount}</li>\r\n                    <li>Transaction Date: {TransactionDate}</li> \r\n                    </ul>\r\n                    <br>\r\n                    You can view your payout history in your customer dashboard. \r\n                    <br> \r\n                    Thank you for being a valued Wedding customer!\r\n                    <br>", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Payout", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}, {PayoutAmount}, {TransactionDate}", "Payout Successful!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Your Wedding Payout is Complete!", "NotifyCustomerPaymentReceived", null, null },
                    { new Guid("efb9c656-d3a8-44b6-81cf-91fe0ac3b97f"), "Dear [UserFullName],<br><br>Your account will be deleted after 14 days.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Remind Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Remind Delete Account!", "RemindDeleteAccount", null, null }
                });

            migrationBuilder.InsertData(
                table: "Privacies",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("7f3852d9-7bc8-444d-91b0-0084129caf9d"), "These are the privacy for our service.", true, new DateTime(2024, 9, 18, 5, 37, 47, 572, DateTimeKind.Utc).AddTicks(6721), "Privacy" });

            migrationBuilder.InsertData(
                table: "TermOfUses",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("0b85ce85-1ef0-4d49-ac25-e08d1e90c3a2"), "These are the terms of use for our service.", true, new DateTime(2024, 9, 18, 5, 37, 47, 572, DateTimeKind.Utc).AddTicks(6757), "Terms of Use" });

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_TemplateId",
                table: "Invitations",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invitations_InvitationTemplates_TemplateId",
                table: "Invitations",
                column: "TemplateId",
                principalTable: "InvitationTemplates",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
