using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencySystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI currencyText;

    public int currencyAmount;

    public static CurrencySystem Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateCurrency(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateCurrency(int change)
    {
        currencyAmount += change;
        currencyText.text = currencyAmount.ToString();
    }
    
}
