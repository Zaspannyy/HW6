using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class User
    {
        public static stateMachine brain;



        static void Main(string[] args)
        {
            brain = new stateMachine();
            brain.Initialize(new beinginVYZ());

            int Day = 1;
           
            do
            {
                Console.WriteLine("\nДень " + Day);
                if (brain.CurrentState.ToString() == new beinginVYZ().ToString())
                {
                    brain.ChangeState(new goingHome());
                }
                if (brain.CurrentState.ToString() == new goingHome().ToString())
                {
                    brain.ChangeState(new dothedishesState());
                }
                if (brain.CurrentState.ToString() == new dothedishesState().ToString())
                {
                    brain.ChangeState(new workingondiplomState());
                }
                if (brain.CurrentState.ToString() == new workingondiplomState().ToString())
                {
                    brain.ChangeState(new Sleep());
                }
                if (brain.CurrentState.ToString() == new Sleep().ToString())
                {
                    brain.ChangeState(new goinginVYZ());
                }
                if (brain.CurrentState.ToString() == new goinginVYZ().ToString())
                {
                    brain.ChangeState(new beinginVYZ());
                }
                Day += 1;
                
            }
            while (Day <= 5);
            
            

        }
    }
}
