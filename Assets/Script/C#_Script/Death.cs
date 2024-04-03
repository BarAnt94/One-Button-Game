using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Canvas reloadCanvas;
    public Button reloadButton;
    public Button reloadButton_Menu;
    public GameObject Player;
    public AudioSource audioSource;

    private void Awake()
    {
        AudioSource audioSource = FindObjectOfType<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            Debug.Log("Mort");
           
            // Afficher le Canvas
            reloadCanvas.gameObject.SetActive(true);

            // Activer le bouton de rechargement
            reloadButton.onClick.AddListener(ReloadLevel);
            reloadButton_Menu.onClick.AddListener(Reload_Menu);
            Player.SetActive(false);
            
            if (audioSource != null)
            {
                audioSource.Stop();
            }
            
        
        }
    }

    private void ReloadLevel()
    {
        // Recharger le niveau actuel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
    private void Reload_Menu() 
    {
        SceneManager.LoadScene(0);
    } 
}
