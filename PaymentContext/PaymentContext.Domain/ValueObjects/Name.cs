using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter ao menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter ao menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve até 3 caracteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve até 3 caracteres"));
                

            if (string.IsNullOrEmpty(FirstName))
                AddNotification("Name.FirstName", "Nome Inválido");

            if (string.IsNullOrEmpty(LastName))
                AddNotification("Name.LastName", "Sobrenome Inválido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
