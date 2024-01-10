using _GAME_.Scripts.StateMachine.Models;
using UnityEngine;

namespace _GAME_.Scripts.StateMachine
{
    public class StateMachineBase : MonoBehaviour
    {
        private State currentState;

        private void Update()
        {
            currentState?.OnUpdate(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            currentState?.OnFixedUpdate(Time.fixedDeltaTime);
        }

        public void SwitchState(State newState)
        {
            currentState?.OnExit();
            currentState = newState;
            currentState?.OnEnter();
        }
    }
}