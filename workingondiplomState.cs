using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class workingondiplomState : States
    {
        public override void Enter()
        {

            base.Enter();
            Console.WriteLine("Начал работу над дипломом");

        }

        public override void Exit()
        {
            base.Exit();
            Console.WriteLine("Перестал работать над дипломом");

        }
    }
}
