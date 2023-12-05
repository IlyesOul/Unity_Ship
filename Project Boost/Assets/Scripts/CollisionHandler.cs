using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] AudioClip success;
    [SerializeField] AudioClip fail;

    [SerializeField]ParticleSystem successParticles;
    [SerializeField] ParticleSystem failParticles;
    [SerializeField] float delay = 1f;

    ParticleSystem ps;
    AudioSource audioSource;
    bool isTransitioning;

    bool collisionDisabled = false;
    void Start() {
        {
            audioSource = GetComponent<AudioSource>();

            ps = GetComponent<ParticleSystem>();
        }
    }

     void Update()
    {
        DebugKeys();
    }

    void DebugKeys()
    {
        if (Input.GetKey(KeyCode.L))
        {
            loadNext();
        }
        else if (Input.GetKey(KeyCode.C))
        {
            collisionDisabled = !collisionDisabled;
        }
    }

    void OnCollisionEnter(Collision other)
    {
       
        if(isTransitioning || collisionDisabled){return;}

        

            SwitchMethod(other);

        if(CollisionHandlerTwo.passLevel == true && other.gameObject.tag == "Finish")
        {
            StartSucessSequence();
        }
    }

     void SwitchMethod(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("You're on start");
                break;
            case "Finish":
                StartSucessSequence();
                break;
            case "Level":
                StartSucessSequence();
                break;
            case "Button":
                Debug.Log("nice");
                break;
            default:
                Debug.Log("You're done");
                StartCrashSequence();
                break;
        }
    }

    void StartCrashSequence()
    {

        isTransitioning = true;
        audioSource.Stop();
        GetComponent<Movement>().enabled = false;
        Invoke("Reload", delay);
        audioSource.PlayOneShot(fail);
        failParticles.Play();
    }

    public void Reload()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void StartSucessSequence()
    {
        isTransitioning = true;
        audioSource.Stop();
        GetComponent<Movement>().enabled = false;
        Invoke("loadNext", delay);
        audioSource.PlayOneShot(success);
        successParticles.Play();
    }

    void loadNext()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }
}