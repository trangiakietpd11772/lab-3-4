using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitEnemy : MonoBehaviour
{
    public Transform centerPoint; // Điểm trung tâm để xoay quanh
    public float rotateSpeed = 100f; // Tốc độ xoay
    public float radius = 2f; // Bán kính quay

    private float angle;

    void Update()
    {
        angle += rotateSpeed * Time.deltaTime;
        float rad = angle * Mathf.Deg2Rad;
        Vector2 offset = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad)) * radius;
        transform.position = (Vector2)centerPoint.position + offset;
    }
}
