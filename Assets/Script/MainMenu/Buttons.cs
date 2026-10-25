using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	
	
	public void HitStart()
    {

        SceneManager.LoadScene(1);

    }

    public void Quit()
    {
        Application.Quit();


    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Upgrades()
    {
        SceneManager.LoadScene(2);
    }

    private void Update()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }


}
