using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	void Awake(){
		StartCoroutine("moja");
	}
	IEnumerator moja(){
		yield return new WaitForSeconds(1);
		
		MyNotifications.CallNotification("Je hebt de opdracht succesvol afgerond!", 4);
		MyNotifications.CallNotification("Je krijgt later weer een nieuwe opdracht.", 5);
		MyNotifications.CallNotification("Je hebt een nieuwe opdracht ontvangen!", 3);
        MyNotifications.CallNotification("De vulkaan op de MCDonald eilanden in uit gebarsten. Er liggen nu overal hamburgers! +100 Voedsel", 3);
    }
}
