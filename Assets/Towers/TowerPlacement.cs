using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] int goldCosts = 50;

    CurrencySystem bank;
    void Start()
    {
        bank = GetComponent<CurrencySystem>();
    }
        
    void Update()
    {
        
    }

    public void TowerCosts()
    {
        if(bank == null)
        {
            return;
        }

        bank.Withdraw(goldCosts);
    }
}
