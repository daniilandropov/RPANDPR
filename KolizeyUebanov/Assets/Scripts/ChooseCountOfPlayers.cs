using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCountOfPlayers : ItsMenu
{
    public MenuWorker GetMenuWorker()
    {
        return _menuWorker;
    }

    internal void LoadMenu(string v)
    {
        _menuWorker.LoadMenu(v);
    }
}
