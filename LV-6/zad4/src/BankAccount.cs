using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;

namespace LV6
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public Memento CreateMemento() { return new Memento(this.OwnerName, this.OwnerAddress, this.Balance); }
        public void RestoreFromMemento(Memento previous)
        {
            this.ownerName = previous.OwnerName;
            this.ownerAddress = previous.OwnerAddress;
            this.balance = previous.Balance;
        }

        public override string ToString()
        {
            return "Owner: " + this.ownerName + " - Address: " + this.ownerAddress + " - Balance: " + this.Balance;
        }


    }

}
