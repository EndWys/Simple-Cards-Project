using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeckController : MonoBehaviour
{
    private DeckModel _deckModel;

    private readonly CardFactory _cardFactory;


    //����� �������� �� ������ ������� ���� �� ������ � ����
    //�������� �� ������� ���������� ���� �� ������� ��� �����������. � ��������� ��� ����� ������������ � ������ ���� � ������ DeckModel
    public DeckController(CardFactory cardFactory)
    {
        _deckModel = new DeckModel();
        _cardFactory = cardFactory;
        _cardFactory.CardsDealing += TakeCardsToDeck;
    }

    ~DeckController()
    {
        _cardFactory.CardsDealing -= TakeCardsToDeck;
    }

    private void TakeCardsToDeck()
    {
        _deckModel.CardsInDeck = _cardFactory.Cards;
    }

}
