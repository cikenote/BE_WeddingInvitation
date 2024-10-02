using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wedding.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_New_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("d80b457a-bfb7-4115-a690-bd5c2afe36b1"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0c0f459b-56cf-4160-97c6-73f65a62988c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("5f8120fc-0f52-4361-9a4f-4a4eea5f50fc"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("60ebf89e-3e33-4a75-a098-02ef07d10ca4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("82332954-f7b0-4954-b19b-1f0376f8339c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("86d755be-3161-4127-ae41-7042f9446699"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("98651df7-bf41-45b8-b6b3-127ad4a4cb32"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c556b59d-f5ba-4511-8f98-a30a63bba7e5"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ec2411dc-66c2-4e74-962e-96d443259a7e"));

            migrationBuilder.DeleteData(
                table: "Privacies",
                keyColumn: "Id",
                keyValue: new Guid("89e1e882-0c42-4488-b7e9-eadf008ea23f"));

            migrationBuilder.DeleteData(
                table: "TermOfUses",
                keyColumn: "Id",
                keyValue: new Guid("2cf13ada-4cb8-4ee7-ae1e-411be3c097ce"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Cards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    LogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_ActivityLogs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvitationTemplates",
                columns: table => new
                {
                    TemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextFont = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitationTemplates", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    WeddingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BrideName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeddingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeddingPhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.WeddingId);
                    table.ForeignKey(
                        name: "FK_Weddings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invitations",
                columns: table => new
                {
                    InvitationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeddingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerTextColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShareableLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitations", x => x.InvitationId);
                    table.ForeignKey(
                        name: "FK_Invitations_InvitationTemplates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "InvitationTemplates",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invitations_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "WeddingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CardManagements",
                columns: table => new
                {
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InvitationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardManagements", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_CardManagements_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardManagements_Invitations_InvitationId",
                        column: x => x.InvitationId,
                        principalTable: "Invitations",
                        principalColumn: "InvitationId");
                });

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
                name: "IX_Cards_CustomerId",
                table: "Cards",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_UserId",
                table: "ActivityLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CardManagements_InvitationId",
                table: "CardManagements",
                column: "InvitationId");

            migrationBuilder.CreateIndex(
                name: "IX_CardManagements_UserId",
                table: "CardManagements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_TemplateId",
                table: "Invitations",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Invitations_WeddingId",
                table: "Invitations",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_UserId",
                table: "Weddings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Customers_CustomerId",
                table: "Cards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Customers_CustomerId",
                table: "Cards");

            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "CardManagements");

            migrationBuilder.DropTable(
                name: "Invitations");

            migrationBuilder.DropTable(
                name: "InvitationTemplates");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CustomerId",
                table: "Cards");

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

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "TranThaiSon493",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dabb1c7b-9a5f-4574-9e3b-5dceff038283", "AQAAAAIAAYagAAAAEC4BfUANqd3mrU4ZVN9H/68HllDa4zWSRsFNJuwoYyHb3UGDpYR3qImPD27EJam3FQ==", "52c678a5-0391-4f1a-8003-787dc18444f6" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Email", "FoundedDate", "LogoUrl", "Name", "Phone", "PostalCode", "State", "Website" },
                values: new object[] { new Guid("d80b457a-bfb7-4115-a690-bd5c2afe36b1"), "123 Main St", "Hometown", "Country", "ABC Corp is a leading company in XYZ industry.", "contact@abccorp.com", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "http://www.abccorp.com/logo.png", "ABC Corp", "123-456-7890", "12345", "State", "http://www.abccorp.com" });

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "BodyContent", "CallToAction", "Category", "CreatedBy", "CreatedTime", "FooterContent", "Language", "PersonalizationTags", "PreHeaderText", "RecipientType", "SenderEmail", "SenderName", "Status", "SubjectLine", "TemplateName", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { new Guid("0c0f459b-56cf-4160-97c6-73f65a62988c"), "Dear [UserFullName],<br><br>Your account has been deleted.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Delete Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Delete Account!", "DeleteAccount", null, null },
                    { new Guid("5f8120fc-0f52-4361-9a4f-4a4eea5f50fc"), "Dear {FirstName} {LastName},<br><br>\r\n\r\n                    This email confirms that your payout request has been processed successfully.\r\n                    <br>\r\n                    <strong>Payout Details:</strong>\r\n                    <ul>\r\n                    <li>Amount: {PayoutAmount}</li>\r\n                    <li>Transaction Date: {TransactionDate}</li> \r\n                    </ul>\r\n                    <br>\r\n                    You can view your payout history in your customer dashboard. \r\n                    <br> \r\n                    Thank you for being a valued Wedding customer!\r\n                    <br>", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Payout", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}, {PayoutAmount}, {TransactionDate}", "Payout Successful!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Your Wedding Payout is Complete!", "NotifyCustomerPaymentReceived", null, null },
                    { new Guid("60ebf89e-3e33-4a75-a098-02ef07d10ca4"), "Dear [UserFullName],<br><br>You have completed our course program, you can take new courses to increase your knowledge and skills.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Course completed", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Congratulations on completing the course!", "CustomerCompleteCourse", null, null },
                    { new Guid("82332954-f7b0-4954-b19b-1f0376f8339c"), "<p>Thank you for registering your Wedding account. Click here to go back the page</p>", "<a href=\"{{Login}}\">Login now</a>", "Verify", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LinkLogin}", "User Account Verified!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Wedding Verify Email", "SendVerifyEmail", null, null },
                    { new Guid("86d755be-3161-4127-ae41-7042f9446699"), "Dear [UserFullName],<br><br>Welcome to Wedding! We are excited to have you join our learning community.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Welcome", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Thank you for signing up!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Welcome to Wedding!", "WelcomeEmail", null, null },
                    { new Guid("98651df7-bf41-45b8-b6b3-127ad4a4cb32"), "Dear [UserFullName],<br><br>Your account will be deleted after 14 days.", "<a href=\"https://cursuslms.xyz/user/sign-in\">Login</a>", "Remind Account", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {LastName}", "Hello!", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Remind Delete Account!", "RemindDeleteAccount", null, null },
                    { new Guid("c556b59d-f5ba-4511-8f98-a30a63bba7e5"), "Hi [UserFullName],<br><br>We received a request to reset your password. Click the link below to reset your password.", "https://cursuslms.xyz/sign-in/verify-email?userId=user.Id&token=Uri.EscapeDataString(token)", "Security", null, null, "If you did not request a password reset, please ignore this email.", "English", "[UserFullName], [ResetPasswordLink]", "Reset your password to regain access", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ForgotPasswordEmail", null, null },
                    { new Guid("ec2411dc-66c2-4e74-962e-96d443259a7e"), "<p>Hello {FirstName},</p><p>Click <a href=\"{ResetLink}\">here</a> to reset your password.</p>", "<a href=\"{{ResetLink}}\">Reset Password</a>", "Security", null, null, "<p>Contact us at cursusservicetts@gmail.com</p>", "English", "{FirstName}, {ResetLink}", "Reset your password to regain access.", "Customer", "cursusservicetts@gmail.com", "Wedding Team", 1, "Reset Your Password", "ChangePassword", null, null }
                });

            migrationBuilder.InsertData(
                table: "Privacies",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("89e1e882-0c42-4488-b7e9-eadf008ea23f"), "These are the privacy for our service.", true, new DateTime(2024, 9, 16, 3, 45, 40, 742, DateTimeKind.Utc).AddTicks(4694), "Privacy" });

            migrationBuilder.InsertData(
                table: "TermOfUses",
                columns: new[] { "Id", "Content", "IsActive", "LastUpdated", "Title" },
                values: new object[] { new Guid("2cf13ada-4cb8-4ee7-ae1e-411be3c097ce"), "These are the terms of use for our service.", true, new DateTime(2024, 9, 16, 3, 45, 40, 742, DateTimeKind.Utc).AddTicks(4722), "Terms of Use" });
        }
    }
}
