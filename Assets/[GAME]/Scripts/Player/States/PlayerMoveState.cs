using UnityEngine;

namespace _GAME_.Scripts.Player.States
{
    public class PlayerMoveState : PlayerBaseState
    {
        private float moveSpeed;
        public PlayerMoveState(PlayerStateMachine machine) : base(machine)
        {
            moveSpeed = stateMachine.moveSpeed;
        }

        public override void OnEnter()
        {
            InputManager.Instance.OnMoveForwardAction += MoveAction;
            InputManager.Instance.OnMoveBackwardAction += MoveAction;
            InputManager.Instance.OnMoveLeftAction += MoveAction;
            InputManager.Instance.OnMoveRightAction += MoveAction;
        }

        public override void OnUpdate(float deltaTime)
        {
        }

        public override void OnFixedUpdate(float fixedDeltaTime)
        {
            
        }

        public override void OnExit()
        {
            InputManager.Instance.OnMoveForwardAction -= MoveAction;
            InputManager.Instance.OnMoveBackwardAction -= MoveAction;
            InputManager.Instance.OnMoveLeftAction -= MoveAction;
            InputManager.Instance.OnMoveRightAction -= MoveAction;
        }

        private void MoveAction(Vector3 direction)
        {
            Move(direction);
        }
    }
}