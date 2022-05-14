using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    GameObject[] _spriteEgg = new GameObject[2];

    AraScripts _ara = new AraScripts();

    // Start is called before the first frame update
    void Start()
    {
        //Efsanevi _efso = new Efsanevi();
        //_efso.EggCreate("1", 50, 5, 10M);

        Nadir _samihYumurtasi = new Nadir();
        _samihYumurtasi.EggCreate("001", 10, 10, 10m);
        _samihYumurtasi.EggPrice();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Referans()
    {
        Standart _standart = new Standart();
    }
}
