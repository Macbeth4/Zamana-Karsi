using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitisharaket : MonoBehaviour
{
   public float speed = 3f; // hareket hızı
    public float distance = 2f; // hareket mesafesi
    public float timeToChangeDirection = 2f; // yön değiştirme süresi

    private float startY;
    private float endY;
    private float direction = 1f;
    private float timer;

    void Start()
    {
        // başlangıç ve bitiş yüksekliğini belirle
        startY = transform.position.y;
        endY = transform.position.y + distance;
    }

    void Update()
    {
        // yön değiştirme süresini kontrol et
        timer += Time.deltaTime;
        if (timer >= timeToChangeDirection)
        {
            direction *= -1f;
            timer = 0f;
        }

        // hareketi hesapla ve uygula
        float newY = transform.position.y + (direction * speed * Time.deltaTime);
        newY = Mathf.Clamp(newY, startY, endY);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

}

