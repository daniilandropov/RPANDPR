using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuWorker : MonoBehaviour
{
    [SerializeField]
    private string _menuOnStart;

    private ItsMenu _currentMenu;

    [SerializeField]
    private List<ItsMenu> _menues;

    void Start()
    {
        LoadMenu(_menuOnStart);
        
    }

    public void LoadMenu(string menuName)
    {
        if(_currentMenu)
            Destroy(_currentMenu.gameObject);

        var menu = _menues.First(x => x.MenuName == menuName);
        _currentMenu = Instantiate(menu);
        _currentMenu.SetMenuWorker(this);
    }


}
