using System;
using System.Collections.Generic;

namespace DeathStar1
{
    public class CentralComputerCore
    {
        string command;
        int computerPower;
        public CentralComputerCore(string Command, int ComputerPower)
        {
            command = Command;
            computerPower = ComputerPower;
        }
        public string IssueCommands(string newCommand)
        {
            if (command == null)
            {
                return newCommand;
            }
            else
            {
                return command;
            }
        }
        public void UseComputer()
        {
            computerPower--;
        }
    }
}