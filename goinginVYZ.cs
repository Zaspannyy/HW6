using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class goinginVYZ : States
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Идет в вуз");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Пришел в вуз");
        }
    }
}
