using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class countChooser : MonoBehaviour
{
    [SerializeField]
    private List<countChooserElement> _countChooserElements;

    private countChooserElement _currentCountChooserElement;

    // Start is called before the first frame update
    void Start()
    {
        _currentCountChooserElement = _countChooserElements.FirstOrDefault();
        _currentCountChooserElement.SpawnRedArrow();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _currentCountChooserElement.DestroyRedArrow();
            _currentCountChooserElement = GameWorker.Next<countChooserElement>(_countChooserElements, _currentCountChooserElement);
            _currentCountChooserElement.SpawnRedArrow();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _currentCountChooserElement.DestroyRedArrow();
            _currentCountChooserElement = GameWorker.Prew<countChooserElement>(_countChooserElements, _currentCountChooserElement);
            _currentCountChooserElement.SpawnRedArrow();
        }
    }
}
