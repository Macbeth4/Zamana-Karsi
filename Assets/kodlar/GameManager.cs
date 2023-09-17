using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI suretext;
    public GameObject karakter;
    public float _currenttime;
    public float _hedef;

    public GameObject tekrardene;
    public GameObject buttonlar;

    public float sayi;

    private void Start() {
        tekrardene.SetActive(false);
        Time.timeScale = 1;
        sayi = -_hedef;
        _currenttime = _hedef;
        suretext.text = _currenttime.ToString("00:00");
        StartCoroutine(UpdateTime());

    }

    private IEnumerator UpdateTime(){
        while(_currenttime >= sayi){
            suretext.text = _currenttime.ToString("00:00");
            yield return new WaitForSeconds(1f);
            _currenttime --;
        }
        yield return null;
    }

    private void Update() {
        suretext.text = _currenttime.ToString("00:00");

        if(_currenttime <= 0){
            Destroy(karakter);
            karakterharaket.yatayharaket = 0;
            Time.timeScale = 0;
            buttonlar.SetActive(false);
            tekrardene.SetActive(true);

        }
    }
}
