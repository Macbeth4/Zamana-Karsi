using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class resulation : MonoBehaviour
{
     private static resulation instance;
    
    void Awake()
    {
        // Eğer başka bir SingletonObject nesnesi varsa bu nesneyi yok et
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Singleton nesneyi ayarla ve sahneler arasında yok etme
        instance = this;
        DontDestroyOnLoad(gameObject);

        // Ekran çözünürlüğünü sadece başlangıç sahnesinde değiştir
        if (SceneManager.GetActiveScene().name == "menulevel")
       {
         Screen.SetResolution(Screen.currentResolution.width /2, Screen.currentResolution.height/2 , true);
       }
        
    }
   
}