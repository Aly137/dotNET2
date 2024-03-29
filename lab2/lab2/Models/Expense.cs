﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public enum ExpenseType
    {
        food, 
        utilities,
        transportation, 
        outing, 
        groceries, 
        clothes, 
        electronics, 
        other
    }

    public class Expense
    {
        [Key()]
        public int Id { get; set; }
        public string Description { get; set; }
        public float Sum { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        [EnumDataType(typeof(ExpenseType))]
        public ExpenseType ExpenseType { get; set; }
    }
}