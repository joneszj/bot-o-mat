namespace CommonPatterns.Helpers
{
    public interface ICacheHelper
    {
        V Set<K, V>(K Key, V Value);
        V TryGet<K, V>(K Key, out bool IsFound);
    }
}