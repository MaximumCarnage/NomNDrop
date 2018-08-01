using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {


 public Button restrtButton;

    void Start()
    {
        Button btn = restrtButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
	public void TaskOnClick()
	{
		
		 SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}
}
