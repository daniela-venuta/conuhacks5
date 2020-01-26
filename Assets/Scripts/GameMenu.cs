using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{ 
    void Start() {
        GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }
  void TaskOnClick()   {
        SceneManager.LoadScene("YeetHaw");
    }
}
