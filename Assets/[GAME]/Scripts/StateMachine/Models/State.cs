namespace _GAME_.Scripts.StateMachine.Models
{
    public abstract class State
    {
        public abstract void OnEnter();
        public abstract void OnUpdate(float deltaTime);
        public abstract void OnFixedUpdate(float fixedDeltaTime);
        public abstract void OnExit();
    }
}