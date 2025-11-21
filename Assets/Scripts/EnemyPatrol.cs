using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 3f;               
    public float switchTime = 2f;           

    private float timer = 0f;
    private int direction = 1;             

    void Update()
    {
        
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

       
        timer += Time.deltaTime;
        if (timer >= switchTime)
        {
            direction *= -1;  
            timer = 0f;       
        }
    }
}