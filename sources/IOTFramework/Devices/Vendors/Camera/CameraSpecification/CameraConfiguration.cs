namespace CameraSpecification
{
    /// <summary>
    /// 可见光摄像机参数
    /// </summary>
    public sealed class CameraConfiguration
    {
        /// <summary>
        /// 通道号
        /// </summary>
        public int channel;

        /// <summary>
        /// 资源地址
        /// </summary>
        public string uri;

        /// <summary>
        /// 图像宽度
        /// </summary>
        public int width;

        /// <summary>
        /// 图像对齐宽度
        /// </summary>
        public int stride;

        /// <summary>
        /// 高度
        /// </summary>
        public int height;

        /// <summary>
        /// 像素位宽
        /// </summary>
        public int bpp;

        /// <summary>
        /// 视频帧率
        /// </summary>
        public int videoFrameRate;
    }
}
