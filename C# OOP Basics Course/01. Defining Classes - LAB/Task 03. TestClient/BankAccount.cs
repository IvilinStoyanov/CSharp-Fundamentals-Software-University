﻿using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {      
        if(Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            this.Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account ID{Id}, balance {Balance:F2}";
    }
}

