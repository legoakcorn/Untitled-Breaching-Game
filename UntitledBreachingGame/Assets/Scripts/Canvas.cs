using UnityEngine;

public class Canvas : MonoBehaviour
{
    [SerializeField] public GameObject m_Image;
    [SerializeField] public GameObject m_Image2;
    [SerializeField] public GameObject m_Image3;

    private void Update()
    {
        if (PlayerMovement.playerHealth == 2)
        {
            m_Image.SetActive(false);
        }
        if (PlayerMovement.playerHealth == 1)
        {
            m_Image2.SetActive(false);
        }
        if (PlayerMovement.playerHealth == 0)
        {
            m_Image3.SetActive(false);
        }
    }
}
