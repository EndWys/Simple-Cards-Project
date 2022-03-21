using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckModel
{
    private List<CardModel> _cardsInDeck;

    public List<CardModel> CardsInDeck { get => _cardsInDeck; set => _cardsInDeck = value; }

}
