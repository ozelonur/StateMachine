using _GAME_.Scripts.Player.States;
using _GAME_.Scripts.StateMachine.Models;
using UnityEngine;

namespace _GAME_.Scripts.Player
{
    public abstract class PlayerBaseState : State
    {
        protected PlayerStateMachine stateMachine;

        public PlayerBaseState(PlayerStateMachine machine)
        {
            stateMachine = machine;
        }

        public void Move(Vector3 direction)
        {
            stateMachine.moveTransform.position += direction * stateMachine.moveSpeed;

            if (stateMachine.moveTransform.position.y <= 0)
            {
                stateMachine.SwitchState(new PlayerJumpState(stateMachine));
            }
        }
    }
}