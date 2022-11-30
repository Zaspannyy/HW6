using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class goingHome : States
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Идет домой");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Пришел домой");
        }
    }
}
