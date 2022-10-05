using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 3f;
    public float rotationSpeed = 200f;

    public string inputAxis;

    private float horizontal = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw(inputAxis);
    }

    void FixedUpdate()
    {
        transform.Translate(speed * Time.fixedDeltaTime * Vector2.up, Space.Self);
        transform.Rotate(-horizontal * rotationSpeed * Time.fixedDeltaTime * Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "KillsPlayer")
        {
            speed = 0f;
            rotationSpeed = 0f;
            GameObject.FindObjectOfType<GameManager>().EndGame();
        }
    }
}
