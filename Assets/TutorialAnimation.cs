using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TutorialAnimation : MonoBehaviour
{
    Animator _animtutor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(waitCoroutine());
    }
    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(5.1f);
        SceneManager.LoadScene("Game Play");

    }
}
