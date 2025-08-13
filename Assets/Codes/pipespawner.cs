using UnityEngine;

public class pipespawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _Pipe;

    private float _timer;
    
    private void Start()
    {
        SpawnPipe();
    }
    private void Update()
    {
        if (_timer  > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
  
    private void SpawnPipe()
    {
        Vector3 spawnpos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject Pipe = Instantiate(_Pipe, spawnpos, Quaternion.identity);

        Destroy(Pipe, 10f);
    }   
}
