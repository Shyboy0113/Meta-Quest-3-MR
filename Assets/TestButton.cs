using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{

    public GameObject panel;
    public GameObject optionPanel;

    public void OpenPanel()
    {
        if (panel is not null)
        {
            panel.SetActive(true);
        }

    }
    public void ClosePanel()
    {
        if (panel is not null)
        {
            panel.SetActive(false);
        }
    }

    public void OpenOptionPanel()
    {
        if (optionPanel is not null)
        {
            optionPanel.SetActive(true);
        }
    }

    public void CloseOptionPanel()
    {
        if (optionPanel is not null)
        {
            optionPanel.SetActive(false);
        }
    }

    public void QuitApp()
    {
        Application.Quit();
    }

}
