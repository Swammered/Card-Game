using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardController : MonoBehaviour
{
    public Card card;
    public Image picture;
    public TextMeshProUGUI cardName, cardNumber;
    
    private void Awake() 
    {
        Initialize(card);
    }
    void Start()
    {
        
    }
    public void  Initialize(Card card) 
    {
       picture.sprite = card.cardImage;
       cardName.text = card.cardName;
       cardNumber.text = card.cardNumber.ToString(); 
    }
    public void Update()
    {
        
    }
}
