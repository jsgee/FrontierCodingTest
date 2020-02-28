using System;
using System.Collections.Generic;
using System.Text;
using AccountsCodingTest.Models;

namespace AccountsCodingTest.Factories
{
    public static class AccountsMockDataFactory
    {
        public static IEnumerable<Account> CreateAccountsCollection() =>
            new List<Account>
            {
                new Account
                {
                    Id = 1,
                    FirstName = "Emma",
                    LastName = "Smith",
                    Email = "emma.smith@email.com",
                    PhoneNumber = "5555559483",
                    AmountDue = 84.22m,
                    PaymentDueDate = DateTimeOffset.Now.Date.AddDays(6),
                    AccountStatusId = AccountStatuses.Active
                },
                new Account
                {
                    Id = 2,
                    FirstName = "Noah",
                    LastName = "Johnson",
                    Email = "noah.johnson@email.com",
                    PhoneNumber = "5555557383",
                    AmountDue = 123.76m,
                    PaymentDueDate = DateTimeOffset.Now.Date.AddDays(21),
                    AccountStatusId = AccountStatuses.Active
                },
                new Account
                {
                    Id = 3,
                    FirstName = "Abigail",
                    LastName = "Williams",
                    Email = "abigail.williams@email.com",
                    PhoneNumber = "5555553928",
                    AmountDue = 42.45m,
                    PaymentDueDate = DateTimeOffset.Now.Date.AddDays(18),
                    AccountStatusId = AccountStatuses.Active
                },
                new Account
                {
                    Id = 4,
                    FirstName = "Mason",
                    LastName = "Brown",
                    Email = "mason.brown@email.com",
                    PhoneNumber = "5555550394",
                    AmountDue = 0,
                    PaymentDueDate = null,
                    AccountStatusId = AccountStatuses.Inactive
                },
                new Account
                {
                    Id = 5,
                    FirstName = "Emily",
                    LastName = "Miller",
                    Email = "emily.miller@email.com",
                    PhoneNumber = "5555556958",
                    AmountDue = 355.67m,
                    PaymentDueDate = DateTimeOffset.Now.Date.AddDays(-15),
                    AccountStatusId = AccountStatuses.Overdue
                },
                new Account
                {
                    Id = 6,
                    FirstName = "Michael",
                    LastName = "Davis",
                    Email = "michael.davis@email.com",
                    PhoneNumber = "5555550394",
                    AmountDue = 0,
                    PaymentDueDate = null,
                    AccountStatusId = AccountStatuses.Inactive
                },
                new Account
                {
                    Id = 7,
                    FirstName = "Joshua",
                    LastName = "Garcia",
                    Email = "joshua.garcia@email.com",
                    PhoneNumber = "5555559283",
                    AmountDue = 98.35m,
                    PaymentDueDate = DateTimeOffset.Now.Date.AddDays(-7),
                    AccountStatusId = AccountStatuses.Overdue
                }
            };
    }
}
