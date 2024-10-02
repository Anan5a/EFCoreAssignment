using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedDbTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "BusinessPhone", "City", "Email", "FirstName", "LastModified", "LastName", "MobilePhone", "Player" },
                values: new object[,]
                {
                    { 1, "123 Main St", "123-456-7890", "New York", "johndoe@example.com", "John", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7715), "Doe", "987-654-3210", "Player A" },
                    { 2, "456 Oak St", "234-567-8901", "Los Angeles", "janesmith@example.com", "Jane", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7718), "Smith", "876-543-2109", "Player B" },
                    { 3, "789 Pine St", "345-678-9012", "Chicago", "michaelj@example.com", "Michael", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7721), "Johnson", "765-432-1098", "Player C" },
                    { 4, "101 Maple St", "456-789-0123", "Houston", "emilyd@example.com", "Emily", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7723), "Davis", "654-321-0987", "Player D" },
                    { 5, "202 Cedar St", "567-890-1234", "Phoenix", "davidw@example.com", "David", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7725), "Wilson", "543-210-9876", "Player E" }
                });

            migrationBuilder.InsertData(
                table: "Monitorings",
                columns: new[] { "MonitoringId", "Aggregate", "Alias", "Contact", "ContactCC", "Delay", "LastControlPosition", "LastModified", "NextReconciliationDate", "Node", "NodeType", "Player", "ProcessDuration", "SLA", "Shifting", "TaskType" },
                values: new object[,]
                {
                    { 1, "Agg1", "NodeA", "Contact1", "ContactCC1", 5, "Position1", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 10, 9, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7888), "Node_001", "Type1", "Player1", 30, "SLA1", "Shift1", "Task1" },
                    { 2, "Agg2", "NodeB", "Contact2", "ContactCC2", 3, "Position2", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7902), new DateTime(2024, 10, 16, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7901), "Node_002", "Type2", "Player2", 45, "SLA2", "Shift2", "Task2" },
                    { 3, "Agg3", "NodeC", "Contact3", "ContactCC3", 7, "Position3", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 11, 1, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7905), "Node_003", "Type3", "Player3", 60, "SLA3", "Shift3", "Task3" },
                    { 4, "Agg4", "NodeD", "Contact4", "ContactCC4", 10, "Position4", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 10, 23, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7909), "Node_004", "Type4", "Player4", 90, "SLA4", "Shift4", "Task4" },
                    { 5, "Agg5", "NodeE", "Contact5", "ContactCC5", 15, "Position5", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 12, 1, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7913), "Node_005", "Type5", "Player5", 120, "SLA5", "Shift5", "Task5" }
                });

            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "NodeId", "Aggregate", "Alias", "ContactCCId", "ContactId", "EmailTemplateId", "LastModified", "LifeInsuranceClass", "NodeIdentifier", "NodeName", "NodeSubType", "NodeType", "PeriodicFormat", "PeriodicFormatStartDate", "Player", "ProcessDuration", "Shifting", "SlaId", "TaskType", "TransactionFormat", "TransactionFormatStartDate" },
                values: new object[,]
                {
                    { 1, "Agg1", "AliasA", 401, 301, 101, new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7950), "ClassA", "ID001", "Node Alpha", "SubType1", "Type1", "Format1", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7944), "Player1", 30, "ShiftA", 201, "Task1", "TransFormat1", new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7946) },
                    { 2, "Agg2", "AliasB", 402, 302, 102, new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7957), "ClassB", "ID002", "Node Beta", "SubType2", "Type2", "Format2", new DateTime(2024, 10, 3, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7953), "Player2", 45, "ShiftB", 202, "Task2", "TransFormat2", new DateTime(2024, 10, 3, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7955) },
                    { 3, "Agg3", "AliasC", 403, 303, 103, new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7963), "ClassC", "ID003", "Node Gamma", "SubType3", "Type3", "Format3", new DateTime(2024, 10, 4, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7960), "Player3", 60, "ShiftC", 203, "Task3", "TransFormat3", new DateTime(2024, 10, 4, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7961) },
                    { 4, "Agg4", "AliasD", 404, 304, 104, new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7968), "ClassD", "ID004", "Node Delta", "SubType4", "Type4", "Format4", new DateTime(2024, 10, 5, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7965), "Player4", 90, "ShiftD", 204, "Task4", "TransFormat4", new DateTime(2024, 10, 5, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7966) },
                    { 5, "Agg5", "AliasE", 405, 305, 105, new DateTime(2024, 10, 2, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7973), "ClassE", "ID005", "Node Epsilon", "SubType5", "Type5", "Format5", new DateTime(2024, 10, 6, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7970), "Player5", 120, "ShiftE", 205, "Task5", "TransFormat5", new DateTime(2024, 10, 6, 5, 50, 17, 744, DateTimeKind.Utc).AddTicks(7971) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "PasswordHash", "UserName" },
                values: new object[,]
                {
                    { 1, "John", "Doe", "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW", "johndoe" },
                    { 2, "Jane", "Smith", "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW", "janesmith" },
                    { 3, "Alice", "Johnson", "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW", "alicejohnson" },
                    { 4, "Bob", "Brown", "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW", "bobbrown" },
                    { 5, "Charlie", "Davis", "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW", "charliedavis" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monitorings",
                keyColumn: "MonitoringId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monitorings",
                keyColumn: "MonitoringId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monitorings",
                keyColumn: "MonitoringId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monitorings",
                keyColumn: "MonitoringId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Monitorings",
                keyColumn: "MonitoringId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "NodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "NodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "NodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "NodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "NodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);
        }
    }
}
