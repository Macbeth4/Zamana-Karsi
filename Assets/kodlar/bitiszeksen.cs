using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitiszeksen : MonoBehaviour
{
public float speed = 50.0f; // dönüş hızı
public float duration = 2.0f; // dönüş süresi

private float elapsed = 0.0f; // geçen süre
private int direction = 1; // dönüş yönü

void Update()
{
    // Geçen süreyi güncelle
    elapsed += Time.deltaTime;

    // Dönüş süresi dolana kadar belirli yönde döndür
    if (elapsed < duration)
    {
        transform.Rotate(Vector3.forward * speed * direction * Time.deltaTime);
    }
    // Dönüş süresi dolduğunda yönü tersine çevir
    else
    {
        direction = -direction; // yönü tersine çevir
        elapsed = 0.0f; // süreyi sıfırla
    }
}
}