using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject CikacakYer;
    public GameObject Mermi;
    public  GameObject[] Dusmanlar;
    public static int sayý;
    public GameObject KazandýnPanel;
    public GameObject KarakterObj;
    public GameObject GameOverPanel;
    public GameObject BaslaButton;
    public TextMeshProUGUI sayýtext;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI Highscoretext;
    public int highscore;

    void Start()
    {
        Time.timeScale = 0;
        KarakterObj.GetComponent<Karakter>().enabled = false;
        StartCoroutine(spawn(0.1f));
        KazandýnPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        BaslaButton.SetActive(true);
    }

    void Update()
    {
        OyunBitti();
        sayýtext.text = sayý.ToString();
        scoretext.text= sayý.ToString();
        highscore = sayý;
      
        if (PlayerPrefs.GetInt("normalsayý") < highscore)
        {
            PlayerPrefs.SetInt("normalsayý", highscore);
        }
        Highscoretext.text =PlayerPrefs.GetInt("normalsayý").ToString();


    }
    IEnumerator spawn(float aralýk)
    {
        while (true)
        {
            Instantiate(Mermi, CikacakYer.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(aralýk);

 
        }

    }
    public void Basla()
    {
        Time.timeScale = 1;
        BaslaButton.SetActive(false);
        KarakterObj.GetComponent<Karakter>().enabled = true;
    }
    public void TekrarOyna()
    {
        sayý = 0;
        KazandýnPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        Time.timeScale = 0;
        SceneManager.LoadScene(0);

        
    }
    public  void OyunBitti()
    {
        if (sayý >= 20)
        {
            KazandýnPanel.SetActive(true);
            Time.timeScale = 0;
           

        }
    }
 
}
