using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

[SerializeField] private Collider2D _collider;
[SerializeField] private Rigidbody2D _rigidbody;
[SerializeField] private float _jump;
[SerializeField] private GameController _gameController;
private bool _isGrounded = true;
private int _points = 0;

 private void CollectCoin(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }

        Debug.Log("Collided with: " + tag);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;
            _rigidbody.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        string tag = collider.gameObject.tag;
        if (tag == "Coin")
        {
            _points++;
           _gameController.UpdatePointsDisplay(_points);
            Destroy(collider.gameObject);
            Debug.Log("Collected coin");
        }
    }
} 
