using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("This is Awake function");
    }
    void Start()
    {
        Debug.Log("This is Start function");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is Update function");
    }
    private void LateUpdate()
    {
        Debug.Log("This is LateUpdate function");
    }
    private void FixedUpdate()
    {
        Debug.Log("This is FixedUpdate function");
    }
}
