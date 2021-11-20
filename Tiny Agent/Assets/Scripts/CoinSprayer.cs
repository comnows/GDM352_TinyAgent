using UnityEngine;
using System.Collections;

public class CoinSprayer : MonoBehaviour {

	public int numCoins = 10;
	public GameObject coinPrefab;
	public float offSetRange = 1.5f;

	void Start () {
		SpawnCoins();
	}

	void SpawnCoins(){
		for (int i = 0; i < numCoins; i++){
			Vector2 spawnOffset = 
				new Vector2 (Random.Range(-offSetRange, offSetRange), 
				             Random.Range(-offSetRange, offSetRange));
			Instantiate(coinPrefab, 
			            (Vector2)transform.position + spawnOffset, 
			            Quaternion.identity);
		}
		Destroy(gameObject);
	}
}
