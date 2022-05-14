using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Efsanevi : Yumurtalar
{

    public override void EggPrice()
    {
        Fiyat = Fiyat * 25;
        Debug.Log(Fiyat);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
