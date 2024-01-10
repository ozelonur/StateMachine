using System;
using UnityEngine;

namespace _GAME_.Scripts
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager Instance;

        public Action<Vector3> OnMoveLeftAction;
        public Action<Vector3> OnMoveRightAction;
        public Action<Vector3> OnMoveForwardAction;
        public Action<Vector3> OnMoveBackwardAction;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                OnMoveLeftAction?.Invoke(Vector3.left);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                OnMoveRightAction?.Invoke(Vector3.right);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                OnMoveForwardAction?.Invoke(Vector3.forward);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                OnMoveBackwardAction?.Invoke(Vector3.back);
            }
        }
    }
}