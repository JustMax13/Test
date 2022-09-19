using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Test01 : MonoBehaviour
{

    private void TestDebug(string str) => Debug.Log(str);

    Rigidbody2D rb;
    void Start()
    {
       GetComponent<Rigidbody2D>();
    }


}
