using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitisyanharaket : MonoBehaviour
{
   public float speed = 2f; // hareket hızı
public float distance = 2f; // hareket mesafesi
public bool moveRight = true; // sağa mı yoksa sola mı hareket edeceğimizi tutan değişken

void Update() {
    if (transform.position.x > distance && moveRight) {
        moveRight = false;
    }
    else if (transform.position.x < -distance && !moveRight) {
        moveRight = true;
    }

    // Hareket yönüne göre platformu hareket ettir
    if (moveRight) {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    else {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }
}
}
