using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossFunctions : MonoBehaviour {
	public GameObject bossui;
	public GameObject BossPrefab;
	public bool bossalive = false;



	int hp = 1000;
	int maxhp = 1000;
	GameObject boss;
	float fullsize = 1f;

	public void SpawnBoss(Vector2 SpawnPoint, string Name){
		boss = Instantiate (BossPrefab, SpawnPoint, Quaternion.identity);
		BossUI (true);
		DisplayName (Name);
		bossalive = true;
	}

	public void BossDies(){
		BossUI (false);
		bossalive = false;
	}

	//Call these two at the top














	void BossUI(bool enabled){
		if (enabled) {
			bossui.SetActive (true);
			GameObject hpBar = bossui.transform.Find ("BG").gameObject;
			hpBar.GetComponent<Animator> ().SetTrigger ("GoDown");
		} else {
			GameObject hpBar = bossui.transform.Find ("BG").gameObject;
			hpBar.GetComponent<Animator> ().SetTrigger ("BackUp");
		}
	}

	void DisplayName(string name){
		name = name.ToUpper();
		GameObject bossname = bossui.transform.Find ("bossname").gameObject;
		bossname.GetComponent<Text> ().text = name;
		bossname.GetComponent<Animator> ().SetTrigger ("asd");
	}

	void Update(){
//		if (bossalive) {
//			hp = boss.GetComponent<BossTaken> ().health;
//
//			float healthPercent = hp / maxhp;
//			float newsize = fullsize * healthPercent;
//			GameObject bar = bossui.transform.Find ("BG").Find ("Bar").gameObject;
//			bar.transform.localScale = new Vector3 (Mathf.Clamp (newsize, 0f, 1f), 1, 1);
//		}
	}

	void DecreaseHP(){
		print (hp + " HP");
		hp--;
		if (hp < 0) {
			hp = 0;
		}
	}
}
