using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] ParticleSystem mainBoost;

    [SerializeField] ParticleSystem rightBoost;

    [SerializeField] ParticleSystem leftBoost;
    [SerializeField] AudioClip music;

    [SerializeField] AudioClip mainEngine;
    [SerializeField] float 
    thrustSpeed = 1000f;
    [SerializeField] float rotationThrust = 1f;
    Rigidbody rb;
    AudioSource audioSource;
    ParticleSystem ps;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();

        ps = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Thrust();
    }
    void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartThrusting();
        }
        else
        {
            StopThrusting();
        }
    }

     void StopThrusting()
    {
        mainBoost.Stop();
        audioSource.Stop();
    }

    void StartThrusting()
    {
        rb.AddRelativeForce(Vector3.left * thrustSpeed * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }
        if (!mainBoost.isPlaying)
        {
            mainBoost.Play();
        }
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            StartRotateLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            StartRotateRight();
        }
        else
        {
            StopRotate();
        }
    }

    void StopRotate()
    {
        rightBoost.Stop();
        leftBoost.Stop();
    }

    void StartRotateRight()
    {
        ApplyRotation(rotationThrust);
        if (!leftBoost.isPlaying)
        {
            leftBoost.Play();
        }
    }

    void StartRotateLeft()
    {
        ApplyRotation(-rotationThrust);
        if (!rightBoost.isPlaying)
        {
            rightBoost.Play();
        }
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}

