﻿namespace NorthwindDataBase_MVC.Models.create
{
    public class CreateCustomerDto
    {

        public int CustomerId { get; set; }

        public string? CustomerName { get; set; }

        public string? ContactName { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

    }
}
