using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    InputManager inputManager;
    Vector2 movement;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = inputManager.ReadMovementInputs();
        transform.Translate(movement * speed*Time.deltaTime, Space.World);
    }
}
