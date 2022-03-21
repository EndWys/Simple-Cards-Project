using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardFactory : MonoBehaviour
{
    public event Action CardsDealing;

    private List<CardModel> _cards;

    public List<CardModel> Cards { get => _cards; set => _cards = value; }

    public void GiveCards(List<CardModel> cards)
    {
        _cards = cards;
        CardsDealing?.Invoke();
    }
}
