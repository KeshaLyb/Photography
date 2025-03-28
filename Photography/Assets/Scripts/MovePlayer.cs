using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 10;
    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * vertical * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }
}
