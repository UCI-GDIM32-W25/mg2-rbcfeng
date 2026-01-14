using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

[SerializeField] private TMP_Text _textpointsnumber;
[SerializeField]private GameObject _coinPrefab;



    void Start()
    {
        
    }

    
    void Update()
    {
        Instantiate(_coinPrefab, new Vector3(14, 13.4f, 0), Quaternion.identity);
    }
public void UpdatePointsDisplay(int points)
    {
        _textpointsnumber.text = points.ToString();
    }

}
