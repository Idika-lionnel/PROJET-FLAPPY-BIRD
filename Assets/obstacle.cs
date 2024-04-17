using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed ;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
