using UnityEngine;

public class obstacleSpawner : MonoBehaviour 
{
    public float maxTime = 1f;
    private float timer = 0f;
    public GameObject obstacle;
    public float height;

    void Start() 
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = transform.position + new Vector3(0f, Random.Range(-height, height), 0f);
    }

    void Update() 
    {
        if (timer > maxTime) 
        {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0f, Random.Range(-height, height), 0f);
            Destroy(newObstacle, 15f);
            timer = 0f;
        }
        
        timer += Time.deltaTime;
    }
}
