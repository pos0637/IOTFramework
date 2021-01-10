namespace IrCameraSpecification
{
    /// <summary>
    /// 控制类型
    /// </summary>
    public enum ControlCode
    {
        GetIrCameraParameters = 0, // 红外摄像机参数
        SetIrCameraParameters, // 红外摄像机参数
        GetNetworkParameters, // 网络参数
        SetNetworkParameters, // 网络参数
        GetTemperatureArray, // 温度矩阵
        GetIrImage, // 红外图像
        GetFrameRate, // 帧率
        SetFrameRate, // 帧率
        GetAtmosphericTemperature, // 大气温度
        SetAtmosphericTemperature, // 大气温度
        GetRelativeHumidity, // 相对湿度
        SetRelativeHumidity, // 相对湿度
        GetReflectedTemperature, // 翻转表面温度
        SetReflectedTemperature, // 翻转表面温度
        GetObjectDistance, // 距离
        SetObjectDistance, // 距离
        GetEmissivity, // 辐射率
        SetEmissivity, // 辐射率
        GetTransmission, // 透过率
        SetTransmission, // 透过率
        GetPaletteMode, // 调色板 
        SetPaletteMode, // 调色板       
        GetFaceThermometryRegion, // 人脸测温区域
        SetFaceThermometryRegion, // 人脸测温区域
        GetFaceThermometryBasicParameter, // 人脸测温基本参数
        SetFaceThermometryBasicParameter, // 人脸测温基本参数
        GetBodyTemperatureCompensation, // 体温温度补偿
        SetBodyTemperatureCompensation, // 体温温度补偿
        GetBlackBody, // 黑体配置
        SetBlackBody, // 黑体配置
        GetMirrorMode, // 镜像模式
        SetMirrorMode // 镜像模式        
    };
}
