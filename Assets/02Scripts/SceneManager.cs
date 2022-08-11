using UnityEngine;
using UnityEngine.SceneManagement; // 필요

public class Example : MonoBehaviour
{
    public void NextSceneWithString()
    {
        // 문자열 이용해서 씬 전환
        //SceneManager.LoadScene("Stage1");        // OK
        SceneManager.LoadScene("1_Scenes/Stage1"); // OK
    }

    public void NextSceneWithNum()
    {
        // 씬 번호를 이용해서 씬 이동
        SceneManager.LoadScene(1);  // 0 번째 씬 로드
    }
}