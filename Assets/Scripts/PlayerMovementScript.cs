using UnityEngine;

namespace Arcade
{
    public class PlayerMovementScript : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private Joystick joystick;

        private void Update()
        {
            MovementHandler();
        }

        private void MovementHandler()
        {
            Vector3 movementVector = new Vector3(joystick.Horizontal, 0.0f, joystick.Vertical);

            transform.position += movementSpeed * Time.deltaTime * movementVector;
            transform.rotation = Quaternion.LookRotation(movementVector);

        }
    }

}