using CameraSpecification;
using Devices;
using IrCameraSpecification;

namespace VirtualIrCamera
{
    /// <summary>
    /// 虚拟红外摄像机
    /// </summary>
    public class VirtualIrCamera : IDevice
    {
        /// <summary>
        /// 红外摄像机参数
        /// </summary>
        private IrCameraConfiguration irCameraConfiguration;

        /// <summary>
        /// 可见光摄像机参数
        /// </summary>
        private CameraConfiguration cameraConfiguration;

        public override void Dispose() {
        }

        public override bool Initialize(in object arguments) {
            var args = arguments as object[];
            irCameraConfiguration = args[0] as IrCameraConfiguration;
            cameraConfiguration = args[1] as CameraConfiguration;

            status = DeviceStatus.Idle;
            return true;
        }

        public override bool Open() {
            status = DeviceStatus.Running;
            return true;
        }

        public override bool Close() {
            status = DeviceStatus.Idle;
            return true;
        }

        public override bool Read(in object arguments, ref object data, out int used) {
            used = 0;
            return true;
        }

        public override bool Write(in object arguments, in object data) {
            return true;
        }

        public override bool Control(in object code, in object arguments, ref object data) {
            if (code == null) {
                return false;
            }

            if (code is IrCameraSpecification.ControlCode) {
                switch ((IrCameraSpecification.ControlCode)code) {
                    case IrCameraSpecification.ControlCode.GetObjectDistance:
                    case IrCameraSpecification.ControlCode.GetEmissivity:
                    case IrCameraSpecification.ControlCode.GetAtmosphericTemperature:
                    case IrCameraSpecification.ControlCode.GetRelativeHumidity:
                    case IrCameraSpecification.ControlCode.GetTransmission: {
                            data = 0.0F;
                            return true;
                        }
                    case IrCameraSpecification.ControlCode.GetIrCameraParameters: {
                            data = irCameraConfiguration;
                            return true;
                        }
                    case IrCameraSpecification.ControlCode.SetIrCameraParameters: {
                            irCameraConfiguration = data as IrCameraConfiguration;
                            return true;
                        }
                    case IrCameraSpecification.ControlCode.GetTemperatureArray: {
                            var dst = (float[])data;
                            for (int y = 0, i = 0; y < irCameraConfiguration.temperatureHeight; ++y) {
                                for (int x = 0; x < irCameraConfiguration.temperatureWidth; ++x) {
                                    dst[i++] = 0.0F;
                                }
                            }

                            return true;
                        }
                    case IrCameraSpecification.ControlCode.GetIrImage: {
                            var dst = (byte[])data;
                            for (int y = 0, i = 0; y < irCameraConfiguration.height; ++y) {
                                for (int x = 0; x < irCameraConfiguration.width; ++x) {
                                    dst[i++] = 0;
                                }
                            }

                            return true;
                        }
                }
            }
            else if (code is CameraSpecification.ControlCode code1) {
                switch (code1) {
                    case CameraSpecification.ControlCode.GetCameraParameters: {
                            data = cameraConfiguration;
                            return true;
                        }
                    case CameraSpecification.ControlCode.SetCameraParameters: {
                            cameraConfiguration = data as CameraConfiguration;
                            return true;
                        }
                    case CameraSpecification.ControlCode.GetImage: {
                            var dst = (byte[])data;
                            for (int y = 0, i = 0; y < cameraConfiguration.height; ++y) {
                                for (int x = 0; x < cameraConfiguration.width; ++x) {
                                    dst[i++] = 0;
                                }
                            }

                            return true;
                        }
                }
            }

            return true;
        }

        public override DeviceStatus GetDeviceStatus() {
            return status;
        }
    }
}
