using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerVariables : MonoBehaviour {

	private float health = 100f;
	private float damageTimer = 1f;
	private Slider healthSlider;

	private int level = 1;
	private int experience = 0;

	void Start () {
		healthSlider = GameObject.Find("HealthSliderUI").GetComponent<Slider>();
	}
	
	void Update () {
		// damageTimer bör öka med tiden som gått från senaste uppdate-loopen. Tiden räknas ut med Time.deltaTime;

		healthSlider.value = Mathf.Lerp(healthSlider.value, health, Time.deltaTime);
		if(experience > level * level * 100){

			// När experience når över den mattematiska formeln i if-satsen bör vi öka level.
		
		}
	}

	public void Harm(float dmg){

		// Om damageTimer är större än en sekund bör vi sänka health med damage. Vi bör även sätta damageTimer till 0f för att nollställa timern.
		
		// Om health är mindre än 1f så bör vi starta funktionen Die(). Det kan bara göras med StartCoroutine eftersom Die() är en IEnumerator.

	}

	IEnumerator Die(){
		GetComponent<PlayerInputs>().enabled = false;
		GetComponent<Collider2D>().enabled = false;
		GetComponent<Animator>().SetTrigger("Die");

		yield return new WaitForSeconds(2f);

		// Här bör en ny level laddas eller en icke implementerad Respawn() funktion kallas på. 

	}
}