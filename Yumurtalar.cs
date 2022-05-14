using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Yumurtalar
{

    public int _miktar;

    public string EggID { get; set; }


    public int Miktar { 
        
        get 
        {
            return _miktar;
        } 
        set 
        {
            if (value >= 50)
            {
                Debug.Log("50 den fazla yumurta girilemez");
            }
            else
            {
                _miktar = value;
                EggPrice();
            }
        } 
    
    }


    public int Tur { get; set; }

    public decimal Fiyat { get; protected set; }

    public int Aciklama { get; set; }

    public GameObject[] EggSprite { get; set; }


    public void EggCreate(string _eggId, int _miktar, int _tur, decimal _fiyat)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = _tur;
        Fiyat = _fiyat;
        
    }

    public void EggCreate(string _eggId, int _miktar, int _tur, decimal _fiyat, int _aciklama)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = _tur;
        Fiyat = _fiyat;
        Aciklama = _aciklama;
        
    }

    public void EggCreate(string _eggId, int _miktar, int _tur, decimal _fiyat, int _aciklama, GameObject[] _spriteEgg)
    {
        EggID = _eggId;
        Miktar = _miktar;
        Tur = _tur;
        Fiyat = _fiyat;
        Aciklama = _aciklama;
        EggSprite = _spriteEgg;
        
    }

    public virtual void EggPrice()
    {
        Debug.Log(Fiyat);
    }



    ////string _yumurtaTuru;
    //float _yumurtaFiyati;

    //public int YumurtaId { get; set; }

    //public int Adet { get; set; }

    ////public int Fiyati { get; set; }

    //public string YumurtaTuru { get; set; }


    ////public string YumurtaTuru
    ////{

    ////    get
    ////    {

    ////        return _yumurtaTuru;

    ////    }
    ////    set

    ////    {
    ////        if (_yumurtaTuru == "Standart")
    ////        {
    ////            Fiyati *= 1;
    ////            _yumurtaTuru = value;
    ////        }

    ////        if (_yumurtaTuru == "Nadir")
    ////        {
    ////            Fiyati *= 5;
    ////            _yumurtaTuru = value;
    ////        }

    ////        if (_yumurtaTuru == "Efsanevi")
    ////        {
    ////            Fiyati *= 25;
    ////            _yumurtaTuru = value;
    ////        }
    ////    }

    ////}

    //public float Fiyati
    //{

    //    get
    //    {

    //        return _yumurtaFiyati;

    //    }
    //    set

    //    {
    //        if (YumurtaTuru == "Standart")
    //        {
    //            _yumurtaFiyati = value;
    //        }

    //        else if (YumurtaTuru == "Nadir")
    //        {
    //            _yumurtaFiyati = value * 5;
    //        }

    //        else if (YumurtaTuru == "Efsanevi")
    //        {
    //            _yumurtaFiyati = value * 25;
    //        }
    //    }

    //}

    //public void YumurtaOlustur(int _yumurtaID, int _adet, int _fiyati, string _yumurtaTuru)
    //{
    //    YumurtaId = _yumurtaID;
    //    Adet = _adet;
    //    Fiyati = _fiyati;
    //    YumurtaTuru = _yumurtaTuru;

    //    Debug.Log(_fiyati);
    //}


}

    

