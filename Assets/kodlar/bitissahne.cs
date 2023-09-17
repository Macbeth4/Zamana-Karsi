
using UnityEngine;

public class bitissahne : MonoBehaviour
{

    public GameObject bitispanel;
    public GameManager managergame;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "karakter"){
            karakterharaket.yatayharaket = 0;
            managergame.buttonlar.SetActive(false);
            Time.timeScale = 0;
            bitispanel.SetActive(true);
            Destroy(other.gameObject);
        }
    }


}
