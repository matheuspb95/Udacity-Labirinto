using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public Animator animator;
	public void ResetScene() 
	{
		StartCoroutine(ResetSceneIenum());
	}

	IEnumerator ResetSceneIenum(){
		animator.Play("FadeOut");
		yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}