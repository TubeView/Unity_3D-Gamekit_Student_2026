using System;
using UnityEngine;
using UnityEngine.Events;


public class WS1 : MonoBehaviour
{
    public int firstValue = 0;
    public bool happy;
    private int newValue;
    private int randomNumber;
    private string shape = "Triangle";
    private float timer = 0;
    public GameObject triangle;
    public GameObject square;
    public Transform triangleTransform;
    private SpriteRenderer squareRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        happy = true;
        firstValue++;
        newValue = firstValue;
        triangleTransform = triangle.GetComponent<Transform>();
        squareRenderer = square.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartDeletion(5);
        }
    }
    
    void StartDeletion(int countdown)
    {
        timer = 0;
        squareRenderer.color = Color.red;
        Console.WriteLine("Square: Sorry...");
        Console.WriteLine("Triangle: What, what have you done?");
        if (timer > countdown)
        {
            Destroy(triangle);
        }

    }
}
