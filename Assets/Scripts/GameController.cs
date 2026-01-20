using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

[SerializeField] private TMP_Text _textpointsnumber;
[SerializeField] public GameObject _coinPrefab;



    void Start()
    {
        InvokeRepeating("SpawnCoin", 1f, 0.3f);
    }

    
    void Update()
    {
        
    }
    void SpawnCoin()
    {
        int spawn = Random.Range(1, 4);
        if (spawn == 2)
        {
            GameObject Coin = Instantiate(_coinPrefab, new Vector3(14, 13.4f, 0), Quaternion.identity);
        }
    }

public void UpdatePointsDisplay(int points)
    {
        _textpointsnumber.text = points.ToString();
    }

}

