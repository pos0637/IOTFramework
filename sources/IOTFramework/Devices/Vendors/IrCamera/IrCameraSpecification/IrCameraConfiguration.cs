namespace IrCameraSpecification
{
    /// <summary>
    /// 红外摄像机配置
    /// </summary>
    public sealed class IrCameraConfiguration
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

        /// <summary>
        /// 温度矩阵宽度
        /// </summary>
        public int temperatureWidth;

        /// <summary>
        /// 温度矩阵对齐宽度
        /// </summary>
        public int temperatureStride;

        /// <summary>
        /// 温度矩阵高度
        /// </summary>
        public int temperatureHeight;

        /// <summary>
        /// 温度帧率
        /// </summary>
        public int temperatureFrameRate;

        /// <summary>
        /// 辐射率
        /// </summary>
        public float? emissivity;

        /// <summary>
        /// 翻转表面温度
        /// </summary>
        public float? reflectedTemperature;

        /// <summary>
        /// 透过率
        /// </summary>
        public float? transmission;

        /// <summary>
        /// 大气温度
        /// </summary>
        public float? atmosphericTemperature;

        /// <summary>
        /// 相对湿度
        /// </summary>
        public float? relativeHumidity;

        /// <summary>
        /// 距离
        /// </summary>
        public float? distance;
    }
}
