using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Gán target = Transform của nhân vật
    public float smoothSpeed = 0.125f; // Tốc độ làm mượt chuyển động

    void LateUpdate()
    {
        if (target != null)
        {
            // Tính toán vị trí mong muốn của camera
            Vector3 desiredPosition = target.position + new Vector3(0f, 0f, -10f);

            // Làm mượt chuyển động camera từ vị trí hiện tại đến vị trí mong muốn
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Cập nhật vị trí mới cho camera
            transform.position = smoothedPosition;
        }
    }

}
