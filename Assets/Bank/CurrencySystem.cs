using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySystem : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;

    int currentBalance;
    public int CurrentBalance { get { return currentBalance; } } //Creates a property of the private variable currentBalance.

    void Start()
    {
        currentBalance = startingBalance;
    }

    
    void Update()
    {
        
    }
}
