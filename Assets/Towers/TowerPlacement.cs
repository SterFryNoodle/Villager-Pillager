using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    [SerializeField] int goldCost = 50;

    CurrencySystem bank;
    void Start()
    {
        bank = GetComponent<CurrencySystem>();
    }
    
    public void TowerCosts()
    {
        if(bank == null)
        {
            return;
        }

        bank.Withdraw(goldCost);
    }

    public bool CreateTower(TowerPlacement tower, Vector3 position)
    {
        Instantiate(tower.gameObject, position, Quaternion.identity);

        return true;
    }
}
