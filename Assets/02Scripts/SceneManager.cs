using UnityEngine;
using UnityEngine.SceneManagement; // �ʿ�

public class Example : MonoBehaviour
{
    public void NextSceneWithString()
    {
        // ���ڿ� �̿��ؼ� �� ��ȯ
        //SceneManager.LoadScene("Stage1");        // OK
        SceneManager.LoadScene("1_Scenes/Stage1"); // OK
    }

    public void NextSceneWithNum()
    {
        // �� ��ȣ�� �̿��ؼ� �� �̵�
        SceneManager.LoadScene(1);  // 0 ��° �� �ε�
    }
}