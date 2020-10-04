using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { START, PLAYERTURN, ENEMYTURN, WON, LOST}

public class GameManager : MonoBehaviour
{
	public GameState state;
	
	public GameObject cardPrefab;
    public GameObject playerArea;
    public GameObject enemyArea;

	private void Start()
	{
		state = GameState.START;
		DrawHands();
	}

	private void DrawHands()
	{
		for (int i = 0; i < 5; i++)
		{
			GameObject playerCard = Instantiate(cardPrefab);
			playerCard.transform.SetParent(playerArea.transform, false);
			playerCard.transform.tag = "PlayerCard";

			GameObject enemyCard = Instantiate(cardPrefab);
			enemyCard.transform.SetParent(enemyArea.transform, false);
			enemyCard.transform.tag = "EnemyCard";
		}
	}
}
