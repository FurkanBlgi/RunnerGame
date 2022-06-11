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
    public static int say�;
    public GameObject Kazand�nPanel;
    public GameObject KarakterObj;
    public GameObject GameOverPanel;
    public GameObject BaslaButton;
    public TextMeshProUGUI say�text;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI Highscoretext;
    public int highscore;

    void Start()
    {
        Time.timeScale = 0;
        KarakterObj.GetComponent<Karakter>().enabled = false;
        StartCoroutine(spawn(0.1f));
        Kazand�nPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        BaslaButton.SetActive(true);
    }

    void Update()
    {
        OyunBitti();
        say�text.text = say�.ToString();
        scoretext.text= say�.ToString();
        highscore = say�;
      
        if (PlayerPrefs.GetInt("normalsay�") < highscore)
        {
            PlayerPrefs.SetInt("normalsay�", highscore);
        }
        Highscoretext.text =PlayerPrefs.GetInt("normalsay�").ToString();


    }
    IEnumerator spawn(float aral�k)
    {
        while (true)
        {
            Instantiate(Mermi, CikacakYer.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(aral�k);

 
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
        say� = 0;
        Kazand�nPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        Time.timeScale = 0;
        SceneManager.LoadScene(0);

        
    }
    public  void OyunBitti()
    {
        if (say� >= 20)
        {
            Kazand�nPanel.SetActive(true);
            Time.timeScale = 0;
           

        }
    }
 
}
