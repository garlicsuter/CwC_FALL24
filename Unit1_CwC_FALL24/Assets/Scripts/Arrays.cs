using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] lottoNumbers = { 11, 22, 33, 44, 55 };
    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        myNumber = lottoNumbers[Random.Range(0, lottoNumbers.Length)];
        print("myNumber = " + myNumber);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
