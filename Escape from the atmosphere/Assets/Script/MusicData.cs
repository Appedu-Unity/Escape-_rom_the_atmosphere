using UnityEngine;

[CreateAssetMenu(menuName = "Music", fileName = "MusicFile")]
public class MusicData : ScriptableObject
{
    [Header("音樂")]
    public AudioClip music;
    [Header("等待時間")]
    public float timeWait = 2f;
    [Header("間隔時間")]
    public float interval = 1f;

    [Header("音樂節點")]
    public PointType[] points;
}
/// <summary>
/// 音樂節點
/// </summary>
public enum PointType
{
    none , Up , Down 
}