using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    //public Canvas quitMenu;
    public Button playText;
    //public Button CustomizeText;
    //public Button SettingsText;
    //public Button StatsText;
    //public Button exitText;
    //public string LevelName;

    // Use this for initialization
    void Start()
    {
      //  quitMenu = quitMenu.GetComponent<Canvas>();
        playText = playText.GetComponent<Button>();
       // quitMenu.enabled = false;
    }

    public void ExitPress()
    {
        //quitMenu.enabled = true;
        playText.enabled = false;
        //exitText.enabled = false;
    }
    public void Nopress()
    {
        //quitMenu.enabled = false;
        playText.enabled = true;
        //exitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("NECSCENE");
    }

    public void ExitGame()
    {
        Application.Quit();

    }
    // Update is called once per frame
    void Update()
    {



    }
}
