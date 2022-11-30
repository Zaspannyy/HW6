using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class dothedishesState : States
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Начал мыть посуду");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Закончил мыть посуду");
        }
    }
}
