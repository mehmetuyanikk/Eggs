using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Standart : Yumurtalar
{

    public override void EggPrice()
    {
        Fiyat = Fiyat * 1;
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
