using System;
using System.Runtime.InteropServices;
using System.Text;

public class DeviceWrapper
{
    public const String LIBWFX_DLLNAME = @"LibWebFXScan.dll";

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LIBWFXEVENTCB(ENUM_LIBWFX_EVENT_CODE enEventCode, int nParam, IntPtr pUserDef);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void LIBWFXCB(ENUM_LIBWFX_NOTIFY_CODE enNotifyCode, IntPtr pUserDef, IntPtr pParam1, IntPtr pParam2);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_Init", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_Init();

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_DeInit", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_DeInit();

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_GetDeviesList", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_GetDeviesList(out IntPtr szDevicesListOut);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_GetFileList", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_GetFileList(out IntPtr szFileListOut);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_RemoveFile", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_RemoveFile(String szFileNameIn);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_SetProperty", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_SetProperty(String szRequestCmdIn, [MarshalAs(UnmanagedType.FunctionPtr)] LIBWFXEVENTCB pfnLibWFXEVENTCBIn, IntPtr pUserDefIn);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_StartScan", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_StartScan([MarshalAs(UnmanagedType.FunctionPtr)] LIBWFXCB pfnLibWFXCBIn, IntPtr pUserDefIn);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_Calibrate", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_Calibrate();

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_ECOControl", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_ECOControl(out uint pulTime, int nSetIn);

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_PaperReady", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_PaperReady();

    [DllImport(LIBWFX_DLLNAME, EntryPoint = "LibWFX_CloseDevice", CallingConvention = CallingConvention.StdCall)]
    public static extern ENUM_LIBWFX_ERRCODE LibWFX_CloseDevice();
}
