using EFCoreAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<Monitoring> Monitorings { get; set; }
        public DbSet<Sla> Slas { get; set; }
        public DbSet<Node> Nodes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
           new Contact
           {
               ContactId = 1,
               FirstName = "John",
               LastName = "Doe",
               Email = "johndoe@example.com",
               Address = "123 Main St",
               Player = "Player A",
               City = "New York",
               BusinessPhone = "123-456-7890",
               MobilePhone = "987-654-3210",
               LastModified = DateTime.UtcNow
           },
           new Contact
           {
               ContactId = 2,
               FirstName = "Jane",
               LastName = "Smith",
               Email = "janesmith@example.com",
               Address = "456 Oak St",
               Player = "Player B",
               City = "Los Angeles",
               BusinessPhone = "234-567-8901",
               MobilePhone = "876-543-2109",
               LastModified = DateTime.UtcNow
           },
           new Contact
           {
               ContactId = 3,
               FirstName = "Michael",
               LastName = "Johnson",
               Email = "michaelj@example.com",
               Address = "789 Pine St",
               Player = "Player C",
               City = "Chicago",
               BusinessPhone = "345-678-9012",
               MobilePhone = "765-432-1098",
               LastModified = DateTime.UtcNow
           },
           new Contact
           {
               ContactId = 4,
               FirstName = "Emily",
               LastName = "Davis",
               Email = "emilyd@example.com",
               Address = "101 Maple St",
               Player = "Player D",
               City = "Houston",
               BusinessPhone = "456-789-0123",
               MobilePhone = "654-321-0987",
               LastModified = DateTime.UtcNow
           },
           new Contact
           {
               ContactId = 5,
               FirstName = "David",
               LastName = "Wilson",
               Email = "davidw@example.com",
               Address = "202 Cedar St",
               Player = "Player E",
               City = "Phoenix",
               BusinessPhone = "567-890-1234",
               MobilePhone = "543-210-9876",
               LastModified = DateTime.UtcNow
           }
       );

            modelBuilder.Entity<Monitoring>().HasData(
            new Monitoring
            {
                MonitoringId = 1,
                Alias = "NodeA",
                Aggregate = "Agg1",
                Node = "Node_001",
                Player = "Player1",
                NodeType = "Type1",
                TaskType = "Task1",
                SLA = "SLA1",
                Shifting = "Shift1",
                ProcessDuration = 30,
                Contact = "Contact1",
                ContactCC = "ContactCC1",
                LastControlPosition = "Position1",
                NextReconciliationDate = DateTime.UtcNow.AddDays(7),
                Delay = 5,
                LastModified = DateTime.UtcNow
            },
           new Monitoring
           {
               MonitoringId = 2,
               Alias = "NodeB",
               Aggregate = "Agg2",
               Node = "Node_002",
               Player = "Player2",
               NodeType = "Type2",
               TaskType = "Task2",
               SLA = "SLA2",
               Shifting = "Shift2",
               ProcessDuration = 45,
               Contact = "Contact2",
               ContactCC = "ContactCC2",
               LastControlPosition = "Position2",
               NextReconciliationDate = DateTime.UtcNow.AddDays(14),
               Delay = 3,
               LastModified = DateTime.UtcNow
           },
           new Monitoring
           {
               MonitoringId = 3,
               Alias = "NodeC",
               Aggregate = "Agg3",
               Node = "Node_003",
               Player = "Player3",
               NodeType = "Type3",
               TaskType = "Task3",
               SLA = "SLA3",
               Shifting = "Shift3",
               ProcessDuration = 60,
               Contact = "Contact3",
               ContactCC = "ContactCC3",
               LastControlPosition = "Position3",
               NextReconciliationDate = DateTime.UtcNow.AddDays(30),
               Delay = 7,
               LastModified = DateTime.UtcNow
           },
           new Monitoring
           {
               MonitoringId = 4,
               Alias = "NodeD",
               Aggregate = "Agg4",
               Node = "Node_004",
               Player = "Player4",
               NodeType = "Type4",
               TaskType = "Task4",
               SLA = "SLA4",
               Shifting = "Shift4",
               ProcessDuration = 90,
               Contact = "Contact4",
               ContactCC = "ContactCC4",
               LastControlPosition = "Position4",
               NextReconciliationDate = DateTime.UtcNow.AddDays(21),
               Delay = 10,
               LastModified = DateTime.UtcNow
           },
           new Monitoring
           {
               MonitoringId = 5,
               Alias = "NodeE",
               Aggregate = "Agg5",
               Node = "Node_005",
               Player = "Player5",
               NodeType = "Type5",
               TaskType = "Task5",
               SLA = "SLA5",
               Shifting = "Shift5",
               ProcessDuration = 120,
               Contact = "Contact5",
               ContactCC = "ContactCC5",
               LastControlPosition = "Position5",
               NextReconciliationDate = DateTime.UtcNow.AddDays(60),
               Delay = 15,
               LastModified = DateTime.UtcNow
           }
       );

            modelBuilder.Entity<Node>().HasData(
            new Node
            {
                NodeId = 1,
                NodeName = "Node Alpha",
                Alias = "AliasA",
                Aggregate = "Agg1",
                Player = "Player1",
                NodeType = "Type1",
                NodeSubType = "SubType1",
                LifeInsuranceClass = "ClassA",
                NodeIdentifier = "ID001",
                PeriodicFormat = "Format1",
                PeriodicFormatStartDate = DateTime.UtcNow,
                TransactionFormat = "TransFormat1",
                TransactionFormatStartDate = DateTime.UtcNow,
                TaskType = "Task1",
                EmailTemplateId = 101,
                SlaId = 201,
                Shifting = "ShiftA",
                ProcessDuration = 30,
                ContactId = 301,
                ContactCCId = 401,
                LastModified = DateTime.UtcNow
            },
            new Node
            {
                NodeId = 2,
                NodeName = "Node Beta",
                Alias = "AliasB",
                Aggregate = "Agg2",
                Player = "Player2",
                NodeType = "Type2",
                NodeSubType = "SubType2",
                LifeInsuranceClass = "ClassB",
                NodeIdentifier = "ID002",
                PeriodicFormat = "Format2",
                PeriodicFormatStartDate = DateTime.UtcNow.AddDays(1),
                TransactionFormat = "TransFormat2",
                TransactionFormatStartDate = DateTime.UtcNow.AddDays(1),
                TaskType = "Task2",
                EmailTemplateId = 102,
                SlaId = 202,
                Shifting = "ShiftB",
                ProcessDuration = 45,
                ContactId = 302,
                ContactCCId = 402,
                LastModified = DateTime.UtcNow
            },
            new Node
            {
                NodeId = 3,
                NodeName = "Node Gamma",
                Alias = "AliasC",
                Aggregate = "Agg3",
                Player = "Player3",
                NodeType = "Type3",
                NodeSubType = "SubType3",
                LifeInsuranceClass = "ClassC",
                NodeIdentifier = "ID003",
                PeriodicFormat = "Format3",
                PeriodicFormatStartDate = DateTime.UtcNow.AddDays(2),
                TransactionFormat = "TransFormat3",
                TransactionFormatStartDate = DateTime.UtcNow.AddDays(2),
                TaskType = "Task3",
                EmailTemplateId = 103,
                SlaId = 203,
                Shifting = "ShiftC",
                ProcessDuration = 60,
                ContactId = 303,
                ContactCCId = 403,
                LastModified = DateTime.UtcNow
            },
            new Node
            {
                NodeId = 4,
                NodeName = "Node Delta",
                Alias = "AliasD",
                Aggregate = "Agg4",
                Player = "Player4",
                NodeType = "Type4",
                NodeSubType = "SubType4",
                LifeInsuranceClass = "ClassD",
                NodeIdentifier = "ID004",
                PeriodicFormat = "Format4",
                PeriodicFormatStartDate = DateTime.UtcNow.AddDays(3),
                TransactionFormat = "TransFormat4",
                TransactionFormatStartDate = DateTime.UtcNow.AddDays(3),
                TaskType = "Task4",
                EmailTemplateId = 104,
                SlaId = 204,
                Shifting = "ShiftD",
                ProcessDuration = 90,
                ContactId = 304,
                ContactCCId = 404,
                LastModified = DateTime.UtcNow
            },
            new Node
            {
                NodeId = 5,
                NodeName = "Node Epsilon",
                Alias = "AliasE",
                Aggregate = "Agg5",
                Player = "Player5",
                NodeType = "Type5",
                NodeSubType = "SubType5",
                LifeInsuranceClass = "ClassE",
                NodeIdentifier = "ID005",
                PeriodicFormat = "Format5",
                PeriodicFormatStartDate = DateTime.UtcNow.AddDays(4),
                TransactionFormat = "TransFormat5",
                TransactionFormatStartDate = DateTime.UtcNow.AddDays(4),
                TaskType = "Task5",
                EmailTemplateId = 105,
                SlaId = 205,
                Shifting = "ShiftE",
                ProcessDuration = 120,
                ContactId = 305,
                ContactCCId = 405,
                LastModified = DateTime.UtcNow
            }
        );

            modelBuilder.Entity<User>().HasData(
            new User
            {
                UserId = 1,
                FirstName = "John",
                LastName = "Doe",
                UserName = "johndoe",
                PasswordHash = "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW" //pwd: 11111111
            },
            new User
            {
                UserId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                UserName = "janesmith",
                PasswordHash = "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW"
            },
            new User
            {
                UserId = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                UserName = "alicejohnson",
                PasswordHash = "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW"
            },
            new User
            {
                UserId = 4,
                FirstName = "Bob",
                LastName = "Brown",
                UserName = "bobbrown",
                PasswordHash = "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW"
            },
            new User
            {
                UserId = 5,
                FirstName = "Charlie",
                LastName = "Davis",
                UserName = "charliedavis",
                PasswordHash = "$2a$14$ygNCCR4r3bKrZTM1G.gqC.aXrdgz0dN5qKyqsFW3/egoSRhe5quOW"
            }
        );

            //base.OnModelCreating(modelBuilder);
        }
    }
}
