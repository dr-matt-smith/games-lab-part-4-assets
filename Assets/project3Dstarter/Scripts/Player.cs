using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static int score = 0;

	private void OnTriggerEnter(Collider other)
	{
		Player.score++;
		Destroy(other.gameObject);
	}

	private void Update()
	{
		print("Score: " + Player.score);
	}
}
