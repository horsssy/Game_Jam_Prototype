using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    InputControls inputActions;
    Vector2 movementInputs;
    private void Awake()
    {
        inputActions = new InputControls();
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementInputs = inputActions.Ground.Move.ReadValue<Vector2>();
        //print(movementInputs);
    }
    public Vector2 ReadMovementInputs()
    {
        return movementInputs;
    }
}
