﻿namespace PhoneBook.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string MobilePhone { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public DateTime BirthDate { get; set; } = new DateTime();
    }
}
