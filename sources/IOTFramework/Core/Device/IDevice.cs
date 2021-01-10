using System;

namespace Devices
{
    /// <summary>
    /// 设备抽象类
    /// </summary>
    public abstract class IDevice : IDisposable
    {
        /// <summary>
        /// 事件处理器
        /// </summary>
        /// <param name="deviceEvent">事件</param>
        /// <param name="arguments">参数</param>
        public delegate void EventHandler(object deviceEvent, params object[] arguments);

        /// <summary>
        /// 设备状态
        /// </summary>
        protected DeviceStatus status = DeviceStatus.Idle;

        /// <summary>
        /// 设备索引
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 初始化设备
        /// </summary>
        /// <param name="arguments">参数</param>
        /// <returns>是否成功</returns>
        public abstract bool Initialize(in object arguments);

        /// <summary>
        /// 打开设备
        /// </summary>
        /// <returns>是否成功</returns>
        public abstract bool Open();

        /// <summary>
        /// 关闭设备
        /// </summary>
        /// <returns>是否成功</returns>
        public abstract bool Close();

        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="arguments">参数</param>
        /// <param name="data">读取数据</param>
        /// <param name="used">数据长度</param>
        /// <returns>是否成功</returns>        
        public abstract bool Read(in object arguments, ref object data, out int used);

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="arguments">参数</param>
        /// <param name="data">写入数据</param>
        /// <returns>是否成功</returns>
        public abstract bool Write(in object arguments, in object data);

        /// <summary>
        /// 控制设备
        /// </summary>
        /// <param name="code">控制类型</param>
        /// <param name="arguments">参数</param>
        /// <param name="data">数据</param>
        /// <returns>是否成功</returns>
        public abstract bool Control(in object code, in object arguments, ref object data);

        /// <summary>
        /// 获取设备状态
        /// </summary>
        /// <returns>设备状态</returns>
        public abstract DeviceStatus GetDeviceStatus();

        /// <summary>
        /// 释放资源
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// 事件
        /// </summary>
        public event EventHandler Handler;

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="deviceEvent">事件</param>
        /// <param name="arguments">参数</param>
        protected void RaiseEvent(object deviceEvent, params object[] arguments) {
            Handler?.Invoke(deviceEvent, arguments);
        }
    }
}
