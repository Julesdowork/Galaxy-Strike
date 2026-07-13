using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float controlSpeed = 10f;

    private Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }

    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float yOffset = movement.y * controlSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(transform.localPosition.x + xOffset, transform.localPosition.y + yOffset, 0);
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
}
