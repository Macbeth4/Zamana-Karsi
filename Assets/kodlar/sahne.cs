using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahne : MonoBehaviour
{
   
    public GameObject levelsahne;
    public GameObject menusahne;


   public void level1(){
    SceneManager.LoadScene("level1");
   }
   public void level2(){
    SceneManager.LoadScene("level2");
   }
   public void level3(){
    SceneManager.LoadScene("level3");
   }
   public void level4(){
    SceneManager.LoadScene("level4");
   }
   public void level5(){
    SceneManager.LoadScene("level5");
   }
   public void level6(){
    SceneManager.LoadScene("level6");
   }
   public void level7(){
    SceneManager.LoadScene("level7");
   }
   public void level8(){
    SceneManager.LoadScene("level8");
   }
   public void level9(){
    SceneManager.LoadScene("level9");
   }
   public void level10(){
    SceneManager.LoadScene("level10");
   }
   public void level11(){
    SceneManager.LoadScene("level11");
   }
   public void level12(){
    SceneManager.LoadScene("level12");
   }
   public void level13(){
    SceneManager.LoadScene("level13");
   }
   public void level14(){
    SceneManager.LoadScene("level14");
   }
   public void level15(){
    SceneManager.LoadScene("level15");
   }
   public void level16(){
    SceneManager.LoadScene("level16");
   }
   public void level17(){
    SceneManager.LoadScene("level17");
   }
   public void level18(){
    SceneManager.LoadScene("level18");
   }
   public void level19(){
    SceneManager.LoadScene("level19");
   }
   public void level20(){
    SceneManager.LoadScene("level20");
   }
   public void level21(){
    SceneManager.LoadScene("level21");
   }
   public void level22(){
    SceneManager.LoadScene("level22");
   }
   public void level23(){
    SceneManager.LoadScene("level23");
   }
   public void level24(){
    SceneManager.LoadScene("level24");
   }
   public void level25(){
    SceneManager.LoadScene("level25");
   }
   public void level26(){
    SceneManager.LoadScene("level26");
   }
   public void level27(){
    SceneManager.LoadScene("level27");
   }
   public void level28(){
    SceneManager.LoadScene("level28");
   }
   public void menu(){
    SceneManager.LoadScene("giris");
   }
   public void ins(){
    SceneManager.LoadScene("ins");
   }
   public void menupanel(){
    menusahne.SetActive(true);
    levelsahne.SetActive(false);
   }
   public void levelpanel(){
    levelsahne.SetActive(true);
    menusahne.SetActive(false);
   }


}
