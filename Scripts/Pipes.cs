using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;
    

    private void Start() {
        //lấy tọa độ biến left edge theo tọa độ màn hình
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    private void Update() {
        //cho các ống di chuyển từ phải sang trái
        transform.position += Vector3.left * speed * Time.deltaTime;
        //ống sẽ despawn khi đi qua khỏi màn hình
        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }
}
