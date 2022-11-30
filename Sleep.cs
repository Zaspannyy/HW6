using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class Sleep : States
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Лег спать");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Проснулся");
        }
    }
}
