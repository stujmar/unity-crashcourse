using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour {
    public int numberToDisplay;
    private int multiplier = 2;

    // Start is called before the first frame update
    void Start() {
        SayHelloWorld();
        MultiplyNumber(5);
    }

    private void SayHelloWorld() {
        for (int i = 0; i < numberToDisplay; i++) {
            Debug.Log("Hello World");
        }
    }

    private void MultiplyNumber(int numberToMultiply) {
        int product = numberToMultiply * multiplier;
        Debug.Log(product);
    }
}
