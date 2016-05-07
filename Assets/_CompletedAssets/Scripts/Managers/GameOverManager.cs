using UnityEngine;

namespace CompleteProject
{
	public class GameOverManager : MonoBehaviour
	{
		public PlayerHealth playerHealth;
		Animator anim;
		public float ShowScoresDelay;
		float ShowScoresTimer;
		void Awake()
		{
			anim = GetComponent<Animator>();
			ShowScoresDelay = 50;
		}


		void Update()
		{
			// If the player has run out of health...
			if(playerHealth.currentHealth <= 0) 
			{
					anim.SetTrigger ("GameOver");	
				ShowScoresTimer += Time.deltaTime;
			}
		}
	}

}