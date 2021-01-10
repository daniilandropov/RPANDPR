using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstMenu : ItsMenu
{

    void Update()
    {
        if (Input.anyKey)
        {
            _menuWorker.LoadMenu("ChooseCountOfPlayers");
        }
    }
}
