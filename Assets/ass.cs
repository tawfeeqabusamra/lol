using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ass : MonoBehaviour
{
    

    void Start()
    {
        
        
        for(int i =1 ; i<11 ; i++){
            // int a = Multiply;
            Debug.Log(Multiply(i,5));
        }
        
        

    }
    int Multiply (int x , int z)
        {
            return x*z;
        }

}
