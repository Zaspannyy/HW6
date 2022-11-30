using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class beinginVYZ : States
    {
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Учится в вузе");
        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Закончил учиться в вузе");
        }
    }
}
