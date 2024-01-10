using _GAME_.Scripts.Player.States;
using _GAME_.Scripts.StateMachine;
using UnityEngine;

namespace _GAME_.Scripts.Player
{
    public class PlayerStateMachine : StateMachineBase
    {
        public float moveSpeed;
        public Transform moveTransform;
        private void Start()
        {
            SwitchState(new PlayerMoveState(this));
        }
    }
}