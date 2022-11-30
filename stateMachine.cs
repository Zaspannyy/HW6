using System;
using System.Collections.Generic;
using System.Text;

namespace HW6
{
    class stateMachine
    {
        public States CurrentState { get; set; }

        public void Initialize(States startState)
        {
            CurrentState = startState;
            CurrentState.Enter();
        }

        public void ChangeState(States newState)
        {
            CurrentState.Exit();
            CurrentState = newState;
            CurrentState.Enter();


        }



    }
}
