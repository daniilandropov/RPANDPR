using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countChooserElement : MonoBehaviour
{
    public int countOfPlayers;

    [SerializeField]
    private placeForArrow _placeForArrow;

    [SerializeField]
    private RedArrow _redArrow;

    private RedArrow _currentArrow;


    public void SpawnRedArrow()
    {
        _currentArrow = Instantiate(_redArrow, _placeForArrow.transform);
    }

    public void DestroyRedArrow()
    {
        Destroy(_currentArrow.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
