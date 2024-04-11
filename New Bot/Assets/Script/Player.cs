using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody2D rig;
    private UnityEngine.Vector2 _playerDirection;

    // Start is called before the first frame update
    void Start()
    {
         rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerDirection = new UnityEngine.Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    }
    void FixedUpdate(){
        rig.MovePosition(rig.position + _playerDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
