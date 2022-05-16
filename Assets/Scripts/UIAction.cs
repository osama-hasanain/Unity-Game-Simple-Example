using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIAction : MonoBehaviour
{

    public GameObject info_list_Object;
    public GameObject settings_list_Object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAction()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void settingsAction()
    {
        Debug.Log("settingsAction()");
    }

    public void quitAction()
    {
        Debug.Log("quitAction()");
    }

    public void showInfo()
    {
        info_list_Object.SetActive(true);
    }

    public void hideInfo()
    {
        info_list_Object.SetActive(false);
    }

    public void showSettings()
    {
        settings_list_Object.SetActive(true);
    }

    public void hideSettings()
    {
        settings_list_Object.SetActive(false);
    }
}
