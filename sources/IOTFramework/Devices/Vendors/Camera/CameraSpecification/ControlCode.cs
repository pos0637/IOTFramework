namespace CameraSpecification
{
    /// <summary>
    /// 控制类型
    /// </summary>
    public enum ControlCode
    {
        GetCameraParameters = 0, // 可见光摄像机参数
        SetCameraParameters, // 可见光摄像机参数
        GetNetworkParameters, // 网络参数
        SetNetworkParameters, // 网络参数
        GetImage, // 可见光图像
        SetImage, // 可见光图像
        GetFrameRate, // 帧率            
        SetFrameRate // 帧率     
    }
}
