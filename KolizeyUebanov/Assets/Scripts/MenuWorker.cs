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

    [SerializeField]
    private AudioSource _secretSound;

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

    private bool _isSecretAct = false;

    private string _password = "";

    public void Update()
    {
        if (_isSecretAct)
            return;

        if (Input.anyKeyDown)
        {
            _password += Input.inputString.ToLower();
            if (_password.Contains("lazyman")  || _password.Contains("дфяньфт")) // похуй
            {
                _isSecretAct = true;
                var secretSound = Instantiate(_secretSound);
                secretSound.Play();
            }
                
        }
            
    }


}
