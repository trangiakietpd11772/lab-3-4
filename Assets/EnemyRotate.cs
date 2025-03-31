using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    public float rotationSpeed = 100f; 

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime); 
    }
}