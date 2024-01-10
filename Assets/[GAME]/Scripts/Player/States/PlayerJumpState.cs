namespace _GAME_.Scripts.Player.States
{
    public class PlayerJumpState : PlayerBaseState
    {
        public PlayerJumpState(PlayerStateMachine machine) : base(machine)
        {
        }

        public override void OnEnter()
        {
            // Jump Code
            
            
            
            stateMachine.SwitchState(new PlayerMoveState(stateMachine));
        }

        public override void OnUpdate(float deltaTime)
        {
            
        }

        public override void OnFixedUpdate(float fixedDeltaTime)
        {
            
        }

        public override void OnExit()
        {
            
        }
    }
}