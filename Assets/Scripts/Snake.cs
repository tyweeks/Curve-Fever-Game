using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;

    private float horizontal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime, Space.Self);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.fixedDeltaTime);
    }
}
