﻿using FluentValidator;
using FluentValidator.Validation;
using Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class Adress:ValueObject
    {
        public Adress(string street, string number, string city)
        {
            Street = street;
            Number = number;
            City = city;
            AddNotifications(new ValidationContract()
                .Requires()
                .IsNotNullOrEmpty(Street, "Adress street", "Street is null or empty")
                .IsNotNullOrEmpty(Number, "Number Adress", "Number is null or empty")
                .IsNotNullOrEmpty(City, "City Adress", "City is null or empty")
                .IsTrue(ReallyExists(this), "Adress", "Adress not exists")
                ); ;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string City { get; private set; }

        public bool ReallyExists(Adress adress)
        {
            var searchResultInGoogleMapsService = true;            

            return searchResultInGoogleMapsService;
        }
    }
}
