namespace Gako.Data.EntityBinder
{
    /// <summary>
    /// 変換の振る舞いを指定します。
    /// </summary>
    public enum ConvertBehavior
    {
        /// <summary>
        /// 暗黙的なキャストを行います。
        /// </summary>
        Cast,

        /// <summary>
        /// 明示的なキャストや特定の変換を行います。
        /// </summary>
        Convert,
    }
}
