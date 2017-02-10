using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScenes : MonoBehaviour {

    public string sceneName;

	public void changeScenes()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
