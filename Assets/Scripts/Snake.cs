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
        transform.Translate(speed * Time.fixedDeltaTime * Vector2.up, Space.Self);
        transform.Rotate(-horizontal * rotationSpeed * Time.fixedDeltaTime * Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
    }
}
